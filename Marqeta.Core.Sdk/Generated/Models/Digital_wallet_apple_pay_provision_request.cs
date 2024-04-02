// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    public class Digital_wallet_apple_pay_provision_request : IAdditionalDataHolder, IParsable {
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
        /// <summary>Base64-encoded leaf and sub-CA certificates provided by Apple.The first element of the array should be the leaf certificate, followed by the sub-CA.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Certificates { get; set; }
#nullable restore
#else
        public List<string> Certificates { get; set; }
#endif
        /// <summary>Type of device into which the digital wallet token will be provisioned.</summary>
        public Digital_wallet_apple_pay_provision_request_device_type? DeviceType { get; set; }
        /// <summary>One-time-use nonce provided by Apple for security purposes.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Nonce { get; set; }
#nullable restore
#else
        public string Nonce { get; set; }
#endif
        /// <summary>Apple-provided signature to the nonce.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NonceSignature { get; set; }
#nullable restore
#else
        public string NonceSignature { get; set; }
#endif
        /// <summary>Version of the application making the provisioning request.Used for debugging and fraud prevention.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProvisioningAppVersion { get; set; }
#nullable restore
#else
        public string ProvisioningAppVersion { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Digital_wallet_apple_pay_provision_request"/> and sets the default values.
        /// </summary>
        public Digital_wallet_apple_pay_provision_request() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Digital_wallet_apple_pay_provision_request"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Digital_wallet_apple_pay_provision_request CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Digital_wallet_apple_pay_provision_request();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"card_token", n => { CardToken = n.GetStringValue(); } },
                {"certificates", n => { Certificates = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"device_type", n => { DeviceType = n.GetEnumValue<Digital_wallet_apple_pay_provision_request_device_type>(); } },
                {"nonce", n => { Nonce = n.GetStringValue(); } },
                {"nonce_signature", n => { NonceSignature = n.GetStringValue(); } },
                {"provisioning_app_version", n => { ProvisioningAppVersion = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("card_token", CardToken);
            writer.WriteCollectionOfPrimitiveValues<string>("certificates", Certificates);
            writer.WriteEnumValue<Digital_wallet_apple_pay_provision_request_device_type>("device_type", DeviceType);
            writer.WriteStringValue("nonce", Nonce);
            writer.WriteStringValue("nonce_signature", NonceSignature);
            writer.WriteStringValue("provisioning_app_version", ProvisioningAppVersion);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
