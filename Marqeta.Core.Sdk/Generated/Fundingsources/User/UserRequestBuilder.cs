// <auto-generated/>
using Marqeta.Core.Sdk.Fundingsources.User.Item;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Marqeta.Core.Sdk.Fundingsources.User {
    /// <summary>
    /// Builds and executes requests for operations under \fundingsources\user
    /// </summary>
    public class UserRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the Marqeta.Core.Sdk.fundingsources.user.item collection</summary>
        /// <param name="position">Unique identifier of the user account holder.</param>
        /// <returns>A <see cref="WithUser_tokenItemRequestBuilder"/></returns>
        public WithUser_tokenItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("user_token", position);
            return new WithUser_tokenItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new <see cref="UserRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UserRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/fundingsources/user", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="UserRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UserRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/fundingsources/user", rawUrl) {
        }
    }
}
