// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    /// <summary>
    /// Specifies shipping details for the order.This object is returned if it exists in the resource.
    /// </summary>
    public class ShippingInformationResponse : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Specifies the value of the care of (C/O) line on the mailing carrier.This field is returned if it exists in the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CareOfLine { get; set; }
#nullable restore
#else
        public string CareOfLine { get; set; }
#endif
        /// <summary>Specifies the shipping service.This field is returned if it exists in the resource.</summary>
        public ShippingInformationResponse_method? Method { get; set; }
        /// <summary>Specifies a fulfillment shipping or return address.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public FulfillmentAddressResponse? RecipientAddress { get; set; }
#nullable restore
#else
        public FulfillmentAddressResponse RecipientAddress { get; set; }
#endif
        /// <summary>Specifies a fulfillment shipping or return address.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public FulfillmentAddressResponse? ReturnAddress { get; set; }
#nullable restore
#else
        public FulfillmentAddressResponse ReturnAddress { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="ShippingInformationResponse"/> and sets the default values.
        /// </summary>
        public ShippingInformationResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ShippingInformationResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ShippingInformationResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ShippingInformationResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"care_of_line", n => { CareOfLine = n.GetStringValue(); } },
                {"method", n => { Method = n.GetEnumValue<ShippingInformationResponse_method>(); } },
                {"recipient_address", n => { RecipientAddress = n.GetObjectValue<FulfillmentAddressResponse>(FulfillmentAddressResponse.CreateFromDiscriminatorValue); } },
                {"return_address", n => { ReturnAddress = n.GetObjectValue<FulfillmentAddressResponse>(FulfillmentAddressResponse.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("care_of_line", CareOfLine);
            writer.WriteEnumValue<ShippingInformationResponse_method>("method", Method);
            writer.WriteObjectValue<FulfillmentAddressResponse>("recipient_address", RecipientAddress);
            writer.WriteObjectValue<FulfillmentAddressResponse>("return_address", ReturnAddress);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
