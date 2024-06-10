// <auto-generated/>
using Marqeta.Core.Sdk.Bulkissuances.Item;
using Marqeta.Core.Sdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Marqeta.Core.Sdk.Bulkissuances
{
    /// <summary>
    /// Builds and executes requests for operations under \bulkissuances
    /// </summary>
    public class BulkissuancesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Marqeta.Core.Sdk.bulkissuances.item collection</summary>
        /// <param name="position">The unique identifier of the bulk card order to retrieve.</param>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Bulkissuances.Item.WithTokenItemRequestBuilder"/></returns>
        public Marqeta.Core.Sdk.Bulkissuances.Item.WithTokenItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("token", position);
                return new Marqeta.Core.Sdk.Bulkissuances.Item.WithTokenItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Bulkissuances.BulkissuancesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BulkissuancesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/bulkissuances{?count*,sort_by*,start_index*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Bulkissuances.BulkissuancesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BulkissuancesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/bulkissuances{?count*,sort_by*,start_index*}", rawUrl)
        {
        }
        /// <summary>
        /// Use this endpoint to list existing bulk card orders.This endpoint supports &lt;&lt;/core-api/sorting-and-pagination, pagination and sorting&gt;&gt;.
        /// </summary>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Models.BulkCardOrderListResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Marqeta.Core.Sdk.Models.ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Marqeta.Core.Sdk.Models.BulkCardOrderListResponse?> GetAsync(Action<RequestConfiguration<Marqeta.Core.Sdk.Bulkissuances.BulkissuancesRequestBuilder.BulkissuancesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Marqeta.Core.Sdk.Models.BulkCardOrderListResponse> GetAsync(Action<RequestConfiguration<Marqeta.Core.Sdk.Bulkissuances.BulkissuancesRequestBuilder.BulkissuancesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Marqeta.Core.Sdk.Models.ApiError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Marqeta.Core.Sdk.Models.BulkCardOrderListResponse>(requestInfo, Marqeta.Core.Sdk.Models.BulkCardOrderListResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Use this endpoint to order physical cards in bulk.A new bulk card order creates new cards or users, generally within about a day.Before creating a bulk card order, set the `config.fulfillment.bulk_ship` field of the associated card product to `true`.*To associate all cards with the same user:** Set `user_association.single_inventory_user=true`* Set `user_association.single_inventory_user_token` equal to the token of an existing user.The bulk card order automatically populates the database with the specified card objects.Values for the card `token` fields are generated in the format `card-numericPostfix`, where `numericPostfix` is a randomly generated number that is added for each new card that is generated.*To associate each card with a unique user:*Set `user_association.single_inventory_user=false`.Both the cards and their associated users are automatically generated.Values for the user `token` fields are generated in the format `user-numericPostfix`.The `numericPostfix` values for cards and their associated users match.This value is also printed on the physical cards if the `name_line_1_numeric_postfix` field is set to `true`.
        /// </summary>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Models.Bulk_issuance_response"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Marqeta.Core.Sdk.Models.ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Marqeta.Core.Sdk.Models.Bulk_issuance_response?> PostAsync(Marqeta.Core.Sdk.Models.Bulk_issuance_request body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Marqeta.Core.Sdk.Models.Bulk_issuance_response> PostAsync(Marqeta.Core.Sdk.Models.Bulk_issuance_request body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Marqeta.Core.Sdk.Models.ApiError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Marqeta.Core.Sdk.Models.Bulk_issuance_response>(requestInfo, Marqeta.Core.Sdk.Models.Bulk_issuance_response.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Use this endpoint to list existing bulk card orders.This endpoint supports &lt;&lt;/core-api/sorting-and-pagination, pagination and sorting&gt;&gt;.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Marqeta.Core.Sdk.Bulkissuances.BulkissuancesRequestBuilder.BulkissuancesRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Marqeta.Core.Sdk.Bulkissuances.BulkissuancesRequestBuilder.BulkissuancesRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Use this endpoint to order physical cards in bulk.A new bulk card order creates new cards or users, generally within about a day.Before creating a bulk card order, set the `config.fulfillment.bulk_ship` field of the associated card product to `true`.*To associate all cards with the same user:** Set `user_association.single_inventory_user=true`* Set `user_association.single_inventory_user_token` equal to the token of an existing user.The bulk card order automatically populates the database with the specified card objects.Values for the card `token` fields are generated in the format `card-numericPostfix`, where `numericPostfix` is a randomly generated number that is added for each new card that is generated.*To associate each card with a unique user:*Set `user_association.single_inventory_user=false`.Both the cards and their associated users are automatically generated.Values for the user `token` fields are generated in the format `user-numericPostfix`.The `numericPostfix` values for cards and their associated users match.This value is also printed on the physical cards if the `name_line_1_numeric_postfix` field is set to `true`.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Marqeta.Core.Sdk.Models.Bulk_issuance_request body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Marqeta.Core.Sdk.Models.Bulk_issuance_request body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
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
        /// <returns>A <see cref="Marqeta.Core.Sdk.Bulkissuances.BulkissuancesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Marqeta.Core.Sdk.Bulkissuances.BulkissuancesRequestBuilder WithUrl(string rawUrl)
        {
            return new Marqeta.Core.Sdk.Bulkissuances.BulkissuancesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Use this endpoint to list existing bulk card orders.This endpoint supports &lt;&lt;/core-api/sorting-and-pagination, pagination and sorting&gt;&gt;.
        /// </summary>
        public class BulkissuancesRequestBuilderGetQueryParameters 
        {
            /// <summary>Number of bulk card orders to retrieve.</summary>
            [QueryParameter("count")]
            public int? Count { get; set; }
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
