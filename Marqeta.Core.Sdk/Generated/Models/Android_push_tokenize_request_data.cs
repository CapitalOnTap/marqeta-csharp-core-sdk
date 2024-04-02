// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    /// <summary>
    /// Contains details about a card tokenization push request.
    /// </summary>
    public class Android_push_tokenize_request_data : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Name of the card as displayed in the digital wallet, typically showing the card brand and last four digits of the primary account number (PAN).`Visa 5678`, for example.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Last four digits of the primary account number of the physical or virtual card.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastDigits { get; set; }
#nullable restore
#else
        public string LastDigits { get; set; }
#endif
        /// <summary>Specifies the card network of the physical or virtual card.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Network { get; set; }
#nullable restore
#else
        public string Network { get; set; }
#endif
        /// <summary>Encrypted data field created by the issuer and passed to Google Wallet during the push provisioning process.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OpaquePaymentCard { get; set; }
#nullable restore
#else
        public string OpaquePaymentCard { get; set; }
#endif
        /// <summary>Specifies the network that provides the digital wallet token service.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TokenServiceProvider { get; set; }
#nullable restore
#else
        public string TokenServiceProvider { get; set; }
#endif
        /// <summary>Specifies the cardholder address.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AndroidPushTokenRequestAddress? UserAddress { get; set; }
#nullable restore
#else
        public AndroidPushTokenRequestAddress UserAddress { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Android_push_tokenize_request_data"/> and sets the default values.
        /// </summary>
        public Android_push_tokenize_request_data() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Android_push_tokenize_request_data"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Android_push_tokenize_request_data CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Android_push_tokenize_request_data();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"display_name", n => { DisplayName = n.GetStringValue(); } },
                {"last_digits", n => { LastDigits = n.GetStringValue(); } },
                {"network", n => { Network = n.GetStringValue(); } },
                {"opaque_payment_card", n => { OpaquePaymentCard = n.GetStringValue(); } },
                {"token_service_provider", n => { TokenServiceProvider = n.GetStringValue(); } },
                {"user_address", n => { UserAddress = n.GetObjectValue<AndroidPushTokenRequestAddress>(AndroidPushTokenRequestAddress.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("display_name", DisplayName);
            writer.WriteStringValue("last_digits", LastDigits);
            writer.WriteStringValue("network", Network);
            writer.WriteStringValue("opaque_payment_card", OpaquePaymentCard);
            writer.WriteStringValue("token_service_provider", TokenServiceProvider);
            writer.WriteObjectValue<AndroidPushTokenRequestAddress>("user_address", UserAddress);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}