// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    /// <summary>
    /// Request body that can be used to create a new ACHO transfer for a given payment.
    /// </summary>
    public class RetryAchPaymentReq : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The new_acho_ach_transfer_token property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NewAchoAchTransferToken { get; set; }
#nullable restore
#else
        public string NewAchoAchTransferToken { get; set; }
#endif
        /// <summary>The payment_token property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PaymentToken { get; set; }
#nullable restore
#else
        public string PaymentToken { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="RetryAchPaymentReq"/> and sets the default values.
        /// </summary>
        public RetryAchPaymentReq() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="RetryAchPaymentReq"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static RetryAchPaymentReq CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RetryAchPaymentReq();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"new_acho_ach_transfer_token", n => { NewAchoAchTransferToken = n.GetStringValue(); } },
                {"payment_token", n => { PaymentToken = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("new_acho_ach_transfer_token", NewAchoAchTransferToken);
            writer.WriteStringValue("payment_token", PaymentToken);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}