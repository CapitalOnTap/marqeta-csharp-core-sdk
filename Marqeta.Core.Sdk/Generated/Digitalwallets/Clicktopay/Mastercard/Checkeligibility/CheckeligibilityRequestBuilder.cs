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
namespace Marqeta.Core.Sdk.Digitalwallets.Clicktopay.Mastercard.Checkeligibility
{
    /// <summary>
    /// Builds and executes requests for operations under \digitalwallets\clicktopay\mastercard\checkeligibility
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class CheckeligibilityRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Digitalwallets.Clicktopay.Mastercard.Checkeligibility.CheckeligibilityRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CheckeligibilityRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/digitalwallets/clicktopay/mastercard/checkeligibility?bin_prefix={bin_prefix}{&include_asset*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Digitalwallets.Clicktopay.Mastercard.Checkeligibility.CheckeligibilityRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CheckeligibilityRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/digitalwallets/clicktopay/mastercard/checkeligibility?bin_prefix={bin_prefix}{&include_asset*}", rawUrl)
        {
        }
        /// <summary>
        /// Use this endpoint to check if a provided BIN prefix is eligible for Click to Pay.
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.Click_to_pay_check_eligibility_response"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Marqeta.Core.Sdk.Models.ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Marqeta.Core.Sdk.Models.Click_to_pay_check_eligibility_response?> GetAsync(Action<RequestConfiguration<global::Marqeta.Core.Sdk.Digitalwallets.Clicktopay.Mastercard.Checkeligibility.CheckeligibilityRequestBuilder.CheckeligibilityRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Marqeta.Core.Sdk.Models.Click_to_pay_check_eligibility_response> GetAsync(Action<RequestConfiguration<global::Marqeta.Core.Sdk.Digitalwallets.Clicktopay.Mastercard.Checkeligibility.CheckeligibilityRequestBuilder.CheckeligibilityRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Marqeta.Core.Sdk.Models.ApiError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Marqeta.Core.Sdk.Models.Click_to_pay_check_eligibility_response>(requestInfo, global::Marqeta.Core.Sdk.Models.Click_to_pay_check_eligibility_response.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Use this endpoint to check if a provided BIN prefix is eligible for Click to Pay.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Marqeta.Core.Sdk.Digitalwallets.Clicktopay.Mastercard.Checkeligibility.CheckeligibilityRequestBuilder.CheckeligibilityRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Marqeta.Core.Sdk.Digitalwallets.Clicktopay.Mastercard.Checkeligibility.CheckeligibilityRequestBuilder.CheckeligibilityRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Digitalwallets.Clicktopay.Mastercard.Checkeligibility.CheckeligibilityRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Marqeta.Core.Sdk.Digitalwallets.Clicktopay.Mastercard.Checkeligibility.CheckeligibilityRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Marqeta.Core.Sdk.Digitalwallets.Clicktopay.Mastercard.Checkeligibility.CheckeligibilityRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Use this endpoint to check if a provided BIN prefix is eligible for Click to Pay.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CheckeligibilityRequestBuilderGetQueryParameters 
        {
            /// <summary>Prefix of the bank identification number.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("bin_prefix")]
            public string? BinPrefix { get; set; }
#nullable restore
#else
            [QueryParameter("bin_prefix")]
            public string BinPrefix { get; set; }
#endif
            /// <summary>Returns a list of image assets for the Click to Pay logo if set to `true`.</summary>
            [QueryParameter("include_asset")]
            public bool? IncludeAsset { get; set; }
        }
    }
}
#pragma warning restore CS0618
