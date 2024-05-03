// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    /// <summary>
    /// Contains the cardholder&apos;s email address and password information.
    /// </summary>
    public class Authentication : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Specifies whether the email address has been verified.</summary>
        public bool? EmailVerified { get; set; }
        /// <summary>Date and time when the email address was verified.</summary>
        public DateTimeOffset? EmailVerifiedTime { get; set; }
        /// <summary>Specifies the channel through which the password was last changed.</summary>
        public Authentication_last_password_update_channel? LastPasswordUpdateChannel { get; set; }
        /// <summary>Date and time when the password was last changed.</summary>
        public DateTimeOffset? LastPasswordUpdateTime { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="Authentication"/> and sets the default values.
        /// </summary>
        public Authentication() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Authentication"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Authentication CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Authentication();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"email_verified", n => { EmailVerified = n.GetBoolValue(); } },
                {"email_verified_time", n => { EmailVerifiedTime = n.GetDateTimeOffsetValue(); } },
                {"last_password_update_channel", n => { LastPasswordUpdateChannel = n.GetEnumValue<Authentication_last_password_update_channel>(); } },
                {"last_password_update_time", n => { LastPasswordUpdateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("email_verified", EmailVerified);
            writer.WriteDateTimeOffsetValue("email_verified_time", EmailVerifiedTime);
            writer.WriteEnumValue<Authentication_last_password_update_channel>("last_password_update_channel", LastPasswordUpdateChannel);
            writer.WriteDateTimeOffsetValue("last_password_update_time", LastPasswordUpdateTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
