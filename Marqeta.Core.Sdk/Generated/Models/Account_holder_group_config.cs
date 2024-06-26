// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models
{
    /// <summary>
    /// Contains configuration fields for the account holder group.
    /// </summary>
    public class Account_holder_group_config : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>If set to `false`, this control prohibits an account holder&apos;s account from being reloaded with funds after the initial load.This restriction applies to GPA orders, peer transfers, and direct deposits, but does not apply to operator adjustments.</summary>
        public bool? IsReloadable { get; set; }
        /// <summary>If set to `ALWAYS`, new account holders are created in an `UNVERIFIED` status and must pass identity verification (KYC) before they can be active; if set to `CONDITIONAL`, new account holders begin in a `LIMITED` status and have limited actions available before passing identity verification; if set to `NEVER`, new account holders are created in an active state.</summary>
        public Marqeta.Core.Sdk.Models.Account_holder_group_config_kyc_required? KycRequired { get; set; }
        /// <summary>Contains configuration fields for a number of controls.*NOTE:* These controls are in effect only if `kyc_required` is `ALWAYS` or `CONDITIONAL` and the account holder has not yet passed KYC.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Marqeta.Core.Sdk.Models.Pre_kyc_controls? PreKycControls { get; set; }
#nullable restore
#else
        public Marqeta.Core.Sdk.Models.Pre_kyc_controls PreKycControls { get; set; }
#endif
        /// <summary>Associates the specified real-time fee group with the members of the account holder group.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RealTimeFeeGroupToken { get; set; }
#nullable restore
#else
        public string RealTimeFeeGroupToken { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Models.Account_holder_group_config"/> and sets the default values.
        /// </summary>
        public Account_holder_group_config()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Models.Account_holder_group_config"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Marqeta.Core.Sdk.Models.Account_holder_group_config CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Marqeta.Core.Sdk.Models.Account_holder_group_config();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "is_reloadable", n => { IsReloadable = n.GetBoolValue(); } },
                { "kyc_required", n => { KycRequired = n.GetEnumValue<Marqeta.Core.Sdk.Models.Account_holder_group_config_kyc_required>(); } },
                { "pre_kyc_controls", n => { PreKycControls = n.GetObjectValue<Marqeta.Core.Sdk.Models.Pre_kyc_controls>(Marqeta.Core.Sdk.Models.Pre_kyc_controls.CreateFromDiscriminatorValue); } },
                { "real_time_fee_group_token", n => { RealTimeFeeGroupToken = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("is_reloadable", IsReloadable);
            writer.WriteEnumValue<Marqeta.Core.Sdk.Models.Account_holder_group_config_kyc_required>("kyc_required", KycRequired);
            writer.WriteObjectValue<Marqeta.Core.Sdk.Models.Pre_kyc_controls>("pre_kyc_controls", PreKycControls);
            writer.WriteStringValue("real_time_fee_group_token", RealTimeFeeGroupToken);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
