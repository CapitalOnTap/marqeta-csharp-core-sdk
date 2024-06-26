// <auto-generated/>
using Marqeta.Core.Sdk.Cardtransitions.Card.Item;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Marqeta.Core.Sdk.Cardtransitions.Card
{
    /// <summary>
    /// Builds and executes requests for operations under \cardtransitions\card
    /// </summary>
    public class CardRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Marqeta.Core.Sdk.cardtransitions.card.item collection</summary>
        /// <param name="position">Unique identifier of the card.</param>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Cardtransitions.Card.Item.WithTokenItemRequestBuilder"/></returns>
        public Marqeta.Core.Sdk.Cardtransitions.Card.Item.WithTokenItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("token", position);
                return new Marqeta.Core.Sdk.Cardtransitions.Card.Item.WithTokenItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Cardtransitions.Card.CardRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CardRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/cardtransitions/card", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Cardtransitions.Card.CardRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CardRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/cardtransitions/card", rawUrl)
        {
        }
    }
}
