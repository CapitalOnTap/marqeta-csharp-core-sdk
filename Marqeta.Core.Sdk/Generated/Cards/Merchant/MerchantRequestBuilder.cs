// <auto-generated/>
#pragma warning disable CS0618
using Marqeta.Core.Sdk.Cards.Merchant.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Marqeta.Core.Sdk.Cards.Merchant
{
    /// <summary>
    /// Builds and executes requests for operations under \cards\merchant
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class MerchantRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Marqeta.Core.Sdk.cards.merchant.item collection</summary>
        /// <param name="position">Merchant token</param>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Cards.Merchant.Item.WithMerchant_tokenItemRequestBuilder"/></returns>
        public global::Marqeta.Core.Sdk.Cards.Merchant.Item.WithMerchant_tokenItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("merchant_token", position);
                return new global::Marqeta.Core.Sdk.Cards.Merchant.Item.WithMerchant_tokenItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Cards.Merchant.MerchantRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MerchantRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/cards/merchant", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Cards.Merchant.MerchantRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MerchantRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/cards/merchant", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
