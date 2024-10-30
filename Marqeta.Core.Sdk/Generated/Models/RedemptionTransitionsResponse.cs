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
    /// Return redemptions transition.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class RedemptionTransitionsResponse : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Date and time when the reward redemption transition was created on Marqeta&apos;s credit platform.</summary>
        public DateTimeOffset? CreatedTime { get; set; }
        /// <summary>Date and time when the reward redemption was settled on your external platform.This field is returned if you handled the reward redemption outside of Marqeta&apos;s credit platform.</summary>
        public DateTimeOffset? ExternalSettlementDateTime { get; set; }
        /// <summary>Status of the redemption.If &lt;&lt;/core-api/reward-redemptions#postRedemptionTransition, transitioning the redemption&apos;s status&gt;&gt;:* `new_state` is the state to which you want to transition the redemption; must be `COMPLETED` or `RETURNED`.* `initial_status` is the initial status of the redemption prior to transition.</summary>
        public global::Marqeta.Core.Sdk.Models.RedemptionStatus? InitialStatus { get; set; }
        /// <summary>Status of the redemption.If &lt;&lt;/core-api/reward-redemptions#postRedemptionTransition, transitioning the redemption&apos;s status&gt;&gt;:* `new_state` is the state to which you want to transition the redemption; must be `COMPLETED` or `RETURNED`.* `initial_status` is the initial status of the redemption prior to transition.</summary>
        public global::Marqeta.Core.Sdk.Models.RedemptionStatus? NewStatus { get; set; }
        /// <summary>Unique identifier of the redemption whose status was transitioned.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RedemptionToken { get; set; }
#nullable restore
#else
        public string RedemptionToken { get; set; }
#endif
        /// <summary>Unique identifier of the reward redemption transition.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.RedemptionTransitionsResponse"/> and sets the default values.
        /// </summary>
        public RedemptionTransitionsResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.RedemptionTransitionsResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.RedemptionTransitionsResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.RedemptionTransitionsResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "created_time", n => { CreatedTime = n.GetDateTimeOffsetValue(); } },
                { "external_settlement_date_time", n => { ExternalSettlementDateTime = n.GetDateTimeOffsetValue(); } },
                { "initial_status", n => { InitialStatus = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.RedemptionStatus>(); } },
                { "new_status", n => { NewStatus = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.RedemptionStatus>(); } },
                { "redemption_token", n => { RedemptionToken = n.GetStringValue(); } },
                { "token", n => { Token = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("created_time", CreatedTime);
            writer.WriteDateTimeOffsetValue("external_settlement_date_time", ExternalSettlementDateTime);
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.RedemptionStatus>("initial_status", InitialStatus);
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.RedemptionStatus>("new_status", NewStatus);
            writer.WriteStringValue("redemption_token", RedemptionToken);
            writer.WriteStringValue("token", Token);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
