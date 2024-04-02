// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    /// <summary>
    /// Contains information returned when configuring an account&apos;s billing cycle day, payment due day, fees, and more.
    /// </summary>
    public class AccountConfigResponse : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Day of month the billing cycle starts.</summary>
        public int? BillingCycleDay { get; set; }
        /// <summary>The level of the credit card.</summary>
        public AccountConfigResponse_card_level? CardLevel { get; set; }
        /// <summary>A value of `true` indicates that the account holder consents to receiving disclosures and statements electronically.</summary>
        public bool? EDisclosureActive { get; set; }
        /// <summary>Contains one or more fees associated with the credit account.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ConfigFeeScheduleResponse>? Fees { get; set; }
#nullable restore
#else
        public List<ConfigFeeScheduleResponse> Fees { get; set; }
#endif
        /// <summary>Contains configurations for a minimum payment override on a credit account, which overrides the minimum payment configurations on the associated credit product.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AccountConfigMinPayment? MinPayment { get; set; }
#nullable restore
#else
        public AccountConfigMinPayment MinPayment { get; set; }
#endif
        /// <summary>Day of month the payment for the previous billing cycle is due.</summary>
        public int? PaymentDueDay { get; set; }
        /// <summary>Contains configurations for a payment hold.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AccountConfigPaymentHolds? PaymentHolds { get; set; }
#nullable restore
#else
        public AccountConfigPaymentHolds PaymentHolds { get; set; }
#endif
        /// <summary>Contains one or more rewards associated with the credit account.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AccountReward>? Rewards { get; set; }
#nullable restore
#else
        public List<AccountReward> Rewards { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="AccountConfigResponse"/> and sets the default values.
        /// </summary>
        public AccountConfigResponse() {
            AdditionalData = new Dictionary<string, object>();
            CardLevel = AccountConfigResponse_card_level.NA;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AccountConfigResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AccountConfigResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccountConfigResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"billing_cycle_day", n => { BillingCycleDay = n.GetIntValue(); } },
                {"card_level", n => { CardLevel = n.GetEnumValue<AccountConfigResponse_card_level>(); } },
                {"e_disclosure_active", n => { EDisclosureActive = n.GetBoolValue(); } },
                {"fees", n => { Fees = n.GetCollectionOfObjectValues<ConfigFeeScheduleResponse>(ConfigFeeScheduleResponse.CreateFromDiscriminatorValue)?.ToList(); } },
                {"min_payment", n => { MinPayment = n.GetObjectValue<AccountConfigMinPayment>(AccountConfigMinPayment.CreateFromDiscriminatorValue); } },
                {"payment_due_day", n => { PaymentDueDay = n.GetIntValue(); } },
                {"payment_holds", n => { PaymentHolds = n.GetObjectValue<AccountConfigPaymentHolds>(AccountConfigPaymentHolds.CreateFromDiscriminatorValue); } },
                {"rewards", n => { Rewards = n.GetCollectionOfObjectValues<AccountReward>(AccountReward.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("billing_cycle_day", BillingCycleDay);
            writer.WriteEnumValue<AccountConfigResponse_card_level>("card_level", CardLevel);
            writer.WriteBoolValue("e_disclosure_active", EDisclosureActive);
            writer.WriteCollectionOfObjectValues<ConfigFeeScheduleResponse>("fees", Fees);
            writer.WriteObjectValue<AccountConfigMinPayment>("min_payment", MinPayment);
            writer.WriteIntValue("payment_due_day", PaymentDueDay);
            writer.WriteObjectValue<AccountConfigPaymentHolds>("payment_holds", PaymentHolds);
            writer.WriteCollectionOfObjectValues<AccountReward>("rewards", Rewards);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}