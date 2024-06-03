// <auto-generated/>
using Marqeta.Core.Sdk.Models;
using Marqeta.Core.Sdk.Usertransitions.Item;
using Marqeta.Core.Sdk.Usertransitions.User;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Marqeta.Core.Sdk.Usertransitions {
    /// <summary>
    /// Builds and executes requests for operations under \usertransitions
    /// </summary>
    public class UsertransitionsRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>The user property</summary>
        public UserRequestBuilder User
        {
            get => new UserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Marqeta.Core.Sdk.usertransitions.item collection</summary>
        /// <param name="position">Unique identifier of the user transition you want to retrieve.</param>
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
        /// Instantiates a new <see cref="UsertransitionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UsertransitionsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/usertransitions", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="UsertransitionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UsertransitionsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/usertransitions", rawUrl)
        {
        }
        /// <summary>
        /// This endpoint enables you to change a user&apos;s status, depending on your role and the previous status change.By changing a user&apos;s status, you can control the user&apos;s capabilities and the setting of the `user.active` field.Do not set the value of the `user.active` field directly.[cols=&quot;2,4a,4a&quot;]|===| user.status Field | Description | User Limitations| `UNVERIFIED`| Initial status of a new user belonging to an account holder group where KYC is always required.*Allowable transitions:*  +`ACTIVE`, `CLOSED`| Cannot activate cards or load funds.*user.active Field:*  +`false`| `LIMITED`| Initial status of a new user belonging to an account holder group where KYC is conditionally required.*Allowable transitions:*  +`ACTIVE`, `SUSPENDED`, `CLOSED`| Restricted by rules in `accountholdergroups.pre_kyc_controls`.*user.active Field:*  +`true`| `ACTIVE`| Status of a user who has passed KYC, or initial status of a new user belonging to an account holder group where KYC is never required.*Allowable transitions:*  +`SUSPENDED`, `CLOSED`, `UNVERIFIED`| None.*user.active Field:*  +`true`| `SUSPENDED`| The user is temporarily inactive.Transitioning a suspended user to the `ACTIVE` status is restricted, based on your role and the details of the previous status change.*Allowable transitions:*  +`ACTIVE`, `LIMITED`, `UNVERIFIED`, `CLOSED`| Cannot activate cards, load funds, or transact.*user.active Field:*  +`false`| `CLOSED`| The user is permanently inactive.In general, the `CLOSED` status should be terminal.For exceptional cases, you can transition a user to other statuses, depending on your role and the details of the previous status change.Contact your Marqeta representative for more information.*Allowable transitions:*  +`ACTIVE`, `LIMITED`, `UNVERIFIED`, `SUSPENDED`| Cannot activate cards, load funds, or transact.*user.active Field:*  +`false`|===[NOTE]The Marqeta platform transitions a user&apos;s status in response to certain events.For example, a user in the `UNVERIFIED` status is transitioned to `ACTIVE` when the user passes KYC verification.
        /// </summary>
        /// <returns>A <see cref="UserTransitionResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<UserTransitionResponse?> PostAsync(UserTransitionRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<UserTransitionResponse> PostAsync(UserTransitionRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"XXX", ApiError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<UserTransitionResponse>(requestInfo, UserTransitionResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// This endpoint enables you to change a user&apos;s status, depending on your role and the previous status change.By changing a user&apos;s status, you can control the user&apos;s capabilities and the setting of the `user.active` field.Do not set the value of the `user.active` field directly.[cols=&quot;2,4a,4a&quot;]|===| user.status Field | Description | User Limitations| `UNVERIFIED`| Initial status of a new user belonging to an account holder group where KYC is always required.*Allowable transitions:*  +`ACTIVE`, `CLOSED`| Cannot activate cards or load funds.*user.active Field:*  +`false`| `LIMITED`| Initial status of a new user belonging to an account holder group where KYC is conditionally required.*Allowable transitions:*  +`ACTIVE`, `SUSPENDED`, `CLOSED`| Restricted by rules in `accountholdergroups.pre_kyc_controls`.*user.active Field:*  +`true`| `ACTIVE`| Status of a user who has passed KYC, or initial status of a new user belonging to an account holder group where KYC is never required.*Allowable transitions:*  +`SUSPENDED`, `CLOSED`, `UNVERIFIED`| None.*user.active Field:*  +`true`| `SUSPENDED`| The user is temporarily inactive.Transitioning a suspended user to the `ACTIVE` status is restricted, based on your role and the details of the previous status change.*Allowable transitions:*  +`ACTIVE`, `LIMITED`, `UNVERIFIED`, `CLOSED`| Cannot activate cards, load funds, or transact.*user.active Field:*  +`false`| `CLOSED`| The user is permanently inactive.In general, the `CLOSED` status should be terminal.For exceptional cases, you can transition a user to other statuses, depending on your role and the details of the previous status change.Contact your Marqeta representative for more information.*Allowable transitions:*  +`ACTIVE`, `LIMITED`, `UNVERIFIED`, `SUSPENDED`| Cannot activate cards, load funds, or transact.*user.active Field:*  +`false`|===[NOTE]The Marqeta platform transitions a user&apos;s status in response to certain events.For example, a user in the `UNVERIFIED` status is transitioned to `ACTIVE` when the user passes KYC verification.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(UserTransitionRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(UserTransitionRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="UsertransitionsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public UsertransitionsRequestBuilder WithUrl(string rawUrl)
        {
            return new UsertransitionsRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
