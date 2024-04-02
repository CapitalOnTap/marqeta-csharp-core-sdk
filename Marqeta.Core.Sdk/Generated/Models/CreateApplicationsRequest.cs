// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    public class CreateApplicationsRequest : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A value of `true` indicates that the user has a non-taxable income source.Required when retrieving an application.</summary>
        public bool? AnyNonTaxableIncome { get; set; }
        /// <summary>Unique identifier of the bundle associated with the application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BundleToken { get; set; }
#nullable restore
#else
        public string BundleToken { get; set; }
#endif
        /// <summary>Contains information on user&apos;s device fingerprint.Usually obtained through a component embedded in the application.Required if application `type` is `PREQUALIFICATION`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Marqeta.Core.Sdk.Models.DeviceData? DeviceData { get; set; }
#nullable restore
#else
        public Marqeta.Core.Sdk.Models.DeviceData DeviceData { get; set; }
#endif
        /// <summary>The tracking token of the eDisclosure.This is the `tracking_token` returned in the `E_DISCLOSURE` object when sending a `GET` request to the `/credit/applications/files` endpoint before a decision on the application is made.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EDisclosureTrackingToken { get; set; }
#nullable restore
#else
        public string EDisclosureTrackingToken { get; set; }
#endif
        /// <summary>Customer-defined additional information about the application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CreateApplicationsRequest_meta_data? MetaData { get; set; }
#nullable restore
#else
        public CreateApplicationsRequest_meta_data MetaData { get; set; }
#endif
        /// <summary>Monthly amount of the mortgage or rent that the user currently pays.Required when retrieving an application.</summary>
        public double? MonthlyMortgageOrRent { get; set; }
        /// <summary>Unique identifier of the offer for a pre-screened applicant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OfferId { get; set; }
#nullable restore
#else
        public string OfferId { get; set; }
#endif
        /// <summary>The tracking token of the Pre-qualified Offer Pre-Terms.This is the `tracking_token` returned in the `PREQUALIFICATION_PRE_TERMS` object when sending a `GET` request to the `/credit/applications/files` endpoint before a decision on the application is made.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrequalifiedOfferPreTermsTrackingToken { get; set; }
#nullable restore
#else
        public string PrequalifiedOfferPreTermsTrackingToken { get; set; }
#endif
        /// <summary>Whether the primary income source comes from the user being employed, unemployed, self-employment, or another situation.Required when retrieving an application.</summary>
        public CreateApplicationsRequest_primary_income_source? PrimaryIncomeSource { get; set; }
        /// <summary>The tracking token of the Privacy Policy.This is the `tracking_token` returned in the `PRIVACY_POLICY` object when sending a `GET` request to the `/credit/applications/files` endpoint before a decision on the application is made.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrivacyPolicyTrackingToken { get; set; }
#nullable restore
#else
        public string PrivacyPolicyTrackingToken { get; set; }
#endif
        /// <summary>Whether the user owns or rents their residence, or has another situation.Required when retrieving an application.</summary>
        public CreateApplicationsRequest_residence_type? ResidenceType { get; set; }
        /// <summary>The tracking token of the Rewards Disclosure Pre-terms.This is the `tracking_token` returned in the `REWARDS_DISCLOSURE_PRE_TERMS` object when sending a `GET` request to the `/credit/applications/files` endpoint before a decision on the application is made.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RewardsDisclosurePreTermsTrackingToken { get; set; }
#nullable restore
#else
        public string RewardsDisclosurePreTermsTrackingToken { get; set; }
#endif
        /// <summary>The tracking token of the Summary of Credit Terms (SOCT).This is the `tracking_token` returned in the `SOCT` object when sending a `GET` request to the `/credit/applications/files` endpoint before a decision on the application is made.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SoctTrackingToken { get; set; }
#nullable restore
#else
        public string SoctTrackingToken { get; set; }
