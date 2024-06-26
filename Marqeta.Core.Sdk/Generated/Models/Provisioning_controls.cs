// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models
{
    #pragma warning disable CS1591
    public class Provisioning_controls : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The dwt_use_card_status_during_auth property</summary>
        public bool? DwtUseCardStatusDuringAuth { get; set; }
        /// <summary>The dwt_verify_atc_during_auth property</summary>
        public bool? DwtVerifyAtcDuringAuth { get; set; }
        /// <summary>The enable_discretionary_data_during_tar property</summary>
        public bool? EnableDiscretionaryDataDuringTar { get; set; }
        /// <summary>A value of `true` requires identity verification set-up for all digital wallets at the card product level.</summary>
        public bool? ForceYellowPathForCardProduct { get; set; }
        /// <summary>The in_app_provisioning property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Marqeta.Core.Sdk.Models.In_app_provisioning? InAppProvisioning { get; set; }
#nullable restore
#else
        public Marqeta.Core.Sdk.Models.In_app_provisioning InAppProvisioning { get; set; }
#endif
        /// <summary>The manual_entry property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Marqeta.Core.Sdk.Models.Manual_entry? ManualEntry { get; set; }
#nullable restore
#else
        public Marqeta.Core.Sdk.Models.Manual_entry ManualEntry { get; set; }
#endif
        /// <summary>The wallet_provider_card_on_file property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Marqeta.Core.Sdk.Models.Wallet_provider_card_on_file? WalletProviderCardOnFile { get; set; }
#nullable restore
#else
        public Marqeta.Core.Sdk.Models.Wallet_provider_card_on_file WalletProviderCardOnFile { get; set; }
#endif
        /// <summary>The web_push_provisioning property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Marqeta.Core.Sdk.Models.Web_push_provisioning? WebPushProvisioning { get; set; }
#nullable restore
#else
        public Marqeta.Core.Sdk.Models.Web_push_provisioning WebPushProvisioning { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Models.Provisioning_controls"/> and sets the default values.
        /// </summary>
        public Provisioning_controls()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Models.Provisioning_controls"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Marqeta.Core.Sdk.Models.Provisioning_controls CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Marqeta.Core.Sdk.Models.Provisioning_controls();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "dwt_use_card_status_during_auth", n => { DwtUseCardStatusDuringAuth = n.GetBoolValue(); } },
                { "dwt_verify_atc_during_auth", n => { DwtVerifyAtcDuringAuth = n.GetBoolValue(); } },
                { "enable_discretionary_data_during_tar", n => { EnableDiscretionaryDataDuringTar = n.GetBoolValue(); } },
                { "force_yellow_path_for_card_product", n => { ForceYellowPathForCardProduct = n.GetBoolValue(); } },
                { "in_app_provisioning", n => { InAppProvisioning = n.GetObjectValue<Marqeta.Core.Sdk.Models.In_app_provisioning>(Marqeta.Core.Sdk.Models.In_app_provisioning.CreateFromDiscriminatorValue); } },
                { "manual_entry", n => { ManualEntry = n.GetObjectValue<Marqeta.Core.Sdk.Models.Manual_entry>(Marqeta.Core.Sdk.Models.Manual_entry.CreateFromDiscriminatorValue); } },
                { "wallet_provider_card_on_file", n => { WalletProviderCardOnFile = n.GetObjectValue<Marqeta.Core.Sdk.Models.Wallet_provider_card_on_file>(Marqeta.Core.Sdk.Models.Wallet_provider_card_on_file.CreateFromDiscriminatorValue); } },
                { "web_push_provisioning", n => { WebPushProvisioning = n.GetObjectValue<Marqeta.Core.Sdk.Models.Web_push_provisioning>(Marqeta.Core.Sdk.Models.Web_push_provisioning.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("dwt_use_card_status_during_auth", DwtUseCardStatusDuringAuth);
            writer.WriteBoolValue("dwt_verify_atc_during_auth", DwtVerifyAtcDuringAuth);
            writer.WriteBoolValue("enable_discretionary_data_during_tar", EnableDiscretionaryDataDuringTar);
            writer.WriteBoolValue("force_yellow_path_for_card_product", ForceYellowPathForCardProduct);
            writer.WriteObjectValue<Marqeta.Core.Sdk.Models.In_app_provisioning>("in_app_provisioning", InAppProvisioning);
            writer.WriteObjectValue<Marqeta.Core.Sdk.Models.Manual_entry>("manual_entry", ManualEntry);
            writer.WriteObjectValue<Marqeta.Core.Sdk.Models.Wallet_provider_card_on_file>("wallet_provider_card_on_file", WalletProviderCardOnFile);
            writer.WriteObjectValue<Marqeta.Core.Sdk.Models.Web_push_provisioning>("web_push_provisioning", WebPushProvisioning);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
