// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    /// <summary>
    /// Contains information from the card network about currency conversion at the time of settlement, including the original currency of the transaction, the amount of the transaction in the original currency, and the conversion rate.
    /// </summary>
    public class Settlement_data : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The settled amount.</summary>
        public double? Amount { get; set; }
        /// <summary>Returned when the transaction currency is different from the origination currency.Conversion rate between the origination currency and the settlement currency.</summary>
        public double? ConversionRate { get; set; }
        /// <summary>The ISO 4217 code of the currency used in the transaction.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CurrencyCode { get; set; }
#nullable restore
#else
        public string CurrencyCode { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Settlement_data"/> and sets the default values.
        /// </summary>
        public Settlement_data() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Settlement_data"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Settlement_data CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Settlement_data();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"amount", n => { Amount = n.GetDoubleValue(); } },
                {"conversion_rate", n => { ConversionRate = n.GetDoubleValue(); } },
                {"currency_code", n => { CurrencyCode = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("amount", Amount);
            writer.WriteDoubleValue("conversion_rate", ConversionRate);
            writer.WriteStringValue("currency_code", CurrencyCode);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