#endif
        /// <summary>Unique identifier of the application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>The total amount of the user&apos;s annual income.Required when retrieving an application.</summary>
        public double? TotalAnnualIncome { get; set; }
        /// <summary>Type of application.</summary>
        public ApplicationType? Type { get; set; }
        /// <summary>Unique identifier of the applicant, the user applying for a credit account.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserToken { get; set; }
#nullable restore
#else
        public string UserToken { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="CreateApplicationsRequest"/> and sets the default values.
        /// </summary>
        public CreateApplicationsRequest() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="CreateApplicationsRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CreateApplicationsRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CreateApplicationsRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"any_non_taxable_income", n => { AnyNonTaxableIncome = n.GetBoolValue(); } },
                {"bundle_token", n => { BundleToken = n.GetStringValue(); } },
                {"device_data", n => { DeviceData = n.GetObjectValue<Marqeta.Core.Sdk.Models.DeviceData>(Marqeta.Core.Sdk.Models.DeviceData.CreateFromDiscriminatorValue); } },
                {"e_disclosure_tracking_token", n => { EDisclosureTrackingToken = n.GetStringValue(); } },
                {"meta_data", n => { MetaData = n.GetObjectValue<CreateApplicationsRequest_meta_data>(CreateApplicationsRequest_meta_data.CreateFromDiscriminatorValue); } },
                {"monthly_mortgage_or_rent", n => { MonthlyMortgageOrRent = n.GetDoubleValue(); } },
                {"offer_id", n => { OfferId = n.GetStringValue(); } },
                {"prequalified_offer_pre_terms_tracking_token", n => { PrequalifiedOfferPreTermsTrackingToken = n.GetStringValue(); } },
                {"primary_income_source", n => { PrimaryIncomeSource = n.GetEnumValue<CreateApplicationsRequest_primary_income_source>(); } },
                {"privacy_policy_tracking_token", n => { PrivacyPolicyTrackingToken = n.GetStringValue(); } },
                {"residence_type", n => { ResidenceType = n.GetEnumValue<CreateApplicationsRequest_residence_type>(); } },
                {"rewards_disclosure_pre_terms_tracking_token", n => { RewardsDisclosurePreTermsTrackingToken = n.GetStringValue(); } },
                {"soct_tracking_token", n => { SoctTrackingToken = n.GetStringValue(); } },
                {"token", n => { Token = n.GetStringValue(); } },
                {"total_annual_income", n => { TotalAnnualIncome = n.GetDoubleValue(); } },
                {"type", n => { Type = n.GetEnumValue<ApplicationType>(); } },
                {"user_token", n => { UserToken = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("any_non_taxable_income", AnyNonTaxableIncome);
            writer.WriteStringValue("bundle_token", BundleToken);
            writer.WriteObjectValue<Marqeta.Core.Sdk.Models.DeviceData>("device_data", DeviceData);
            writer.WriteStringValue("e_disclosure_tracking_token", EDisclosureTrackingToken);
            writer.WriteObjectValue<CreateApplicationsRequest_meta_data>("meta_data", MetaData);
            writer.WriteDoubleValue("monthly_mortgage_or_rent", MonthlyMortgageOrRent);
            writer.WriteStringValue("offer_id", OfferId);
            writer.WriteStringValue("prequalified_offer_pre_terms_tracking_token", PrequalifiedOfferPreTermsTrackingToken);
            writer.WriteEnumValue<CreateApplicationsRequest_primary_income_source>("primary_income_source", PrimaryIncomeSource);
            writer.WriteStringValue("privacy_policy_tracking_token", PrivacyPolicyTrackingToken);
            writer.WriteEnumValue<CreateApplicationsRequest_residence_type>("residence_type", ResidenceType);
            writer.WriteStringValue("rewards_disclosure_pre_terms_tracking_token", RewardsDisclosurePreTermsTrackingToken);
            writer.WriteStringValue("soct_tracking_token", SoctTrackingToken);
            writer.WriteStringValue("token", Token);
            writer.WriteDoubleValue("total_annual_income", TotalAnnualIncome);
            writer.WriteEnumValue<ApplicationType>("type", Type);
            writer.WriteStringValue("user_token", UserToken);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}