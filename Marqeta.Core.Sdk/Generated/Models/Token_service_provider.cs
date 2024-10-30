// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Marqeta.Core.Sdk.Models
{
    /// <summary>
    /// Contains information held and provided by the token service provider (card network).
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Token_service_provider : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Unique value representing a tokenization request (Mastercard only).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CorrelationId { get; set; }
#nullable restore
#else
        public string CorrelationId { get; set; }
#endif
        /// <summary>Unique identifier of the digital wallet token primary account number (PAN) within the card network.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PanReferenceId { get; set; }
#nullable restore
#else
        public string PanReferenceId { get; set; }
#endif
        /// <summary>_(Mastercard only)_ Represents the confidence level in the digital wallet token.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TokenAssuranceLevel { get; set; }
#nullable restore
#else
        public string TokenAssuranceLevel { get; set; }
#endif
        /// <summary>Digital wallet&apos;s decision as to whether the digital wallet token should be provisioned.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TokenEligibilityDecision { get; set; }
#nullable restore
#else
        public string TokenEligibilityDecision { get; set; }
#endif
        /// <summary>Expiration date of the digital wallet token.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TokenExpiration { get; set; }
#nullable restore
#else
        public string TokenExpiration { get; set; }
#endif
        /// <summary>Primary account number (PAN) of the digital wallet token.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TokenPan { get; set; }
#nullable restore
#else
        public string TokenPan { get; set; }
#endif
        /// <summary>Unique identifier of the digital wallet token within the card network.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TokenReferenceId { get; set; }
#nullable restore
#else
        public string TokenReferenceId { get; set; }
#endif
        /// <summary>Unique numerical identifier of the token requestor within the card network.These ID numbers map to `token_requestor_name` field values as follows:*Mastercard** 50110030273 – `APPLE_PAY`* 50120834693 – `ANDROID_PAY`* 50139059239 – `SAMSUNG_PAY`*Visa** 40010030273 – `APPLE_PAY`* 40010075001 – `ANDROID_PAY`* 40010043095 – `SAMSUNG_PAY`* 40010075196 – `MICROSOFT_PAY`* 40010075338 – `VISA_CHECKOUT`* 40010075449 – `FACEBOOK`* 40010075839 – `NETFLIX`* 40010077056 – `FITBIT_PAY`* 40010069887 – `GARMIN_PAY`</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TokenRequestorId { get; set; }
#nullable restore
#else
        public string TokenRequestorId { get; set; }
#endif
        /// <summary>Name of the token requestor within the card network.*NOTE:* The list of example values for this field is maintained by the card networks and is subject to change.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TokenRequestorName { get; set; }
#nullable restore
#else
        public string TokenRequestorName { get; set; }
#endif
        /// <summary>Token score assigned by the digital wallet.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TokenScore { get; set; }
#nullable restore
#else
        public string TokenScore { get; set; }
#endif
        /// <summary>Type of the digital wallet token.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TokenType { get; set; }
#nullable restore
#else
        public string TokenType { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.Token_service_provider"/> and sets the default values.
        /// </summary>
        public Token_service_provider()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.Token_service_provider"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.Token_service_provider CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.Token_service_provider();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "correlation_id", n => { CorrelationId = n.GetStringValue(); } },
                { "pan_reference_id", n => { PanReferenceId = n.GetStringValue(); } },
                { "token_assurance_level", n => { TokenAssuranceLevel = n.GetStringValue(); } },
                { "token_eligibility_decision", n => { TokenEligibilityDecision = n.GetStringValue(); } },
                { "token_expiration", n => { TokenExpiration = n.GetStringValue(); } },
                { "token_pan", n => { TokenPan = n.GetStringValue(); } },
                { "token_reference_id", n => { TokenReferenceId = n.GetStringValue(); } },
                { "token_requestor_id", n => { TokenRequestorId = n.GetStringValue(); } },
                { "token_requestor_name", n => { TokenRequestorName = n.GetStringValue(); } },
                { "token_score", n => { TokenScore = n.GetStringValue(); } },
                { "token_type", n => { TokenType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("correlation_id", CorrelationId);
            writer.WriteStringValue("pan_reference_id", PanReferenceId);
            writer.WriteStringValue("token_assurance_level", TokenAssuranceLevel);
            writer.WriteStringValue("token_eligibility_decision", TokenEligibilityDecision);
            writer.WriteStringValue("token_expiration", TokenExpiration);
            writer.WriteStringValue("token_pan", TokenPan);
            writer.WriteStringValue("token_reference_id", TokenReferenceId);
            writer.WriteStringValue("token_requestor_id", TokenRequestorId);
            writer.WriteStringValue("token_requestor_name", TokenRequestorName);
            writer.WriteStringValue("token_score", TokenScore);
            writer.WriteStringValue("token_type", TokenType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
