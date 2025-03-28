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
    public partial class Pin_reveal_request : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The supplemental method used to verify the cardholder&apos;s identity before revealing the card&apos;s personal identification number (PIN).The possible cardholder verification methods are:* *BIOMETRIC_FACE:* In-app authentication via facial recognition* *BIOMETRIC_FINGERPRINT:* In-app authentication via biometric fingerprint* *EXP_CVV:* In-app authentication by entering the card&apos;s expiration date and card verification value (CVV)* *LOGIN:* In-app authentication by re-entering the app password* *OTP:* Two-factor authentication involving a one-time password (OTP)* *OTP_CVV:* Two-factor authentication involving the card&apos;s CVV and an OTP* *OTHER:* Authentication that relies on other secure methods</summary>
        public global::Marqeta.Core.Sdk.Models.Pin_reveal_request_cardholder_verification_method? CardholderVerificationMethod { get; set; }
        /// <summary>Unique value generated as a result of issuing a `POST` request to the `/pins/controltoken` endpoint.This value cannot be updated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ControlToken { get; set; }
#nullable restore
#else
        public string ControlToken { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.Pin_reveal_request"/> and sets the default values.
        /// </summary>
        public Pin_reveal_request()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.Pin_reveal_request"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.Pin_reveal_request CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.Pin_reveal_request();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "cardholder_verification_method", n => { CardholderVerificationMethod = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.Pin_reveal_request_cardholder_verification_method>(); } },
                { "control_token", n => { ControlToken = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.Pin_reveal_request_cardholder_verification_method>("cardholder_verification_method", CardholderVerificationMethod);
            writer.WriteStringValue("control_token", ControlToken);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
