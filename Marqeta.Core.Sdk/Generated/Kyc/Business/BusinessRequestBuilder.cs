// <auto-generated/>
using Marqeta.Core.Sdk.Kyc.Business.Item;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Marqeta.Core.Sdk.Kyc.Business {
    /// <summary>
    /// Builds and executes requests for operations under \kyc\business
    /// </summary>
    public class BusinessRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>Gets an item from the Marqeta.Core.Sdk.kyc.business.item collection</summary>
        /// <param name="position">The unique identifier of the business resource for which you want to retrieve KYC verification results.</param>
        /// <returns>A <see cref="WithBusiness_tokenItemRequestBuilder"/></returns>
        public WithBusiness_tokenItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("business_token", position);
                return new WithBusiness_tokenItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="BusinessRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BusinessRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/kyc/business", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="BusinessRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BusinessRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/kyc/business", rawUrl)
        {
        }
    }
}
