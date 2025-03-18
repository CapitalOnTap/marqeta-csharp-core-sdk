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
    public partial class Strong_customer_authentication_limits : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The cavv_authentication_amount_incremental_percentage property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CavvAuthenticationAmountIncrementalPercentage { get; set; }
#nullable restore
#else
        public string CavvAuthenticationAmountIncrementalPercentage { get; set; }
#endif
        /// <summary>The enable_biometric_bypass_sca_contactless property</summary>
        public bool? EnableBiometricBypassScaContactless { get; set; }
        /// <summary>The enable_cavv_authentication_amount_validation property</summary>
        public bool? EnableCavvAuthenticationAmountValidation { get; set; }
        /// <summary>The enable_issuer_tra_exemption property</summary>
        public bool? EnableIssuerTraExemption { get; set; }
        /// <summary>The sca_contactless_cumulative_amount_limit property</summary>
        public double? ScaContactlessCumulativeAmountLimit { get; set; }
        /// <summary>The sca_contactless_transaction_limit property</summary>
        public double? ScaContactlessTransactionLimit { get; set; }
        /// <summary>The sca_contactless_transactions_count_limit property</summary>
        public int? ScaContactlessTransactionsCountLimit { get; set; }
        /// <summary>The sca_contactless_transactions_currency property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ScaContactlessTransactionsCurrency { get; set; }
#nullable restore
#else
        public string ScaContactlessTransactionsCurrency { get; set; }
#endif
        /// <summary>The sca_lvp_cumulative_amount_limit property</summary>
        public double? ScaLvpCumulativeAmountLimit { get; set; }
        /// <summary>The sca_lvp_transaction_limit property</summary>
        public double? ScaLvpTransactionLimit { get; set; }
        /// <summary>The sca_lvp_transactions_count_limit property</summary>
        public int? ScaLvpTransactionsCountLimit { get; set; }
        /// <summary>The sca_lvp_transactions_currency property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ScaLvpTransactionsCurrency { get; set; }
#nullable restore
#else
        public string ScaLvpTransactionsCurrency { get; set; }
#endif
        /// <summary>The sca_tra_exemption_amount_limit property</summary>
        public double? ScaTraExemptionAmountLimit { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.Strong_customer_authentication_limits"/> and sets the default values.
        /// </summary>
        public Strong_customer_authentication_limits()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.Strong_customer_authentication_limits"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.Strong_customer_authentication_limits CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.Strong_customer_authentication_limits();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "cavv_authentication_amount_incremental_percentage", n => { CavvAuthenticationAmountIncrementalPercentage = n.GetStringValue(); } },
                { "enable_biometric_bypass_sca_contactless", n => { EnableBiometricBypassScaContactless = n.GetBoolValue(); } },
                { "enable_cavv_authentication_amount_validation", n => { EnableCavvAuthenticationAmountValidation = n.GetBoolValue(); } },
                { "enable_issuer_tra_exemption", n => { EnableIssuerTraExemption = n.GetBoolValue(); } },
                { "sca_contactless_cumulative_amount_limit", n => { ScaContactlessCumulativeAmountLimit = n.GetDoubleValue(); } },
                { "sca_contactless_transaction_limit", n => { ScaContactlessTransactionLimit = n.GetDoubleValue(); } },
                { "sca_contactless_transactions_count_limit", n => { ScaContactlessTransactionsCountLimit = n.GetIntValue(); } },
                { "sca_contactless_transactions_currency", n => { ScaContactlessTransactionsCurrency = n.GetStringValue(); } },
                { "sca_lvp_cumulative_amount_limit", n => { ScaLvpCumulativeAmountLimit = n.GetDoubleValue(); } },
                { "sca_lvp_transaction_limit", n => { ScaLvpTransactionLimit = n.GetDoubleValue(); } },
                { "sca_lvp_transactions_count_limit", n => { ScaLvpTransactionsCountLimit = n.GetIntValue(); } },
                { "sca_lvp_transactions_currency", n => { ScaLvpTransactionsCurrency = n.GetStringValue(); } },
                { "sca_tra_exemption_amount_limit", n => { ScaTraExemptionAmountLimit = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("cavv_authentication_amount_incremental_percentage", CavvAuthenticationAmountIncrementalPercentage);
            writer.WriteBoolValue("enable_biometric_bypass_sca_contactless", EnableBiometricBypassScaContactless);
            writer.WriteBoolValue("enable_cavv_authentication_amount_validation", EnableCavvAuthenticationAmountValidation);
            writer.WriteBoolValue("enable_issuer_tra_exemption", EnableIssuerTraExemption);
            writer.WriteDoubleValue("sca_contactless_cumulative_amount_limit", ScaContactlessCumulativeAmountLimit);
            writer.WriteDoubleValue("sca_contactless_transaction_limit", ScaContactlessTransactionLimit);
            writer.WriteIntValue("sca_contactless_transactions_count_limit", ScaContactlessTransactionsCountLimit);
            writer.WriteStringValue("sca_contactless_transactions_currency", ScaContactlessTransactionsCurrency);
            writer.WriteDoubleValue("sca_lvp_cumulative_amount_limit", ScaLvpCumulativeAmountLimit);
            writer.WriteDoubleValue("sca_lvp_transaction_limit", ScaLvpTransactionLimit);
            writer.WriteIntValue("sca_lvp_transactions_count_limit", ScaLvpTransactionsCountLimit);
            writer.WriteStringValue("sca_lvp_transactions_currency", ScaLvpTransactionsCurrency);
            writer.WriteDoubleValue("sca_tra_exemption_amount_limit", ScaTraExemptionAmountLimit);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
