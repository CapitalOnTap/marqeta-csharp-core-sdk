// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models
{
    #pragma warning disable CS1591
    public class Msa_aggregated_balances : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The available_balance property</summary>
        public double? AvailableBalance { get; set; }
        /// <summary>The balances property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Marqeta.Core.Sdk.Models.Msa_aggregated_balances_balances? Balances { get; set; }
#nullable restore
#else
        public Marqeta.Core.Sdk.Models.Msa_aggregated_balances_balances Balances { get; set; }
#endif
        /// <summary>The cached_balance property</summary>
        public double? CachedBalance { get; set; }
        /// <summary>The credit_balance property</summary>
        public double? CreditBalance { get; set; }
        /// <summary>The currency_code property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CurrencyCode { get; set; }
#nullable restore
#else
        public string CurrencyCode { get; set; }
#endif
        /// <summary>The impacted_amount property</summary>
        public double? ImpactedAmount { get; set; }
        /// <summary>The last_updated_time property</summary>
        public DateTimeOffset? LastUpdatedTime { get; set; }
        /// <summary>The ledger_balance property</summary>
        public double? LedgerBalance { get; set; }
        /// <summary>The pending_credits property</summary>
        public double? PendingCredits { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Models.Msa_aggregated_balances"/> and sets the default values.
        /// </summary>
        public Msa_aggregated_balances()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Models.Msa_aggregated_balances"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Marqeta.Core.Sdk.Models.Msa_aggregated_balances CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Marqeta.Core.Sdk.Models.Msa_aggregated_balances();
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
                { "balances", n => { Balances = n.GetObjectValue<Marqeta.Core.Sdk.Models.Msa_aggregated_balances_balances>(Marqeta.Core.Sdk.Models.Msa_aggregated_balances_balances.CreateFromDiscriminatorValue); } },
                { "cached_balance", n => { CachedBalance = n.GetDoubleValue(); } },
                { "credit_balance", n => { CreditBalance = n.GetDoubleValue(); } },
                { "currency_code", n => { CurrencyCode = n.GetStringValue(); } },
                { "impacted_amount", n => { ImpactedAmount = n.GetDoubleValue(); } },
                { "last_updated_time", n => { LastUpdatedTime = n.GetDateTimeOffsetValue(); } },
                { "ledger_balance", n => { LedgerBalance = n.GetDoubleValue(); } },
                { "pending_credits", n => { PendingCredits = n.GetDoubleValue(); } },
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
            writer.WriteObjectValue<Marqeta.Core.Sdk.Models.Msa_aggregated_balances_balances>("balances", Balances);
            writer.WriteDoubleValue("cached_balance", CachedBalance);
            writer.WriteDoubleValue("credit_balance", CreditBalance);
            writer.WriteStringValue("currency_code", CurrencyCode);
            writer.WriteDoubleValue("impacted_amount", ImpactedAmount);
            writer.WriteDateTimeOffsetValue("last_updated_time", LastUpdatedTime);
            writer.WriteDoubleValue("ledger_balance", LedgerBalance);
            writer.WriteDoubleValue("pending_credits", PendingCredits);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
