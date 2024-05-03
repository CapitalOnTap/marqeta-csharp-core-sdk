// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    /// <summary>
    /// Contains information on a returned payment.
    /// </summary>
    public class ReturnedDetails : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Return code for the returned payment.For more, see &lt;&lt;/developer-guides/ach-origination#_nacha_ach_return_codes, NACHA ACH return codes&gt;&gt;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReturnCode { get; set; }
#nullable restore
#else
        public string ReturnCode { get; set; }
#endif
        /// <summary>Reason the payment was returned.For more, see &lt;&lt;/developer-guides/ach-origination#_nacha_ach_return_codes, NACHA ACH return codes&gt;&gt;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReturnReason { get; set; }
#nullable restore
#else
        public string ReturnReason { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="ReturnedDetails"/> and sets the default values.
        /// </summary>
        public ReturnedDetails() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ReturnedDetails"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ReturnedDetails CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ReturnedDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"return_code", n => { ReturnCode = n.GetStringValue(); } },
                {"return_reason", n => { ReturnReason = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("return_code", ReturnCode);
            writer.WriteStringValue("return_reason", ReturnReason);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
