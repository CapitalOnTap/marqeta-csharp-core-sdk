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
    /// Contains network-provided information about fraud determinations.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Network_fraud_view : IAdditionalDataHolder, IParsable
    {
        /// <summary>_(Visa only)_ Account holder risk condition code evaluated by the card network.A higher score indicates a greater likelihood that the card number is compromised.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountRiskScore { get; set; }
#nullable restore
#else
        public string AccountRiskScore { get; set; }
#endif
        /// <summary>_(Visa only)_ Unique code that describes the main driver of the `account_risk_score`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountRiskScoreReasonCode { get; set; }
#nullable restore
#else
        public string AccountRiskScoreReasonCode { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Network-provided risk score for the transaction.A higher score indicates higher risk.Useful for making authorization decisions.</summary>
        public int? TransactionRiskScore { get; set; }
        /// <summary>_(Mastercard only)_ Unique code that describes the main driver of the `transaction_risk_score`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TransactionRiskScoreReasonCode { get; set; }
#nullable restore
#else
        public string TransactionRiskScoreReasonCode { get; set; }
#endif
        /// <summary>_(Mastercard only)_ Description of the `transaction_risk_score_reason_code`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TransactionRiskScoreReasonDescription { get; set; }
#nullable restore
#else
        public string TransactionRiskScoreReasonDescription { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.Network_fraud_view"/> and sets the default values.
        /// </summary>
        public Network_fraud_view()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.Network_fraud_view"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.Network_fraud_view CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.Network_fraud_view();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "account_risk_score", n => { AccountRiskScore = n.GetStringValue(); } },
                { "account_risk_score_reason_code", n => { AccountRiskScoreReasonCode = n.GetStringValue(); } },
                { "transaction_risk_score", n => { TransactionRiskScore = n.GetIntValue(); } },
                { "transaction_risk_score_reason_code", n => { TransactionRiskScoreReasonCode = n.GetStringValue(); } },
                { "transaction_risk_score_reason_description", n => { TransactionRiskScoreReasonDescription = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("account_risk_score", AccountRiskScore);
            writer.WriteStringValue("account_risk_score_reason_code", AccountRiskScoreReasonCode);
            writer.WriteIntValue("transaction_risk_score", TransactionRiskScore);
            writer.WriteStringValue("transaction_risk_score_reason_code", TransactionRiskScoreReasonCode);
            writer.WriteStringValue("transaction_risk_score_reason_description", TransactionRiskScoreReasonDescription);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
