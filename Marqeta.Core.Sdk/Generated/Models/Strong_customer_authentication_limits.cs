// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Marqeta.Core.Sdk.Models
{
    /// <summary>
    /// Contains information about Strong Customer Authentication (SCA) behavior for contactless point-of-sale (POS) and low-value payment (LVP) e-commerce transactions.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Strong_customer_authentication_limits : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>If you have enabled CAVV authentication amount validation, the value of this field specifies the maximum allowable variance between the authorization amount and the 3D Secure authentication amount.Expressed as a percentage.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CavvAuthenticationAmountIncrementalPercentage { get; set; }
#nullable restore
#else
        public string CavvAuthenticationAmountIncrementalPercentage { get; set; }
#endif
        /// <summary>If set to `true`, Marqeta validates the amount in the authorization transaction against the amount in the 3D Secure authentication attempt.If the authorization amount is greater than the 3D Secure authentication amount, Marqeta rejects the transaction.You can specify an allowable variance for the 3D Secure authentication amount in the `cavv_authentication_amount_incremental_percentage` field.</summary>
        public bool? EnableCavvAuthenticationAmountValidation { get; set; }
        /// <summary>Specifies the cumulative limit of transactions the cardholder can perform before receiving an SCA challenge.A value of `0` in this field means that the cumulative amount spent in contactless POS transactions performed by the cardholder does not impact the decision of whether or not an SCA challenge is served.</summary>
        public double? ScaContactlessCumulativeAmountLimit { get; set; }
        /// <summary>Specifies the maximum allowable amount for a single contactless point-of-sale (POS) transaction, above which the cardholder receives a strong customer authentication (SCA) challenge.A value of `0` in this field means that the amount of any single contactless POS transaction performed by the cardholder does not impact the decision of whether or not an SCA challenge is served.</summary>
        public double? ScaContactlessTransactionLimit { get; set; }
        /// <summary>Specifies the number of contactless POS transactions the cardholder can perform before receiving an SCA challenge.A value of `0` in this field means that the number of contactless POS transactions performed by the cardholder does not impact the decision of whether or not an SCA challenge is served.</summary>
        public int? ScaContactlessTransactionsCountLimit { get; set; }
        /// <summary>Specifies the currency type for contactless POS transactions.This field is required if either the `sca_contactless_transaction_limit` field or the `sca_contactless_cumulative_amount_limit` field in this object contains a value, even if that value is `0`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ScaContactlessTransactionsCurrency { get; set; }
#nullable restore
#else
        public string ScaContactlessTransactionsCurrency { get; set; }
#endif
        /// <summary>Specifies the cumulative limit of LVP e-commerce transactions the cardholder can perform before receiving an SCA challenge.For example, if you set the value of this field to `100.00`, your cardholder can perform two transactions for `30.00` and two transactions for `20.00` before receiving an SCA challenge.If you leave this field blank, the cumulative amount spent in LVP e-commerce transactions performed by the cardholder does not impact the decision of whether or not an SCA challenge is served.</summary>
        public double? ScaLvpCumulativeAmountLimit { get; set; }
        /// <summary>Specifies the maximum allowable amount for a single low-value payment (LVP) e-commerce transaction, above which the cardholder receives a strong customer authentication (SCA) challenge.If you leave this field blank, the amount of any single LVP e-commerce transaction performed by the cardholder does not impact the decision of whether or not an SCA challenge is served.</summary>
        public double? ScaLvpTransactionLimit { get; set; }
        /// <summary>Specifies the number of LVP e-commerce transactions the cardholder can perform before receiving an SCA challenge.If you leave this field blank, the total number of LVP e-commerce transactions performed by the cardholder does not impact the decision of whether or not an SCA challenge is served.</summary>
        public int? ScaLvpTransactionsCountLimit { get; set; }
        /// <summary>Specifies the currency type for LVP e-commerce transaction limits.This field is required if any one of the `sca_lvp_transaction_limit`, `sca_lvp_cumulative_amount_limit`, or `sca_lvp_transactions_count_limit` fields in this object contains a value, even if that value is `0`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ScaLvpTransactionsCurrency { get; set; }
#nullable restore
#else
        public string ScaLvpTransactionsCurrency { get; set; }
#endif
        /// <summary>Specifies the maximum allowable amount for a single low-value payment (LVP) e-commerce transaction with transaction risk analysis (TRA) exemption sent by the merchant or acquirer.If the transaction amount exceeds the specified limit, then the transaction is either approved or it receives a strong customer authentication (SCA) challenge based on `sca_lvp_transaction_limit` and `sca_lvp_transactions_currency`.</summary>
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
                { "enable_cavv_authentication_amount_validation", n => { EnableCavvAuthenticationAmountValidation = n.GetBoolValue(); } },
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
            writer.WriteBoolValue("enable_cavv_authentication_amount_validation", EnableCavvAuthenticationAmountValidation);
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
