// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Marqeta.Core.Sdk.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class Shipping : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>255 char max</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CareOfLine { get; set; }
#nullable restore
#else
        public string CareOfLine { get; set; }
#endif
        /// <summary>The method property</summary>
        public global::Marqeta.Core.Sdk.Models.Shipping_method? Method { get; set; }
        /// <summary>The recipient_address property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.Models.Fulfillment_address_request? RecipientAddress { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.Fulfillment_address_request RecipientAddress { get; set; }
#endif
        /// <summary>The return_address property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.Models.Fulfillment_address_request? ReturnAddress { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.Fulfillment_address_request ReturnAddress { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.Shipping"/> and sets the default values.
        /// </summary>
        public Shipping()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.Shipping"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.Shipping CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.Shipping();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "care_of_line", n => { CareOfLine = n.GetStringValue(); } },
                { "method", n => { Method = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.Shipping_method>(); } },
                { "recipient_address", n => { RecipientAddress = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.Fulfillment_address_request>(global::Marqeta.Core.Sdk.Models.Fulfillment_address_request.CreateFromDiscriminatorValue); } },
                { "return_address", n => { ReturnAddress = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.Fulfillment_address_request>(global::Marqeta.Core.Sdk.Models.Fulfillment_address_request.CreateFromDiscriminatorValue); } },
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
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.Shipping_method>("method", Method);
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.Fulfillment_address_request>("recipient_address", RecipientAddress);
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.Fulfillment_address_request>("return_address", ReturnAddress);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
