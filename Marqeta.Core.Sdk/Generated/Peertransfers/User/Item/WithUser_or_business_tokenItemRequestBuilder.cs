// <auto-generated/>
#pragma warning disable CS0618
using Marqeta.Core.Sdk.Models;
using Marqeta.Core.Sdk.Peertransfers.User.Item.Recipient;
using Marqeta.Core.Sdk.Peertransfers.User.Item.Sender;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Marqeta.Core.Sdk.Peertransfers.User.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \peertransfers\user\{user_or_business_token}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WithUser_or_business_tokenItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The recipient property</summary>
        public global::Marqeta.Core.Sdk.Peertransfers.User.Item.Recipient.RecipientRequestBuilder Recipient
        {
            get => new global::Marqeta.Core.Sdk.Peertransfers.User.Item.Recipient.RecipientRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The sender property</summary>
        public global::Marqeta.Core.Sdk.Peertransfers.User.Item.Sender.SenderRequestBuilder Sender
        {
            get => new global::Marqeta.Core.Sdk.Peertransfers.User.Item.Sender.SenderRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Peertransfers.User.Item.WithUser_or_business_tokenItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithUser_or_business_tokenItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/peertransfers/user/{user_or_business_token}{?count*,fields*,start_index*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Peertransfers.User.Item.WithUser_or_business_tokenItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithUser_or_business_tokenItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/peertransfers/user/{user_or_business_token}{?count*,fields*,start_index*}", rawUrl)
        {
        }
        /// <summary>
        /// Use this endpoint to list peer transfers sent or received by a particular account holder.Include a user or business token as a path parameter to identify the account holder whose transfers you want to list.This endpoint supports &lt;&lt;/core-api/field-filtering, field filtering&gt;&gt; and &lt;&lt;/core-api/sorting-and-pagination, pagination&gt;&gt;.
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.Peer_transfer_response"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Marqeta.Core.Sdk.Models.ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Marqeta.Core.Sdk.Models.Peer_transfer_response?> GetAsync(Action<RequestConfiguration<global::Marqeta.Core.Sdk.Peertransfers.User.Item.WithUser_or_business_tokenItemRequestBuilder.WithUser_or_business_tokenItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Marqeta.Core.Sdk.Models.Peer_transfer_response> GetAsync(Action<RequestConfiguration<global::Marqeta.Core.Sdk.Peertransfers.User.Item.WithUser_or_business_tokenItemRequestBuilder.WithUser_or_business_tokenItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Marqeta.Core.Sdk.Models.ApiError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Marqeta.Core.Sdk.Models.Peer_transfer_response>(requestInfo, global::Marqeta.Core.Sdk.Models.Peer_transfer_response.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Use this endpoint to list peer transfers sent or received by a particular account holder.Include a user or business token as a path parameter to identify the account holder whose transfers you want to list.This endpoint supports &lt;&lt;/core-api/field-filtering, field filtering&gt;&gt; and &lt;&lt;/core-api/sorting-and-pagination, pagination&gt;&gt;.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Marqeta.Core.Sdk.Peertransfers.User.Item.WithUser_or_business_tokenItemRequestBuilder.WithUser_or_business_tokenItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Marqeta.Core.Sdk.Peertransfers.User.Item.WithUser_or_business_tokenItemRequestBuilder.WithUser_or_business_tokenItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Peertransfers.User.Item.WithUser_or_business_tokenItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Marqeta.Core.Sdk.Peertransfers.User.Item.WithUser_or_business_tokenItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Marqeta.Core.Sdk.Peertransfers.User.Item.WithUser_or_business_tokenItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Use this endpoint to list peer transfers sent or received by a particular account holder.Include a user or business token as a path parameter to identify the account holder whose transfers you want to list.This endpoint supports &lt;&lt;/core-api/field-filtering, field filtering&gt;&gt; and &lt;&lt;/core-api/sorting-and-pagination, pagination&gt;&gt;.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class WithUser_or_business_tokenItemRequestBuilderGetQueryParameters 
        {
            /// <summary>Number of peer transfer resources to retrieve.</summary>
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
            /// <summary>Sort order index of the first resource in the returned array.</summary>
            [QueryParameter("start_index")]
            public int? StartIndex { get; set; }
        }
    }
}
#pragma warning restore CS0618
