// <auto-generated/>
using Marqeta.Core.Sdk.Admin.Item;
using Marqeta.Core.Sdk.Admin.Replayfailedstatements;
using Marqeta.Core.Sdk.Admin.ScheduleStatements;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Marqeta.Core.Sdk.Admin {
    /// <summary>
    /// Builds and executes requests for operations under \admin
    /// </summary>
    public class AdminRequestBuilder : BaseRequestBuilder {
        /// <summary>The replayfailedstatements property</summary>
        public ReplayfailedstatementsRequestBuilder Replayfailedstatements { get =>
            new ReplayfailedstatementsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The scheduleStatements property</summary>
        public ScheduleStatementsRequestBuilder ScheduleStatements { get =>
            new ScheduleStatementsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Marqeta.Core.Sdk.admin.item collection</summary>
        /// <param name="position">Short code of the program</param>
        /// <returns>A <see cref="WithShort_codeItemRequestBuilder"/></returns>
        public WithShort_codeItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("short_code", position);
            return new WithShort_codeItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new <see cref="AdminRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AdminRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="AdminRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AdminRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin", rawUrl) {
        }
    }
}
