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
namespace Marqeta.Core.Sdk.Digitalwalletprovisionrequests.Samsungpay {
    /// <summary>
    /// Builds and executes requests for operations under \digitalwalletprovisionrequests\samsungpay
    /// </summary>
    public class SamsungpayRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>
        /// Instantiates a new <see cref="SamsungpayRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SamsungpayRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/digitalwalletprovisionrequests/samsungpay", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="SamsungpayRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SamsungpayRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/digitalwalletprovisionrequests/samsungpay", rawUrl)
        {
        }
        /// <summary>
        /// [NOTE]This endpoint is limited in availability.For more information, contact your Marqeta representative.Use this endpoint to return card data for use in provisioning a digital wallet token into Samsung Wallet.The returned card data is encrypted using the digital wallet provider&apos;s encryption key, thereby reducing your PCI compliance overhead.
        /// </summary>
        /// <returns>A <see cref="Digital_wallet_samsung_pay_provision_response"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Digital_wallet_samsung_pay_provision_response?> PostAsync(Digital_wallet_samsung_pay_provision_request body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Digital_wallet_samsung_pay_provision_response> PostAsync(Digital_wallet_samsung_pay_provision_request body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"XXX", ApiError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Digital_wallet_samsung_pay_provision_response>(requestInfo, Digital_wallet_samsung_pay_provision_response.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// [NOTE]This endpoint is limited in availability.For more information, contact your Marqeta representative.Use this endpoint to return card data for use in provisioning a digital wallet token into Samsung Wallet.The returned card data is encrypted using the digital wallet provider&apos;s encryption key, thereby reducing your PCI compliance overhead.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Digital_wallet_samsung_pay_provision_request body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Digital_wallet_samsung_pay_provision_request body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="SamsungpayRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public SamsungpayRequestBuilder WithUrl(string rawUrl)
        {
            return new SamsungpayRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
