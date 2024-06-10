// <auto-generated/>
using Marqeta.Core.Sdk.Depositaccounts.Item.Cdd.Item;
using Marqeta.Core.Sdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Marqeta.Core.Sdk.Depositaccounts.Item.Cdd
{
    /// <summary>
    /// Builds and executes requests for operations under \depositaccounts\{token-id}\cdd
    /// </summary>
    public class CddRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Marqeta.Core.Sdk.depositaccounts.item.cdd.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Depositaccounts.Item.Cdd.Item.WithCddtokenItemRequestBuilder"/></returns>
        public Marqeta.Core.Sdk.Depositaccounts.Item.Cdd.Item.WithCddtokenItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("cddtoken", position);
                return new Marqeta.Core.Sdk.Depositaccounts.Item.Cdd.Item.WithCddtokenItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Depositaccounts.Item.Cdd.CddRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CddRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/depositaccounts/{token%2Did}/cdd", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Depositaccounts.Item.Cdd.CddRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CddRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/depositaccounts/{token%2Did}/cdd", rawUrl)
        {
        }
        /// <summary>
        /// Get direct deposit account transition list for card holder.
        /// </summary>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Models.Customer_due_diligence_response"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Marqeta.Core.Sdk.Models.ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Marqeta.Core.Sdk.Models.Customer_due_diligence_response?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Marqeta.Core.Sdk.Models.Customer_due_diligence_response> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Marqeta.Core.Sdk.Models.ApiError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Marqeta.Core.Sdk.Models.Customer_due_diligence_response>(requestInfo, Marqeta.Core.Sdk.Models.Customer_due_diligence_response.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get direct deposit account transition list for card holder.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="Marqeta.Core.Sdk.Depositaccounts.Item.Cdd.CddRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Marqeta.Core.Sdk.Depositaccounts.Item.Cdd.CddRequestBuilder WithUrl(string rawUrl)
        {
            return new Marqeta.Core.Sdk.Depositaccounts.Item.Cdd.CddRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
