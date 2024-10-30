// <auto-generated/>
#pragma warning disable CS0618
using Marqeta.Core.Sdk.Directdeposits.Accounts.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Marqeta.Core.Sdk.Directdeposits.Accounts
{
    /// <summary>
    /// Builds and executes requests for operations under \directdeposits\accounts
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class AccountsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Marqeta.Core.Sdk.directdeposits.accounts.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Directdeposits.Accounts.Item.WithUser_or_business_tokenItemRequestBuilder"/></returns>
        [Obsolete("")]
        public global::Marqeta.Core.Sdk.Directdeposits.Accounts.Item.WithUser_or_business_tokenItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("user_or_business_token", position);
                return new global::Marqeta.Core.Sdk.Directdeposits.Accounts.Item.WithUser_or_business_tokenItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Directdeposits.Accounts.AccountsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AccountsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/directdeposits/accounts", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Directdeposits.Accounts.AccountsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AccountsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/directdeposits/accounts", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
