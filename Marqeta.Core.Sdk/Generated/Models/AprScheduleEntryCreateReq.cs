// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    public class AprScheduleEntryCreateReq : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The number of percentage points added to the prime rate, used to calculate a variable value.Used for variable values only.</summary>
        public float? Margin { get; set; }
        /// <summary>Indicates whether the APR value is fixed or variable.</summary>
        public AprScheduleEntryCreateReq_type? Type { get; set; }
        /// <summary>Percentage value of the APR.If the APR type is `FIXED`, this is the value of the fixed rate.If the APR type is `VARIABLE`, the value is calculated by adding the margin to the prime rate that was stored on Marqeta&apos;s credit platform when your credit program was created.When backdating an APR, this value cannot be greater than the value of the effective APR on the backdated date.</summary>
        public double? Value { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="AprScheduleEntryCreateReq"/> and sets the default values.
        /// </summary>
        public AprScheduleEntryCreateReq() {
            AdditionalData = new Dictionary<string, object>();
            Type = AprScheduleEntryCreateReq_type.FIXED;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AprScheduleEntryCreateReq"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AprScheduleEntryCreateReq CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AprScheduleEntryCreateReq();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"margin", n => { Margin = n.GetFloatValue(); } },
                {"type", n => { Type = n.GetEnumValue<AprScheduleEntryCreateReq_type>(); } },
                {"value", n => { Value = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteFloatValue("margin", Margin);
            writer.WriteEnumValue<AprScheduleEntryCreateReq_type>("type", Type);
            writer.WriteDoubleValue("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}