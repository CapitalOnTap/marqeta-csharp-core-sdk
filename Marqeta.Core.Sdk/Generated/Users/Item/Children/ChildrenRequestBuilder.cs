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
namespace Marqeta.Core.Sdk.Users.Item.Children {
    /// <summary>
    /// Builds and executes requests for operations under \users\{parent_token-id}\children
    /// </summary>
    public class ChildrenRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new <see cref="ChildrenRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ChildrenRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{parent_token%2Did}/children{?count*,fields*,sort_by*,start_index*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="ChildrenRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ChildrenRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{parent_token%2Did}/children{?count*,fields*,sort_by*,start_index*}", rawUrl) {
        }
        /// <summary>
        /// To retrieve users who are children of a parent user or business, send a `GET` request to the `/users/{parent_token}/children` endpoint.Include the parent&apos;s user or business token as a URL path parameter.The `business_token` field is conditionally returned in the response (it cannot be set through the API).You can use this field in conjunction with the `parent_token` field to determine whether the user has a parent or grandparent that is a business:[cols=&quot;1,1,1&quot;]|===| parent_token | business_token | Description| Not populated| Not populated| User does not have a parent.| Populated| Not populated| User&apos;s parent is a user.| Populated; matches `business_token`| Populated; matches `parent_token`| User&apos;s parent is a business.| Populated; does not match `business_token`| Populated; does not match `parent_token`| User&apos;s parent is a user and their grandparent is a business.|===This endpoint supports &lt;&lt;/core-api/field-filtering, field filtering&gt;&gt;.
        /// </summary>
        /// <returns>A <see cref="UserCardHolderListResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<UserCardHolderListResponse?> GetAsync(Action<RequestConfiguration<ChildrenRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<UserCardHolderListResponse> GetAsync(Action<RequestConfiguration<ChildrenRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"XXX", ApiError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<UserCardHolderListResponse>(requestInfo, UserCardHolderListResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// To retrieve users who are children of a parent user or business, send a `GET` request to the `/users/{parent_token}/children` endpoint.Include the parent&apos;s user or business token as a URL path parameter.The `business_token` field is conditionally returned in the response (it cannot be set through the API).You can use this field in conjunction with the `parent_token` field to determine whether the user has a parent or grandparent that is a business:[cols=&quot;1,1,1&quot;]|===| parent_token | business_token | Description| Not populated| Not populated| User does not have a parent.| Populated| Not populated| User&apos;s parent is a user.| Populated; matches `business_token`| Populated; matches `parent_token`| User&apos;s parent is a business.| Populated; does not match `business_token`| Populated; does not match `parent_token`| User&apos;s parent is a user and their grandparent is a business.|===This endpoint supports &lt;&lt;/core-api/field-filtering, field filtering&gt;&gt;.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ChildrenRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ChildrenRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="ChildrenRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ChildrenRequestBuilder WithUrl(string rawUrl) {
            return new ChildrenRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// To retrieve users who are children of a parent user or business, send a `GET` request to the `/users/{parent_token}/children` endpoint.Include the parent&apos;s user or business token as a URL path parameter.The `business_token` field is conditionally returned in the response (it cannot be set through the API).You can use this field in conjunction with the `parent_token` field to determine whether the user has a parent or grandparent that is a business:[cols=&quot;1,1,1&quot;]|===| parent_token | business_token | Description| Not populated| Not populated| User does not have a parent.| Populated| Not populated| User&apos;s parent is a user.| Populated; matches `business_token`| Populated; matches `parent_token`| User&apos;s parent is a business.| Populated; does not match `business_token`| Populated; does not match `parent_token`| User&apos;s parent is a user and their grandparent is a business.|===This endpoint supports &lt;&lt;/core-api/field-filtering, field filtering&gt;&gt;.
        /// </summary>
        public class ChildrenRequestBuilderGetQueryParameters {
            /// <summary>Number of user resources to retrieve.</summary>
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
            /// <summary>Sort order index of the first resource in the returned array.</summary>
            [QueryParameter("start_index")]
            public int? StartIndex { get; set; }
        }
    }
}