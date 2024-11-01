// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Marqeta.Core.Sdk.Models
{
    /// <summary>
    /// Contains information on a bundle.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class BundleResponse : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Contains information on an APR policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.Models.PolicyAprResponse? AprPolicyDetail { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.PolicyAprResponse AprPolicyDetail { get; set; }
#endif
        /// <summary>Unique identifier of the bundle&apos;s APR policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AprPolicyToken { get; set; }
#nullable restore
#else
        public string AprPolicyToken { get; set; }
#endif
        /// <summary>Date and time when the bundle was created on Marqeta&apos;s credit platform, in UTC.</summary>
        public DateTimeOffset? CreatedTime { get; set; }
        /// <summary>Contains information on the credit product policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.Models.PolicyProductResponse? CreditProductPolicyDetail { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.PolicyProductResponse CreditProductPolicyDetail { get; set; }
#endif
        /// <summary>Unique identifier of the bundle&apos;s credit product policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreditProductPolicyToken { get; set; }
#nullable restore
#else
        public string CreditProductPolicyToken { get; set; }
#endif
        /// <summary>Description of the bundle.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Contains information on a document policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.Models.PolicyDocumentResponse? DocumentPolicyDetail { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.PolicyDocumentResponse DocumentPolicyDetail { get; set; }
#endif
        /// <summary>Unique identifier of the bundle&apos;s document policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DocumentPolicyToken { get; set; }
#nullable restore
#else
        public string DocumentPolicyToken { get; set; }
#endif
        /// <summary>Contains information on a fee policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.Models.PolicyFeeResponse? FeePolicyDetail { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.PolicyFeeResponse FeePolicyDetail { get; set; }
#endif
        /// <summary>Unique identifier of the bundle&apos;s fee policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FeePolicyToken { get; set; }
#nullable restore
#else
        public string FeePolicyToken { get; set; }
#endif
        /// <summary>Name of the bundle.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Contains information on an offer policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.Models.PolicyOfferResponse? OfferPolicyDetail { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.PolicyOfferResponse OfferPolicyDetail { get; set; }
#endif
        /// <summary>Unique identifier of the bundle&apos;s offer policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OfferPolicyToken { get; set; }
#nullable restore
#else
        public string OfferPolicyToken { get; set; }
#endif
        /// <summary>Contains information on a reward policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.Models.PolicyRewardResponse? RewardPolicyDetail { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.PolicyRewardResponse RewardPolicyDetail { get; set; }
#endif
        /// <summary>Unique identifier of the bundle&apos;s reward policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RewardPolicyToken { get; set; }
#nullable restore
#else
        public string RewardPolicyToken { get; set; }
#endif
        /// <summary>Status of the bundle.* `DRAFT` - The bundle is in the process of being created.* `PENDING_APPROVAL` - The bundle has been created and is awaiting approval.* `SENT_FOR_REVISION` - The bundle has been returned for revision.* `ACTIVE` - The bundle is active.* `REJECTED` - The bundle has been rejected; this status cannot be changed.* `ARCHIVED` - The previously active bundle has been archived.* `APPROVED` - The bundle has been approved (after having been sent for approval).</summary>
        public global::Marqeta.Core.Sdk.Models.BundleResourceStatus? Status { get; set; }
        /// <summary>Unique identifier of the bundle.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>Date and time when the bundle was last updated on Marqeta&apos;s credit platform, in UTC.</summary>
        public DateTimeOffset? UpdatedTime { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.BundleResponse"/> and sets the default values.
        /// </summary>
        public BundleResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.BundleResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.BundleResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.BundleResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "apr_policy_detail", n => { AprPolicyDetail = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.PolicyAprResponse>(global::Marqeta.Core.Sdk.Models.PolicyAprResponse.CreateFromDiscriminatorValue); } },
                { "apr_policy_token", n => { AprPolicyToken = n.GetStringValue(); } },
                { "created_time", n => { CreatedTime = n.GetDateTimeOffsetValue(); } },
                { "credit_product_policy_detail", n => { CreditProductPolicyDetail = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.PolicyProductResponse>(global::Marqeta.Core.Sdk.Models.PolicyProductResponse.CreateFromDiscriminatorValue); } },
                { "credit_product_policy_token", n => { CreditProductPolicyToken = n.GetStringValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "document_policy_detail", n => { DocumentPolicyDetail = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.PolicyDocumentResponse>(global::Marqeta.Core.Sdk.Models.PolicyDocumentResponse.CreateFromDiscriminatorValue); } },
                { "document_policy_token", n => { DocumentPolicyToken = n.GetStringValue(); } },
                { "fee_policy_detail", n => { FeePolicyDetail = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.PolicyFeeResponse>(global::Marqeta.Core.Sdk.Models.PolicyFeeResponse.CreateFromDiscriminatorValue); } },
                { "fee_policy_token", n => { FeePolicyToken = n.GetStringValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "offer_policy_detail", n => { OfferPolicyDetail = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.PolicyOfferResponse>(global::Marqeta.Core.Sdk.Models.PolicyOfferResponse.CreateFromDiscriminatorValue); } },
                { "offer_policy_token", n => { OfferPolicyToken = n.GetStringValue(); } },
                { "reward_policy_detail", n => { RewardPolicyDetail = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.PolicyRewardResponse>(global::Marqeta.Core.Sdk.Models.PolicyRewardResponse.CreateFromDiscriminatorValue); } },
                { "reward_policy_token", n => { RewardPolicyToken = n.GetStringValue(); } },
                { "status", n => { Status = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.BundleResourceStatus>(); } },
                { "token", n => { Token = n.GetStringValue(); } },
                { "updated_time", n => { UpdatedTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.PolicyAprResponse>("apr_policy_detail", AprPolicyDetail);
            writer.WriteStringValue("apr_policy_token", AprPolicyToken);
            writer.WriteDateTimeOffsetValue("created_time", CreatedTime);
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.PolicyProductResponse>("credit_product_policy_detail", CreditProductPolicyDetail);
            writer.WriteStringValue("credit_product_policy_token", CreditProductPolicyToken);
            writer.WriteStringValue("description", Description);
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.PolicyDocumentResponse>("document_policy_detail", DocumentPolicyDetail);
            writer.WriteStringValue("document_policy_token", DocumentPolicyToken);
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.PolicyFeeResponse>("fee_policy_detail", FeePolicyDetail);
            writer.WriteStringValue("fee_policy_token", FeePolicyToken);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.PolicyOfferResponse>("offer_policy_detail", OfferPolicyDetail);
            writer.WriteStringValue("offer_policy_token", OfferPolicyToken);
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.PolicyRewardResponse>("reward_policy_detail", RewardPolicyDetail);
            writer.WriteStringValue("reward_policy_token", RewardPolicyToken);
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.BundleResourceStatus>("status", Status);
            writer.WriteStringValue("token", Token);
            writer.WriteDateTimeOffsetValue("updated_time", UpdatedTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
