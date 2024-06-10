// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models
{
    /// <summary>
    /// Contains information on how a credit account is used and what types of balances are permitted on the account.
    /// </summary>
    public class AccountUsageUpdateReq : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Contains one or more annual percentage rates (APRs) associated with the credit account.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Marqeta.Core.Sdk.Models.AprScheduleUpdateReq>? Aprs { get; set; }
#nullable restore
#else
        public List<Marqeta.Core.Sdk.Models.AprScheduleUpdateReq> Aprs { get; set; }
#endif
        /// <summary>Type of balance.* `PURCHASE` - The balance on purchases.</summary>
        public Marqeta.Core.Sdk.Models.BalanceType? Type { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Models.AccountUsageUpdateReq"/> and sets the default values.
        /// </summary>
        public AccountUsageUpdateReq()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Models.AccountUsageUpdateReq"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Marqeta.Core.Sdk.Models.AccountUsageUpdateReq CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Marqeta.Core.Sdk.Models.AccountUsageUpdateReq();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "aprs", n => { Aprs = n.GetCollectionOfObjectValues<Marqeta.Core.Sdk.Models.AprScheduleUpdateReq>(Marqeta.Core.Sdk.Models.AprScheduleUpdateReq.CreateFromDiscriminatorValue)?.ToList(); } },
                { "type", n => { Type = n.GetEnumValue<Marqeta.Core.Sdk.Models.BalanceType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<Marqeta.Core.Sdk.Models.AprScheduleUpdateReq>("aprs", Aprs);
            writer.WriteEnumValue<Marqeta.Core.Sdk.Models.BalanceType>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
