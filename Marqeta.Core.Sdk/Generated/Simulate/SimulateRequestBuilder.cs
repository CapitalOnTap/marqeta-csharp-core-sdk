// <auto-generated/>
#pragma warning disable CS0618
using Marqeta.Core.Sdk.Simulate.Authorization;
using Marqeta.Core.Sdk.Simulate.Clearing;
using Marqeta.Core.Sdk.Simulate.Directdeposits;
using Marqeta.Core.Sdk.Simulate.Financial;
using Marqeta.Core.Sdk.Simulate.Reversal;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Marqeta.Core.Sdk.Simulate
{
    /// <summary>
    /// Builds and executes requests for operations under \simulate
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class SimulateRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The authorization property</summary>
        public global::Marqeta.Core.Sdk.Simulate.Authorization.AuthorizationRequestBuilder Authorization
        {
            get => new global::Marqeta.Core.Sdk.Simulate.Authorization.AuthorizationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The clearing property</summary>
        public global::Marqeta.Core.Sdk.Simulate.Clearing.ClearingRequestBuilder Clearing
        {
            get => new global::Marqeta.Core.Sdk.Simulate.Clearing.ClearingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The directdeposits property</summary>
        public global::Marqeta.Core.Sdk.Simulate.Directdeposits.DirectdepositsRequestBuilder Directdeposits
        {
            get => new global::Marqeta.Core.Sdk.Simulate.Directdeposits.DirectdepositsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The financial property</summary>
        public global::Marqeta.Core.Sdk.Simulate.Financial.FinancialRequestBuilder Financial
        {
            get => new global::Marqeta.Core.Sdk.Simulate.Financial.FinancialRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The reversal property</summary>
        public global::Marqeta.Core.Sdk.Simulate.Reversal.ReversalRequestBuilder Reversal
        {
            get => new global::Marqeta.Core.Sdk.Simulate.Reversal.ReversalRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Simulate.SimulateRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SimulateRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/simulate", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Simulate.SimulateRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SimulateRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/simulate", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
