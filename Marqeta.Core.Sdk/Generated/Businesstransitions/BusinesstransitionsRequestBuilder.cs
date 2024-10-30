// <auto-generated/>
#pragma warning disable CS0618
using Marqeta.Core.Sdk.Businesstransitions.Business;
using Marqeta.Core.Sdk.Businesstransitions.Item;
using Marqeta.Core.Sdk.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Marqeta.Core.Sdk.Businesstransitions
{
    /// <summary>
    /// Builds and executes requests for operations under \businesstransitions
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class BusinesstransitionsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The business property</summary>
        public global::Marqeta.Core.Sdk.Businesstransitions.Business.BusinessRequestBuilder Business
        {
            get => new global::Marqeta.Core.Sdk.Businesstransitions.Business.BusinessRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Marqeta.Core.Sdk.businesstransitions.item collection</summary>
        /// <param name="position">The unique identifier of the business transition you want to retrieve.</param>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Businesstransitions.Item.WithTokenItemRequestBuilder"/></returns>
        public global::Marqeta.Core.Sdk.Businesstransitions.Item.WithTokenItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("token", position);
                return new global::Marqeta.Core.Sdk.Businesstransitions.Item.WithTokenItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Businesstransitions.BusinesstransitionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BusinesstransitionsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/businesstransitions", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Businesstransitions.BusinesstransitionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BusinesstransitionsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/businesstransitions", rawUrl)
        {
        }
        /// <summary>
        /// This endpoint enables you to change a business&apos; status, depending on your role and the previous status change.By changing a business&apos; status, you can control the business&apos; capabilities and the setting of the `business.active` field.The `business.active` field is `true` if your business is in the `LIMITED` or `ACTIVE` state, and `false` if your business is in the `UNVERIFIED` state.You cannot control the value of the `business.active` field directly.[cols=&quot;,2a,2a&quot;]|===| The business.status field | Description | Business limitations| Unverified| Initial status of a newly created business belonging to an `accountholdergroup` where KYC is always required.| Cannot load funds.*The business.active field:*   +`false`*Allowable transitions:*   +`ACTIVE`, `SUSPENDED`, `CLOSED`| Limited| Initial status of a newly created business belonging to an `accountholdergroup` where KYC is conditionally required.| Restricted by rules in `accountholdergroups.pre_kyc_controls`.*The business.active field:*   +`true`*Allowable transitions:*   +`ACTIVE`, `SUSPENDED`, `CLOSED`| Active| Status of a business that has passed KYC; initial status of a newly created business belonging to an `accountholdergroup` where KYC is never required.| None.*The business.active field:*   +`true`*Allowable transitions:*   +`SUSPENDED`, `CLOSED`| Suspended| The business is temporarily inactive.*NOTE:* Transitioning a suspended business to the `ACTIVE` status is restricted, based on your role and the details of the previous status change.| Cannot load funds or activate cards.*The business.active field:*   +`false`*Allowable transitions:*   +`ACTIVE`, `LIMITED`, `UNVERIFIED`, `CLOSED`| Closed| The business is permanently inactive.*NOTE:* `CLOSED` is a terminal status.In exceptional cases, you can transition a business from `CLOSED` to another status, depending on your role and the details of the previous status change.Contact your Marqeta representative for more information.| Cannot load funds.*The business.active field:*   +`false`*Allowable transitions:*   +`ACTIVE`, `LIMITED`, `UNVERIFIED`, `SUSPENDED`|===[NOTE]The Marqeta platform transitions a business&apos; status in response to certain events.For example, a business with an `UNVERIFIED` status transitions to `ACTIVE` when the business passes KYC.
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.BusinessTransitionResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Marqeta.Core.Sdk.Models.ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Marqeta.Core.Sdk.Models.BusinessTransitionResponse?> PostAsync(global::Marqeta.Core.Sdk.Models.BusinessTransitionRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Marqeta.Core.Sdk.Models.BusinessTransitionResponse> PostAsync(global::Marqeta.Core.Sdk.Models.BusinessTransitionRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Marqeta.Core.Sdk.Models.ApiError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Marqeta.Core.Sdk.Models.BusinessTransitionResponse>(requestInfo, global::Marqeta.Core.Sdk.Models.BusinessTransitionResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// This endpoint enables you to change a business&apos; status, depending on your role and the previous status change.By changing a business&apos; status, you can control the business&apos; capabilities and the setting of the `business.active` field.The `business.active` field is `true` if your business is in the `LIMITED` or `ACTIVE` state, and `false` if your business is in the `UNVERIFIED` state.You cannot control the value of the `business.active` field directly.[cols=&quot;,2a,2a&quot;]|===| The business.status field | Description | Business limitations| Unverified| Initial status of a newly created business belonging to an `accountholdergroup` where KYC is always required.| Cannot load funds.*The business.active field:*   +`false`*Allowable transitions:*   +`ACTIVE`, `SUSPENDED`, `CLOSED`| Limited| Initial status of a newly created business belonging to an `accountholdergroup` where KYC is conditionally required.| Restricted by rules in `accountholdergroups.pre_kyc_controls`.*The business.active field:*   +`true`*Allowable transitions:*   +`ACTIVE`, `SUSPENDED`, `CLOSED`| Active| Status of a business that has passed KYC; initial status of a newly created business belonging to an `accountholdergroup` where KYC is never required.| None.*The business.active field:*   +`true`*Allowable transitions:*   +`SUSPENDED`, `CLOSED`| Suspended| The business is temporarily inactive.*NOTE:* Transitioning a suspended business to the `ACTIVE` status is restricted, based on your role and the details of the previous status change.| Cannot load funds or activate cards.*The business.active field:*   +`false`*Allowable transitions:*   +`ACTIVE`, `LIMITED`, `UNVERIFIED`, `CLOSED`| Closed| The business is permanently inactive.*NOTE:* `CLOSED` is a terminal status.In exceptional cases, you can transition a business from `CLOSED` to another status, depending on your role and the details of the previous status change.Contact your Marqeta representative for more information.| Cannot load funds.*The business.active field:*   +`false`*Allowable transitions:*   +`ACTIVE`, `LIMITED`, `UNVERIFIED`, `SUSPENDED`|===[NOTE]The Marqeta platform transitions a business&apos; status in response to certain events.For example, a business with an `UNVERIFIED` status transitions to `ACTIVE` when the business passes KYC.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Marqeta.Core.Sdk.Models.BusinessTransitionRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Marqeta.Core.Sdk.Models.BusinessTransitionRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Businesstransitions.BusinesstransitionsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Marqeta.Core.Sdk.Businesstransitions.BusinesstransitionsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Marqeta.Core.Sdk.Businesstransitions.BusinesstransitionsRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
#pragma warning restore CS0618
