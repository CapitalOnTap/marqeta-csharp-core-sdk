// <auto-generated/>
#pragma warning disable CS0618
using Marqeta.Core.Sdk.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Marqeta.Core.Sdk.Users.Item.Ssn
{
    /// <summary>
    /// Builds and executes requests for operations under \users\{parent_token-id}\ssn
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class SsnRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Users.Item.Ssn.SsnRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SsnRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{parent_token%2Did}/ssn{?full_ssn*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Users.Item.Ssn.SsnRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SsnRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{parent_token%2Did}/ssn{?full_ssn*}", rawUrl)
        {
        }
        /// <summary>
        /// To retrieve the government-issued identification number for a user, send a `GET` request to the `/users/{token}/ssn` endpoint.Include the `token` path parameter to specify the user whose identification number (SSN, TIN, NIN, SIN) you wish to return.You can indicate whether to return the full number or the last four digits only.
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.Ssn_response_model"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Marqeta.Core.Sdk.Models.ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Marqeta.Core.Sdk.Models.Ssn_response_model?> GetAsync(Action<RequestConfiguration<global::Marqeta.Core.Sdk.Users.Item.Ssn.SsnRequestBuilder.SsnRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Marqeta.Core.Sdk.Models.Ssn_response_model> GetAsync(Action<RequestConfiguration<global::Marqeta.Core.Sdk.Users.Item.Ssn.SsnRequestBuilder.SsnRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Marqeta.Core.Sdk.Models.ApiError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Marqeta.Core.Sdk.Models.Ssn_response_model>(requestInfo, global::Marqeta.Core.Sdk.Models.Ssn_response_model.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// To retrieve the government-issued identification number for a user, send a `GET` request to the `/users/{token}/ssn` endpoint.Include the `token` path parameter to specify the user whose identification number (SSN, TIN, NIN, SIN) you wish to return.You can indicate whether to return the full number or the last four digits only.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Marqeta.Core.Sdk.Users.Item.Ssn.SsnRequestBuilder.SsnRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Marqeta.Core.Sdk.Users.Item.Ssn.SsnRequestBuilder.SsnRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Users.Item.Ssn.SsnRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Marqeta.Core.Sdk.Users.Item.Ssn.SsnRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Marqeta.Core.Sdk.Users.Item.Ssn.SsnRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// To retrieve the government-issued identification number for a user, send a `GET` request to the `/users/{token}/ssn` endpoint.Include the `token` path parameter to specify the user whose identification number (SSN, TIN, NIN, SIN) you wish to return.You can indicate whether to return the full number or the last four digits only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class SsnRequestBuilderGetQueryParameters 
        {
            /// <summary>To return the full identification number, set to `true`.To return only the last four digits, set to `false`.If the identifications array contains only the last four digits of the identification number, the `/users/{token}/ssn` endpoint will return only the last four digits, regardless of the `full_ssn` parameter.</summary>
            [QueryParameter("full_ssn")]
            public bool? FullSsn { get; set; }
        }
    }
}
#pragma warning restore CS0618
