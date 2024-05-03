// <auto-generated/>
using Marqeta.Core.Sdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Marqeta.Core.Sdk.Kyc.Business.Item {
    /// <summary>
    /// Builds and executes requests for operations under \kyc\business\{business_token}
    /// </summary>
    public class WithBusiness_tokenItemRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new <see cref="WithBusiness_tokenItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithBusiness_tokenItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/kyc/business/{business_token}{?count*,fields*,sort_by*,start_index*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="WithBusiness_tokenItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithBusiness_tokenItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/kyc/business/{business_token}{?count*,fields*,sort_by*,start_index*}", rawUrl) {
        }
        /// <summary>
        /// Use this endpoint to retrieve all KYC verification results for a business.This endpoint supports &lt;&lt;/core-api/sorting-and-pagination, pagination&gt;&gt;.=== Business KYC outcome reasons (business response)The following tables describe KYC outcome reasons potentially returned in the `outcome_reasons` field of the business `result` response object when a business is in a `PENDING` or `FAILURE` state.Where possible, they also describe acceptable documents that your customers can submit to resolve `PENDING` outcomes.==== Outcome reasons for the businessThese outcome reasons pertain to the business organization itself.[cols=&quot;,,2a&quot;]|===| Outcome Reason and State | Description | Accepted Documents| AddressIssue   +`PENDING`| Missing, invalid, mismatched, or PO Box address.| One of the following documents.Document must show the full business name and address:* Bank statement* Utility bill* Current lease or rental agreement* Insurance policy| BusinessNameIssue   +`PENDING`| Invalid or mismatched name.| Articles or certificate of incorporation.| OFACIssue   +`FAILURE`| Business appears on an OFAC list.| This outcome requires a manual review by Marqeta to determine the next appropriate step.Contact your Marqeta representative.| RegistrationIssue   +`PENDING`| Business is inactive, not registered, or not in good standing with the Secretary of State; recently reported or not recently updated.| This outcome requires a manual review by Marqeta to determine the next appropriate step.Contact your Marqeta representative.| Sanctions List Non-OFAC   +`PENDING`| Business appears on a non-OFAC screening list, bankruptcy, or alert list.| This outcome requires a manual review by Marqeta to determine the next appropriate step.Contact your Marqeta representative.| TINIssue   +`PENDING`| Missing, invalid, or mismatched Tax Identification Number (TIN).| IRS Notice Letter 147C or CP575, or most recent tax return.|======== Outcome reasons for individuals associated with a businessThese outcome reasons pertain to individuals associated with a business: proprietors, business officers, and beneficial owners.[cols=&quot;,,2a&quot;]|===| Outcome Reason and State | Description | Accepted Documents| AddressIssue   +`PENDING`| Missing, invalid, mismatched, or PO Box address.| One of the following documents.Document must show the full name and address:* Unexpired state-issued driver&apos;s license or identification card* US Military Identification Card* Utility bill* Bank statement* Current rental or lease agreement* Mortgage statement| DateOfBirthIssue   +`PENDING`| Invalid or mismatched date of birth.| Unexpired government-issued photo identification that shows name and date of birth:* Driver&apos;s license or state-issued identification card* Passport| NameIssue   +`PENDING`| Invalid or mismatched name.| Unexpired government-issued photo identification that has name and date of birth:* Driver&apos;s license or state-issued identification card* Passport or US passport card| NoRecordFound   +`FAILURE`| No records were found for this individual.| As no record was found for this individual, supporting documentation must be provided for each attribute (name, date of birth, address, and SSN):* To verify an individual&apos;s address, provide one of these documents:** Unexpired state-issued driver&apos;s license or identification card** US Military Identification Card** Utility bill** Bank statement** Current rental or lease agreement** Mortgage statement* To verify an individual&apos;s name and date of birth, provide one of these documents:** Driver&apos;s license or state-issued identification card** Passport* To verify an individual&apos;s Social Security Number, provide one of these documents:** Social Security card** Recent W-2 or 1099 showing nine-digit SSN, full name, and address.** ITIN card or document showing ITIN approval| OFAC   +`FAILURE`| Appears on an Office of Foreign Assets Control (OFAC) list.| This outcome requires a manual review by Marqeta to determine the next appropriate step.Contact your Marqeta representative.| RiskIssue   +`FAILURE`| Appears on a non-OFAC screening list, bankruptcy, or alert list, or has an insufficient record.| This outcome requires a manual review by Marqeta to determine the next appropriate step.Contact your Marqeta representative.//| SSNFail   +`FAILURE`//| Social Security Number (SSN) appears on Network Alert List, is of a deceased person, or was issued before the individual&apos;s date of birth.//| This outcome requires a manual review by Marqeta to determine the next appropriate step.//Contact your Marqeta representative.//Code removed per https://marqeta.atlassian.net/browse/ID-3574, commenting out in case we ever add it back.| SSNIssue   +`PENDING`| Missing, invalid, or mismatched SSN.| * Social Security card* Recent W-2 or 1099 showing nine-digit SSN, full name, and address.* ITIN card or document showing ITIN approval| warmaddress   +`FAILURE`| Address is a PO box or other post office address, virtual address, UPS store, mail forward, or mail drop.Such addresses are not valid for KYC verification.| One of the following documents.Document must show the full name and valid street address:* Unexpired state-issued driver&apos;s license or identification card* US Military Identification Card* Utility bill* Bank statement* Current rental or lease agreement* Mortgage statement|===
        /// </summary>
        /// <returns>A <see cref="KYCListResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<KYCListResponse?> GetAsync(Action<RequestConfiguration<WithBusiness_tokenItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<KYCListResponse> GetAsync(Action<RequestConfiguration<WithBusiness_tokenItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"XXX", ApiError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<KYCListResponse>(requestInfo, KYCListResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Use this endpoint to retrieve all KYC verification results for a business.This endpoint supports &lt;&lt;/core-api/sorting-and-pagination, pagination&gt;&gt;.=== Business KYC outcome reasons (business response)The following tables describe KYC outcome reasons potentially returned in the `outcome_reasons` field of the business `result` response object when a business is in a `PENDING` or `FAILURE` state.Where possible, they also describe acceptable documents that your customers can submit to resolve `PENDING` outcomes.==== Outcome reasons for the businessThese outcome reasons pertain to the business organization itself.[cols=&quot;,,2a&quot;]|===| Outcome Reason and State | Description | Accepted Documents| AddressIssue   +`PENDING`| Missing, invalid, mismatched, or PO Box address.| One of the following documents.Document must show the full business name and address:* Bank statement* Utility bill* Current lease or rental agreement* Insurance policy| BusinessNameIssue   +`PENDING`| Invalid or mismatched name.| Articles or certificate of incorporation.| OFACIssue   +`FAILURE`| Business appears on an OFAC list.| This outcome requires a manual review by Marqeta to determine the next appropriate step.Contact your Marqeta representative.| RegistrationIssue   +`PENDING`| Business is inactive, not registered, or not in good standing with the Secretary of State; recently reported or not recently updated.| This outcome requires a manual review by Marqeta to determine the next appropriate step.Contact your Marqeta representative.| Sanctions List Non-OFAC   +`PENDING`| Business appears on a non-OFAC screening list, bankruptcy, or alert list.| This outcome requires a manual review by Marqeta to determine the next appropriate step.Contact your Marqeta representative.| TINIssue   +`PENDING`| Missing, invalid, or mismatched Tax Identification Number (TIN).| IRS Notice Letter 147C or CP575, or most recent tax return.|======== Outcome reasons for individuals associated with a businessThese outcome reasons pertain to individuals associated with a business: proprietors, business officers, and beneficial owners.[cols=&quot;,,2a&quot;]|===| Outcome Reason and State | Description | Accepted Documents| AddressIssue   +`PENDING`| Missing, invalid, mismatched, or PO Box address.| One of the following documents.Document must show the full name and address:* Unexpired state-issued driver&apos;s license or identification card* US Military Identification Card* Utility bill* Bank statement* Current rental or lease agreement* Mortgage statement| DateOfBirthIssue   +`PENDING`| Invalid or mismatched date of birth.| Unexpired government-issued photo identification that shows name and date of birth:* Driver&apos;s license or state-issued identification card* Passport| NameIssue   +`PENDING`| Invalid or mismatched name.| Unexpired government-issued photo identification that has name and date of birth:* Driver&apos;s license or state-issued identification card* Passport or US passport card| NoRecordFound   +`FAILURE`| No records were found for this individual.| As no record was found for this individual, supporting documentation must be provided for each attribute (name, date of birth, address, and SSN):* To verify an individual&apos;s address, provide one of these documents:** Unexpired state-issued driver&apos;s license or identification card** US Military Identification Card** Utility bill** Bank statement** Current rental or lease agreement** Mortgage statement* To verify an individual&apos;s name and date of birth, provide one of these documents:** Driver&apos;s license or state-issued identification card** Passport* To verify an individual&apos;s Social Security Number, provide one of these documents:** Social Security card** Recent W-2 or 1099 showing nine-digit SSN, full name, and address.** ITIN card or document showing ITIN approval| OFAC   +`FAILURE`| Appears on an Office of Foreign Assets Control (OFAC) list.| This outcome requires a manual review by Marqeta to determine the next appropriate step.Contact your Marqeta representative.| RiskIssue   +`FAILURE`| Appears on a non-OFAC screening list, bankruptcy, or alert list, or has an insufficient record.| This outcome requires a manual review by Marqeta to determine the next appropriate step.Contact your Marqeta representative.//| SSNFail   +`FAILURE`//| Social Security Number (SSN) appears on Network Alert List, is of a deceased person, or was issued before the individual&apos;s date of birth.//| This outcome requires a manual review by Marqeta to determine the next appropriate step.//Contact your Marqeta representative.//Code removed per https://marqeta.atlassian.net/browse/ID-3574, commenting out in case we ever add it back.| SSNIssue   +`PENDING`| Missing, invalid, or mismatched SSN.| * Social Security card* Recent W-2 or 1099 showing nine-digit SSN, full name, and address.* ITIN card or document showing ITIN approval| warmaddress   +`FAILURE`| Address is a PO box or other post office address, virtual address, UPS store, mail forward, or mail drop.Such addresses are not valid for KYC verification.| One of the following documents.Document must show the full name and valid street address:* Unexpired state-issued driver&apos;s license or identification card* US Military Identification Card* Utility bill* Bank statement* Current rental or lease agreement* Mortgage statement|===
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<WithBusiness_tokenItemRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<WithBusiness_tokenItemRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="WithBusiness_tokenItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public WithBusiness_tokenItemRequestBuilder WithUrl(string rawUrl) {
            return new WithBusiness_tokenItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Use this endpoint to retrieve all KYC verification results for a business.This endpoint supports &lt;&lt;/core-api/sorting-and-pagination, pagination&gt;&gt;.=== Business KYC outcome reasons (business response)The following tables describe KYC outcome reasons potentially returned in the `outcome_reasons` field of the business `result` response object when a business is in a `PENDING` or `FAILURE` state.Where possible, they also describe acceptable documents that your customers can submit to resolve `PENDING` outcomes.==== Outcome reasons for the businessThese outcome reasons pertain to the business organization itself.[cols=&quot;,,2a&quot;]|===| Outcome Reason and State | Description | Accepted Documents| AddressIssue   +`PENDING`| Missing, invalid, mismatched, or PO Box address.| One of the following documents.Document must show the full business name and address:* Bank statement* Utility bill* Current lease or rental agreement* Insurance policy| BusinessNameIssue   +`PENDING`| Invalid or mismatched name.| Articles or certificate of incorporation.| OFACIssue   +`FAILURE`| Business appears on an OFAC list.| This outcome requires a manual review by Marqeta to determine the next appropriate step.Contact your Marqeta representative.| RegistrationIssue   +`PENDING`| Business is inactive, not registered, or not in good standing with the Secretary of State; recently reported or not recently updated.| This outcome requires a manual review by Marqeta to determine the next appropriate step.Contact your Marqeta representative.| Sanctions List Non-OFAC   +`PENDING`| Business appears on a non-OFAC screening list, bankruptcy, or alert list.| This outcome requires a manual review by Marqeta to determine the next appropriate step.Contact your Marqeta representative.| TINIssue   +`PENDING`| Missing, invalid, or mismatched Tax Identification Number (TIN).| IRS Notice Letter 147C or CP575, or most recent tax return.|======== Outcome reasons for individuals associated with a businessThese outcome reasons pertain to individuals associated with a business: proprietors, business officers, and beneficial owners.[cols=&quot;,,2a&quot;]|===| Outcome Reason and State | Description | Accepted Documents| AddressIssue   +`PENDING`| Missing, invalid, mismatched, or PO Box address.| One of the following documents.Document must show the full name and address:* Unexpired state-issued driver&apos;s license or identification card* US Military Identification Card* Utility bill* Bank statement* Current rental or lease agreement* Mortgage statement| DateOfBirthIssue   +`PENDING`| Invalid or mismatched date of birth.| Unexpired government-issued photo identification that shows name and date of birth:* Driver&apos;s license or state-issued identification card* Passport| NameIssue   +`PENDING`| Invalid or mismatched name.| Unexpired government-issued photo identification that has name and date of birth:* Driver&apos;s license or state-issued identification card* Passport or US passport card| NoRecordFound   +`FAILURE`| No records were found for this individual.| As no record was found for this individual, supporting documentation must be provided for each attribute (name, date of birth, address, and SSN):* To verify an individual&apos;s address, provide one of these documents:** Unexpired state-issued driver&apos;s license or identification card** US Military Identification Card** Utility bill** Bank statement** Current rental or lease agreement** Mortgage statement* To verify an individual&apos;s name and date of birth, provide one of these documents:** Driver&apos;s license or state-issued identification card** Passport* To verify an individual&apos;s Social Security Number, provide one of these documents:** Social Security card** Recent W-2 or 1099 showing nine-digit SSN, full name, and address.** ITIN card or document showing ITIN approval| OFAC   +`FAILURE`| Appears on an Office of Foreign Assets Control (OFAC) list.| This outcome requires a manual review by Marqeta to determine the next appropriate step.Contact your Marqeta representative.| RiskIssue   +`FAILURE`| Appears on a non-OFAC screening list, bankruptcy, or alert list, or has an insufficient record.| This outcome requires a manual review by Marqeta to determine the next appropriate step.Contact your Marqeta representative.//| SSNFail   +`FAILURE`//| Social Security Number (SSN) appears on Network Alert List, is of a deceased person, or was issued before the individual&apos;s date of birth.//| This outcome requires a manual review by Marqeta to determine the next appropriate step.//Contact your Marqeta representative.//Code removed per https://marqeta.atlassian.net/browse/ID-3574, commenting out in case we ever add it back.| SSNIssue   +`PENDING`| Missing, invalid, or mismatched SSN.| * Social Security card* Recent W-2 or 1099 showing nine-digit SSN, full name, and address.* ITIN card or document showing ITIN approval| warmaddress   +`FAILURE`| Address is a PO box or other post office address, virtual address, UPS store, mail forward, or mail drop.Such addresses are not valid for KYC verification.| One of the following documents.Document must show the full name and valid street address:* Unexpired state-issued driver&apos;s license or identification card* US Military Identification Card* Utility bill* Bank statement* Current rental or lease agreement* Mortgage statement|===
        /// </summary>
        public class WithBusiness_tokenItemRequestBuilderGetQueryParameters {
            /// <summary>The number of resources to retrieve.</summary>
            [QueryParameter("count")]
            public int? Count { get; set; }
            /// <summary>Comma-delimited list of fields to return (`field_1,field_2`, and so on).Leave blank to return all fields.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields")]
            public string? Fields { get; set; }
#nullable restore
#else
            [QueryParameter("fields")]
            public string Fields { get; set; }
#endif
            /// <summary>Field on which to sort.Use any field in the resource model, or one of the system fields `lastModifiedTime` or `createdTime`.Prefix the field name with a hyphen (`-`) to sort in descending order.Omit the hyphen to sort in ascending order.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("sort_by")]
            public string? SortBy { get; set; }
#nullable restore
#else
            [QueryParameter("sort_by")]
            public string SortBy { get; set; }
#endif
            /// <summary>The sort order index of the first resource in the returned array.</summary>
            [QueryParameter("start_index")]
            public int? StartIndex { get; set; }
        }
    }
}
