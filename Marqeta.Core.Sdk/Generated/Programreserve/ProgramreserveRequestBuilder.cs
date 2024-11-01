// <auto-generated/>
#pragma warning disable CS0618
using Marqeta.Core.Sdk.Programreserve.Balances;
using Marqeta.Core.Sdk.Programreserve.Transactions;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Marqeta.Core.Sdk.Programreserve
{
    /// <summary>
    /// Builds and executes requests for operations under \programreserve
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ProgramreserveRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The balances property</summary>
        public global::Marqeta.Core.Sdk.Programreserve.Balances.BalancesRequestBuilder Balances
        {
            get => new global::Marqeta.Core.Sdk.Programreserve.Balances.BalancesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The transactions property</summary>
        public global::Marqeta.Core.Sdk.Programreserve.Transactions.TransactionsRequestBuilder Transactions
        {
            get => new global::Marqeta.Core.Sdk.Programreserve.Transactions.TransactionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Programreserve.ProgramreserveRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ProgramreserveRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/programreserve", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Programreserve.ProgramreserveRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ProgramreserveRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/programreserve", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
