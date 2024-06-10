// <auto-generated/>
using Marqeta.Core.Sdk.Pushtocards.Disburse;
using Marqeta.Core.Sdk.Pushtocards.Paymentcard;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Marqeta.Core.Sdk.Pushtocards
{
    /// <summary>
    /// Builds and executes requests for operations under \pushtocards
    /// </summary>
    public class PushtocardsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The disburse property</summary>
        public Marqeta.Core.Sdk.Pushtocards.Disburse.DisburseRequestBuilder Disburse
        {
            get => new Marqeta.Core.Sdk.Pushtocards.Disburse.DisburseRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The paymentcard property</summary>
        public Marqeta.Core.Sdk.Pushtocards.Paymentcard.PaymentcardRequestBuilder Paymentcard
        {
            get => new Marqeta.Core.Sdk.Pushtocards.Paymentcard.PaymentcardRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Pushtocards.PushtocardsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PushtocardsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/pushtocards", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Pushtocards.PushtocardsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PushtocardsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/pushtocards", rawUrl)
        {
        }
    }
}
