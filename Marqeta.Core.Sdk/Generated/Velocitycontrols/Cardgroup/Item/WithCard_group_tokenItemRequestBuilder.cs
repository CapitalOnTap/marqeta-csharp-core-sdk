// <auto-generated/>
using Marqeta.Core.Sdk.Velocitycontrols.Cardgroup.Item.Available;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Marqeta.Core.Sdk.Velocitycontrols.Cardgroup.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \velocitycontrols\cardgroup\{card_group_token}
    /// </summary>
    public class WithCard_group_tokenItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The available property</summary>
        public Marqeta.Core.Sdk.Velocitycontrols.Cardgroup.Item.Available.AvailableRequestBuilder Available
        {
            get => new Marqeta.Core.Sdk.Velocitycontrols.Cardgroup.Item.Available.AvailableRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Velocitycontrols.Cardgroup.Item.WithCard_group_tokenItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithCard_group_tokenItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/velocitycontrols/cardgroup/{card_group_token}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Velocitycontrols.Cardgroup.Item.WithCard_group_tokenItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithCard_group_tokenItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/velocitycontrols/cardgroup/{card_group_token}", rawUrl)
        {
        }
    }
}