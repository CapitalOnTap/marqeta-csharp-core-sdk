// <auto-generated/>
using Marqeta.Core.Sdk.Fundingsources.Addresses.User.Item;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Marqeta.Core.Sdk.Fundingsources.Addresses.User
{
    /// <summary>
    /// Builds and executes requests for operations under \fundingsources\addresses\user
    /// </summary>
    public class UserRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Marqeta.Core.Sdk.fundingsources.addresses.user.item collection</summary>
        /// <param name="position">Unique identifier of the user account holder.</param>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Fundingsources.Addresses.User.Item.WithUser_tokenItemRequestBuilder"/></returns>
        public Marqeta.Core.Sdk.Fundingsources.Addresses.User.Item.WithUser_tokenItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("user_token", position);
                return new Marqeta.Core.Sdk.Fundingsources.Addresses.User.Item.WithUser_tokenItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Fundingsources.Addresses.User.UserRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UserRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/fundingsources/addresses/user", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Fundingsources.Addresses.User.UserRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UserRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/fundingsources/addresses/user", rawUrl)
        {
        }
    }
}
