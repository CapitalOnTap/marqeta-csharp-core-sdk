// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    public class Digital_wallet_samsung_pay_provision_response : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Unique identifier of the card resource to use for the provisioning request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CardToken { get; set; }
#nullable restore
#else
        public string CardToken { get; set; }
#endif
        /// <summary>Date and time when the digital wallet provisioning request was created, in UTC.</summary>
        public DateTimeOffset? CreatedTime { get; set; }
        /// <summary>Date and time when the digital wallet token provisioning request was last updated, in UTC.</summary>
        public DateTimeOffset? LastModifiedTime { get; set; }
        /// <summary>Contains details about a card tokenization push request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Samsung_push_tokenize_request_data? PushTokenizeRequestData { get; set; }
#nullable restore
#else
        public Samsung_push_tokenize_request_data PushTokenizeRequestData { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Digital_wallet_samsung_pay_provision_response"/> and sets the default values.
        /// </summary>
        public Digital_wallet_samsung_pay_provision_response() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Digital_wallet_samsung_pay_provision_response"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Digital_wallet_samsung_pay_provision_response CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Digital_wallet_samsung_pay_provision_response();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"card_token", n => { CardToken = n.GetStringValue(); } },
                {"created_time", n => { CreatedTime = n.GetDateTimeOffsetValue(); } },
                {"last_modified_time", n => { LastModifiedTime = n.GetDateTimeOffsetValue(); } },
                {"push_tokenize_request_data", n => { PushTokenizeRequestData = n.GetObjectValue<Samsung_push_tokenize_request_data>(Samsung_push_tokenize_request_data.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("card_token", CardToken);
            writer.WriteDateTimeOffsetValue("created_time", CreatedTime);
            writer.WriteDateTimeOffsetValue("last_modified_time", LastModifiedTime);
            writer.WriteObjectValue<Samsung_push_tokenize_request_data>("push_tokenize_request_data", PushTokenizeRequestData);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}