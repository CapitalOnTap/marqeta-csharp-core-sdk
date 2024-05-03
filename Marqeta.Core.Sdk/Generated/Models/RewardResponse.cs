// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    public class RewardResponse : IAdditionalDataHolder, IParsable {
        /// <summary>Unique identifier of the account on which the reward exists.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountToken { get; set; }
#nullable restore
#else
        public string AccountToken { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Amount of the reward.</summary>
        public double? Amount { get; set; }
        /// <summary>Total amount to which a percentage reward method is applied (for example, if a 3% reward is applied to 100, then `100` is the `applied_to_amount` value).This field is not applicable for a flat fee method.Returned for auto-cash back reward types only.</summary>
        public double? AppliedToAmount { get; set; }
        /// <summary>Date and time when the reward was created on Marqeta&apos;s credit platform, in UTC.</summary>
        public DateTimeOffset? CreatedTime { get; set; }
        /// <summary>Valid three-digit link:https://www.iso.org/iso-4217-currency-codes.html[ISO 4217 currency code, window=&quot;_blank&quot;]</summary>
        public Marqeta.Core.Sdk.Models.CurrencyCode? CurrencyCode { get; set; }
        /// <summary>Description of the reward.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Method, either a flat amount or a percentage.*NOTE:*Only `FLAT` is currently supported.</summary>
        public MethodObject? Method { get; set; }
        /// <summary>Additional information about the reward.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Note { get; set; }
#nullable restore
#else
        public string Note { get; set; }
#endif
        /// <summary>Unique identifier of the reward.If in the `detail_object`, unique identifier of the detail object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>Type of reward.</summary>
        public RewardType? Type { get; set; }
        /// <summary>Date and time when the reward was last updated on Marqeta&apos;s credit platform, in UTC.</summary>
        public DateTimeOffset? UpdatedTime { get; set; }
        /// <summary>Value of the percentage or flat amount.Returned for auto-cash back reward types only.</summary>
        public double? Value { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="RewardResponse"/> and sets the default values.
        /// </summary>
        public RewardResponse() {
            AdditionalData = new Dictionary<string, object>();
            CurrencyCode = Marqeta.Core.Sdk.Models.CurrencyCode.USD;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="RewardResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static RewardResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RewardResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"account_token", n => { AccountToken = n.GetStringValue(); } },
                {"amount", n => { Amount = n.GetDoubleValue(); } },
                {"applied_to_amount", n => { AppliedToAmount = n.GetDoubleValue(); } },
                {"created_time", n => { CreatedTime = n.GetDateTimeOffsetValue(); } },
                {"currency_code", n => { CurrencyCode = n.GetEnumValue<CurrencyCode>(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"method", n => { Method = n.GetEnumValue<MethodObject>(); } },
                {"note", n => { Note = n.GetStringValue(); } },
                {"token", n => { Token = n.GetStringValue(); } },
                {"type", n => { Type = n.GetEnumValue<RewardType>(); } },
                {"updated_time", n => { UpdatedTime = n.GetDateTimeOffsetValue(); } },
                {"value", n => { Value = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("account_token", AccountToken);
            writer.WriteDoubleValue("amount", Amount);
            writer.WriteDoubleValue("applied_to_amount", AppliedToAmount);
            writer.WriteDateTimeOffsetValue("created_time", CreatedTime);
            writer.WriteEnumValue<CurrencyCode>("currency_code", CurrencyCode);
            writer.WriteStringValue("description", Description);
            writer.WriteEnumValue<MethodObject>("method", Method);
            writer.WriteStringValue("note", Note);
            writer.WriteStringValue("token", Token);
            writer.WriteEnumValue<RewardType>("type", Type);
            writer.WriteDateTimeOffsetValue("updated_time", UpdatedTime);
            writer.WriteDoubleValue("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
