// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    public class Digital_wallet_x_pay_provision_request : IAdditionalDataHolder, IParsable {
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
        /// <summary>Unique identifier of the user&apos;s XPay device, as provided by XPay during the provisioning process.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceId { get; set; }
#nullable restore
#else
        public string DeviceId { get; set; }
#endif
        /// <summary>Type of device into which the digital wallet token will be provisioned.</summary>
        public Digital_wallet_x_pay_provision_request_device_type? DeviceType { get; set; }
        /// <summary>Version of the application making the provisioning request.Used for debugging and fraud prevention.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProvisioningAppVersion { get; set; }
#nullable restore
#else
        public string ProvisioningAppVersion { get; set; }
#endif
        /// <summary>Unique numerical identifier of the digital wallet token requestor within the card network.These ID numbers map to `token_requestor_name` field values as follows:*Mastercard** 50110030273 – `APPLE_PAY`* 50120834693 – `ANDROID_PAY`* 50139059239 – `SAMSUNG_PAY`*Visa** 40010030273 – `APPLE_PAY`* 40010075001 – `ANDROID_PAY`* 40010043095 – `SAMSUNG_PAY`* 40010075196 – `MICROSOFT_PAY`* 40010075338 – `VISA_CHECKOUT`* 40010075449 – `FACEBOOK`* 40010075839 – `NETFLIX`* 40010077056 – `FITBIT_PAY`* 40010069887 – `GARMIN_PAY`</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TokenRequestorId { get; set; }
#nullable restore
#else
        public string TokenRequestorId { get; set; }
#endif
        /// <summary>User&apos;s XPay account identifier, as provided by XPay during the provisioning process.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WalletAccountId { get; set; }
#nullable restore
#else
        public string WalletAccountId { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Digital_wallet_x_pay_provision_request"/> and sets the default values.
        /// </summary>
        public Digital_wallet_x_pay_provision_request() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Digital_wallet_x_pay_provision_request"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Digital_wallet_x_pay_provision_request CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Digital_wallet_x_pay_provision_request();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"card_token", n => { CardToken = n.GetStringValue(); } },
                {"device_id", n => { DeviceId = n.GetStringValue(); } },
                {"device_type", n => { DeviceType = n.GetEnumValue<Digital_wallet_x_pay_provision_request_device_type>(); } },
                {"provisioning_app_version", n => { ProvisioningAppVersion = n.GetStringValue(); } },
                {"token_requestor_id", n => { TokenRequestorId = n.GetStringValue(); } },
                {"wallet_account_id", n => { WalletAccountId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("card_token", CardToken);
            writer.WriteStringValue("device_id", DeviceId);
            writer.WriteEnumValue<Digital_wallet_x_pay_provision_request_device_type>("device_type", DeviceType);
            writer.WriteStringValue("provisioning_app_version", ProvisioningAppVersion);
            writer.WriteStringValue("token_requestor_id", TokenRequestorId);
            writer.WriteStringValue("wallet_account_id", WalletAccountId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}