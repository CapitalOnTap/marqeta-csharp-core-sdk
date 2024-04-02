// <auto-generated/>
using Marqeta.Core.Sdk.Banktransfers.Ach;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Marqeta.Core.Sdk.Banktransfers {
    /// <summary>
    /// Builds and executes requests for operations under \banktransfers
    /// </summary>
    public class BanktransfersRequestBuilder : BaseRequestBuilder {
        /// <summary>The ach property</summary>
        public AchRequestBuilder Ach { get =>
            new AchRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="BanktransfersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BanktransfersRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/banktransfers", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="BanktransfersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BanktransfersRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/banktransfers", rawUrl) {
        }
    }
}