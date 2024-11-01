// <auto-generated/>
#pragma warning disable CS0618
using Marqeta.Core.Sdk.Kyc.User.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Marqeta.Core.Sdk.Kyc.User
{
    /// <summary>
    /// Builds and executes requests for operations under \kyc\user
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class UserRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Marqeta.Core.Sdk.kyc.user.item collection</summary>
        /// <param name="position">Unique identifier of the user resource for which you want to retrieve KYC verification results.</param>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Kyc.User.Item.WithUser_tokenItemRequestBuilder"/></returns>
        public global::Marqeta.Core.Sdk.Kyc.User.Item.WithUser_tokenItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("user_token", position);
                return new global::Marqeta.Core.Sdk.Kyc.User.Item.WithUser_tokenItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Kyc.User.UserRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UserRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/kyc/user", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Kyc.User.UserRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UserRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/kyc/user", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
