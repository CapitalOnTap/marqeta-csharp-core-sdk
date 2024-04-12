// <auto-generated/>
using Marqeta.Core.Sdk.Kyc.Business;
using Marqeta.Core.Sdk.Kyc.Item;
using Marqeta.Core.Sdk.Kyc.User;
using Marqeta.Core.Sdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Marqeta.Core.Sdk.Kyc {
    /// <summary>
    /// Builds and executes requests for operations under \kyc
    /// </summary>
    public class KycRequestBuilder : BaseRequestBuilder {
        /// <summary>The business property</summary>
        public BusinessRequestBuilder Business { get =>
            new BusinessRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The user property</summary>
        public UserRequestBuilder User { get =>
            new UserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Marqeta.Core.Sdk.kyc.item collection</summary>
        /// <param name="position">Unique identifier of the KYC verification for which you want to retrieve the result.</param>
        /// <returns>A <see cref="WithTokenItemRequestBuilder"/></returns>
        public WithTokenItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("token", position);
            return new WithTokenItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new <see cref="KycRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public KycRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/kyc", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="KycRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public KycRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/kyc", rawUrl) {
        }
        /// <summary>
        /// Use this endpoint to verify the identity of an account holder in the United States, either a user or a business.You can perform KYC verification on an account holder, provided the following are true:* The KYC status of the account holder is `UNVERIFIED` or `LIMITED`* The account holder has not been submitted for KYC verification twice=== Required fieldsIn order to perform KYC verification, the user or business resource on which you perform the check must have the following fields configured with valid values:[cols=&quot;1a,1a&quot;]|===| User Fields Required for KYC | Business Fields Required for KYC|* `first_name` (legal first name only, no prefixes)* `last_name` (legal last name only, no suffixes)* `address1` (cannot be a PO Box)* `city`* `state`* `postal_code`* `country`* `birth_date`* `ssn` (nine digits, no delimiters)* `email` (required in some cases)* `phone` (required in some cases)|* `business_name_legal` (128 char max)* `business_name_dba` (&quot;Doing Business As&quot; or fictitious business name; enter the legal business name in this field if your business does not use a fictitious business name)* `office_location` (cannot be a PO Box; `state` field must use a &lt;&lt;valid_state_provincial_and_territorial_abbreviations, valid two-letter state, provincial, or territorial abbreviation&gt;&gt;)* `identifications` (nine digits, no delimiters)* `incorporation.incorporation_type`* `incorporation.state_of_incorporation`* `date_established`* `proprietor_or_officer`* `beneficial_owner` (maximum of four beneficial owners)* `proprietor_is_beneficial_owner` (required if the business proprietor or officer is also a beneficial owner)* `attestation_consent`* `attester_name`* `attestation_date`|======= Valid state, provincial, and territorial abbreviationsThe following list includes all valid two-letter abbreviations for US states, territories, and military (APO/FPO/DPO) addresses.It also includes abbreviations for Canadian provinces and territories.State, provincial, and territorial abbreviations are case sensitive, and must be in uppercase as they appear in this list:* `AL`: Alabama* `AK`: Alaska* `AB`: Alberta* `AS`: American Samoa* `AZ`: Arizona* `AR`: Arkansas* `AE`: Armed Forces* `AA`: Armed Forces Americas* `AP`: Armed Forces Pacific* `BC`: British Columbia* `CA`: California* `CO`: Colorado* `CT`: Connecticut* `DE`: Delaware* `DC`: District of Columbia* `FL`: Florida* `GA`: Georgia* `GU`: Guam* `HI`: Hawaii* `ID`: Idaho* `IL`: Illinois* `IN`: Indiana* `IA`: Iowa* `KS`: Kansas* `KY`: Kentucky* `LA`: Louisiana* `ME`: Maine* `MB`: Manitoba* `MD`: Maryland* `MA`: Massachusetts* `MI`: Michigan* `MN`: Minnesota* `MS`: Mississippi* `MO`: Missouri* `MT`: Montana* `NE`: Nebraska* `NV`: Nevada* `NB`: New Brunswick* `NH`: New Hampshire* `NJ`: New Jersey* `NM`: New Mexico* `NY`: New York* `NF`: Newfoundland* `NC`: North Carolina* `ND`: North Dakota* `NT`: Northwest Territories* `NS`: Nova Scotia* `NU`: Nunavut* `OH`: Ohio* `OK`: Oklahoma* `ON`: Ontario* `OR`: Oregon* `PA`: Pennsylvania* `PE`: Prince Edward Island* `PR`: Puerto Rico* `QC`: Quebec* `RI`: Rhode Island* `SK`: Saskatchewan* `SC`: South Carolina* `SD`: South Dakota* `TN`: Tennessee* `TX`: Texas* `UT`: Utah* `VT`: Vermont* `VI`: Virgin Islands* `VA`: Virginia* `WA`: Washington* `WV`: West Virginia* `WI`: Wisconsin* `WY`: Wyoming* `YT`: Yukon Territory
        /// </summary>
        /// <returns>A <see cref="Kyc_response"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Kyc_response?> PostAsync(Kyc_request body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Kyc_response> PostAsync(Kyc_request body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"XXX", ApiError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Kyc_response>(requestInfo, Kyc_response.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Use this endpoint to verify the identity of an account holder in the United States, either a user or a business.You can perform KYC verification on an account holder, provided the following are true:* The KYC status of the account holder is `UNVERIFIED` or `LIMITED`* The account holder has not been submitted for KYC verification twice=== Required fieldsIn order to perform KYC verification, the user or business resource on which you perform the check must have the following fields configured with valid values:[cols=&quot;1a,1a&quot;]|===| User Fields Required for KYC | Business Fields Required for KYC|* `first_name` (legal first name only, no prefixes)* `last_name` (legal last name only, no suffixes)* `address1` (cannot be a PO Box)* `city`* `state`* `postal_code`* `country`* `birth_date`* `ssn` (nine digits, no delimiters)* `email` (required in some cases)* `phone` (required in some cases)|* `business_name_legal` (128 char max)* `business_name_dba` (&quot;Doing Business As&quot; or fictitious business name; enter the legal business name in this field if your business does not use a fictitious business name)* `office_location` (cannot be a PO Box; `state` field must use a &lt;&lt;valid_state_provincial_and_territorial_abbreviations, valid two-letter state, provincial, or territorial abbreviation&gt;&gt;)* `identifications` (nine digits, no delimiters)* `incorporation.incorporation_type`* `incorporation.state_of_incorporation`* `date_established`* `proprietor_or_officer`* `beneficial_owner` (maximum of four beneficial owners)* `proprietor_is_beneficial_owner` (required if the business proprietor or officer is also a beneficial owner)* `attestation_consent`* `attester_name`* `attestation_date`|======= Valid state, provincial, and territorial abbreviationsThe following list includes all valid two-letter abbreviations for US states, territories, and military (APO/FPO/DPO) addresses.It also includes abbreviations for Canadian provinces and territories.State, provincial, and territorial abbreviations are case sensitive, and must be in uppercase as they appear in this list:* `AL`: Alabama* `AK`: Alaska* `AB`: Alberta* `AS`: American Samoa* `AZ`: Arizona* `AR`: Arkansas* `AE`: Armed Forces* `AA`: Armed Forces Americas* `AP`: Armed Forces Pacific* `BC`: British Columbia* `CA`: California* `CO`: Colorado* `CT`: Connecticut* `DE`: Delaware* `DC`: District of Columbia* `FL`: Florida* `GA`: Georgia* `GU`: Guam* `HI`: Hawaii* `ID`: Idaho* `IL`: Illinois* `IN`: Indiana* `IA`: Iowa* `KS`: Kansas* `KY`: Kentucky* `LA`: Louisiana* `ME`: Maine* `MB`: Manitoba* `MD`: Maryland* `MA`: Massachusetts* `MI`: Michigan* `MN`: Minnesota* `MS`: Mississippi* `MO`: Missouri* `MT`: Montana* `NE`: Nebraska* `NV`: Nevada* `NB`: New Brunswick* `NH`: New Hampshire* `NJ`: New Jersey* `NM`: New Mexico* `NY`: New York* `NF`: Newfoundland* `NC`: North Carolina* `ND`: North Dakota* `NT`: Northwest Territories* `NS`: Nova Scotia* `NU`: Nunavut* `OH`: Ohio* `OK`: Oklahoma* `ON`: Ontario* `OR`: Oregon* `PA`: Pennsylvania* `PE`: Prince Edward Island* `PR`: Puerto Rico* `QC`: Quebec* `RI`: Rhode Island* `SK`: Saskatchewan* `SC`: South Carolina* `SD`: South Dakota* `TN`: Tennessee* `TX`: Texas* `UT`: Utah* `VT`: Vermont* `VI`: Virgin Islands* `VA`: Virginia* `WA`: Washington* `WV`: West Virginia* `WI`: Wisconsin* `WY`: Wyoming* `YT`: Yukon Territory
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Kyc_request body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Kyc_request body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="KycRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public KycRequestBuilder WithUrl(string rawUrl) {
            return new KycRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
