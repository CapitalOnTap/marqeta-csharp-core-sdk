// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models
{
    #pragma warning disable CS1591
    public class ApplicationsResponse : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Unique identifier of the credit account for which the user is applying.Returned when retrieving an application in the `APPROVED` state.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountToken { get; set; }
#nullable restore
#else
        public string AccountToken { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A value of `true` indicates that the user has a non-taxable income source.</summary>
        public bool? AnyNonTaxableIncome { get; set; }
        /// <summary>Date and time when the application was accepted on the Marqeta platform, in UTC.Returned if the user accepted their approved application.</summary>
        public DateTimeOffset? ApplicationAcceptedAt { get; set; }
        /// <summary>Date and time when the application was canceled on the Marqeta platform, in UTC.</summary>
        public DateTimeOffset? ApplicationCanceledAt { get; set; }
        /// <summary>Date and time when Marqeta accepted the Benefits Disclosure, in UTC.Returned if the user accepted their approved application.</summary>
        public DateTimeOffset? BenefitsDisclosureAcceptedAt { get; set; }
        /// <summary>Unique identifier of the bundle associated with the application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BundleToken { get; set; }
#nullable restore
#else
        public string BundleToken { get; set; }
#endif
        /// <summary>Date and time when Marqeta accepted the Card Membership Agreement, in UTC.Returned if the user accepted their approved application.</summary>
        public DateTimeOffset? CardMembershipAgreementAcceptedAt { get; set; }
        /// <summary>Date and time when the application was created on the Marqeta platform, in UTC.</summary>
        public DateTimeOffset? CreatedDate { get; set; }
        /// <summary>Contains information on the decision model returned by the issuing bank if a decision has been rendered.Returned when retrieving an application after a decision has been rendered.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Marqeta.Core.Sdk.Models.DecisionsResponse? DecisionModel { get; set; }
#nullable restore
#else
        public Marqeta.Core.Sdk.Models.DecisionsResponse DecisionModel { get; set; }
#endif
        /// <summary>Unique identifier of the decision made on the application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DecisionToken { get; set; }
#nullable restore
#else
        public string DecisionToken { get; set; }
#endif
        /// <summary>Contains information on user&apos;s device fingerprint.Usually obtained through a component embedded in the application.Required if application `type` is `PREQUALIFICATION`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Marqeta.Core.Sdk.Models.DeviceData? DeviceData { get; set; }
#nullable restore
#else
        public Marqeta.Core.Sdk.Models.DeviceData DeviceData { get; set; }
#endif
        /// <summary>Date and time when Marqeta accepted the e-Disclosure, in UTC.Returned if the user accepted their approved application.</summary>
        public DateTimeOffset? EDisclosureAcceptedAt { get; set; }
        /// <summary>Contains details on an application error.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Marqeta.Core.Sdk.Models.ErrorDetailsResponse? ErrorDetails { get; set; }
#nullable restore
#else
        public Marqeta.Core.Sdk.Models.ErrorDetailsResponse ErrorDetails { get; set; }
#endif
        /// <summary>Customer-defined additional information about the application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Marqeta.Core.Sdk.Models.ApplicationsResponse_meta_data? MetaData { get; set; }
#nullable restore
#else
        public Marqeta.Core.Sdk.Models.ApplicationsResponse_meta_data MetaData { get; set; }
#endif
        /// <summary>Monthly amount of the mortgage or rent that the user currently pays.</summary>
        public double? MonthlyMortgageOrRent { get; set; }
        /// <summary>Unique identifier of the offer for a pre-screened applicant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OfferId { get; set; }
#nullable restore
#else
        public string OfferId { get; set; }
#endif
        /// <summary>Date and time when Marqeta accepted the Pre-qualified Offer Pre-terms, in UTC.Returned if the user accepted their approved application.</summary>
        public DateTimeOffset? PrequalifiedOfferPreTermsAcceptedAt { get; set; }
        /// <summary>Whether the primary income source comes from the user being employed, unemployed, self-employment, or another situation.</summary>
        public Marqeta.Core.Sdk.Models.ApplicationsResponse_primary_income_source? PrimaryIncomeSource { get; set; }
        /// <summary>Date and time when Marqeta accepted the Privacy Policy, in UTC.Returned if the user accepted their approved application.</summary>
        public DateTimeOffset? PrivacyPolicyAcceptedAt { get; set; }
        /// <summary>Whether the user owns or rents their residence, or has another situation.</summary>
        public Marqeta.Core.Sdk.Models.ApplicationsResponse_residence_type? ResidenceType { get; set; }
        /// <summary>Date and time when Marqeta accepted the Rewards Disclosure, in UTC.Returned if the user accepted their approved application.</summary>
        public DateTimeOffset? RewardsDisclosurePostTermsAcceptedAt { get; set; }
        /// <summary>Date and time when Marqeta accepted the Rewards Disclosure, in UTC.Returned if the user accepted their approved application.</summary>
        public DateTimeOffset? RewardsDisclosurePreTermsAcceptedAt { get; set; }
        /// <summary>Date and time when Marqeta accepted the Summary of Credit Terms (SOCT), in UTC.Returned if the user accepted their approved application.</summary>
        public DateTimeOffset? SoctAcceptedAt { get; set; }
        /// <summary>State of the application.If manually &lt;&lt;/core-api/credit-applications#transitionApplication, transitioning an application state&gt;&gt;:* `application_state` is the state to which you want to transition the application status; must be `ACCEPTED` or `REJECTED`.* `original_status` returns the state of the application before it was manually transitioned.* `status` returns the state to which the application was transitioned.</summary>
        public Marqeta.Core.Sdk.Models.ApplicationResourceState? State { get; set; }
        /// <summary>Date and time when Marqeta accepted the Terms Schedule, in UTC.Returned if the user accepted their approved application.</summary>
        public DateTimeOffset? TermScheduleInformationAcceptedAt { get; set; }
        /// <summary>Unique identifier of the application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>The total amount of the user&apos;s annual income.</summary>
        public double? TotalAnnualIncome { get; set; }
        /// <summary>Type of application.</summary>
        public Marqeta.Core.Sdk.Models.ApplicationType? Type { get; set; }
        /// <summary>Date and time when the application was last updated on the Marqeta platform, in UTC.</summary>
        public DateTimeOffset? UpdatedDate { get; set; }
        /// <summary>Unique identifier of the applicant, the user applying for a credit account.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserToken { get; set; }
#nullable restore
#else
        public string UserToken { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Models.ApplicationsResponse"/> and sets the default values.
        /// </summary>
        public ApplicationsResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Models.ApplicationsResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Marqeta.Core.Sdk.Models.ApplicationsResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Marqeta.Core.Sdk.Models.ApplicationsResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "account_token", n => { AccountToken = n.GetStringValue(); } },
                { "any_non_taxable_income", n => { AnyNonTaxableIncome = n.GetBoolValue(); } },
                { "application_accepted_at", n => { ApplicationAcceptedAt = n.GetDateTimeOffsetValue(); } },
                { "application_canceled_at", n => { ApplicationCanceledAt = n.GetDateTimeOffsetValue(); } },
                { "benefits_disclosure_accepted_at", n => { BenefitsDisclosureAcceptedAt = n.GetDateTimeOffsetValue(); } },
                { "bundle_token", n => { BundleToken = n.GetStringValue(); } },
                { "card_membership_agreement_accepted_at", n => { CardMembershipAgreementAcceptedAt = n.GetDateTimeOffsetValue(); } },
                { "created_date", n => { CreatedDate = n.GetDateTimeOffsetValue(); } },
                { "decision_model", n => { DecisionModel = n.GetObjectValue<Marqeta.Core.Sdk.Models.DecisionsResponse>(Marqeta.Core.Sdk.Models.DecisionsResponse.CreateFromDiscriminatorValue); } },
                { "decision_token", n => { DecisionToken = n.GetStringValue(); } },
                { "device_data", n => { DeviceData = n.GetObjectValue<Marqeta.Core.Sdk.Models.DeviceData>(Marqeta.Core.Sdk.Models.DeviceData.CreateFromDiscriminatorValue); } },
                { "e_disclosure_accepted_at", n => { EDisclosureAcceptedAt = n.GetDateTimeOffsetValue(); } },
                { "error_details", n => { ErrorDetails = n.GetObjectValue<Marqeta.Core.Sdk.Models.ErrorDetailsResponse>(Marqeta.Core.Sdk.Models.ErrorDetailsResponse.CreateFromDiscriminatorValue); } },
                { "meta_data", n => { MetaData = n.GetObjectValue<Marqeta.Core.Sdk.Models.ApplicationsResponse_meta_data>(Marqeta.Core.Sdk.Models.ApplicationsResponse_meta_data.CreateFromDiscriminatorValue); } },
                { "monthly_mortgage_or_rent", n => { MonthlyMortgageOrRent = n.GetDoubleValue(); } },
                { "offer_id", n => { OfferId = n.GetStringValue(); } },
                { "prequalified_offer_pre_terms_accepted_at", n => { PrequalifiedOfferPreTermsAcceptedAt = n.GetDateTimeOffsetValue(); } },
                { "primary_income_source", n => { PrimaryIncomeSource = n.GetEnumValue<Marqeta.Core.Sdk.Models.ApplicationsResponse_primary_income_source>(); } },
                { "privacy_policy_accepted_at", n => { PrivacyPolicyAcceptedAt = n.GetDateTimeOffsetValue(); } },
                { "residence_type", n => { ResidenceType = n.GetEnumValue<Marqeta.Core.Sdk.Models.ApplicationsResponse_residence_type>(); } },
                { "rewards_disclosure_post_terms_accepted_at", n => { RewardsDisclosurePostTermsAcceptedAt = n.GetDateTimeOffsetValue(); } },
                { "rewards_disclosure_pre_terms_accepted_at", n => { RewardsDisclosurePreTermsAcceptedAt = n.GetDateTimeOffsetValue(); } },
                { "soct_accepted_at", n => { SoctAcceptedAt = n.GetDateTimeOffsetValue(); } },
                { "state", n => { State = n.GetEnumValue<Marqeta.Core.Sdk.Models.ApplicationResourceState>(); } },
                { "term_schedule_information_accepted_at", n => { TermScheduleInformationAcceptedAt = n.GetDateTimeOffsetValue(); } },
                { "token", n => { Token = n.GetStringValue(); } },
                { "total_annual_income", n => { TotalAnnualIncome = n.GetDoubleValue(); } },
                { "type", n => { Type = n.GetEnumValue<Marqeta.Core.Sdk.Models.ApplicationType>(); } },
                { "updated_date", n => { UpdatedDate = n.GetDateTimeOffsetValue(); } },
                { "user_token", n => { UserToken = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("account_token", AccountToken);
            writer.WriteBoolValue("any_non_taxable_income", AnyNonTaxableIncome);
            writer.WriteDateTimeOffsetValue("application_accepted_at", ApplicationAcceptedAt);
            writer.WriteDateTimeOffsetValue("application_canceled_at", ApplicationCanceledAt);
            writer.WriteDateTimeOffsetValue("benefits_disclosure_accepted_at", BenefitsDisclosureAcceptedAt);
            writer.WriteStringValue("bundle_token", BundleToken);
            writer.WriteDateTimeOffsetValue("card_membership_agreement_accepted_at", CardMembershipAgreementAcceptedAt);
            writer.WriteDateTimeOffsetValue("created_date", CreatedDate);
            writer.WriteObjectValue<Marqeta.Core.Sdk.Models.DecisionsResponse>("decision_model", DecisionModel);
            writer.WriteStringValue("decision_token", DecisionToken);
            writer.WriteObjectValue<Marqeta.Core.Sdk.Models.DeviceData>("device_data", DeviceData);
            writer.WriteDateTimeOffsetValue("e_disclosure_accepted_at", EDisclosureAcceptedAt);
            writer.WriteObjectValue<Marqeta.Core.Sdk.Models.ErrorDetailsResponse>("error_details", ErrorDetails);
            writer.WriteObjectValue<Marqeta.Core.Sdk.Models.ApplicationsResponse_meta_data>("meta_data", MetaData);
            writer.WriteDoubleValue("monthly_mortgage_or_rent", MonthlyMortgageOrRent);
            writer.WriteStringValue("offer_id", OfferId);
            writer.WriteDateTimeOffsetValue("prequalified_offer_pre_terms_accepted_at", PrequalifiedOfferPreTermsAcceptedAt);
            writer.WriteEnumValue<Marqeta.Core.Sdk.Models.ApplicationsResponse_primary_income_source>("primary_income_source", PrimaryIncomeSource);
            writer.WriteDateTimeOffsetValue("privacy_policy_accepted_at", PrivacyPolicyAcceptedAt);
            writer.WriteEnumValue<Marqeta.Core.Sdk.Models.ApplicationsResponse_residence_type>("residence_type", ResidenceType);
            writer.WriteDateTimeOffsetValue("rewards_disclosure_post_terms_accepted_at", RewardsDisclosurePostTermsAcceptedAt);
            writer.WriteDateTimeOffsetValue("rewards_disclosure_pre_terms_accepted_at", RewardsDisclosurePreTermsAcceptedAt);
            writer.WriteDateTimeOffsetValue("soct_accepted_at", SoctAcceptedAt);
            writer.WriteEnumValue<Marqeta.Core.Sdk.Models.ApplicationResourceState>("state", State);
            writer.WriteDateTimeOffsetValue("term_schedule_information_accepted_at", TermScheduleInformationAcceptedAt);
            writer.WriteStringValue("token", Token);
            writer.WriteDoubleValue("total_annual_income", TotalAnnualIncome);
            writer.WriteEnumValue<Marqeta.Core.Sdk.Models.ApplicationType>("type", Type);
            writer.WriteDateTimeOffsetValue("updated_date", UpdatedDate);
            writer.WriteStringValue("user_token", UserToken);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
