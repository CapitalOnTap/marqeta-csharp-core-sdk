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
namespace Marqeta.Core.Sdk.Fundingsources.Addresses.Business.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \fundingsources\addresses\business\{business_token}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WithBusiness_tokenItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Fundingsources.Addresses.Business.Item.WithBusiness_tokenItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithBusiness_tokenItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/fundingsources/addresses/business/{business_token}{?fields*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Fundingsources.Addresses.Business.Item.WithBusiness_tokenItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithBusiness_tokenItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/fundingsources/addresses/business/{business_token}{?fields*}", rawUrl)
        {
        }
        /// <summary>
        /// Use this endpoint to list existing addresses for a business.This endpoint supports &lt;&lt;/core-api/field-filtering, field filtering&gt;&gt;.
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.CardholderAddressListResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Marqeta.Core.Sdk.Models.ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Marqeta.Core.Sdk.Models.CardholderAddressListResponse?> GetAsync(Action<RequestConfiguration<global::Marqeta.Core.Sdk.Fundingsources.Addresses.Business.Item.WithBusiness_tokenItemRequestBuilder.WithBusiness_tokenItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Marqeta.Core.Sdk.Models.CardholderAddressListResponse> GetAsync(Action<RequestConfiguration<global::Marqeta.Core.Sdk.Fundingsources.Addresses.Business.Item.WithBusiness_tokenItemRequestBuilder.WithBusiness_tokenItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Marqeta.Core.Sdk.Models.ApiError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Marqeta.Core.Sdk.Models.CardholderAddressListResponse>(requestInfo, global::Marqeta.Core.Sdk.Models.CardholderAddressListResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Use this endpoint to list existing addresses for a business.This endpoint supports &lt;&lt;/core-api/field-filtering, field filtering&gt;&gt;.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Marqeta.Core.Sdk.Fundingsources.Addresses.Business.Item.WithBusiness_tokenItemRequestBuilder.WithBusiness_tokenItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Marqeta.Core.Sdk.Fundingsources.Addresses.Business.Item.WithBusiness_tokenItemRequestBuilder.WithBusiness_tokenItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Fundingsources.Addresses.Business.Item.WithBusiness_tokenItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Marqeta.Core.Sdk.Fundingsources.Addresses.Business.Item.WithBusiness_tokenItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Marqeta.Core.Sdk.Fundingsources.Addresses.Business.Item.WithBusiness_tokenItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Use this endpoint to list existing addresses for a business.This endpoint supports &lt;&lt;/core-api/field-filtering, field filtering&gt;&gt;.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class WithBusiness_tokenItemRequestBuilderGetQueryParameters 
        {
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
        }
    }
}
#pragma warning restore CS0618
