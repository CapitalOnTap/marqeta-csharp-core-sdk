// <auto-generated/>
#pragma warning disable CS0618
using Marqeta.Core.Sdk.Fundingsources.Ach.Partner.Item;
using Marqeta.Core.Sdk.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Marqeta.Core.Sdk.Fundingsources.Ach.Partner
{
    /// <summary>
    /// Builds and executes requests for operations under \fundingsources\ach\partner
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class PartnerRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Marqeta.Core.Sdk.fundingsources.ach.partner.item collection</summary>
        /// <param name="position">Funding source token</param>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Fundingsources.Ach.Partner.Item.WithFunding_source_tokenItemRequestBuilder"/></returns>
        public global::Marqeta.Core.Sdk.Fundingsources.Ach.Partner.Item.WithFunding_source_tokenItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("funding_source_token", position);
                return new global::Marqeta.Core.Sdk.Fundingsources.Ach.Partner.Item.WithFunding_source_tokenItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Fundingsources.Ach.Partner.PartnerRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PartnerRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/fundingsources/ach/partner", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Fundingsources.Ach.Partner.PartnerRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PartnerRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/fundingsources/ach/partner", rawUrl)
        {
        }
        /// <summary>
        /// Create an ACH funding source for an existing account holder by using a third-party partner to handle account validation and provide PII account data.Because you don&apos;t handle any personally identifiable information (PII) yourself, using a third party when creating the funding source enables you to bypass the regulatory and compliance measures related to capturing, storing, and transmitting PII.With this endpoint, you can create a US-based funding source—either a checking account or a savings account—for a program or user without passing bank account details such as the account number or routing number to Marqeta.Instead, validating account data and account verification is handled by the third-party partner you specify, and a secure token (i.e., a Plaid `processor_token`) is shared across partners.By using a secure account verification platform to provide immediate verification, you shorten the wait time until the ACH funding source is ready and avoid managing the microdeposit-based account verification process.To create an ACH funding source for an existing account holder without validating through a third party, see &lt;&lt;/core-api/account-holder-funding-sources#postFundingsourcesAch, Create ACH source&gt;&gt;.[NOTE]This endpoint assumes that you already have established a relationship with both Marqeta and the third-party account validation partner you want to use.In addition, you must explicitly authorize the sharing of information with the third-party partner, and enable Marqeta as a processor for your integration.For more information, contact your Marqeta representative.
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.Ach_response_model"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Marqeta.Core.Sdk.Models.ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Marqeta.Core.Sdk.Models.Ach_response_model?> PostAsync(global::Marqeta.Core.Sdk.Models.Ach_partner_request_model body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Marqeta.Core.Sdk.Models.Ach_response_model> PostAsync(global::Marqeta.Core.Sdk.Models.Ach_partner_request_model body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Marqeta.Core.Sdk.Models.ApiError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Marqeta.Core.Sdk.Models.Ach_response_model>(requestInfo, global::Marqeta.Core.Sdk.Models.Ach_response_model.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create an ACH funding source for an existing account holder by using a third-party partner to handle account validation and provide PII account data.Because you don&apos;t handle any personally identifiable information (PII) yourself, using a third party when creating the funding source enables you to bypass the regulatory and compliance measures related to capturing, storing, and transmitting PII.With this endpoint, you can create a US-based funding source—either a checking account or a savings account—for a program or user without passing bank account details such as the account number or routing number to Marqeta.Instead, validating account data and account verification is handled by the third-party partner you specify, and a secure token (i.e., a Plaid `processor_token`) is shared across partners.By using a secure account verification platform to provide immediate verification, you shorten the wait time until the ACH funding source is ready and avoid managing the microdeposit-based account verification process.To create an ACH funding source for an existing account holder without validating through a third party, see &lt;&lt;/core-api/account-holder-funding-sources#postFundingsourcesAch, Create ACH source&gt;&gt;.[NOTE]This endpoint assumes that you already have established a relationship with both Marqeta and the third-party account validation partner you want to use.In addition, you must explicitly authorize the sharing of information with the third-party partner, and enable Marqeta as a processor for your integration.For more information, contact your Marqeta representative.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Marqeta.Core.Sdk.Models.Ach_partner_request_model body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Marqeta.Core.Sdk.Models.Ach_partner_request_model body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Fundingsources.Ach.Partner.PartnerRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Marqeta.Core.Sdk.Fundingsources.Ach.Partner.PartnerRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Marqeta.Core.Sdk.Fundingsources.Ach.Partner.PartnerRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
#pragma warning restore CS0618
