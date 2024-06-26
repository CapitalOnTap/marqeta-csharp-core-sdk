// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models
{
    /// <summary>
    /// Contains the configurations for billing cycle day, payment due day, and fees.
    /// </summary>
    public class PolicyProductPaymentConfiguration : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Ordered list of balance types to which payments are allocated, from first to last.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Marqeta.Core.Sdk.Models.PaymentAllocationOrderEnum?>? AllocationOrder { get; set; }
#nullable restore
#else
        public List<Marqeta.Core.Sdk.Models.PaymentAllocationOrderEnum?> AllocationOrder { get; set; }
#endif
        /// <summary>Day of month the billing cycle starts.</summary>
        public int? BillingCycleDay { get; set; }
        /// <summary>Determines if the billing cycle day is manually set or determined dynamically during account creation based on cycling logic.</summary>
        public Marqeta.Core.Sdk.Models.PolicyProductPaymentConfiguration_billing_cycle_day_strategy? BillingCycleDayStrategy { get; set; }
        /// <summary>Frequency at which your account is billed.</summary>
        public Marqeta.Core.Sdk.Models.PolicyProductPaymentConfiguration_billing_cycle_frequency? BillingCycleFrequency { get; set; }
        /// <summary>Day of month the payment for the previous billing cycle is due.This field is being deprecated and replaced by `payment_due_interval` of a product policy.To retrieve `payment_due_interval`, see &lt;&lt;/core-api/policies#retrieveProductPolicy, Retrieve credit product policy, payments.payment_due_interval&gt;&gt;.</summary>
        [Obsolete("")]
        public int? DueDay { get; set; }
        /// <summary>Contains information used to calculate the minimum payment amount on a credit product policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Marqeta.Core.Sdk.Models.PolicyProductMinPaymentCalculation? MinPaymentCalculation { get; set; }
#nullable restore
#else
        public Marqeta.Core.Sdk.Models.PolicyProductMinPaymentCalculation MinPaymentCalculation { get; set; }
#endif
        /// <summary>Specifies the payment due interval that is used to determine the payment due date for a billing cycle.The accepted values are either -1 or a value between 1 and 26.A value of -1 indicates one day prior to the next billing cycle date</summary>
        public int? PaymentDueInterval { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Models.PolicyProductPaymentConfiguration"/> and sets the default values.
        /// </summary>
        public PolicyProductPaymentConfiguration()
        {
            AdditionalData = new Dictionary<string, object>();
            BillingCycleDayStrategy = Marqeta.Core.Sdk.Models.PolicyProductPaymentConfiguration_billing_cycle_day_strategy.MANUAL;
            BillingCycleFrequency = Marqeta.Core.Sdk.Models.PolicyProductPaymentConfiguration_billing_cycle_frequency.MONTHLY;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Models.PolicyProductPaymentConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Marqeta.Core.Sdk.Models.PolicyProductPaymentConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Marqeta.Core.Sdk.Models.PolicyProductPaymentConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "allocation_order", n => { AllocationOrder = n.GetCollectionOfEnumValues<Marqeta.Core.Sdk.Models.PaymentAllocationOrderEnum>()?.ToList(); } },
                { "billing_cycle_day", n => { BillingCycleDay = n.GetIntValue(); } },
                { "billing_cycle_day_strategy", n => { BillingCycleDayStrategy = n.GetEnumValue<Marqeta.Core.Sdk.Models.PolicyProductPaymentConfiguration_billing_cycle_day_strategy>(); } },
                { "billing_cycle_frequency", n => { BillingCycleFrequency = n.GetEnumValue<Marqeta.Core.Sdk.Models.PolicyProductPaymentConfiguration_billing_cycle_frequency>(); } },
                { "due_day", n => { DueDay = n.GetIntValue(); } },
                { "min_payment_calculation", n => { MinPaymentCalculation = n.GetObjectValue<Marqeta.Core.Sdk.Models.PolicyProductMinPaymentCalculation>(Marqeta.Core.Sdk.Models.PolicyProductMinPaymentCalculation.CreateFromDiscriminatorValue); } },
                { "payment_due_interval", n => { PaymentDueInterval = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfEnumValues<Marqeta.Core.Sdk.Models.PaymentAllocationOrderEnum>("allocation_order", AllocationOrder);
            writer.WriteIntValue("billing_cycle_day", BillingCycleDay);
            writer.WriteEnumValue<Marqeta.Core.Sdk.Models.PolicyProductPaymentConfiguration_billing_cycle_day_strategy>("billing_cycle_day_strategy", BillingCycleDayStrategy);
            writer.WriteEnumValue<Marqeta.Core.Sdk.Models.PolicyProductPaymentConfiguration_billing_cycle_frequency>("billing_cycle_frequency", BillingCycleFrequency);
            writer.WriteIntValue("due_day", DueDay);
            writer.WriteObjectValue<Marqeta.Core.Sdk.Models.PolicyProductMinPaymentCalculation>("min_payment_calculation", MinPaymentCalculation);
            writer.WriteIntValue("payment_due_interval", PaymentDueInterval);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
