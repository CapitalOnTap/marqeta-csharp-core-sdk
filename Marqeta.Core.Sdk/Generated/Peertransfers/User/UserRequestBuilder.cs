// <auto-generated/>
#pragma warning disable CS0618
using Marqeta.Core.Sdk.Peertransfers.User.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Marqeta.Core.Sdk.Peertransfers.User
{
    /// <summary>
    /// Builds and executes requests for operations under \peertransfers\user
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class UserRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Marqeta.Core.Sdk.peertransfers.user.item collection</summary>
        /// <param name="position">Existing user or business token.Send a `GET` request to `/users` to retrieve user tokens or to `/businesses` to retrieve business tokens.</param>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Peertransfers.User.Item.WithUser_or_business_tokenItemRequestBuilder"/></returns>
        public global::Marqeta.Core.Sdk.Peertransfers.User.Item.WithUser_or_business_tokenItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("user_or_business_token", position);
                return new global::Marqeta.Core.Sdk.Peertransfers.User.Item.WithUser_or_business_tokenItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Peertransfers.User.UserRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UserRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/peertransfers/user", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Peertransfers.User.UserRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UserRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/peertransfers/user", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
