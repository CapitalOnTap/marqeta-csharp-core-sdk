// <auto-generated/>
#pragma warning disable CS0618
using Marqeta.Core.Sdk.Admin.Item.Replayfailedstatement.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Marqeta.Core.Sdk.Admin.Item.Replayfailedstatement
{
    /// <summary>
    /// Builds and executes requests for operations under \admin\{short_code}\replayfailedstatement
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ReplayfailedstatementRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Marqeta.Core.Sdk.admin.item.replayfailedstatement.item collection</summary>
        /// <param name="position">account token of the account</param>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Admin.Item.Replayfailedstatement.Item.WithAccount_tokenItemRequestBuilder"/></returns>
        public global::Marqeta.Core.Sdk.Admin.Item.Replayfailedstatement.Item.WithAccount_tokenItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("account_token", position);
                return new global::Marqeta.Core.Sdk.Admin.Item.Replayfailedstatement.Item.WithAccount_tokenItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Admin.Item.Replayfailedstatement.ReplayfailedstatementRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ReplayfailedstatementRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin/{short_code}/replayfailedstatement", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Admin.Item.Replayfailedstatement.ReplayfailedstatementRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ReplayfailedstatementRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin/{short_code}/replayfailedstatement", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
