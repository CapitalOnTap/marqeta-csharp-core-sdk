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
    /// Contains information from the card network about currency conversion, including the original currency of the transaction, the amount of the transaction in the original currency, and the conversion rate.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Network : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Conversion rate between the origination currency and the settlement currency.Returned when the transaction currency is different from the origination currency.</summary>
        public double? ConversionRate { get; set; }
        /// <summary>Indicates whether currency conversion was performed dynamically at the point of sale.</summary>
        public bool? DynamicCurrencyConversion { get; set; }
        /// <summary>Amount of the transaction in the currency in which it originated.</summary>
        public double? OriginalAmount { get; set; }
        /// <summary>Currency type of the origination currency.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OriginalCurrencyCode { get; set; }
#nullable restore
#else
        public string OriginalCurrencyCode { get; set; }
#endif
        /// <summary>Contains information from the card network about currency conversion at the time of settlement, including the original currency of the transaction, the amount of the transaction in the original currency, and the conversion rate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.Models.Settlement_data? SettlementData { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.Settlement_data SettlementData { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.Network"/> and sets the default values.
        /// </summary>
        public Network()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.Network"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.Network CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.Network();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "conversion_rate", n => { ConversionRate = n.GetDoubleValue(); } },
                { "dynamic_currency_conversion", n => { DynamicCurrencyConversion = n.GetBoolValue(); } },
                { "original_amount", n => { OriginalAmount = n.GetDoubleValue(); } },
                { "original_currency_code", n => { OriginalCurrencyCode = n.GetStringValue(); } },
                { "settlement_data", n => { SettlementData = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.Settlement_data>(global::Marqeta.Core.Sdk.Models.Settlement_data.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("conversion_rate", ConversionRate);
            writer.WriteBoolValue("dynamic_currency_conversion", DynamicCurrencyConversion);
            writer.WriteDoubleValue("original_amount", OriginalAmount);
            writer.WriteStringValue("original_currency_code", OriginalCurrencyCode);
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.Settlement_data>("settlement_data", SettlementData);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
