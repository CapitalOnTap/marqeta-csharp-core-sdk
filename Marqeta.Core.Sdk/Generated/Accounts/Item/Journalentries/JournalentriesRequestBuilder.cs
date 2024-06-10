// <auto-generated/>
using Marqeta.Core.Sdk.Accounts.Item.Journalentries.Item;
using Marqeta.Core.Sdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Marqeta.Core.Sdk.Accounts.Item.Journalentries
{
    /// <summary>
    /// Builds and executes requests for operations under \accounts\{account_token}\journalentries
    /// </summary>
    public class JournalentriesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Marqeta.Core.Sdk.accounts.item.journalentries.item collection</summary>
        /// <param name="position">Unique identifier of the journal entry you want to retrieve.Send a `GET` request to `/credit/accounts/{account_token}/journalentries` to retrieve existing journal entry tokens.</param>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Accounts.Item.Journalentries.Item.WithJournal_entry_tokenItemRequestBuilder"/></returns>
        public Marqeta.Core.Sdk.Accounts.Item.Journalentries.Item.WithJournal_entry_tokenItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("journal_entry_token", position);
                return new Marqeta.Core.Sdk.Accounts.Item.Journalentries.Item.WithJournal_entry_tokenItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Accounts.Item.Journalentries.JournalentriesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public JournalentriesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_token}/journalentries{?card_tokens*,count*,end_created_time*,end_date*,end_impact_time*,expand*,groups*,sort_by*,start_created_time*,start_date*,start_impact_time*,start_index*,statuses*,types*,user_tokens*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Accounts.Item.Journalentries.JournalentriesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public JournalentriesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_token}/journalentries{?card_tokens*,count*,end_created_time*,end_date*,end_impact_time*,expand*,groups*,sort_by*,start_created_time*,start_date*,start_impact_time*,start_index*,statuses*,types*,user_tokens*}", rawUrl)
        {
        }
        /// <summary>
        /// Retrieve an array of journal entries on a credit account.This endpoint supports &lt;&lt;/core-api/sorting-and-pagination, sorting and pagination&gt;&gt; and &lt;&lt;/core-api/object-expansion, object expansion&gt;&gt;.
        /// </summary>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Models.JournalEntriesPage"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Marqeta.Core.Sdk.Models.ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Marqeta.Core.Sdk.Models.JournalEntriesPage?> GetAsync(Action<RequestConfiguration<Marqeta.Core.Sdk.Accounts.Item.Journalentries.JournalentriesRequestBuilder.JournalentriesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Marqeta.Core.Sdk.Models.JournalEntriesPage> GetAsync(Action<RequestConfiguration<Marqeta.Core.Sdk.Accounts.Item.Journalentries.JournalentriesRequestBuilder.JournalentriesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Marqeta.Core.Sdk.Models.ApiError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Marqeta.Core.Sdk.Models.JournalEntriesPage>(requestInfo, Marqeta.Core.Sdk.Models.JournalEntriesPage.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieve an array of journal entries on a credit account.This endpoint supports &lt;&lt;/core-api/sorting-and-pagination, sorting and pagination&gt;&gt; and &lt;&lt;/core-api/object-expansion, object expansion&gt;&gt;.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Marqeta.Core.Sdk.Accounts.Item.Journalentries.JournalentriesRequestBuilder.JournalentriesRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Marqeta.Core.Sdk.Accounts.Item.Journalentries.JournalentriesRequestBuilder.JournalentriesRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Accounts.Item.Journalentries.JournalentriesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Marqeta.Core.Sdk.Accounts.Item.Journalentries.JournalentriesRequestBuilder WithUrl(string rawUrl)
        {
            return new Marqeta.Core.Sdk.Accounts.Item.Journalentries.JournalentriesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Retrieve an array of journal entries on a credit account.This endpoint supports &lt;&lt;/core-api/sorting-and-pagination, sorting and pagination&gt;&gt; and &lt;&lt;/core-api/object-expansion, object expansion&gt;&gt;.
        /// </summary>
        public class JournalentriesRequestBuilderGetQueryParameters 
        {
            /// <summary>Array of card tokens by which to filter journal entries.Returns journal entries associated with the specified card tokens.Send a `GET` request to `/credit/accounts/{account_token}/cards/` to retrieve existing card tokens.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("card_tokens")]
            public string[]? CardTokens { get; set; }
#nullable restore
#else
            [QueryParameter("card_tokens")]
            public string[] CardTokens { get; set; }
#endif
            /// <summary>Number of journal entry resources to retrieve.</summary>
            [QueryParameter("count")]
            public int? Count { get; set; }
            /// <summary>Ending `created_date` of the date range from which to return journal entries.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("end_created_time")]
            public string? EndCreatedTime { get; set; }
#nullable restore
#else
            [QueryParameter("end_created_time")]
            public string EndCreatedTime { get; set; }
#endif
            /// <summary>Ending date of the date range from which to return journal entries.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("end_date")]
            public string? EndDate { get; set; }
#nullable restore
#else
            [QueryParameter("end_date")]
            public string EndDate { get; set; }
#endif
            /// <summary>Ending `impact_time` of the date range from which to return journal entries.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("end_impact_time")]
            public string? EndImpactTime { get; set; }
#nullable restore
#else
            [QueryParameter("end_impact_time")]
            public string EndImpactTime { get; set; }
#endif
            /// <summary>Embeds the specified object into the response.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("expand")]
            public Marqeta.Core.Sdk.Accounts.Item.Journalentries.GetExpandQueryParameterType[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("expand")]
            public Marqeta.Core.Sdk.Accounts.Item.Journalentries.GetExpandQueryParameterType[] Expand { get; set; }
#endif
            /// <summary>Array of groups by which to filter journal entries.To return all journal entry groups, do not include this query parameter.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("groups")]
            public Marqeta.Core.Sdk.Accounts.Item.Journalentries.GetGroupsQueryParameterType[]? Groups { get; set; }
#nullable restore
#else
            [QueryParameter("groups")]
            public Marqeta.Core.Sdk.Accounts.Item.Journalentries.GetGroupsQueryParameterType[] Groups { get; set; }
#endif
            /// <summary>Field on which to sort.Prefix the field name with a hyphen (`-`) to sort in descending order.Omit the hyphen to sort in ascending order.*NOTE:*You must sort using system field names such as `createdTime`, and not by the field names appearing in response bodies such as `created_time`.</summary>
            [QueryParameter("sort_by")]
            public Marqeta.Core.Sdk.Accounts.Item.Journalentries.GetSort_byQueryParameterType? SortBy { get; set; }
            /// <summary>Starting `created_date` of the date range from which to return journal entries.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("start_created_time")]
            public string? StartCreatedTime { get; set; }
#nullable restore
#else
            [QueryParameter("start_created_time")]
            public string StartCreatedTime { get; set; }
#endif
            /// <summary>Starting date of the date range from which to return journal entries.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("start_date")]
            public string? StartDate { get; set; }
#nullable restore
#else
            [QueryParameter("start_date")]
            public string StartDate { get; set; }
#endif
            /// <summary>Starting `impact_time` of the date range from which to return journal entries.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("start_impact_time")]
            public string? StartImpactTime { get; set; }
#nullable restore
#else
            [QueryParameter("start_impact_time")]
            public string StartImpactTime { get; set; }
#endif
            /// <summary>Sort order index of the first resource in the returned array.</summary>
            [QueryParameter("start_index")]
            public int? StartIndex { get; set; }
            /// <summary>Array of statuses by which to filter journal entries.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("statuses")]
            public Marqeta.Core.Sdk.Accounts.Item.Journalentries.GetStatusesQueryParameterType[]? Statuses { get; set; }
#nullable restore
#else
            [QueryParameter("statuses")]
            public Marqeta.Core.Sdk.Accounts.Item.Journalentries.GetStatusesQueryParameterType[] Statuses { get; set; }
#endif
            /// <summary>Array of &lt;&lt;/core-api/event-types#_credit_journal_entry_events, event types&gt;&gt; by which to filter journal entries.To return all event types, do not include this query parameter.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("types")]
            public Marqeta.Core.Sdk.Accounts.Item.Journalentries.GetTypesQueryParameterType[]? Types { get; set; }
#nullable restore
#else
            [QueryParameter("types")]
            public Marqeta.Core.Sdk.Accounts.Item.Journalentries.GetTypesQueryParameterType[] Types { get; set; }
#endif
            /// <summary>Array of user tokens by which to filter journal entries.Returns journal entries associated with the specified user tokens.Send a `GET` request to `/users` to retrieve existing user tokens.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("user_tokens")]
            public string[]? UserTokens { get; set; }
#nullable restore
#else
            [QueryParameter("user_tokens")]
            public string[] UserTokens { get; set; }
#endif
        }
    }
}
