// <auto-generated/>
#pragma warning disable CS0618
using Marqeta.Core.Sdk.Digitalwallettokens.Card.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Marqeta.Core.Sdk.Digitalwallettokens.Card
{
    /// <summary>
    /// Builds and executes requests for operations under \digitalwallettokens\card
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class CardRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Marqeta.Core.Sdk.digitalwallettokens.card.item collection</summary>
        /// <param name="position">Unique identifier of the card.Used to minimize the need to exchange card details during subsequent calls, and also for troubleshooting.</param>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Digitalwallettokens.Card.Item.WithCard_tokenItemRequestBuilder"/></returns>
        public global::Marqeta.Core.Sdk.Digitalwallettokens.Card.Item.WithCard_tokenItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("card_token", position);
                return new global::Marqeta.Core.Sdk.Digitalwallettokens.Card.Item.WithCard_tokenItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Digitalwallettokens.Card.CardRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CardRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/digitalwallettokens/card", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Digitalwallettokens.Card.CardRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CardRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/digitalwallettokens/card", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
