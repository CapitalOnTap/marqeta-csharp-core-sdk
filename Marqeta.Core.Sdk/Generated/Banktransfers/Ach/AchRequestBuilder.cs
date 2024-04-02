// <auto-generated/>
using Marqeta.Core.Sdk.Banktransfers.Ach.Item;
using Marqeta.Core.Sdk.Banktransfers.Ach.Transitions;
using Marqeta.Core.Sdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Marqeta.Core.Sdk.Banktransfers.Ach {
    /// <summary>
    /// Builds and executes requests for operations under \banktransfers\ach
    /// </summary>
    public class AchRequestBuilder : BaseRequestBuilder {
        /// <summary>The transitions property</summary>
        public TransitionsRequestBuilder Transitions { get =>
            new TransitionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Marqeta.Core.Sdk.banktransfers.ach.item collection</summary>
        /// <param name="position">Unique identifier of the bank transfer.</param>
        /// <returns>A <see cref="WithTokenItemRequestBuilder"/></returns>
        public WithTokenItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("token", position);
            return new WithTokenItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new <see cref="AchRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AchRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/banktransfers/ach{?business_token*,count*,expand*,funding_source_token*,funding_source_type*,sort_by*,start_index*,statuses*,user_token*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="AchRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AchRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/banktransfers/ach{?business_token*,count*,expand*,funding_source_token*,funding_source_type*,sort_by*,start_index*,statuses*,user_token*}", rawUrl) {
        }
        /// <summary>
        /// Retrieve a list of all ACH transfers.
        /// </summary>
        /// <returns>A <see cref="BankTransferListResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<BankTransferListResponse?> GetAsync(Action<RequestConfiguration<AchRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<BankTransferListResponse> GetAsync(Action<RequestConfiguration<AchRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"XXX", ApiError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<BankTransferListResponse>(requestInfo, BankTransferListResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create an ACH transfer that pushes funds to an external account or pulls funds into your program funding account.
        /// </summary>
        /// <returns>A <see cref="Bank_transfer_response_model"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Bank_transfer_response_model?> PostAsync(Bank_transfer_request_model body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Bank_transfer_response_model> PostAsync(Bank_transfer_request_model body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"XXX", ApiError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Bank_transfer_response_model>(requestInfo, Bank_transfer_response_model.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieve a list of all ACH transfers.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<AchRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<AchRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Create an ACH transfer that pushes funds to an external account or pulls funds into your program funding account.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Bank_transfer_request_model body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Bank_transfer_request_model body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, "{+baseurl}/banktransfers/ach", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="AchRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public AchRequestBuilder WithUrl(string rawUrl) {
            return new AchRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Retrieve a list of all ACH transfers.
        /// </summary>
        public class AchRequestBuilderGetQueryParameters {
            /// <summary>Unique identifier of the business resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("business_token")]
            public string? BusinessToken { get; set; }
#nullable restore
#else
            [QueryParameter("business_token")]
            public string BusinessToken { get; set; }
#endif
            /// <summary>Number of resources to retrieve.</summary>
            [QueryParameter("count")]
            public int? Count { get; set; }
            /// <summary>Returns the full funding source object when `fundingsource` is passed.Otherwise, returns the funding source token.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("expand")]
            public string? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("expand")]
            public string Expand { get; set; }
#endif
            /// <summary>Unique identifier of the funding source.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("funding_source_token")]
            public string? FundingSourceToken { get; set; }
#nullable restore
#else
            [QueryParameter("funding_source_token")]
            public string FundingSourceToken { get; set; }
#endif
            /// <summary>Funding source type to filter.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("funding_source_type")]
            public string? FundingSourceType { get; set; }
#nullable restore
#else
            [QueryParameter("funding_source_type")]
            public string FundingSourceType { get; set; }
#endif
            /// <summary>Field on which to sort Use any field in the resource model, or one of the system fields `lastModifiedTime` or `createdTime`. Prefix the field name with a hyphen (`-`) to sort in descending order. Omit the hyphen to sort in ascending order.</summary>
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
            /// <summary>Comma-delimited list of bank transfer statuses.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("statuses")]
            public string? Statuses { get; set; }
#nullable restore
#else
            [QueryParameter("statuses")]
            public string Statuses { get; set; }
#endif
            /// <summary>Unique identifier of the user resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("user_token")]
            public string? UserToken { get; set; }
#nullable restore
#else
            [QueryParameter("user_token")]
            public string UserToken { get; set; }
#endif
        }
    }
}