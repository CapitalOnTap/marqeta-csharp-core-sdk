// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Marqeta.Core.Sdk.SimulationsV2.Models
{
    /// <summary>
    /// Contains information about the GPA balances and pending credits.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class TransactionModel_gpa : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Ledger balance minus any authorized transactions that have not yet cleared.Also known as the cardholder&apos;s purchasing power.When using JIT Funding, this balance is usually equal to $0.00.</summary>
        public double? AvailableBalance { get; set; }
        /// <summary>Balance change based on the amount of the transaction.</summary>
        public double? ImpactedAmount { get; set; }
        /// <summary>When using standard funding: The funds that are available to spend immediately, including funds from any authorized transactions that have not yet cleared.When using Just-in-Time (JIT) Funding: Authorized funds that are currently on hold, but not yet cleared.</summary>
        public double? LedgerBalance { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.SimulationsV2.Models.TransactionModel_gpa"/> and sets the default values.
        /// </summary>
        public TransactionModel_gpa()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.SimulationsV2.Models.TransactionModel_gpa"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.SimulationsV2.Models.TransactionModel_gpa CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.SimulationsV2.Models.TransactionModel_gpa();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "available_balance", n => { AvailableBalance = n.GetDoubleValue(); } },
                { "impacted_amount", n => { ImpactedAmount = n.GetDoubleValue(); } },
                { "ledger_balance", n => { LedgerBalance = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("available_balance", AvailableBalance);
            writer.WriteDoubleValue("impacted_amount", ImpactedAmount);
            writer.WriteDoubleValue("ledger_balance", LedgerBalance);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
