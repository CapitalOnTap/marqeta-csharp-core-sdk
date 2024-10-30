// <auto-generated/>
#pragma warning disable CS0618
using Marqeta.Core.Sdk.Admin.Item;
using Marqeta.Core.Sdk.Admin.Programs;
using Marqeta.Core.Sdk.Admin.Replayfailedstatements;
using Marqeta.Core.Sdk.Admin.ScheduleStatements;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Marqeta.Core.Sdk.Admin
{
    /// <summary>
    /// Builds and executes requests for operations under \admin
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class AdminRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The programs property</summary>
        public global::Marqeta.Core.Sdk.Admin.Programs.ProgramsRequestBuilder Programs
        {
            get => new global::Marqeta.Core.Sdk.Admin.Programs.ProgramsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The replayfailedstatements property</summary>
        public global::Marqeta.Core.Sdk.Admin.Replayfailedstatements.ReplayfailedstatementsRequestBuilder Replayfailedstatements
        {
            get => new global::Marqeta.Core.Sdk.Admin.Replayfailedstatements.ReplayfailedstatementsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The scheduleStatements property</summary>
        public global::Marqeta.Core.Sdk.Admin.ScheduleStatements.ScheduleStatementsRequestBuilder ScheduleStatements
        {
            get => new global::Marqeta.Core.Sdk.Admin.ScheduleStatements.ScheduleStatementsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Marqeta.Core.Sdk.admin.item collection</summary>
        /// <param name="position">Short code of the program</param>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Admin.Item.WithShort_codeItemRequestBuilder"/></returns>
        public global::Marqeta.Core.Sdk.Admin.Item.WithShort_codeItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("short_code", position);
                return new global::Marqeta.Core.Sdk.Admin.Item.WithShort_codeItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Admin.AdminRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AdminRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Admin.AdminRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AdminRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
