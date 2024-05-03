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
    public class PolicyDocumentResponse : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Response details for a template.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PolicyDocumentTemplateResponse? AccountStatement { get; set; }
#nullable restore
#else
        public PolicyDocumentTemplateResponse AccountStatement { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Return details for a specific asset.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PolicyDocumentAssetResponse? BenefitsDisclosurePremium { get; set; }
#nullable restore
#else
        public PolicyDocumentAssetResponse BenefitsDisclosurePremium { get; set; }
#endif
        /// <summary>Return details for a specific asset.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PolicyDocumentAssetResponse? BenefitsDisclosureTraditional { get; set; }
#nullable restore
#else
        public PolicyDocumentAssetResponse BenefitsDisclosureTraditional { get; set; }
#endif
        /// <summary>Return details for a specific asset.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PolicyDocumentAssetResponse? CardMemberAgreement { get; set; }
#nullable restore
#else
        public PolicyDocumentAssetResponse CardMemberAgreement { get; set; }
#endif
        /// <summary>Date and time when the document policy was created on Marqeta&apos;s credit platform, in UTC.</summary>
        public DateTimeOffset? CreatedTime { get; set; }
        /// <summary>Return details for a specific asset.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PolicyDocumentAssetResponse? EDisclosure { get; set; }
#nullable restore
#else
        public PolicyDocumentAssetResponse EDisclosure { get; set; }
#endif
        /// <summary>Name of the document policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Response details for a template.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PolicyDocumentTemplateResponse? NoaaMultipleReasonWithDoddFrank { get; set; }
#nullable restore
#else
        public PolicyDocumentTemplateResponse NoaaMultipleReasonWithDoddFrank { get; set; }
#endif
        /// <summary>Response details for a template.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PolicyDocumentTemplateResponse? NoaaSingleReason { get; set; }
#nullable restore
#else
        public PolicyDocumentTemplateResponse NoaaSingleReason { get; set; }
#endif
        /// <summary>Response details for a template.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PolicyDocumentTemplateResponse? NoaaSingleReasonWithDoddFrank { get; set; }
#nullable restore
#else
        public PolicyDocumentTemplateResponse NoaaSingleReasonWithDoddFrank { get; set; }
#endif
        /// <summary>Return details for a specific asset and the template on which it was based.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PolicyDocumentAssetAndTemplateResponse? PreQualificationDisclosure { get; set; }
#nullable restore
#else
        public PolicyDocumentAssetAndTemplateResponse PreQualificationDisclosure { get; set; }
#endif
        /// <summary>Return details for a specific asset.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PolicyDocumentAssetResponse? PrivacyPolicy { get; set; }
#nullable restore
#else
        public PolicyDocumentAssetResponse PrivacyPolicy { get; set; }
#endif
        /// <summary>Return details for a specific asset and the template on which it was based.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PolicyDocumentAssetAndTemplateResponse? RewardsDisclosure { get; set; }
#nullable restore
#else
        public PolicyDocumentAssetAndTemplateResponse RewardsDisclosure { get; set; }
#endif
        /// <summary>Return details for a specific asset and the template on which it was based.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PolicyDocumentAssetAndTemplateResponse? SummaryOfCreditTerms { get; set; }
#nullable restore
#else
        public PolicyDocumentAssetAndTemplateResponse SummaryOfCreditTerms { get; set; }
#endif
        /// <summary>Response details for a template.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PolicyDocumentTemplateResponse? TermsSchedule { get; set; }
#nullable restore
#else
        public PolicyDocumentTemplateResponse TermsSchedule { get; set; }
#endif
        /// <summary>Unique identifier of the document policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>Date and time when the document policy was last updated on Marqeta&apos;s credit platform, in UTC.</summary>
        public DateTimeOffset? UpdatedTime { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="PolicyDocumentResponse"/> and sets the default values.
        /// </summary>
        public PolicyDocumentResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PolicyDocumentResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PolicyDocumentResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PolicyDocumentResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"account_statement", n => { AccountStatement = n.GetObjectValue<PolicyDocumentTemplateResponse>(PolicyDocumentTemplateResponse.CreateFromDiscriminatorValue); } },
                {"benefits_disclosure_premium", n => { BenefitsDisclosurePremium = n.GetObjectValue<PolicyDocumentAssetResponse>(PolicyDocumentAssetResponse.CreateFromDiscriminatorValue); } },
                {"benefits_disclosure_traditional", n => { BenefitsDisclosureTraditional = n.GetObjectValue<PolicyDocumentAssetResponse>(PolicyDocumentAssetResponse.CreateFromDiscriminatorValue); } },
                {"card_member_agreement", n => { CardMemberAgreement = n.GetObjectValue<PolicyDocumentAssetResponse>(PolicyDocumentAssetResponse.CreateFromDiscriminatorValue); } },
                {"created_time", n => { CreatedTime = n.GetDateTimeOffsetValue(); } },
                {"e_disclosure", n => { EDisclosure = n.GetObjectValue<PolicyDocumentAssetResponse>(PolicyDocumentAssetResponse.CreateFromDiscriminatorValue); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"noaa_multiple_reason_with_dodd_frank", n => { NoaaMultipleReasonWithDoddFrank = n.GetObjectValue<PolicyDocumentTemplateResponse>(PolicyDocumentTemplateResponse.CreateFromDiscriminatorValue); } },
                {"noaa_single_reason", n => { NoaaSingleReason = n.GetObjectValue<PolicyDocumentTemplateResponse>(PolicyDocumentTemplateResponse.CreateFromDiscriminatorValue); } },
                {"noaa_single_reason_with_dodd_frank", n => { NoaaSingleReasonWithDoddFrank = n.GetObjectValue<PolicyDocumentTemplateResponse>(PolicyDocumentTemplateResponse.CreateFromDiscriminatorValue); } },
                {"pre_qualification_disclosure", n => { PreQualificationDisclosure = n.GetObjectValue<PolicyDocumentAssetAndTemplateResponse>(PolicyDocumentAssetAndTemplateResponse.CreateFromDiscriminatorValue); } },
                {"privacy_policy", n => { PrivacyPolicy = n.GetObjectValue<PolicyDocumentAssetResponse>(PolicyDocumentAssetResponse.CreateFromDiscriminatorValue); } },
                {"rewards_disclosure", n => { RewardsDisclosure = n.GetObjectValue<PolicyDocumentAssetAndTemplateResponse>(PolicyDocumentAssetAndTemplateResponse.CreateFromDiscriminatorValue); } },
                {"summary_of_credit_terms", n => { SummaryOfCreditTerms = n.GetObjectValue<PolicyDocumentAssetAndTemplateResponse>(PolicyDocumentAssetAndTemplateResponse.CreateFromDiscriminatorValue); } },
                {"terms_schedule", n => { TermsSchedule = n.GetObjectValue<PolicyDocumentTemplateResponse>(PolicyDocumentTemplateResponse.CreateFromDiscriminatorValue); } },
                {"token", n => { Token = n.GetStringValue(); } },
                {"updated_time", n => { UpdatedTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<PolicyDocumentTemplateResponse>("account_statement", AccountStatement);
            writer.WriteObjectValue<PolicyDocumentAssetResponse>("benefits_disclosure_premium", BenefitsDisclosurePremium);
            writer.WriteObjectValue<PolicyDocumentAssetResponse>("benefits_disclosure_traditional", BenefitsDisclosureTraditional);
            writer.WriteObjectValue<PolicyDocumentAssetResponse>("card_member_agreement", CardMemberAgreement);
            writer.WriteDateTimeOffsetValue("created_time", CreatedTime);
            writer.WriteObjectValue<PolicyDocumentAssetResponse>("e_disclosure", EDisclosure);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<PolicyDocumentTemplateResponse>("noaa_multiple_reason_with_dodd_frank", NoaaMultipleReasonWithDoddFrank);
            writer.WriteObjectValue<PolicyDocumentTemplateResponse>("noaa_single_reason", NoaaSingleReason);
            writer.WriteObjectValue<PolicyDocumentTemplateResponse>("noaa_single_reason_with_dodd_frank", NoaaSingleReasonWithDoddFrank);
            writer.WriteObjectValue<PolicyDocumentAssetAndTemplateResponse>("pre_qualification_disclosure", PreQualificationDisclosure);
            writer.WriteObjectValue<PolicyDocumentAssetResponse>("privacy_policy", PrivacyPolicy);
            writer.WriteObjectValue<PolicyDocumentAssetAndTemplateResponse>("rewards_disclosure", RewardsDisclosure);
            writer.WriteObjectValue<PolicyDocumentAssetAndTemplateResponse>("summary_of_credit_terms", SummaryOfCreditTerms);
            writer.WriteObjectValue<PolicyDocumentTemplateResponse>("terms_schedule", TermsSchedule);
            writer.WriteStringValue("token", Token);
            writer.WriteDateTimeOffsetValue("updated_time", UpdatedTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
