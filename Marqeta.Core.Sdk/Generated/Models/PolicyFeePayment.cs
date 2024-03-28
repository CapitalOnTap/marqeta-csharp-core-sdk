// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    /// <summary>
    /// Contains information on a specific fee in a fee policy.
    /// </summary>
    public class PolicyFeePayment : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Method used to calculate the fee value.</summary>
        public FeeMethod? DefaultMethod { get; set; }
        /// <summary>Amount of the fee.</summary>
        public double? DefaultValue { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="PolicyFeePayment"/> and sets the default values.
        /// </summary>
        public PolicyFeePayment() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PolicyFeePayment"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PolicyFeePayment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PolicyFeePayment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"default_method", n => { DefaultMethod = n.GetEnumValue<FeeMethod>(); } },
                {"default_value", n => { DefaultValue = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<FeeMethod>("default_method", DefaultMethod);
            writer.WriteDoubleValue("default_value", DefaultValue);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
