// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    public class WebhookUpdateCustomHeaderRequest : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Additional custom information included in the HTTP header.For example, this might contain security information, along with Basic Authentication, when making a JIT Funding request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WebhookUpdateCustomHeaderRequest_custom_header? CustomHeader { get; set; }
#nullable restore
#else
        public WebhookUpdateCustomHeaderRequest_custom_header CustomHeader { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="WebhookUpdateCustomHeaderRequest"/> and sets the default values.
        /// </summary>
        public WebhookUpdateCustomHeaderRequest() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="WebhookUpdateCustomHeaderRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WebhookUpdateCustomHeaderRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WebhookUpdateCustomHeaderRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"custom_header", n => { CustomHeader = n.GetObjectValue<WebhookUpdateCustomHeaderRequest_custom_header>(WebhookUpdateCustomHeaderRequest_custom_header.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<WebhookUpdateCustomHeaderRequest_custom_header>("custom_header", CustomHeader);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}