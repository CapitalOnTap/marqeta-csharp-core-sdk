// <auto-generated/>
using Marqeta.Core.Sdk.Cards.User.Item;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Marqeta.Core.Sdk.Cards.User {
    /// <summary>
    /// Builds and executes requests for operations under \cards\user
    /// </summary>
    public class UserRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>Gets an item from the Marqeta.Core.Sdk.cards.user.item collection</summary>
        /// <param name="position">Unique identifier of the user whose cards you want to list.Send a `GET` request to `/users` to retrieve user tokens.</param>
        /// <returns>A <see cref="WithTokenItemRequestBuilder"/></returns>
        public WithTokenItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("token", position);
                return new WithTokenItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="UserRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UserRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/cards/user", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="UserRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UserRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/cards/user", rawUrl)
        {
        }
    }
}
