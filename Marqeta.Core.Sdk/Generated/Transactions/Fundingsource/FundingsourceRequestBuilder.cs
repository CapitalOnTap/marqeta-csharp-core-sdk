// <auto-generated/>
using Marqeta.Core.Sdk.Transactions.Fundingsource.Item;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Marqeta.Core.Sdk.Transactions.Fundingsource
{
    /// <summary>
    /// Builds and executes requests for operations under \transactions\fundingsource
    /// </summary>
    public class FundingsourceRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Marqeta.Core.Sdk.transactions.fundingsource.item collection</summary>
        /// <param name="position">The unique identifier of the funding account.</param>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Transactions.Fundingsource.Item.WithFunding_source_tokenItemRequestBuilder"/></returns>
        public Marqeta.Core.Sdk.Transactions.Fundingsource.Item.WithFunding_source_tokenItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("funding_source_token", position);
                return new Marqeta.Core.Sdk.Transactions.Fundingsource.Item.WithFunding_source_tokenItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Transactions.Fundingsource.FundingsourceRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FundingsourceRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/transactions/fundingsource", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Transactions.Fundingsource.FundingsourceRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FundingsourceRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/transactions/fundingsource", rawUrl)
        {
        }
    }
}
