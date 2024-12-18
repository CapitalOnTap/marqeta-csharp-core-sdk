// <auto-generated/>
#pragma warning disable CS0618
using Marqeta.Core.Sdk.Webhooks.Customheaders.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Marqeta.Core.Sdk.Webhooks.Customheaders
{
    /// <summary>
    /// Builds and executes requests for operations under \webhooks\customheaders
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class CustomheadersRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Marqeta.Core.Sdk.webhooks.customheaders.item collection</summary>
        /// <param name="position">Unique identifier of the webhook.</param>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Webhooks.Customheaders.Item.WithTokenItemRequestBuilder"/></returns>
        public global::Marqeta.Core.Sdk.Webhooks.Customheaders.Item.WithTokenItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("token", position);
                return new global::Marqeta.Core.Sdk.Webhooks.Customheaders.Item.WithTokenItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Webhooks.Customheaders.CustomheadersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CustomheadersRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/webhooks/customheaders", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Webhooks.Customheaders.CustomheadersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CustomheadersRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/webhooks/customheaders", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
