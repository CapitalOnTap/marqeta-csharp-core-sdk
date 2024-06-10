// <auto-generated/>
using Marqeta.Core.Sdk.Businesstransitions.Business.Item;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Marqeta.Core.Sdk.Businesstransitions.Business
{
    /// <summary>
    /// Builds and executes requests for operations under \businesstransitions\business
    /// </summary>
    public class BusinessRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Marqeta.Core.Sdk.businesstransitions.business.item collection</summary>
        /// <param name="position">Unique identifier of the business resource associated with the transitions to retrieve.</param>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Businesstransitions.Business.Item.WithBusiness_tokenItemRequestBuilder"/></returns>
        public Marqeta.Core.Sdk.Businesstransitions.Business.Item.WithBusiness_tokenItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("business_token", position);
                return new Marqeta.Core.Sdk.Businesstransitions.Business.Item.WithBusiness_tokenItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Businesstransitions.Business.BusinessRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BusinessRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/businesstransitions/business", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Businesstransitions.Business.BusinessRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BusinessRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/businesstransitions/business", rawUrl)
        {
        }
    }
}
