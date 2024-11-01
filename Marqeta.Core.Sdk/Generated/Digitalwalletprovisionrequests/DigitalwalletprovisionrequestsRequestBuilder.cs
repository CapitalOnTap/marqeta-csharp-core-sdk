// <auto-generated/>
#pragma warning disable CS0618
using Marqeta.Core.Sdk.Digitalwalletprovisionrequests.Androidpay;
using Marqeta.Core.Sdk.Digitalwalletprovisionrequests.Applepay;
using Marqeta.Core.Sdk.Digitalwalletprovisionrequests.Samsungpay;
using Marqeta.Core.Sdk.Digitalwalletprovisionrequests.Xpay;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Marqeta.Core.Sdk.Digitalwalletprovisionrequests
{
    /// <summary>
    /// Builds and executes requests for operations under \digitalwalletprovisionrequests
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DigitalwalletprovisionrequestsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The androidpay property</summary>
        public global::Marqeta.Core.Sdk.Digitalwalletprovisionrequests.Androidpay.AndroidpayRequestBuilder Androidpay
        {
            get => new global::Marqeta.Core.Sdk.Digitalwalletprovisionrequests.Androidpay.AndroidpayRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The applepay property</summary>
        public global::Marqeta.Core.Sdk.Digitalwalletprovisionrequests.Applepay.ApplepayRequestBuilder Applepay
        {
            get => new global::Marqeta.Core.Sdk.Digitalwalletprovisionrequests.Applepay.ApplepayRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The samsungpay property</summary>
        public global::Marqeta.Core.Sdk.Digitalwalletprovisionrequests.Samsungpay.SamsungpayRequestBuilder Samsungpay
        {
            get => new global::Marqeta.Core.Sdk.Digitalwalletprovisionrequests.Samsungpay.SamsungpayRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The xpay property</summary>
        public global::Marqeta.Core.Sdk.Digitalwalletprovisionrequests.Xpay.XpayRequestBuilder Xpay
        {
            get => new global::Marqeta.Core.Sdk.Digitalwalletprovisionrequests.Xpay.XpayRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Digitalwalletprovisionrequests.DigitalwalletprovisionrequestsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DigitalwalletprovisionrequestsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/digitalwalletprovisionrequests", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Digitalwalletprovisionrequests.DigitalwalletprovisionrequestsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DigitalwalletprovisionrequestsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/digitalwalletprovisionrequests", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
