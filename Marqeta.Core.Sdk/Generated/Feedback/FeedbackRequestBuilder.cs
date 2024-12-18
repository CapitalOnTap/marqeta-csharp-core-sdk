// <auto-generated/>
#pragma warning disable CS0618
using Marqeta.Core.Sdk.Feedback.Fraud;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Marqeta.Core.Sdk.Feedback
{
    /// <summary>
    /// Builds and executes requests for operations under \feedback
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class FeedbackRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The fraud property</summary>
        public global::Marqeta.Core.Sdk.Feedback.Fraud.FraudRequestBuilder Fraud
        {
            get => new global::Marqeta.Core.Sdk.Feedback.Fraud.FraudRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Feedback.FeedbackRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FeedbackRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/feedback", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Feedback.FeedbackRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FeedbackRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/feedback", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
