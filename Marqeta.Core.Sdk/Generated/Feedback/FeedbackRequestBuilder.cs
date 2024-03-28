// <auto-generated/>
using Marqeta.Core.Sdk.Feedback.Fraud;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Marqeta.Core.Sdk.Feedback {
    /// <summary>
    /// Builds and executes requests for operations under \feedback
    /// </summary>
    public class FeedbackRequestBuilder : BaseRequestBuilder {
        /// <summary>The fraud property</summary>
        public FraudRequestBuilder Fraud { get =>
            new FraudRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="FeedbackRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FeedbackRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/feedback", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="FeedbackRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FeedbackRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/feedback", rawUrl) {
        }
    }
}
