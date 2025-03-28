// <auto-generated/>
#pragma warning disable CS0618
using Marqeta.Core.Sdk.Models;
using Marqeta.Core.Sdk.Users.Item.Children;
using Marqeta.Core.Sdk.Users.Item.Notes;
using Marqeta.Core.Sdk.Users.Item.Ssn;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Marqeta.Core.Sdk.Users.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \users\{parent_token-id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Parent_tokenItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The children property</summary>
        public global::Marqeta.Core.Sdk.Users.Item.Children.ChildrenRequestBuilder Children
        {
            get => new global::Marqeta.Core.Sdk.Users.Item.Children.ChildrenRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The notes property</summary>
        public global::Marqeta.Core.Sdk.Users.Item.Notes.NotesRequestBuilder Notes
        {
            get => new global::Marqeta.Core.Sdk.Users.Item.Notes.NotesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The ssn property</summary>
        public global::Marqeta.Core.Sdk.Users.Item.Ssn.SsnRequestBuilder Ssn
        {
            get => new global::Marqeta.Core.Sdk.Users.Item.Ssn.SsnRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Users.Item.Parent_tokenItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Parent_tokenItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{parent_token%2Did}{?fields*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Users.Item.Parent_tokenItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Parent_tokenItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{parent_token%2Did}{?fields*}", rawUrl)
        {
        }
        /// <summary>
        /// To retrieve a specific user, send a `GET` request to the `/users/{token}` endpoint.Include the user `token` path parameter to specify the user to return.The `business_token` field is conditionally returned in the response (it cannot be set through the API).You can use this field in conjunction with the `parent_token` field to determine whether the user has a parent or grandparent that is a business:[cols=&quot;1,1,1&quot;]|===| parent_token | business_token | Description| Not populated| Not populated| User does not have a parent.| Populated| Not populated| User&apos;s parent is a user.| Populated; matches `business_token`| Populated; matches `parent_token`| User&apos;s parent is a business.| Populated; does not match `business_token`| Populated; does not match `parent_token`| User&apos;s parent is a user and their grandparent is a business.|===This endpoint supports &lt;&lt;/core-api/field-filtering, field filtering&gt;&gt;.
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.User_card_holder_response"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Marqeta.Core.Sdk.Models.ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Marqeta.Core.Sdk.Models.User_card_holder_response?> GetAsync(Action<RequestConfiguration<global::Marqeta.Core.Sdk.Users.Item.Parent_tokenItemRequestBuilder.Parent_tokenItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Marqeta.Core.Sdk.Models.User_card_holder_response> GetAsync(Action<RequestConfiguration<global::Marqeta.Core.Sdk.Users.Item.Parent_tokenItemRequestBuilder.Parent_tokenItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Marqeta.Core.Sdk.Models.ApiError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Marqeta.Core.Sdk.Models.User_card_holder_response>(requestInfo, global::Marqeta.Core.Sdk.Models.User_card_holder_response.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// To update a specific user resource, send a `PUT` request to the `/users/{token}` endpoint.Include the user `token` path parameter to specify the user to update.To unlink a child user account from a parent account, pass a null value to the `parent_token` field of the child user resource.
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.Card_holder_model"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Marqeta.Core.Sdk.Models.ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Marqeta.Core.Sdk.Models.Card_holder_model?> PutAsync(global::Marqeta.Core.Sdk.Models.UserCardHolderUpdateModel body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Marqeta.Core.Sdk.Models.Card_holder_model> PutAsync(global::Marqeta.Core.Sdk.Models.UserCardHolderUpdateModel body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPutRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Marqeta.Core.Sdk.Models.ApiError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Marqeta.Core.Sdk.Models.Card_holder_model>(requestInfo, global::Marqeta.Core.Sdk.Models.Card_holder_model.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// To retrieve a specific user, send a `GET` request to the `/users/{token}` endpoint.Include the user `token` path parameter to specify the user to return.The `business_token` field is conditionally returned in the response (it cannot be set through the API).You can use this field in conjunction with the `parent_token` field to determine whether the user has a parent or grandparent that is a business:[cols=&quot;1,1,1&quot;]|===| parent_token | business_token | Description| Not populated| Not populated| User does not have a parent.| Populated| Not populated| User&apos;s parent is a user.| Populated; matches `business_token`| Populated; matches `parent_token`| User&apos;s parent is a business.| Populated; does not match `business_token`| Populated; does not match `parent_token`| User&apos;s parent is a user and their grandparent is a business.|===This endpoint supports &lt;&lt;/core-api/field-filtering, field filtering&gt;&gt;.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Marqeta.Core.Sdk.Users.Item.Parent_tokenItemRequestBuilder.Parent_tokenItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Marqeta.Core.Sdk.Users.Item.Parent_tokenItemRequestBuilder.Parent_tokenItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// To update a specific user resource, send a `PUT` request to the `/users/{token}` endpoint.Include the user `token` path parameter to specify the user to update.To unlink a child user account from a parent account, pass a null value to the `parent_token` field of the child user resource.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(global::Marqeta.Core.Sdk.Models.UserCardHolderUpdateModel body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(global::Marqeta.Core.Sdk.Models.UserCardHolderUpdateModel body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PUT, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Users.Item.Parent_tokenItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Marqeta.Core.Sdk.Users.Item.Parent_tokenItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Marqeta.Core.Sdk.Users.Item.Parent_tokenItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// To retrieve a specific user, send a `GET` request to the `/users/{token}` endpoint.Include the user `token` path parameter to specify the user to return.The `business_token` field is conditionally returned in the response (it cannot be set through the API).You can use this field in conjunction with the `parent_token` field to determine whether the user has a parent or grandparent that is a business:[cols=&quot;1,1,1&quot;]|===| parent_token | business_token | Description| Not populated| Not populated| User does not have a parent.| Populated| Not populated| User&apos;s parent is a user.| Populated; matches `business_token`| Populated; matches `parent_token`| User&apos;s parent is a business.| Populated; does not match `business_token`| Populated; does not match `parent_token`| User&apos;s parent is a user and their grandparent is a business.|===This endpoint supports &lt;&lt;/core-api/field-filtering, field filtering&gt;&gt;.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class Parent_tokenItemRequestBuilderGetQueryParameters 
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
