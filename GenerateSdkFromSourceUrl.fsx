(* Reference nuget packages, fixed version numbers to prevent breaking changes and make script runs consistent
   If possible, please try updating the nuget packages each time we modify the script *)
#r "nuget: Microsoft.OpenApi,1.6.14"
#r "nuget: Microsoft.OpenApi.Readers,1.6.14"
#r "nuget: Fli,1.111.10"
#r "nuget: FsHttp,14.5.0"

/// <summary>
///     Module of string helpers
/// </summary>
module StringHelpers =
    open System

    /// <summary>
    ///     Takes two strings and performs a case insensitive comparison.
    /// </summary>
    /// <param name="a">Original string.</param>
    /// <param name="b">String to compare to original.</param>
    /// <returns>true/false.</returns>
    let stringCompareIgnoreCase (a: string, b : string) =
        String.Equals(a, b, StringComparison.OrdinalIgnoreCase)

/// <summary>
///     Module of helpers for manipulating OpenApi specs
/// </summary>
module OpenApiHelpers =
    open Microsoft.OpenApi
    open Microsoft.OpenApi.Extensions
    open Microsoft.OpenApi.Readers
    open System.Collections.Generic
    open Microsoft.OpenApi.Any
    open Microsoft.OpenApi.Interfaces
    open Microsoft.OpenApi.Models
    open Microsoft.OpenApi.Validations
    open System.Linq
    open StringHelpers

    /// <summary>
    ///     The reference Id for our Api Error object
    /// </summary>
    let private defaultErrorSchemaReferenceId = "ApiError" // This is the id of the schema object in #/components/schema

    /// <summary>
    ///     Takes an OpenApiMediaType and removes its examples.
    ///     We do this because the examples don't always match the provided specification,
    ///     and it adds noise to the validation logs.
    /// </summary>
    /// <param name="openApiMediaType">The OpenApiMediaType to remove examples from</param>
    let private removeOpenApiMediaTypeExamples (openApiMediaType: OpenApiMediaType) =
        openApiMediaType.Example <- null
        openApiMediaType.Examples <- null
    
    /// <summary>
    ///     Takes an OpenApiResponse and applies relevant modifications.
    /// </summary>
    /// <param name="openApiResponse">The OpenApiResponse to apply modifications to.</param>
    let private applyResponseModifications (openApiResponse: OpenApiResponse) =
        for mediaType in openApiResponse.Content.Values do
            // Remove examples from each media type, they're not needed for SDK generation and cause warnings due to type mismatches
            removeOpenApiMediaTypeExamples(mediaType)

    /// <summary>
    ///     Takes an OpenApiRequestBody and applies modifications to it.
    /// </summary>
    /// <param name="openApiRequest">The OpenApiRequestBody to modify.</param>
    let private applyRequestModifications (openApiRequest: OpenApiRequestBody) =
        // Check the request and content is not null
        if not(openApiRequest = null) && not (openApiRequest.Content = null) then
            for mediaType in openApiRequest.Content.Values do
                // Remove examples from each media type, they're not needed for SDK generation and cause warnings due to type mismatches
                removeOpenApiMediaTypeExamples(mediaType)                      

    /// <summary>
    ///     Returns an OpenApiResponse for our default error response.
    /// </summary>
    /// <param name="schemaReferenceId">The id of the schema object to reference.</param>
    /// <param name="responseDescription">The description to use for the response.</param>
    /// <returns>An OpenApiResponse representing the default schema response object we want to use for errors.</returns>
    let private defaultErrorResponse (schemaReferenceId: string, responseDescription: string) =
        // Create the reference to the ApiError schema object
        let errorReference = OpenApiReference()
        errorReference.Type <- ReferenceType.Schema
        errorReference.Id <- schemaReferenceId
        
        // Create a schema pointing to the reference
        let errorSchema = OpenApiSchema()
        errorSchema.Reference <- errorReference
        
        // Create a media type that uses the schema
        let errorMediaType = OpenApiMediaType()
        errorMediaType.Schema <- errorSchema

        // Create the error response object using the created media type
        let errorResponse = OpenApiResponse()
        errorResponse.Description <- responseDescription
        errorResponse.Content.Add("application/json", errorMediaType)
        
        // return the created error response object
        errorResponse
    
    /// <summary>
    ///     If a default response exists on an OpenApiOperation it removes it.
    ///     Regardless of whether it had a default response or not, it adds a new OpenApiResponse
    ///     which represents our own ApiError model.
    /// </summary>
    /// <param name="openApiOperation">The OpenApiOperation to add/replace the default response on</param>
    let private addOrReplaceDefaultErrorResponse (openApiOperation: OpenApiOperation) =
        
        let defaultDescription = "Error response" // The description for the default response
        let defaultResponseKey = "default" // The key for the default response in the OpenApiOperation.Responses collection
        
        // If the operation has a default object, remove it as we'll be adding our own
        if openApiOperation.Responses.ContainsKey(defaultResponseKey) then
            openApiOperation.Responses.Remove(defaultResponseKey) |> ignore
        
        // Add our ApiError object as the default response
        let apiErrorResponse = defaultErrorResponse(defaultErrorSchemaReferenceId, defaultDescription)
        openApiOperation.Responses.Add(defaultResponseKey, apiErrorResponse)
    
    /// <summary>
    ///     Applies required modifications to an OpenApiOperation item.
    ///     An operation represents a HTTP method (GET, POST, PUT, etc...)
    /// </summary>
    /// <param name="openApiOperation">The OpenApiOperation to modify</param>
    let private applyOperationsModifications (openApiOperation: OpenApiOperation) =
        // Adds or modifies the default response, which for our case will handle error responses
        addOrReplaceDefaultErrorResponse(openApiOperation)

        (* For each response object on an operation (HTTP Status code 200, 201, 400 etc...)
           perform modifications *)
        for response in openApiOperation.Responses do
            // If the response is for 4XX or 5XX error codes, remove it
            if (response.Key.StartsWith("4") || response.Key.StartsWith("5")) then
                openApiOperation.Responses.Remove(response.Key) |> ignore
            
            // otherwise, perform response modification
            else
                applyResponseModifications(response.Value)
        
        // Apply modification to the request body
        applyRequestModifications(openApiOperation.RequestBody)

    /// <summary>
    ///     Applies required modifications to an OpenApiPathItem item.
    ///     A path represents an endpoint ignoring HTTP Method.
    ///     For example: https://sandbox-api.marqeta.com/v3/transactions.
    /// </summary>
    /// <param name="openApiPath">The OpenApiPathItem to apply modifications to.</param>
    let private applyPathModifications (openApiPath: OpenApiPathItem) =
        // Loop through each operation in a path (GET, POST, PUT, etc...) and apply modifications
        for operation in openApiPath.Operations do
            applyOperationsModifications(operation.Value)

    /// <summary>
    ///     Apply modifications to relevant paths in OpenApiPaths
    ///     A path represents an endpoint ignoring HTTP Method.
    ///     For example: https://sandbox-api.marqeta.com/v3/transactions.
    /// </summary>
    /// <param name="openApiPaths">A collection of OpenApiPathItem to perform modifications to.</param>
    let private applyPathsModifications (openApiPaths: OpenApiPaths) =
        // Loop through all paths in the spec and apply modifications to each
        for path in openApiPaths do
            applyPathModifications(path.Value)

    /// <summary>
    ///     Apply modifications to OpenApiSchema items that represent a property on a parent OpenApiSchema.
    /// </summary>
    /// <param name="property">A property of a schema represented as OpenApiSchema.</param>
    let private applySchemaPropertiesModifications (property: OpenApiSchema) =
        property.ReadOnly <- false // We don't want properties to be readonly as this messes up SDK generation
        
    /// <summary>
    ///     Applies modifications to the mcc_group_model schema.
    /// </summary>
    /// <param name="openApiSchema">The OpenApiSchema object representing mcc_group_model.</param>
    let private applyMccGroupModelModifications (openApiSchema: OpenApiSchema) =
        (* We want to modify the type of the property mcc to be an array of strings
           at time of writing it is a string of objects. *)
        let mccObjectKey = "mccs" // The property we want to change the type of
        if openApiSchema.Properties.ContainsKey(mccObjectKey) then
            let property = openApiSchema.Properties[mccObjectKey]
            let expectedType = "string"
            (* If the type is not string, we want to fix this, the existing schema has this as
               an array of objects, this changes it to an array of strings *)
            if not(stringCompareIgnoreCase(property.Items.Type, expectedType)) then
                property.Items.Type <- expectedType

    /// <summary>
    ///     Applies modifications to the card_holder_model schema.
    /// </summary>
    /// <param name="openApiSchema">The OpenApiSchema object representing card_holder_model.</param>
    let private applyCardHolderModelModifications (openApiSchema: OpenApiSchema) =
        // If the status property enum doesn't exist, create and add it
        let statusEnumKey = "status" // The key for the status property
        if not(openApiSchema.Properties.ContainsKey(statusEnumKey)) then
            // The status enum
            let enum = List<IOpenApiAny>()
            enum.Add(OpenApiString("UNVERIFIED"))
            enum.Add(OpenApiString("LIMITED"))
            enum.Add(OpenApiString("ACTIVE"))
            enum.Add(OpenApiString("SUSPENDED"))
            enum.Add(OpenApiString("CLOSED"))
            
            // The property to hold the enum values
            let cardHolderStatusEnumProperty = OpenApiSchema()
            cardHolderStatusEnumProperty.Description <- "Specifies the status of the cardholder on the Marqeta platform."
            cardHolderStatusEnumProperty.Type <- "string"
            cardHolderStatusEnumProperty.Enum <- enum
            
            // Add the created property to the schema properties collection
            openApiSchema.Properties.Add(statusEnumKey, cardHolderStatusEnumProperty)

    let private applyTransactionModelTypeModifications (openApiSchema: OpenApiSchema) =
        let enumsToAdd = [
            "authorization.clearing.representment"
            "billpayment"
            "billpayment.clearing"
            "billpayment.reversal" 
            "fee.charge.pending.refund"
            "transaction.unknown"
            "address.verification"
        ]

        let typeEnum = openApiSchema.Properties["type"].Enum

        for enumToAdd in enumsToAdd do
            let enumString = OpenApiString(enumToAdd) 

            if not(typeEnum.Contains(enumString)) then
                typeEnum.Add(enumString)

    /// <summary>
    ///     Applies modifications to the payment_channel schema.
    /// </summary>
    /// <param name="openApiSchema">The OpenApiSchema object representing transaction_metadata.</param>
    let private applyTransactionMetadataPaymentChannelModifications(openApiSchema: OpenApiSchema) = 
        let enumsToAdd = [
            "EU_MOTO_NON_SECURE"
        ]

        let typeEnum = openApiSchema.Properties["payment_channel"].Enum
        for enumToAdd in enumsToAdd do 
            let enumString = OpenApiString(enumToAdd)

            if(not(typeEnum.Contains(enumString))) then
                typeEnum.Add(enumString)

    let private applyTransactionModelModifications (openApiSchema: OpenApiSchema) =
        applyTransactionModelTypeModifications(openApiSchema)

    let private applyTransactionMetadataModifications (openApiSchema: OpenApiSchema) =
        applyTransactionMetadataPaymentChannelModifications(openApiSchema)

    /// <summary>
    ///     Takes a schema and applies relevant modifications.
    /// </summary>
    /// <param name="openApiSchema">The OpenApiSchema to apply modifications to.</param>
    let private applySchemaModifications (openApiSchema: OpenApiSchema) =
        // Loops through properties and apply modifications to each one
        for property in openApiSchema.Properties do
            applySchemaPropertiesModifications(property.Value)
        
    /// <summary>
    ///     Adds an error schema item to #/components/schemas.
    ///     We're adding our own schema for an ApiError model here, this is a re-usable object that
    ///     matches the marqeta json error response model.
    ///     example response:
    ///     {
    ///          "error_code" : "400008",
    ///          "error_message" : "Missing a required field."
    ///     }
    ///     https://github.com/OAI/OpenAPI-Specification/blob/main/versions/3.0.3.md#schema-object
    /// </summary>
    /// <param name="openApiSchemas">The schema collection to add error schema to.</param>
    let private addErrorSchema (openApiSchemas: IDictionary<string, OpenApiSchema>) =
        // OpenApiSchema for the type string, this is because schema properties have their own schema..
        let stringSchema = OpenApiSchema()
        stringSchema.Type <- "string"
        
        // OpenApiSchema for our ApiError model of type object, this is a key/value pair
        let schema = OpenApiSchema() // Creates an OpenApiSchema model for our error type `ApiError`
        schema.Type <- "object"

        let errorPropertyKey = "error_code" // The property key for error_code
        let errorMessageProperty = "error_message" // The property key for error_message
        let messagePropertyKey = "message" // The property key for message
        
        // Adds the properties itself to the ApiError schema, with their own respective schemas which is string
        schema.Properties.Add(errorPropertyKey, stringSchema)
        schema.Properties.Add(errorMessageProperty, stringSchema)
        schema.Properties.Add(messagePropertyKey, stringSchema)
        
        // Adds our created ApiError schema to the existing collection of schema objects
        openApiSchemas.Add(defaultErrorSchemaReferenceId, schema)

    /// <summary>
    ///     Removes unused Error schemas from the schema collection as we add our own error schema.
    /// </summary>
    /// <param name="openApiSchemas">The schema collection to remove error models from.</param>
    let private removeUnusedErrorSchemas (openApiSchemas: IDictionary<string, OpenApiSchema>) =
        (* Remove the following schema models from the schema as we use our own
           As .Remove(..) returns a bool, and we don't care about value, we call |> ignore,
           think of it as a discard *)
        openApiSchemas.Remove("BadRequestError") |> ignore
        openApiSchemas.Remove("Error") |> ignore
        openApiSchemas.Remove("ForbiddenError") |> ignore
        openApiSchemas.Remove("InternalServerError") |> ignore
        openApiSchemas.Remove("UnauthorizedError") |> ignore
        
    /// <summary>
    ///     Applies modifications to the schema objects in a collection of OpenApiSchema.
    /// </summary>
    /// <param name="openApiSchemas">The collection of OpenApiSchema to apply modifications to.</param>
    let private applySchemasModifications (openApiSchemas: IDictionary<string, OpenApiSchema>) =
        removeUnusedErrorSchemas(openApiSchemas)
        
        addErrorSchema(openApiSchemas)
        
        // Apply modifications relevant to all schemas
        for schema in openApiSchemas do
            applySchemaModifications(schema.Value)
        
        if openApiSchemas.ContainsKey("mcc_group_model") then
            applyMccGroupModelModifications(openApiSchemas["mcc_group_model"])
        
        if openApiSchemas.ContainsKey("card_holder_model") then
            applyCardHolderModelModifications(openApiSchemas["card_holder_model"])
            
        if openApiSchemas.ContainsKey("transaction_model") then
            applyTransactionModelModifications(openApiSchemas["transaction_model"])

        if openApiSchemas.ContainsKey("transaction_metadata") then
            applyTransactionMetadataModifications(openApiSchemas["transaction_metadata"])
        
    /// <summary>
    ///     Applies modifications to the Components on an OpenAPI spec.
    /// </summary>
    /// <param name="openApiComponents">The OpenApiComponents to apply modifications to.</param>
    let private applyComponentsModifications (openApiComponents: OpenApiComponents) =
        applySchemasModifications(openApiComponents.Schemas)

    let private applyAuthorisationReversalAddition (paths: OpenApiPaths) =
        // Create Response Object by building out the response reference then the schema and content and finally the actual response. 
        let transactionReference: OpenApiReference = new OpenApiReference()
        transactionReference.ExternalResource <- "#/components/schemas/transaction_model"

        let reversalPathResponseSchema: OpenApiSchema = new OpenApiSchema()
        reversalPathResponseSchema.Reference <- transactionReference

        let reversalPathResponseMediaType: OpenApiMediaType = new OpenApiMediaType()
        reversalPathResponseMediaType.Schema <- reversalPathResponseSchema

        let reversalPathResponseContent: Dictionary<string,OpenApiMediaType> = new Dictionary<string, OpenApiMediaType>()
        reversalPathResponseContent.Add("application/json", reversalPathResponseMediaType) 

        let reversalPathResponseList: OpenApiResponses = new OpenApiResponses()
        let reversalPathResponse: OpenApiResponse = new OpenApiResponse()
        reversalPathResponse.Content <- reversalPathResponseContent
        reversalPathResponseList.Add("200", reversalPathResponse)

        // OriginalTransactionSchema - Create teh schema for the original transaction field
        let originalTransactionProperty = new Dictionary<string, OpenApiSchema>()
        let originalTransactionSchema = new OpenApiSchema()
        originalTransactionSchema.Type <- "string"
        originalTransactionSchema.Description <- "Identifies the transaction to reverse."
        originalTransactionSchema.MaxLength <- 36
        originalTransactionSchema.MinLength <- 1
        originalTransactionProperty.Add("original_transaction_token", originalTransactionSchema)

        // Request body content which contains the aforementioned original Transaction schema
        let requestBodySchemaProperties = new Dictionary<string, OpenApiSchema>()
        let requestBodySchemaPropertiesSchema = new OpenApiSchema()
        requestBodySchemaPropertiesSchema.Type <- "object"
        requestBodySchemaPropertiesSchema.Properties <- originalTransactionProperty
        requestBodySchemaProperties.Add("reverse_authorization_model", requestBodySchemaPropertiesSchema)
        
        // Create the media type and schema for the request content
        let requestBodyOpenApiMediaType = new OpenApiMediaType()
        let requestBodySchema = new OpenApiSchema()
        requestBodySchema.Properties <- requestBodySchemaProperties
        requestBodyOpenApiMediaType.Schema <- requestBodySchema

        let requestBodyContent = new Dictionary<string, OpenApiMediaType>()
        requestBodyContent.Add("application/json", requestBodyOpenApiMediaType)

        // Create the actual request
        let requestBody = new OpenApiRequestBody()
        requestBody.Description <- "Identifies the transaction to reverse."
        requestBody.Content <- requestBodyContent

        // Create operation
        let reversalPathOperation: OpenApiOperation = new OpenApiOperation()

        // Hydrate operation
        reversalPathOperation.Responses <- reversalPathResponseList
        reversalPathOperation.Summary <- "Reverse an authorisation"

        // Create tag for the path. 
        let reversalPathTag = new List<OpenApiTag>()
        let openApiTag = new OpenApiTag()
        openApiTag.Name <- "Transactions"
        reversalPathTag.Add(openApiTag)
        reversalPathOperation.Tags <- reversalPathTag

        reversalPathOperation.OperationId <- "authorizationReversal"
        reversalPathOperation.RequestBody <- requestBody

        // Add new path to path list
        let reversalPath: OpenApiPathItem = new OpenApiPathItem()

        // Add summary 
        reversalPath.Summary <- "Reverse an authorisation."

        // Add operation to path
        reversalPath.AddOperation(OperationType.Post, reversalPathOperation)

        // Add path to other paths
        paths.Add("/transactions/authorizationreversal", reversalPath)

    /// <summary>
    ///     Applies modifications to a provided OpenApiDocument.
    /// </summary>
    /// <param name="openApiDocument">The OpenApiDocument to apply modifications to.</param>
    let applyOpenApiDocumentModifications (openApiDocument: OpenApiDocument) =
        applyAuthorisationReversalAddition(openApiDocument.Paths)
        applyPathsModifications(openApiDocument.Paths) // Apply modifications to the Paths on root document
        applyComponentsModifications(openApiDocument.Components) // Apply modifications to the Components on root document
        
    /// <summary>
    ///     Parses an OpenAPI spec in stream form.
    /// </summary>
    /// <param name="stream">stream containing a yaml spec for OpenApi.</param>
    /// <returns>The parsed OpenApiDocument and OpenApiDiagnostic.</returns>
    let getParsedOpenApiDocFromStream (stream: System.IO.Stream) =
        OpenApiStreamReader().Read(stream)

    /// <summary>
    ///     Serializes an already parsed OpenApiDocument as YAML using OpenAPI 3.0 spec.
    /// </summary>
    /// <param name="parsedOpenApiDocument">OpenApiDocument to serialize.</param>
    /// <returns>A string representing the serialized YAML.</returns>
    let getOpenApiDocumentSerializedAsYaml (parsedOpenApiDocument: IOpenApiSerializable) =
        parsedOpenApiDocument.SerializeAsYaml(OpenApiSpecVersion.OpenApi3_0)
            
    /// <summary>
    ///     Takes an already parsed OpenApiDocument and validates it.
    /// </summary>
    /// <param name="openApiDocument">OpenApiDocument to validate.</param>
    /// <returns>The diagnostic results after validating the provided OpenApiDocument.</returns>
    let validateDocument (openApiDocument: OpenApiDocument) =
        (* Local helper function to convert OpenApiValidatorError/OpenApiValidatorWarning to a list of OpenApiError
           the type is inferred *)
        let diagnosticsToList (diagnostics: IEnumerable<'T>) =
            let list = List<OpenApiError>()
            for diagnostic in diagnostics do
                list.Add(diagnostic :> OpenApiError) // :> is a cast operator, this casts diagnostic to OpenApiError
            list // return the converted list of OpenApiError

        // Validate the OpenApiDocument using the default rule set
        let validationResult = openApiDocument.Validate(OpenApiReaderSettings().RuleSet)
        
        (* Here we create an OpenApiDiagnostic, and set the errors and warning properties
           the .OfType<> allows us to filter validationResult by type, as both
           OpenApiValidatorError and OpenApiValidatorWarning inherit OpenApiError*)
        let diagnostic = OpenApiDiagnostic()
        diagnostic.Errors <- diagnosticsToList(validationResult.OfType<OpenApiValidatorError>())
        diagnostic.Warnings <- diagnosticsToList(validationResult.OfType<OpenApiValidatorWarning>())
        
        diagnostic // return the diagnostics

    
    /// <summary>
    ///     Log the OpenApiDiagnostic Errors and Warnings with provided logging function.
    /// </summary>
    /// <param name="diagnostics">The OpenApiDiagnostic we want to log Errors and Warnings for.</param>
    /// <param name="logFunc">A function that takes a string and outputs unit (nothing).</param>
    let logDiagnostics (diagnostics: OpenApiDiagnostic, logFunc: string -> unit) =
        // Local helper function to log a list of provided OpenApiError with a level
        let logOpenApiErrors (diagnostics: IList<OpenApiError>, level: string, logFunc: string -> unit) =
            for error in diagnostics do
                // Log the formatted error with provided logging function
                logFunc($"%s{level}: %s{error.Message} -> %s{error.Pointer}")

        // Log errors and warnings independently
        logOpenApiErrors(diagnostics.Errors, "Error", logFunc)
        logOpenApiErrors(diagnostics.Warnings, "Warning", logFunc)

/// <summary>
///     Module of helpers for file system operations.
/// </summary>
module FileHelpers =
    open System.IO
    
    /// <summary>
    ///     Gets a stream representing a file for a specified path.
    /// </summary>
    /// <param name="path">The path to open as a stream.</param>
    /// <returns>A stream representation of specified path.</returns>
    let getFileStreamByPath (path: string) =
        File.OpenRead path

    /// <summary>
    ///     Writes all text to the specified path.
    /// </summary>
    /// <param name="text">Text to write to file.</param>
    /// <param name="path">Path to write text to.</param>
    let writeAllTextToPath (text: string, path: string) =
        File.WriteAllText(path, text)

    /// <summary>
    ///     Checks if file exists at specified path.
    /// </summary>
    /// <param name="path">The path to check for file.</param>
    /// <returns>true/false</returns>
    let fileExists (path: string) =
        File.Exists(path)

/// <summary>
///     Helpers for logging.
/// </summary>
module LogHelpers =
    open System

    /// <summary>
    ///     Logs specified message to console.
    /// </summary>
    /// /// <param name="color">The colour to log message as.</param>
    /// <param name="message">The message to log.</param>
    let private log (color: ConsoleColor, message: string)=
        let lockObj = obj()
        lock lockObj (fun _ ->
            Console.ForegroundColor <- color
            let time = DateTimeOffset.Now.ToString("HH:mm:ss:fff")
            // printf prints a formatted string to console
            printfn $"[%s{time}] - %s{message}"
            Console.ResetColor())
            
    /// <summary>
    ///     Logs ok message to console.
    /// </summary>
    /// <param name="message">The message to log.</param>
    let logOk (message: string) =
        log(ConsoleColor.Green, message)
        
    /// <summary>
    ///     Logs debug message to console.
    /// </summary>
    /// <param name="message">The message to log.</param>
    let logDebug (message: string) =
        log(ConsoleColor.Cyan, message)
    
    /// <summary>
    ///     Logs warn message to console.
    /// </summary>
    /// <param name="message">The message to log.</param>
    let logWarn (message: string) =
        log(ConsoleColor.Yellow, message)
    
    /// <summary>
    ///     Logs error message to console.
    /// </summary>
    /// <param name="message">The message to log.</param>
    let logError (message: string) =
        log(ConsoleColor.Red, message)

/// <summary>
///     Helpers for using stopwatch.
/// </summary>
module Stopwatch =
    open System.Diagnostics
    
    /// <summary>
    ///     Starts a Stopwatch.
    /// <returns>The started Stopwatch.</returns>
    /// </summary>
    let start = Stopwatch.StartNew()

    /// <summary>
    ///     Stops a started Stopwatch.
    /// </summary>
    /// <param name="stopwatch">The Stopwatch to stop.</param>
    /// <returns>The stopped Stopwatch.</returns>
    let stop (stopwatch: Stopwatch) =
        stopwatch.Stop()
        stopwatch

    /// <summary>
    ///     Gets a formatted representation of the current elapsed time in milliseconds on the provided Stopwatch.
    /// </summary>
    /// <param name="stopwatch">The Stopwatch to get the formatted elapsed time for.</param>
    /// <returns>A formatted string representing the elapsed time in milliseconds.</returns>
    let getElapsedTime (stopwatch: Stopwatch) =
        $" - Elapsed Time (%f{stopwatch.Elapsed.TotalMilliseconds})ms"

module DotnetCli =
    open Fli
    open LogHelpers
    
    /// <summary>
    ///     Base cli command for dotnet commands.
    ///     https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet
    /// </summary>
    let dotnetBaseCommand =
        cli {
            Exec "dotnet"
            Output logDebug
        }
        
    /// <summary>
    ///     Restores the tools specified in dotnet tool manifest.
    ///     https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-tool-restore
    /// </summary>
    let restoreDotnetTools () =
        Command.execute(dotnetBaseCommand { Arguments "tool restore" })
        |> ignore
        
    let buildSolution () =
        Command.execute(dotnetBaseCommand { Arguments "build" })
        |> ignore
        
    let testSolution () =
        Command.execute(dotnetBaseCommand { Arguments "test" })
        |> ignore

/// <summary>
///     Helpers for generating SDK from an OpenAPI spec.
/// </summary>
module SdkGenerator =
    open LogHelpers
    open FileHelpers
    open Fli
    open DotnetCli

    (*
        We're using Fli nuget package to build an execute console commands here.
        It uses something in F# known as computation expressions.
        
        A brief explanation of how this works is that we can define an expression for cli as follows:
            let baseGitCommand = cli { 
                                     Exec "git" 
                                     }
        
        We can then use this baseCommand to add more to it:
            let gitAddAllFiles = baseGitCommand { 
                                                Arguments "add -A" 
                                                }
        
        This is the same as declaring it all in one go as so:
            let gitAddAllFiles = cli { 
                                                Exec "git"
                                                Arguments "add -A" 
                                                }

        This allows us to build up a console command, reusing base properties effectively.
        
        We can then take this command and execute it
            gitAddAllFiles |> Command.execute
            which is syntax sugar for 
            Command.execute(gitAddAllFiles)

        We add a |> ignore as we don't care about the output of Command.execute.
    *)

    /// <summary>
    ///     The base cli command for Kiota.
    ///     https://learn.microsoft.com/en-us/openapi/kiota/using
    ///     https://github.com/microsoft/kiota
    ///     Will print output using the logToConsole function.
    /// </summary>
    let private kiotaBaseCommand =
        dotnetBaseCommand {
            Arguments "tool run kiota"
            Output logDebug
        }

    /// <summary>
    ///     Generates a new SDK with provided parameters.
    /// </summary>
    /// <param name="clientName">The name of the client for the generated SDK.</param>
    /// <param name="clientNamespace">The namespace to use for generated SDK.</param>
    /// <param name="outputPath">The output path for generated SDK.</param>
    /// <param name="openApiYamlPath">The path to the OpenAPI YAML file.</param>
    let generateNewSdk (clientName: string, clientNamespace: string, outputPath: string, openApiYamlPath: string) =
        kiotaBaseCommand {
            Arguments
                (*
                    Use Kiota to generate an SDK
                    Will also create a kiota-lock.json with the used parameters
                    https://learn.microsoft.com/en-us/openapi/kiota/using#client-generation
                *)
                [
                 kiotaBaseCommand.config.Arguments |> Option.defaultValue ""  // Adds default arguments
                 "generate" // Use the generate command
                 "-l CSharp" // Set the generation langauge as C#
                 $"-c {clientName}" // Set the ClientName for generated SDK
                 $"-n {clientNamespace}" // Set the namespace for generated SDK
                 $"-d {openApiYamlPath}" // Set path/url of the OpenAPI YAML spec to generate from
                 $"-o {outputPath}" // Set the output path for generated SDK files
                 "--additional-data true" // Generate metadata
                 "--clean-output" // Clean files from output path
                 "--clear-cache" // Clear cache of OpenAPI spec
                 "--exclude-backward-compatible" // excludes backwards compat changes, keeps SDK up to date
                 "--deserializer Marqeta.Core.Sdk.Serialization.Text.TextHtmlParseNodeFactory" // Adds our custom deserializer for text/html
                 "--deserializer Marqeta.Core.Sdk.Serialization.Json.CustomJsonParseNodeFactory" // Adds our custom deserializer for application/json
                 // Adds the default Kiota deseriazliers for the SDK
                 "--deserializer Microsoft.Kiota.Serialization.Text.TextParseNodeFactory"
                 "--deserializer Microsoft.Kiota.Serialization.Form.FormParseNodeFactory"
                 "--exclude-path /webhooks/{event_type}/{resource_token}" // Excludes this endpoint from generation, clashes with /webhooks/{token}/{event_type}/{resource_token}
                ]
        }
        |> Command.execute
        |> ignore

    /// <summary>
    /// Updates an existing SDK at specified path.
    /// </summary>
    /// <param name="outputPath">The path of the existing SDK.</param>
    let updateExistingSdk (outputPath: string) =
        kiotaBaseCommand {
            (*
                Use Kiota to update an SDK
                Uses the kiota-lock.json in the outputPath for updating
                https://learn.microsoft.com/en-us/openapi/kiota/using#client-update
            *)
            Arguments
                [
                 kiotaBaseCommand.config.Arguments |> Option.defaultValue "" // Adds default arguments
                 "update" // Use the update command
                 $"-o {outputPath}" // Sets the output path
                 "--clean-output" // Clean files from output path
                 "--clear-cache" // Clear cache of OpenAPI spec
                ]
        }
        |> Command.execute
        |> ignore

    /// <summary>
    ///     Checks if an SDK exists at specified path.
    /// </summary>
    /// <param name="outputPath">The path to check for existing SDK.</param>
    /// <returns>true/false</returns>
    let clientExists (outputPath: string) =
        fileExists $"{outputPath}/kiota-lock.json"

/// <summary>
///     Helpers for performing HTTP Operations
/// </summary>
module Http =
    open FsHttp

    /// <summary>
    ///     Gets a file as a stream from a provided URL.
    /// </summary>
    /// <param name="url">URL of file to retrieve.</param>
    /// <returns>A stream representation of the requested file.</returns>
    let getFileFromUrl url =
        http { GET url } |> Request.send |> Response.toStream

open OpenApiHelpers
open FileHelpers
open LogHelpers
open Stopwatch
open SdkGenerator
open Http
open DotnetCli

/// Config type for the script
type GeneratorConfig = {OpenApiSourceUrl:string
                        SourceOpenApiOutputPath:string
                        TransformedOpenApiPath:string
                        SdkGeneratorTool:string
                        SdkOutputPath:string
                        SdkClientName:string
                        SdkClientNamespace:string}

/// <summary>
///     Transform an OpenAPI spec using specified config.
/// </summary>
/// <param name="generatorConfig">Configuration parameters for the OpenAPI spec transformation.</param>
/// <param name="stopwatch">Stopwatch for timing execution.</param>
let transformOpenApiSpec (generatorConfig: GeneratorConfig, stopwatch:System.Diagnostics.Stopwatch) =
    logOk($"Fetching document {generatorConfig.OpenApiSourceUrl} {getElapsedTime(stopwatch)}")
    let fetchedDocument = getFileFromUrl(generatorConfig.OpenApiSourceUrl)

    logOk($"Parsing document {generatorConfig.OpenApiSourceUrl} {getElapsedTime(stopwatch)}")
    let parsedOpenApiDocument, parsedOpenApiDocumentDiagnostics =
        getParsedOpenApiDocFromStream(fetchedDocument)

    logOk($"Diagnostics before fixing {getElapsedTime(stopwatch)}")
    logDiagnostics(parsedOpenApiDocumentDiagnostics, logWarn)

    logOk($"Writing to file {generatorConfig.SourceOpenApiOutputPath} {getElapsedTime(stopwatch)}")
    writeAllTextToPath(getOpenApiDocumentSerializedAsYaml(parsedOpenApiDocument), generatorConfig.SourceOpenApiOutputPath)
    
    logOk($"Applying fixes and validating {getElapsedTime(stopwatch)}")
    applyOpenApiDocumentModifications(parsedOpenApiDocument)
    let fixedOpenApiDocumentDiagnostics = validateDocument(parsedOpenApiDocument)

    logOk($"Diagnostics after fixing {getElapsedTime(stopwatch)}")
    logDiagnostics(fixedOpenApiDocumentDiagnostics, logWarn)

    logOk($"Writing to file {generatorConfig.TransformedOpenApiPath} {getElapsedTime(stopwatch)}")
    writeAllTextToPath(getOpenApiDocumentSerializedAsYaml(parsedOpenApiDocument), generatorConfig.TransformedOpenApiPath)

    logOk($"Finished transforming {generatorConfig.OpenApiSourceUrl} into {generatorConfig.TransformedOpenApiPath} {getElapsedTime(stopwatch)}")

/// <summary>
///     Generate SDK using specified config.
/// </summary>
/// <param name="generatorConfig">Configuration parameters for SDK Generation.</param>
/// <param name="stopwatch">Stopwatch for timing execution.</param>
let generateSdk (generatorConfig: GeneratorConfig, stopwatch: System.Diagnostics.Stopwatch) =
    logOk($"Restoring dotnet tools from manifest {getElapsedTime(stopwatch)}")
    restoreDotnetTools()

    logOk($"Generating client from {generatorConfig.TransformedOpenApiPath} with ClientName:({generatorConfig.SdkClientName}) ClientNamespace:({generatorConfig.SdkClientNamespace}) OutputPath:({generatorConfig.SdkOutputPath}) {getElapsedTime(stopwatch)}")
    if clientExists generatorConfig.SdkOutputPath then
        logOk($"Existing client found, updating {getElapsedTime(stopwatch)}")
        updateExistingSdk(generatorConfig.SdkOutputPath)
    else
        logOk($"No existing client found, generating new {getElapsedTime(stopwatch)}")
        generateNewSdk(generatorConfig.SdkClientName,
                       generatorConfig.SdkClientNamespace,
                       generatorConfig.SdkOutputPath,
                       generatorConfig.TransformedOpenApiPath)

    logOk($"Finished generating client {getElapsedTime(stopwatch)}")

let buildAndTestSolution (stopwatch: System.Diagnostics.Stopwatch) =
    logOk($"Building SLN {getElapsedTime(stopwatch)}")
    buildSolution()
    logOk($"Testing SLN {getElapsedTime(stopwatch)}")
    testSolution()

let projectPath = "Marqeta.Core.Sdk" // The path of the .csproj for SDK (also used for namespace)
let config = {
    // The source YAML, references Marqeta GitHub CoreAPI.yaml currently
    OpenApiSourceUrl = "https://raw.githubusercontent.com/marqeta/marqeta-openapi/main/yaml/CoreAPI.yaml"
    // The output path to save the source YAML to
    SourceOpenApiOutputPath = $"{projectPath}/SourceCoreAPI.yaml"
    // The output path to save the transformed YAML to
    TransformedOpenApiPath = $"{projectPath}/CoreAPI.yaml"
    // The dotnet tool to use for SDK generation
    SdkGeneratorTool = "Microsoft.OpenApi.Kiota"
    // The output path to use for generated SDK files
    SdkOutputPath = $"{projectPath}/Generated"
    // The client name to use for the generated SDK
    SdkClientName =  "MarqetaClient"
    // The namespace to use for the generated SDK
    SdkClientNamespace =  projectPath
}

let stopwatch = start

// Retrieve and transform the OpenAPI spec
transformOpenApiSpec(config, stopwatch)
// Generate an SDK using the transformed OpenAPI spec
generateSdk(config, stopwatch)

// Build and test SLN
buildAndTestSolution(stopwatch)

logOk($"Script completed, exiting {getElapsedTime(stop(stopwatch))}")