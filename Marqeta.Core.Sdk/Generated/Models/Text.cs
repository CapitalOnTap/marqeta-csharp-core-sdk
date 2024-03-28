// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    /// <summary>
    /// Specifies personalized text that appears on the card.
    /// </summary>
    public class Text : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The name_line_1 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Text_value? NameLine1 { get; set; }
#nullable restore
#else
        public Text_value NameLine1 { get; set; }
#endif
        /// <summary>The name_line_2 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Text_value? NameLine2 { get; set; }
#nullable restore
#else
        public Text_value NameLine2 { get; set; }
#endif
        /// <summary>The name_line_3 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Text_value? NameLine3 { get; set; }
#nullable restore
#else
        public Text_value NameLine3 { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Text"/> and sets the default values.
        /// </summary>
        public Text() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Text"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Text CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Text();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"name_line_1", n => { NameLine1 = n.GetObjectValue<Text_value>(Text_value.CreateFromDiscriminatorValue); } },
                {"name_line_2", n => { NameLine2 = n.GetObjectValue<Text_value>(Text_value.CreateFromDiscriminatorValue); } },
                {"name_line_3", n => { NameLine3 = n.GetObjectValue<Text_value>(Text_value.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Text_value>("name_line_1", NameLine1);
            writer.WriteObjectValue<Text_value>("name_line_2", NameLine2);
            writer.WriteObjectValue<Text_value>("name_line_3", NameLine3);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
