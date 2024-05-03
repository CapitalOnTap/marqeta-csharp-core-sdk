// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    #pragma warning disable CS1591
    public class Sending_provisioning_data_to_google_pay_backend_request : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Indicates if the Funding Primary Account Number (FPAN) will be attempted.* *1* - FPAN save will be attempted.* *0* - FPAN save will not be attempted.</summary>
        public int? CardSetting { get; set; }
        /// <summary>Unique identifier of the card resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CardToken { get; set; }
#nullable restore
#else
        public string CardToken { get; set; }
#endif
        /// <summary>String provided by Google Wallet that identifies the client session.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClientSessionId { get; set; }
#nullable restore
#else
        public string ClientSessionId { get; set; }
#endif
        /// <summary>Google-assigned string that uniquely identifies both the integrator that is initiating the session and the issuer of the card.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IntegratorId { get; set; }
#nullable restore
#else
        public string IntegratorId { get; set; }
#endif
        /// <summary>String provided by Google Wallet that identifies the Android device that will receive the digital wallet token.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PublicDeviceId { get; set; }
#nullable restore
#else
        public string PublicDeviceId { get; set; }
#endif
        /// <summary>String provided by Google Wallet that identifies the device-scoped wallet that receives the digital wallet token.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PublicWalletId { get; set; }
#nullable restore
#else
        public string PublicWalletId { get; set; }
#endif
        /// <summary>String provided by Google Wallet that identifies the backend session.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServerSessionId { get; set; }
#nullable restore
#else
        public string ServerSessionId { get; set; }
#endif
        /// <summary>Indicates if tokenization will be attempted.* *1* - Tokenization will be attempted.* *0* - Tokenization will not be attempted.</summary>
        public int? TokenSetting { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="Sending_provisioning_data_to_google_pay_backend_request"/> and sets the default values.
        /// </summary>
        public Sending_provisioning_data_to_google_pay_backend_request()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Sending_provisioning_data_to_google_pay_backend_request"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Sending_provisioning_data_to_google_pay_backend_request CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Sending_provisioning_data_to_google_pay_backend_request();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"card_setting", n => { CardSetting = n.GetIntValue(); } },
                {"card_token", n => { CardToken = n.GetStringValue(); } },
                {"client_session_id", n => { ClientSessionId = n.GetStringValue(); } },
                {"integrator_id", n => { IntegratorId = n.GetStringValue(); } },
                {"public_device_id", n => { PublicDeviceId = n.GetStringValue(); } },
                {"public_wallet_id", n => { PublicWalletId = n.GetStringValue(); } },
                {"server_session_id", n => { ServerSessionId = n.GetStringValue(); } },
                {"token_setting", n => { TokenSetting = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("card_setting", CardSetting);
            writer.WriteStringValue("card_token", CardToken);
            writer.WriteStringValue("client_session_id", ClientSessionId);
            writer.WriteStringValue("integrator_id", IntegratorId);
            writer.WriteStringValue("public_device_id", PublicDeviceId);
            writer.WriteStringValue("public_wallet_id", PublicWalletId);
            writer.WriteStringValue("server_session_id", ServerSessionId);
            writer.WriteIntValue("token_setting", TokenSetting);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
