// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models
{
    /// <summary>
    /// Contains information relevant for configuring an account&apos;s billing cycle day, payment due day, fees, and more.
    /// </summary>
    public class AccountConfigReq : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Day of month the billing cycle starts. If an override value is not provided, the default value is derived from the bundle.</summary>
        public int? BillingCycleDay { get; set; }
        /// <summary>Level of the credit card.</summary>
        public Marqeta.Core.Sdk.Models.AccountConfigReq_card_level? CardLevel { get; set; }
        /// <summary>A value of `true` indicates that the account holder consents to receiving disclosures and statements electronically.</summary>
        public bool? EDisclosureActive { get; set; }
        /// <summary>Contains one or more fees associated with the credit account.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Marqeta.Core.Sdk.Models.ConfigFeeScheduleReq>? Fees { get; set; }
#nullable restore
#else
        public List<Marqeta.Core.Sdk.Models.ConfigFeeScheduleReq> Fees { get; set; }
#endif
        /// <summary>Day of month the payment for the previous billing cycle is due.This field is deprecated.Use the `account.payment_due_interval` field instead.To retrieve `payment_due_interval`, see &lt;&lt;/core-api/policies#retrieveProductPolicy, Retrieve credit product policy, payments.payment_due_interval&gt;&gt;.</summary>
        [Obsolete("")]
        public int? PaymentDueDay { get; set; }
        /// <summary>Contains configurations for a payment hold.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Marqeta.Core.Sdk.Models.AccountConfigPaymentHolds? PaymentHolds { get; set; }
#nullable restore
#else
        public Marqeta.Core.Sdk.Models.AccountConfigPaymentHolds PaymentHolds { get; set; }
#endif
        /// <summary>Contains one or more rewards associated with the credit account.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Marqeta.Core.Sdk.Models.AccountReward>? Rewards { get; set; }
#nullable restore
#else
        public List<Marqeta.Core.Sdk.Models.AccountReward> Rewards { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Models.AccountConfigReq"/> and sets the default values.
        /// </summary>
        public AccountConfigReq()
        {
            AdditionalData = new Dictionary<string, object>();
            CardLevel = Marqeta.Core.Sdk.Models.AccountConfigReq_card_level.NA;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Models.AccountConfigReq"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Marqeta.Core.Sdk.Models.AccountConfigReq CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Marqeta.Core.Sdk.Models.AccountConfigReq();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "billing_cycle_day", n => { BillingCycleDay = n.GetIntValue(); } },
                { "card_level", n => { CardLevel = n.GetEnumValue<Marqeta.Core.Sdk.Models.AccountConfigReq_card_level>(); } },
                { "e_disclosure_active", n => { EDisclosureActive = n.GetBoolValue(); } },
                { "fees", n => { Fees = n.GetCollectionOfObjectValues<Marqeta.Core.Sdk.Models.ConfigFeeScheduleReq>(Marqeta.Core.Sdk.Models.ConfigFeeScheduleReq.CreateFromDiscriminatorValue)?.ToList(); } },
                { "payment_due_day", n => { PaymentDueDay = n.GetIntValue(); } },
                { "payment_holds", n => { PaymentHolds = n.GetObjectValue<Marqeta.Core.Sdk.Models.AccountConfigPaymentHolds>(Marqeta.Core.Sdk.Models.AccountConfigPaymentHolds.CreateFromDiscriminatorValue); } },
                { "rewards", n => { Rewards = n.GetCollectionOfObjectValues<Marqeta.Core.Sdk.Models.AccountReward>(Marqeta.Core.Sdk.Models.AccountReward.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("billing_cycle_day", BillingCycleDay);
            writer.WriteEnumValue<Marqeta.Core.Sdk.Models.AccountConfigReq_card_level>("card_level", CardLevel);
            writer.WriteBoolValue("e_disclosure_active", EDisclosureActive);
            writer.WriteCollectionOfObjectValues<Marqeta.Core.Sdk.Models.ConfigFeeScheduleReq>("fees", Fees);
            writer.WriteIntValue("payment_due_day", PaymentDueDay);
            writer.WriteObjectValue<Marqeta.Core.Sdk.Models.AccountConfigPaymentHolds>("payment_holds", PaymentHolds);
            writer.WriteCollectionOfObjectValues<Marqeta.Core.Sdk.Models.AccountReward>("rewards", Rewards);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
