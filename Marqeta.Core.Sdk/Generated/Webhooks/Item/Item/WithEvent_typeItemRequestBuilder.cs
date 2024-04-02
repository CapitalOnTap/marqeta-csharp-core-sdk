// <auto-generated/>
using Marqeta.Core.Sdk.Webhooks.Item.Item.Item;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Marqeta.Core.Sdk.Webhooks.Item.Item {
    /// <summary>
    /// Builds and executes requests for operations under \webhooks\{token}\{event_type}
    /// </summary>
    public class WithEvent_typeItemRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the Marqeta.Core.Sdk.webhooks.item.item.item collection</summary>
        /// <param name="position">Unique identifier of the event for which you want to resend a notification.</param>
        /// <returns>A <see cref="WithEvent_tokenItemRequestBuilder"/></returns>
        public WithEvent_tokenItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("event_token", position);
            return new WithEvent_tokenItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new <see cref="WithEvent_typeItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithEvent_typeItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/webhooks/{token}/{event_type}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="WithEvent_typeItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithEvent_typeItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/webhooks/{token}/{event_type}", rawUrl) {
        }
    }
}
