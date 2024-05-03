// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    /// <summary>
    /// Contains information on a document policy.
    /// </summary>
    public class PolicyDocumentCreateReq : IAdditionalDataHolder, IParsable {
        /// <summary>Request details for a template.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PolicyDocumentTemplateReq? AccountStatement { get; set; }
#nullable restore
#else
        public PolicyDocumentTemplateReq AccountStatement { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Request details for a specific asset.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PolicyDocumentAssetReq? BenefitsDisclosurePremium { get; set; }
#nullable restore
#else
        public PolicyDocumentAssetReq BenefitsDisclosurePremium { get; set; }
#endif
        /// <summary>Request details for a specific asset.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PolicyDocumentAssetReq? BenefitsDisclosureTraditional { get; set; }
#nullable restore
#else
        public PolicyDocumentAssetReq BenefitsDisclosureTraditional { get; set; }
#endif
        /// <summary>Request details for a specific asset.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PolicyDocumentAssetReq? CardMemberAgreement { get; set; }
#nullable restore
#else
        public PolicyDocumentAssetReq CardMemberAgreement { get; set; }
#endif
        /// <summary>Request details for a specific asset.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PolicyDocumentAssetReq? EDisclosure { get; set; }
#nullable restore
#else
        public PolicyDocumentAssetReq EDisclosure { get; set; }
#endif
        /// <summary>Name of the document policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Request details for a template.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PolicyDocumentTemplateReq? NoaaMultipleReasonWithDoddFrank { get; set; }
#nullable restore
#else
        public PolicyDocumentTemplateReq NoaaMultipleReasonWithDoddFrank { get; set; }
#endif
        /// <summary>Request details for a template.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PolicyDocumentTemplateReq? NoaaSingleReason { get; set; }
#nullable restore
#else
        public PolicyDocumentTemplateReq NoaaSingleReason { get; set; }
#endif
        /// <summary>Request details for a template.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PolicyDocumentTemplateReq? NoaaSingleReasonWithDoddFrank { get; set; }
#nullable restore
#else
        public PolicyDocumentTemplateReq NoaaSingleReasonWithDoddFrank { get; set; }
#endif
        /// <summary>Request details for a specific asset and the template on which it was based.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PolicyDocumentAssetAndTemplateReq? PreQualificationDisclosure { get; set; }
#nullable restore
#else
        public PolicyDocumentAssetAndTemplateReq PreQualificationDisclosure { get; set; }
#endif
        /// <summary>Request details for a specific asset.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PolicyDocumentAssetReq? PrivacyPolicy { get; set; }
#nullable restore
#else
        public PolicyDocumentAssetReq PrivacyPolicy { get; set; }
#endif
        /// <summary>Request details for a specific asset and the template on which it was based.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PolicyDocumentAssetAndTemplateReq? RewardsDisclosure { get; set; }
#nullable restore
#else
        public PolicyDocumentAssetAndTemplateReq RewardsDisclosure { get; set; }
#endif
        /// <summary>Request details for a specific asset and the template on which it was based.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PolicyDocumentAssetAndTemplateReq? SummaryOfCreditTerms { get; set; }
#nullable restore
#else
        public PolicyDocumentAssetAndTemplateReq SummaryOfCreditTerms { get; set; }
#endif
        /// <summary>Request details for a template.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PolicyDocumentTemplateReq? TermsSchedule { get; set; }
#nullable restore
#else
        public PolicyDocumentTemplateReq TermsSchedule { get; set; }
#endif
        /// <summary>Unique identifier of the document policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="PolicyDocumentCreateReq"/> and sets the default values.
        /// </summary>
        public PolicyDocumentCreateReq() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PolicyDocumentCreateReq"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PolicyDocumentCreateReq CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PolicyDocumentCreateReq();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"account_statement", n => { AccountStatement = n.GetObjectValue<PolicyDocumentTemplateReq>(PolicyDocumentTemplateReq.CreateFromDiscriminatorValue); } },
                {"benefits_disclosure_premium", n => { BenefitsDisclosurePremium = n.GetObjectValue<PolicyDocumentAssetReq>(PolicyDocumentAssetReq.CreateFromDiscriminatorValue); } },
                {"benefits_disclosure_traditional", n => { BenefitsDisclosureTraditional = n.GetObjectValue<PolicyDocumentAssetReq>(PolicyDocumentAssetReq.CreateFromDiscriminatorValue); } },
                {"card_member_agreement", n => { CardMemberAgreement = n.GetObjectValue<PolicyDocumentAssetReq>(PolicyDocumentAssetReq.CreateFromDiscriminatorValue); } },
                {"e_disclosure", n => { EDisclosure = n.GetObjectValue<PolicyDocumentAssetReq>(PolicyDocumentAssetReq.CreateFromDiscriminatorValue); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"noaa_multiple_reason_with_dodd_frank", n => { NoaaMultipleReasonWithDoddFrank = n.GetObjectValue<PolicyDocumentTemplateReq>(PolicyDocumentTemplateReq.CreateFromDiscriminatorValue); } },
                {"noaa_single_reason", n => { NoaaSingleReason = n.GetObjectValue<PolicyDocumentTemplateReq>(PolicyDocumentTemplateReq.CreateFromDiscriminatorValue); } },
                {"noaa_single_reason_with_dodd_frank", n => { NoaaSingleReasonWithDoddFrank = n.GetObjectValue<PolicyDocumentTemplateReq>(PolicyDocumentTemplateReq.CreateFromDiscriminatorValue); } },
                {"pre_qualification_disclosure", n => { PreQualificationDisclosure = n.GetObjectValue<PolicyDocumentAssetAndTemplateReq>(PolicyDocumentAssetAndTemplateReq.CreateFromDiscriminatorValue); } },
                {"privacy_policy", n => { PrivacyPolicy = n.GetObjectValue<PolicyDocumentAssetReq>(PolicyDocumentAssetReq.CreateFromDiscriminatorValue); } },
                {"rewards_disclosure", n => { RewardsDisclosure = n.GetObjectValue<PolicyDocumentAssetAndTemplateReq>(PolicyDocumentAssetAndTemplateReq.CreateFromDiscriminatorValue); } },
                {"summary_of_credit_terms", n => { SummaryOfCreditTerms = n.GetObjectValue<PolicyDocumentAssetAndTemplateReq>(PolicyDocumentAssetAndTemplateReq.CreateFromDiscriminatorValue); } },
                {"terms_schedule", n => { TermsSchedule = n.GetObjectValue<PolicyDocumentTemplateReq>(PolicyDocumentTemplateReq.CreateFromDiscriminatorValue); } },
                {"token", n => { Token = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<PolicyDocumentTemplateReq>("account_statement", AccountStatement);
            writer.WriteObjectValue<PolicyDocumentAssetReq>("benefits_disclosure_premium", BenefitsDisclosurePremium);
            writer.WriteObjectValue<PolicyDocumentAssetReq>("benefits_disclosure_traditional", BenefitsDisclosureTraditional);
            writer.WriteObjectValue<PolicyDocumentAssetReq>("card_member_agreement", CardMemberAgreement);
            writer.WriteObjectValue<PolicyDocumentAssetReq>("e_disclosure", EDisclosure);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<PolicyDocumentTemplateReq>("noaa_multiple_reason_with_dodd_frank", NoaaMultipleReasonWithDoddFrank);
            writer.WriteObjectValue<PolicyDocumentTemplateReq>("noaa_single_reason", NoaaSingleReason);
            writer.WriteObjectValue<PolicyDocumentTemplateReq>("noaa_single_reason_with_dodd_frank", NoaaSingleReasonWithDoddFrank);
            writer.WriteObjectValue<PolicyDocumentAssetAndTemplateReq>("pre_qualification_disclosure", PreQualificationDisclosure);
            writer.WriteObjectValue<PolicyDocumentAssetReq>("privacy_policy", PrivacyPolicy);
            writer.WriteObjectValue<PolicyDocumentAssetAndTemplateReq>("rewards_disclosure", RewardsDisclosure);
            writer.WriteObjectValue<PolicyDocumentAssetAndTemplateReq>("summary_of_credit_terms", SummaryOfCreditTerms);
            writer.WriteObjectValue<PolicyDocumentTemplateReq>("terms_schedule", TermsSchedule);
            writer.WriteStringValue("token", Token);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
