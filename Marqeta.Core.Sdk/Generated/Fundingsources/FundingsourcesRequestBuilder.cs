// <auto-generated/>
#pragma warning disable CS0618
using Marqeta.Core.Sdk.Fundingsources.Ach;
using Marqeta.Core.Sdk.Fundingsources.Addresses;
using Marqeta.Core.Sdk.Fundingsources.Business;
using Marqeta.Core.Sdk.Fundingsources.Item;
using Marqeta.Core.Sdk.Fundingsources.Paymentcard;
using Marqeta.Core.Sdk.Fundingsources.Program;
using Marqeta.Core.Sdk.Fundingsources.Programgateway;
using Marqeta.Core.Sdk.Fundingsources.User;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Marqeta.Core.Sdk.Fundingsources
{
    /// <summary>
    /// Builds and executes requests for operations under \fundingsources
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class FundingsourcesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The ach property</summary>
        public global::Marqeta.Core.Sdk.Fundingsources.Ach.AchRequestBuilder Ach
        {
            get => new global::Marqeta.Core.Sdk.Fundingsources.Ach.AchRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The addresses property</summary>
        public global::Marqeta.Core.Sdk.Fundingsources.Addresses.AddressesRequestBuilder Addresses
        {
            get => new global::Marqeta.Core.Sdk.Fundingsources.Addresses.AddressesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The business property</summary>
        public global::Marqeta.Core.Sdk.Fundingsources.Business.BusinessRequestBuilder Business
        {
            get => new global::Marqeta.Core.Sdk.Fundingsources.Business.BusinessRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The paymentcard property</summary>
        public global::Marqeta.Core.Sdk.Fundingsources.Paymentcard.PaymentcardRequestBuilder Paymentcard
        {
            get => new global::Marqeta.Core.Sdk.Fundingsources.Paymentcard.PaymentcardRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The program property</summary>
        public global::Marqeta.Core.Sdk.Fundingsources.Program.ProgramRequestBuilder Program
        {
            get => new global::Marqeta.Core.Sdk.Fundingsources.Program.ProgramRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The programgateway property</summary>
        public global::Marqeta.Core.Sdk.Fundingsources.Programgateway.ProgramgatewayRequestBuilder Programgateway
        {
            get => new global::Marqeta.Core.Sdk.Fundingsources.Programgateway.ProgramgatewayRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The user property</summary>
        public global::Marqeta.Core.Sdk.Fundingsources.User.UserRequestBuilder User
        {
            get => new global::Marqeta.Core.Sdk.Fundingsources.User.UserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Marqeta.Core.Sdk.fundingsources.item collection</summary>
        /// <param name="position">Unique identifier of the funding source.Send a `GET` request to `/fundingsources/user/{user_token}` to retrieve existing funding source tokens for a user or to `/fundingsources/business/{business_token}` to retrieve existing funding source tokens for a business.</param>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Fundingsources.Item.WithFunding_source_tokenItemRequestBuilder"/></returns>
        public global::Marqeta.Core.Sdk.Fundingsources.Item.WithFunding_source_tokenItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("funding_source_token", position);
                return new global::Marqeta.Core.Sdk.Fundingsources.Item.WithFunding_source_tokenItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Fundingsources.FundingsourcesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FundingsourcesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/fundingsources", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Fundingsources.FundingsourcesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FundingsourcesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/fundingsources", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
