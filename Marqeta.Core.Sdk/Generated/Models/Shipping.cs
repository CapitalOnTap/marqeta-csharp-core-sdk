// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    /// <summary>
    /// Specifies shipping details for the order.
    /// </summary>
    public class Shipping : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Adds the specified value as a care of (C/O) line to the mailing carrier.*NOTE:* This field can be specified on cards, card products, and bulk card orders.If you specify this field at multiple levels, the order of precedence is: card, bulk card order, card product.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CareOfLine { get; set; }
#nullable restore
#else
        public string CareOfLine { get; set; }
#endif
        /// <summary>Specifies the shipping service.</summary>
        public Shipping_method? Method { get; set; }
        /// <summary>Specifies a fulfillment shipping or return address.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Fulfillment_address_request? RecipientAddress { get; set; }
#nullable restore
#else
        public Fulfillment_address_request RecipientAddress { get; set; }
#endif
        /// <summary>Specifies a fulfillment shipping or return address.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Fulfillment_address_request? ReturnAddress { get; set; }
#nullable restore
#else
        public Fulfillment_address_request ReturnAddress { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Shipping"/> and sets the default values.
        /// </summary>
        public Shipping() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Shipping"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Shipping CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Shipping();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"care_of_line", n => { CareOfLine = n.GetStringValue(); } },
                {"method", n => { Method = n.GetEnumValue<Shipping_method>(); } },
                {"recipient_address", n => { RecipientAddress = n.GetObjectValue<Fulfillment_address_request>(Fulfillment_address_request.CreateFromDiscriminatorValue); } },
                {"return_address", n => { ReturnAddress = n.GetObjectValue<Fulfillment_address_request>(Fulfillment_address_request.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("care_of_line", CareOfLine);
            writer.WriteEnumValue<Shipping_method>("method", Method);
            writer.WriteObjectValue<Fulfillment_address_request>("recipient_address", RecipientAddress);
            writer.WriteObjectValue<Fulfillment_address_request>("return_address", ReturnAddress);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}