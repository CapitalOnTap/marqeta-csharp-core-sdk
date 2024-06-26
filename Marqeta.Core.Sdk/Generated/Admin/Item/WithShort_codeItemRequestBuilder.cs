// <auto-generated/>
using Marqeta.Core.Sdk.Admin.Item.Replayfailedstatement;
using Marqeta.Core.Sdk.Admin.Item.Retryachpayments;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Marqeta.Core.Sdk.Admin.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \admin\{short_code}
    /// </summary>
    public class WithShort_codeItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The replayfailedstatement property</summary>
        public Marqeta.Core.Sdk.Admin.Item.Replayfailedstatement.ReplayfailedstatementRequestBuilder Replayfailedstatement
        {
            get => new Marqeta.Core.Sdk.Admin.Item.Replayfailedstatement.ReplayfailedstatementRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The retryachpayments property</summary>
        public Marqeta.Core.Sdk.Admin.Item.Retryachpayments.RetryachpaymentsRequestBuilder Retryachpayments
        {
            get => new Marqeta.Core.Sdk.Admin.Item.Retryachpayments.RetryachpaymentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Admin.Item.WithShort_codeItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithShort_codeItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin/{short_code}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Admin.Item.WithShort_codeItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithShort_codeItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin/{short_code}", rawUrl)
        {
        }
    }
}
