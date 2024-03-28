// <auto-generated/>
using Marqeta.Core.Sdk.Fundingsources.Item.Default;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Marqeta.Core.Sdk.Fundingsources.Item {
    /// <summary>
    /// Builds and executes requests for operations under \fundingsources\{funding_source_token}
    /// </summary>
    public class WithFunding_source_tokenItemRequestBuilder : BaseRequestBuilder {
        /// <summary>The default property</summary>
        public DefaultRequestBuilder Default { get =>
            new DefaultRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="WithFunding_source_tokenItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithFunding_source_tokenItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/fundingsources/{funding_source_token}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="WithFunding_source_tokenItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithFunding_source_tokenItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/fundingsources/{funding_source_token}", rawUrl) {
        }
    }
}
