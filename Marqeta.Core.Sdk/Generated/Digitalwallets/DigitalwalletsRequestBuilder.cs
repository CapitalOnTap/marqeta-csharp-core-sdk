// <auto-generated/>
#pragma warning disable CS0618
using Marqeta.Core.Sdk.Digitalwallets.Wpp;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Marqeta.Core.Sdk.Digitalwallets
{
    /// <summary>
    /// Builds and executes requests for operations under \digitalwallets
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DigitalwalletsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The wpp property</summary>
        public global::Marqeta.Core.Sdk.Digitalwallets.Wpp.WppRequestBuilder Wpp
        {
            get => new global::Marqeta.Core.Sdk.Digitalwallets.Wpp.WppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Digitalwallets.DigitalwalletsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DigitalwalletsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/digitalwallets", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Digitalwallets.DigitalwalletsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DigitalwalletsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/digitalwallets", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
