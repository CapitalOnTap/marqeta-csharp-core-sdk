// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    /// <summary>
    /// Contains information on how a credit account is used and what types of balances are permitted on the account.
    /// </summary>
    public class AccountUsageResponse : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Contains one or more APRs associated with the type of balance on the credit account.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AprScheduleResponse>? Aprs { get; set; }
#nullable restore
#else
        public List<AprScheduleResponse> Aprs { get; set; }
#endif
        /// <summary>Contains one or more fees associated with the usage type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AccountFee>? Fees { get; set; }
#nullable restore
#else
        public List<AccountFee> Fees { get; set; }
#endif
        /// <summary>Type of balance.* `PURCHASE` - The balance on purchases.</summary>
        public BalanceType? Type { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="AccountUsageResponse"/> and sets the default values.
        /// </summary>
        public AccountUsageResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AccountUsageResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AccountUsageResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccountUsageResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"aprs", n => { Aprs = n.GetCollectionOfObjectValues<AprScheduleResponse>(AprScheduleResponse.CreateFromDiscriminatorValue)?.ToList(); } },
                {"fees", n => { Fees = n.GetCollectionOfObjectValues<AccountFee>(AccountFee.CreateFromDiscriminatorValue)?.ToList(); } },
                {"type", n => { Type = n.GetEnumValue<BalanceType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<AprScheduleResponse>("aprs", Aprs);
            writer.WriteCollectionOfObjectValues<AccountFee>("fees", Fees);
            writer.WriteEnumValue<BalanceType>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
