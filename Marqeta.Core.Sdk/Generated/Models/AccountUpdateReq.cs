// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    public class AccountUpdateReq : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Contains information relevant for updating configurations for electronic disclosures, fees, payment holds, and minimum payment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AccountConfigUpdateReq? Config { get; set; }
#nullable restore
#else
        public AccountConfigUpdateReq Config { get; set; }
#endif
        /// <summary>Contains information on the credit limit.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AccountUpdateReq_credit_limit? CreditLimit { get; set; }
#nullable restore
#else
        public AccountUpdateReq_credit_limit CreditLimit { get; set; }
#endif
        /// <summary>Type of cycle.* `BEGINNING_REVOLVING` - Account is beginning to revolve and just started carrying a balancefrom the previous month.* `REVOLVING` - Account is revolving and has been carrying a balance from month to month for more than one month.* `END_REVOLVING` - Account is no longer revolving and the previous month&apos;s balance is paid off.* `TRANSACTING` - Account is not revolving and the balance is paid off each month.</summary>
        public CycleType? LatestStatementCycleType { get; set; }
        /// <summary>Contains one or more `usages` objects that contain information on how a credit account is used and what types of balances are permitted on the account.You can pass only one `usages` object per `usages.type`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AccountUsageUpdateReq>? Usages { get; set; }
#nullable restore
#else
        public List<AccountUsageUpdateReq> Usages { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="AccountUpdateReq"/> and sets the default values.
        /// </summary>
        public AccountUpdateReq() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AccountUpdateReq"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AccountUpdateReq CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccountUpdateReq();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"config", n => { Config = n.GetObjectValue<AccountConfigUpdateReq>(AccountConfigUpdateReq.CreateFromDiscriminatorValue); } },
                {"credit_limit", n => { CreditLimit = n.GetObjectValue<AccountUpdateReq_credit_limit>(AccountUpdateReq_credit_limit.CreateFromDiscriminatorValue); } },
                {"latest_statement_cycle_type", n => { LatestStatementCycleType = n.GetEnumValue<CycleType>(); } },
                {"usages", n => { Usages = n.GetCollectionOfObjectValues<AccountUsageUpdateReq>(AccountUsageUpdateReq.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<AccountConfigUpdateReq>("config", Config);
            writer.WriteObjectValue<AccountUpdateReq_credit_limit>("credit_limit", CreditLimit);
            writer.WriteEnumValue<CycleType>("latest_statement_cycle_type", LatestStatementCycleType);
            writer.WriteCollectionOfObjectValues<AccountUsageUpdateReq>("usages", Usages);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}