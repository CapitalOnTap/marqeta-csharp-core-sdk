// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    /// <summary>
    /// Contains one or more fraud determinations by the card network that apply to either the transaction or the cardholder&apos;s account.
    /// </summary>
    public class Fraud_view : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Contains one or more fraud determinations by the card network that apply to either the transaction or the cardholder&apos;s account.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Issuer_fraud_view? IssuerProcessor { get; set; }
#nullable restore
#else
        public Issuer_fraud_view IssuerProcessor { get; set; }
#endif
        /// <summary>Contains network-provided information about fraud determinations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Network_fraud_view? Network { get; set; }
#nullable restore
#else
        public Network_fraud_view Network { get; set; }
#endif
        /// <summary>Account intelligence score information, as provided by the Mastercard network.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Network_account_intelligence_score? NetworkAccountIntelligenceScore { get; set; }
#nullable restore
#else
        public Network_account_intelligence_score NetworkAccountIntelligenceScore { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Fraud_view"/> and sets the default values.
        /// </summary>
        public Fraud_view() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Fraud_view"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Fraud_view CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Fraud_view();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"issuer_processor", n => { IssuerProcessor = n.GetObjectValue<Issuer_fraud_view>(Issuer_fraud_view.CreateFromDiscriminatorValue); } },
                {"network", n => { Network = n.GetObjectValue<Network_fraud_view>(Network_fraud_view.CreateFromDiscriminatorValue); } },
                {"network_account_intelligence_score", n => { NetworkAccountIntelligenceScore = n.GetObjectValue<Network_account_intelligence_score>(Network_account_intelligence_score.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Issuer_fraud_view>("issuer_processor", IssuerProcessor);
            writer.WriteObjectValue<Network_fraud_view>("network", Network);
            writer.WriteObjectValue<Network_account_intelligence_score>("network_account_intelligence_score", NetworkAccountIntelligenceScore);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
