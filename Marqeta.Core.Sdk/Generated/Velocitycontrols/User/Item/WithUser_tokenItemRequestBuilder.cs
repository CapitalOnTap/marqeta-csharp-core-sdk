// <auto-generated/>
using Marqeta.Core.Sdk.Velocitycontrols.User.Item.Available;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Marqeta.Core.Sdk.Velocitycontrols.User.Item {
    /// <summary>
    /// Builds and executes requests for operations under \velocitycontrols\user\{user_token}
    /// </summary>
    public class WithUser_tokenItemRequestBuilder : BaseRequestBuilder {
        /// <summary>The available property</summary>
        public AvailableRequestBuilder Available { get =>
            new AvailableRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="WithUser_tokenItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithUser_tokenItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/velocitycontrols/user/{user_token}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="WithUser_tokenItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithUser_tokenItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/velocitycontrols/user/{user_token}", rawUrl) {
        }
    }
}
