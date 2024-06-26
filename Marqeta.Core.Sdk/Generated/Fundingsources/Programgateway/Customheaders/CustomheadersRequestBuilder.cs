// <auto-generated/>
using Marqeta.Core.Sdk.Fundingsources.Programgateway.Customheaders.Item;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Marqeta.Core.Sdk.Fundingsources.Programgateway.Customheaders
{
    /// <summary>
    /// Builds and executes requests for operations under \fundingsources\programgateway\customheaders
    /// </summary>
    public class CustomheadersRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Marqeta.Core.Sdk.fundingsources.programgateway.customheaders.item collection</summary>
        /// <param name="position">Unique identifier of the program gateway funding source.</param>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Fundingsources.Programgateway.Customheaders.Item.WithTokenItemRequestBuilder"/></returns>
        public Marqeta.Core.Sdk.Fundingsources.Programgateway.Customheaders.Item.WithTokenItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("token", position);
                return new Marqeta.Core.Sdk.Fundingsources.Programgateway.Customheaders.Item.WithTokenItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Fundingsources.Programgateway.Customheaders.CustomheadersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CustomheadersRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/fundingsources/programgateway/customheaders", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Fundingsources.Programgateway.Customheaders.CustomheadersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CustomheadersRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/fundingsources/programgateway/customheaders", rawUrl)
        {
        }
    }
}
