// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    public class CreateRedemptionsRequest : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Amount of the reward redemption.</summary>
        public decimal? Amount { get; set; }
        /// <summary>Destination of the reward redemption.* `INVESTMENT` - The redemption is paid into an investment account.* `WALLET` - The redemption is paid into a digital wallet.* `ACH` - The redemption is paid into an ACH account.Required for external redemptions.</summary>
        public DestinationType? Destination { get; set; }
        /// <summary>A note explaining why the reward is being redeemed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Note { get; set; }
#nullable restore
#else
        public string Note { get; set; }
#endif
        /// <summary>Unique identifier of the external account receiving the reward redemption.This token is equivalent to the &lt;&lt;/core-api/payment-sources, payment source&gt;&gt; token.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReceivingAccountToken { get; set; }
#nullable restore
#else
        public string ReceivingAccountToken { get; set; }
#endif
        /// <summary>Unique identifier of the reward redemption.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>Type of redemption.* `EXTERNAL` - You issue the redemption on your external platform; Marqeta adjusts the reward program balance on the system of record.* `STATEMENT_CREDIT` - Marqeta issues the redemption as a statement credit on the associated account. +*NOTE*: This creates a new journal entry on the account and cannot be undone.* `ACH` - The reward redemption is issued as an ACH transfer to the receiving account.</summary>
        public RedemptionType? Type { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="CreateRedemptionsRequest"/> and sets the default values.
        /// </summary>
        public CreateRedemptionsRequest() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="CreateRedemptionsRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CreateRedemptionsRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CreateRedemptionsRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"amount", n => { Amount = n.GetDecimalValue(); } },
                {"destination", n => { Destination = n.GetEnumValue<DestinationType>(); } },
                {"note", n => { Note = n.GetStringValue(); } },
                {"receiving_account_token", n => { ReceivingAccountToken = n.GetStringValue(); } },
                {"token", n => { Token = n.GetStringValue(); } },
                {"type", n => { Type = n.GetEnumValue<RedemptionType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDecimalValue("amount", Amount);
            writer.WriteEnumValue<DestinationType>("destination", Destination);
            writer.WriteStringValue("note", Note);
            writer.WriteStringValue("receiving_account_token", ReceivingAccountToken);
            writer.WriteStringValue("token", Token);
            writer.WriteEnumValue<RedemptionType>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
