// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    #pragma warning disable CS1591
    public class Program_reserve_account_balance : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Ledger balance, minus any authorized transactions that have not yet cleared.When using JIT Funding, this balance is usually equal to $0.00.</summary>
        public double? AvailableBalance { get; set; }
        /// <summary>Contains program reserve account balance information, organized by currency code.Sometimes referred to as a _program funding account_.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Program_reserve_account_balance_balances? Balances { get; set; }
#nullable restore
#else
        public Program_reserve_account_balance_balances Balances { get; set; }
#endif
        /// <summary>Not currently in use.</summary>
        public double? CreditBalance { get; set; }
        /// <summary>Three-digit ISO 4217 currency code.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CurrencyCode { get; set; }
#nullable restore
#else
        public string CurrencyCode { get; set; }
#endif
        /// <summary>When using standard funding: The funds that are available to spend immediately, including funds from any authorized transactions that have not yet cleared.When using Just-in-Time (JIT) Funding: Authorized funds that are currently on hold, but not yet cleared.</summary>
        public double? LedgerBalance { get; set; }
        /// <summary>ACH loads that have been accepted, but for which the funding time has not yet elapsed.</summary>
        public double? PendingCredits { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="Program_reserve_account_balance"/> and sets the default values.
        /// </summary>
        public Program_reserve_account_balance()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Program_reserve_account_balance"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Program_reserve_account_balance CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Program_reserve_account_balance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"available_balance", n => { AvailableBalance = n.GetDoubleValue(); } },
                {"balances", n => { Balances = n.GetObjectValue<Program_reserve_account_balance_balances>(Program_reserve_account_balance_balances.CreateFromDiscriminatorValue); } },
                {"credit_balance", n => { CreditBalance = n.GetDoubleValue(); } },
                {"currency_code", n => { CurrencyCode = n.GetStringValue(); } },
                {"ledger_balance", n => { LedgerBalance = n.GetDoubleValue(); } },
                {"pending_credits", n => { PendingCredits = n.GetDoubleValue(); } },
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
            writer.WriteObjectValue<Program_reserve_account_balance_balances>("balances", Balances);
            writer.WriteDoubleValue("credit_balance", CreditBalance);
            writer.WriteStringValue("currency_code", CurrencyCode);
            writer.WriteDoubleValue("ledger_balance", LedgerBalance);
            writer.WriteDoubleValue("pending_credits", PendingCredits);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
