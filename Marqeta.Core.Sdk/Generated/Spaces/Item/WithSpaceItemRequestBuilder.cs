// <auto-generated/>
#pragma warning disable CS0618
using Marqeta.Core.Sdk.Spaces.Item.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Marqeta.Core.Sdk.Spaces.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \spaces\{space}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WithSpaceItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Marqeta.Core.Sdk.spaces.item.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Spaces.Item.Item.WithKeyItemRequestBuilder"/></returns>
        public global::Marqeta.Core.Sdk.Spaces.Item.Item.WithKeyItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("key", position);
                return new global::Marqeta.Core.Sdk.Spaces.Item.Item.WithKeyItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Spaces.Item.WithSpaceItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithSpaceItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/spaces/{space}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Spaces.Item.WithSpaceItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithSpaceItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/spaces/{space}", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
