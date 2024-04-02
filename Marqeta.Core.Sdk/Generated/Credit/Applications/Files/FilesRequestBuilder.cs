// <auto-generated/>
using Marqeta.Core.Sdk.Credit.Applications.Files.Item;
using Marqeta.Core.Sdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Marqeta.Core.Sdk.Credit.Applications.Files {
    /// <summary>
    /// Builds and executes requests for operations under \credit\applications\files
    /// </summary>
    public class FilesRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the Marqeta.Core.Sdk.credit.applications.files.item collection</summary>
        /// <param name="position">The type of file to retrieve.* `SOCT` - The Summary of Credit Terms (SOCT), which outlines the interest rates, interest charges, and fees associated with the credit account being offered to the user.* `REWARDS_DISCLOSURE_PRE_TERMS` - The Rewards Disclosure Pre-terms, which discloses detailed information about the rewards program on the credit account being offered to the user before a decision is rendered on their application.* `REWARDS_DISCLOSURE_POST_TERMS` - The Rewards Disclosure Post-terms, which discloses detailed information about the rewards program on the user&apos;s credit account if their application is approved.* `BENEFITS_DISCLOSURE` - The Benefits Disclosure, which which is given to a user if their application is approved and discloses detailed information about the benefits on the user&apos;s credit account.* `CARD_MEMBER_AGREEMENT` - The Card Member Agreement, which specifies the terms and conditions of the user&apos;s credit account, including the interest rates, interest charges, fees, minimum payment calculations, and more.* `PRIVACY_POLICY` - The Privacy Policy, which explains how the information on the user&apos;s application is collected, handled, and processed.* `E_DISCLOSURE` - The eDisclosure, which states that the user has agreed to receive disclosures electronically.* `TERMS_SCHEDULE` - The Terms Schedule, which is given to a user if their application is approved and specifies the interest rate details on the user&apos;s credit account.* `NOAA` - The Notice of Adverse Action (NOAA), which is given to a user if their application is declined and informs them of the specific reasons why they were denied a credit account.</param>
        /// <returns>A <see cref="WithTypeItemRequestBuilder"/></returns>
        public WithTypeItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("type", position);
            return new WithTypeItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new <see cref="FilesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FilesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/credit/applications/files{?application_token*,bundle_token*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="FilesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FilesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/credit/applications/files{?application_token*,bundle_token*}", rawUrl) {
        }
        /// <summary>
        /// Retrieve an array of files on a bundle or applicationEach top-level object returned in the array contains the fields documented in the &lt;&lt;/core-api/credit-applications#_response_body_4, response body&gt;&gt;. The name of each object is its corresponding file type:* `BENEFITS_DISCLOSURE`* `CARD_MEMBER_AGREEMENT`* `E_DISCLOSURE`* `NOAA`* `PRIVACY_POLICY`* `REWARDS_DISCLOSURE_PRE_TERMS`* `REWARDS_DISCLOSURE_POST_TERMS`* `SOCT`* `TERMS_SCHEDULE`
        /// </summary>
        /// <returns>A <see cref="FileMapResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<FileMapResponse?> GetAsync(Action<RequestConfiguration<FilesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<FileMapResponse> GetAsync(Action<RequestConfiguration<FilesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"XXX", ApiError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<FileMapResponse>(requestInfo, FileMapResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieve an array of files on a bundle or applicationEach top-level object returned in the array contains the fields documented in the &lt;&lt;/core-api/credit-applications#_response_body_4, response body&gt;&gt;. The name of each object is its corresponding file type:* `BENEFITS_DISCLOSURE`* `CARD_MEMBER_AGREEMENT`* `E_DISCLOSURE`* `NOAA`* `PRIVACY_POLICY`* `REWARDS_DISCLOSURE_PRE_TERMS`* `REWARDS_DISCLOSURE_POST_TERMS`* `SOCT`* `TERMS_SCHEDULE`
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<FilesRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<FilesRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="FilesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public FilesRequestBuilder WithUrl(string rawUrl) {
            return new FilesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Retrieve an array of files on a bundle or applicationEach top-level object returned in the array contains the fields documented in the &lt;&lt;/core-api/credit-applications#_response_body_4, response body&gt;&gt;. The name of each object is its corresponding file type:* `BENEFITS_DISCLOSURE`* `CARD_MEMBER_AGREEMENT`* `E_DISCLOSURE`* `NOAA`* `PRIVACY_POLICY`* `REWARDS_DISCLOSURE_PRE_TERMS`* `REWARDS_DISCLOSURE_POST_TERMS`* `SOCT`* `TERMS_SCHEDULE`
        /// </summary>
        public class FilesRequestBuilderGetQueryParameters {
            /// <summary>Unique identifier of the application whose files you want to retrieve.The following file types are returned with the `application_token`:* `BENEFITS_DISCLOSURE`* `CARD_MEMBER_AGREEMENT`* `E_DISCLOSURE`* `NOAA`* `PRIVACY_POLICY`* `REWARDS_DISCLOSURE_PRE_TERMS`* `REWARDS_DISCLOSURE_POST_TERMS`* `SOCT`* `TERMS_SCHEDULE`</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("application_token")]
            public string? ApplicationToken { get; set; }
#nullable restore
#else
            [QueryParameter("application_token")]
            public string ApplicationToken { get; set; }
#endif
            /// <summary>Unique identifier of the bundle whose files you want to retrieve.The following file types are returned with the `bundle_token`:* `CARD_MEMBER_AGREEMENT`* `E_DISCLOSURE`* `PRIVACY_POLICY`* `REWARDS_DISCLOSURE_PRE_TERMS`* `REWARDS_DISCLOSURE_POST_TERMS`* `SOCT`</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("bundle_token")]
            public string? BundleToken { get; set; }
#nullable restore
#else
            [QueryParameter("bundle_token")]
            public string BundleToken { get; set; }
#endif
        }
    }
}