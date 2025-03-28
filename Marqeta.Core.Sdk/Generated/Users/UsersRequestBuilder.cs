// <auto-generated/>
#pragma warning disable CS0618
using Marqeta.Core.Sdk.Models;
using Marqeta.Core.Sdk.Users.Auth;
using Marqeta.Core.Sdk.Users.Item;
using Marqeta.Core.Sdk.Users.Lookup;
using Marqeta.Core.Sdk.Users.Phonenumber;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Marqeta.Core.Sdk.Users
{
    /// <summary>
    /// Builds and executes requests for operations under \users
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class UsersRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The auth property</summary>
        public global::Marqeta.Core.Sdk.Users.Auth.AuthRequestBuilder Auth
        {
            get => new global::Marqeta.Core.Sdk.Users.Auth.AuthRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The lookup property</summary>
        public global::Marqeta.Core.Sdk.Users.Lookup.LookupRequestBuilder Lookup
        {
            get => new global::Marqeta.Core.Sdk.Users.Lookup.LookupRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The phonenumber property</summary>
        public global::Marqeta.Core.Sdk.Users.Phonenumber.PhonenumberRequestBuilder Phonenumber
        {
            get => new global::Marqeta.Core.Sdk.Users.Phonenumber.PhonenumberRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Marqeta.Core.Sdk.users.item collection</summary>
        /// <param name="position">Unique identifier of the user resource.</param>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Users.Item.Parent_tokenItemRequestBuilder"/></returns>
        public global::Marqeta.Core.Sdk.Users.Item.Parent_tokenItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("parent_token%2Did", position);
                return new global::Marqeta.Core.Sdk.Users.Item.Parent_tokenItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Users.UsersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UsersRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users{?count*,fields*,search_type*,sort_by*,start_index*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Users.UsersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UsersRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users{?count*,fields*,search_type*,sort_by*,start_index*}", rawUrl)
        {
        }
        /// <summary>
        /// To return an array of all of a program&apos;s users, send a `GET` request to the `/users` endpoint.This endpoint supports &lt;&lt;/core-api/field-filtering, field filtering&gt;&gt; and &lt;&lt;/core-api/sorting-and-pagination, pagination&gt;&gt;.To narrow your result set to users that match certain criteria, see the &lt;&lt;search_users,Search users&gt;&gt; endpoint.The `business_token` field is conditionally returned in the response (it cannot be set through the API).You can use this field in conjunction with the `parent_token` field to determine whether the user has a parent or grandparent that is a business:[cols=&quot;1,1,1&quot;]|===| parent_token | business_token | Description| Not populated| Not populated| User does not have a parent.| Populated| Not populated| User&apos;s parent is a user.| Populated; matches `business_token`| Populated; matches `parent_token`| User&apos;s parent is a business.| Populated; does not match `business_token`| Populated; does not match `parent_token`| User&apos;s parent is a user and their grandparent is a business.|===
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.UserCardHolderListResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Marqeta.Core.Sdk.Models.ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Marqeta.Core.Sdk.Models.UserCardHolderListResponse?> GetAsync(Action<RequestConfiguration<global::Marqeta.Core.Sdk.Users.UsersRequestBuilder.UsersRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Marqeta.Core.Sdk.Models.UserCardHolderListResponse> GetAsync(Action<RequestConfiguration<global::Marqeta.Core.Sdk.Users.UsersRequestBuilder.UsersRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Marqeta.Core.Sdk.Models.ApiError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Marqeta.Core.Sdk.Models.UserCardHolderListResponse>(requestInfo, global::Marqeta.Core.Sdk.Models.UserCardHolderListResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// This endpoint enables you to create a user.A new user&apos;s initial status depends on the &lt;&lt;/core-api/kyc-verification, Know Your Customer (KYC) requirements&gt;&gt; of the program or associated &lt;&lt;/core-api/account-holder-groups, account holder group&gt;&gt;.[cols=&quot;1,1,1,1&quot;]|===| KYC Required | Initial User Status | User Active on Creation | User Limitations| Always| `UNVERIFIED`| Optional| Cannot load funds; cannot activate cards.| Conditionally| `LIMITED`| Optional| Restricted by rules in `accountholdergroups.pre_kyc_controls`.| Never| `ACTIVE`| Required| None.|===[NOTE]Use the `/usertransitions` endpoints to transition user resources between statuses and to view the history of a user&apos;s status.Do not set the value of the `user.active` field directly.For more information on status changes, see &lt;&lt;/core-api/user-transitions#postUsertransitions, Create User Transition&gt;&gt;.To perform KYC verification on users, the user object must have the following fields configured:* `first_name` (legal first name only, no prefixes)* `last_name` (legal last name only, no suffixes)* `address1` (cannot be a PO Box)* `city`* `state`* `postal_code`* `country`* `birth_date`* `identifications`* `phone` (required in some cases)* `email` (required in some cases)[NOTE]The `identifications` requirement depends on your program&apos;s configuration.To determine if you should provide a full or abbreviated identification number, contact your Marqeta representative.KYC verification requires the full Social Security Number (SSN) of the user.To create a child user, you must identify the parent user or business and determine whether the child user shares an account with the parent.The parent must be an existing user or business.On the child user, set the `parent_token` field to the value of the parent&apos;s `token` field.If either the parent or the grandparent is a business, a `business_token` field is added to the user.This field&apos;s value is set to the token of either the parent or grandparent (whichever is the business).The `uses_parent_account` field determines whether the child shares balances with the parent (`true`) or whether the child balances are independent of the parent (`false`).If you do not specify a value for `uses_parent_account`, it is set to `false` by default (the user does not share the parent&apos;s balance) and returned in the response body.This field cannot be updated, so you must decide upon creation whether the child user shares the parent balance.Sharing an account with a parent user affects how the child user interacts with cards as follows:* A child user cannot spend funds if its parent is not active.* An active child user can activate cards, whether the parent is active or not.
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.User_card_holder_response"/></returns>
        /// <param name="body">Contains information about a cardholder.</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Marqeta.Core.Sdk.Models.ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Marqeta.Core.Sdk.Models.User_card_holder_response?> PostAsync(global::Marqeta.Core.Sdk.Models.Card_holder_model body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Marqeta.Core.Sdk.Models.User_card_holder_response> PostAsync(global::Marqeta.Core.Sdk.Models.Card_holder_model body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Marqeta.Core.Sdk.Models.ApiError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Marqeta.Core.Sdk.Models.User_card_holder_response>(requestInfo, global::Marqeta.Core.Sdk.Models.User_card_holder_response.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// To return an array of all of a program&apos;s users, send a `GET` request to the `/users` endpoint.This endpoint supports &lt;&lt;/core-api/field-filtering, field filtering&gt;&gt; and &lt;&lt;/core-api/sorting-and-pagination, pagination&gt;&gt;.To narrow your result set to users that match certain criteria, see the &lt;&lt;search_users,Search users&gt;&gt; endpoint.The `business_token` field is conditionally returned in the response (it cannot be set through the API).You can use this field in conjunction with the `parent_token` field to determine whether the user has a parent or grandparent that is a business:[cols=&quot;1,1,1&quot;]|===| parent_token | business_token | Description| Not populated| Not populated| User does not have a parent.| Populated| Not populated| User&apos;s parent is a user.| Populated; matches `business_token`| Populated; matches `parent_token`| User&apos;s parent is a business.| Populated; does not match `business_token`| Populated; does not match `parent_token`| User&apos;s parent is a user and their grandparent is a business.|===
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Marqeta.Core.Sdk.Users.UsersRequestBuilder.UsersRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Marqeta.Core.Sdk.Users.UsersRequestBuilder.UsersRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// This endpoint enables you to create a user.A new user&apos;s initial status depends on the &lt;&lt;/core-api/kyc-verification, Know Your Customer (KYC) requirements&gt;&gt; of the program or associated &lt;&lt;/core-api/account-holder-groups, account holder group&gt;&gt;.[cols=&quot;1,1,1,1&quot;]|===| KYC Required | Initial User Status | User Active on Creation | User Limitations| Always| `UNVERIFIED`| Optional| Cannot load funds; cannot activate cards.| Conditionally| `LIMITED`| Optional| Restricted by rules in `accountholdergroups.pre_kyc_controls`.| Never| `ACTIVE`| Required| None.|===[NOTE]Use the `/usertransitions` endpoints to transition user resources between statuses and to view the history of a user&apos;s status.Do not set the value of the `user.active` field directly.For more information on status changes, see &lt;&lt;/core-api/user-transitions#postUsertransitions, Create User Transition&gt;&gt;.To perform KYC verification on users, the user object must have the following fields configured:* `first_name` (legal first name only, no prefixes)* `last_name` (legal last name only, no suffixes)* `address1` (cannot be a PO Box)* `city`* `state`* `postal_code`* `country`* `birth_date`* `identifications`* `phone` (required in some cases)* `email` (required in some cases)[NOTE]The `identifications` requirement depends on your program&apos;s configuration.To determine if you should provide a full or abbreviated identification number, contact your Marqeta representative.KYC verification requires the full Social Security Number (SSN) of the user.To create a child user, you must identify the parent user or business and determine whether the child user shares an account with the parent.The parent must be an existing user or business.On the child user, set the `parent_token` field to the value of the parent&apos;s `token` field.If either the parent or the grandparent is a business, a `business_token` field is added to the user.This field&apos;s value is set to the token of either the parent or grandparent (whichever is the business).The `uses_parent_account` field determines whether the child shares balances with the parent (`true`) or whether the child balances are independent of the parent (`false`).If you do not specify a value for `uses_parent_account`, it is set to `false` by default (the user does not share the parent&apos;s balance) and returned in the response body.This field cannot be updated, so you must decide upon creation whether the child user shares the parent balance.Sharing an account with a parent user affects how the child user interacts with cards as follows:* A child user cannot spend funds if its parent is not active.* An active child user can activate cards, whether the parent is active or not.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">Contains information about a cardholder.</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Marqeta.Core.Sdk.Models.Card_holder_model body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Marqeta.Core.Sdk.Models.Card_holder_model body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Users.UsersRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Marqeta.Core.Sdk.Users.UsersRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Marqeta.Core.Sdk.Users.UsersRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// To return an array of all of a program&apos;s users, send a `GET` request to the `/users` endpoint.This endpoint supports &lt;&lt;/core-api/field-filtering, field filtering&gt;&gt; and &lt;&lt;/core-api/sorting-and-pagination, pagination&gt;&gt;.To narrow your result set to users that match certain criteria, see the &lt;&lt;search_users,Search users&gt;&gt; endpoint.The `business_token` field is conditionally returned in the response (it cannot be set through the API).You can use this field in conjunction with the `parent_token` field to determine whether the user has a parent or grandparent that is a business:[cols=&quot;1,1,1&quot;]|===| parent_token | business_token | Description| Not populated| Not populated| User does not have a parent.| Populated| Not populated| User&apos;s parent is a user.| Populated; matches `business_token`| Populated; matches `parent_token`| User&apos;s parent is a business.| Populated; does not match `business_token`| Populated; does not match `parent_token`| User&apos;s parent is a user and their grandparent is a business.|===
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class UsersRequestBuilderGetQueryParameters 
        {
            /// <summary>Number of user resources to retrieve.</summary>
            [QueryParameter("count")]
            public int? Count { get; set; }
            /// <summary>Comma-delimited list of fields to return (`field_1,field_2`, and so on).Leave blank to return all fields.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields")]
            public string? Fields { get; set; }
#nullable restore
#else
            [QueryParameter("fields")]
            public string Fields { get; set; }
#endif
            /// <summary>Search type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("search_type")]
            public string? SearchType { get; set; }
#nullable restore
#else
            [QueryParameter("search_type")]
            public string SearchType { get; set; }
#endif
            /// <summary>Field on which to sort.Use any field in the resource model, or one of the system fields `lastModifiedTime` or `createdTime`.Prefix the field name with a hyphen (`-`) to sort in descending order.Omit the hyphen to sort in ascending order.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("sort_by")]
            public string? SortBy { get; set; }
#nullable restore
#else
            [QueryParameter("sort_by")]
            public string SortBy { get; set; }
#endif
            /// <summary>Sort order index of the first resource in the returned array.</summary>
            [QueryParameter("start_index")]
            public int? StartIndex { get; set; }
        }
    }
}
#pragma warning restore CS0618
