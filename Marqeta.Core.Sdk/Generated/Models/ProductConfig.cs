// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models
{
    /// <summary>
    /// Contains information on configurations for billing cycle day, payment due day, and fees.
    /// </summary>
    public class ProductConfig : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Day of month the billing cycle starts.</summary>
        public int? BillingCycleDay { get; set; }
        /// <summary>Determines if the billing cycle day is manually set or determined dynamically during account creation based on cycling logic.</summary>
        public Marqeta.Core.Sdk.Models.ProductConfig_billing_cycle_day_strategy? BillingCycleDayStrategy { get; set; }
        /// <summary>Frequency at which your account is billed.</summary>
        public Marqeta.Core.Sdk.Models.ProductConfig_billing_cycle_frequency? BillingCycleFrequency { get; set; }
        /// <summary>One or more fee types.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Marqeta.Core.Sdk.Models.ProductFeeType?>? Fees { get; set; }
#nullable restore
#else
        public List<Marqeta.Core.Sdk.Models.ProductFeeType?> Fees { get; set; }
#endif
        /// <summary>Day of month the payment for the previous billing cycle is due.This field is deprecated.Use the `product.payment_due_interval` field instead.To retrieve `payment_due_interval`, see &lt;&lt;/core-api/credit-products#retrieveProduct, Retrieve credit product, config.payment_due_interval&gt;&gt;.</summary>
        [Obsolete("")]
        public int? PaymentDueDay { get; set; }
        /// <summary>Specifies the payment due interval that is used to determine the payment due date for a billing cycle.The accepted values are either -1 or a value between 1 and 26.A value of -1 indicates one day prior to the next billing cycle date.</summary>
        public int? PaymentDueInterval { get; set; }
        /// <summary>Contains one or more periodic fees.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Marqeta.Core.Sdk.Models.ProductConfig_periodic_fees>? PeriodicFees { get; set; }
#nullable restore
#else
        public List<Marqeta.Core.Sdk.Models.ProductConfig_periodic_fees> PeriodicFees { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Models.ProductConfig"/> and sets the default values.
        /// </summary>
        public ProductConfig()
        {
            AdditionalData = new Dictionary<string, object>();
            BillingCycleDayStrategy = Marqeta.Core.Sdk.Models.ProductConfig_billing_cycle_day_strategy.MANUAL;
            BillingCycleFrequency = Marqeta.Core.Sdk.Models.ProductConfig_billing_cycle_frequency.MONTHLY;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Models.ProductConfig"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Marqeta.Core.Sdk.Models.ProductConfig CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Marqeta.Core.Sdk.Models.ProductConfig();
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
                { "billing_cycle_day_strategy", n => { BillingCycleDayStrategy = n.GetEnumValue<Marqeta.Core.Sdk.Models.ProductConfig_billing_cycle_day_strategy>(); } },
                { "billing_cycle_frequency", n => { BillingCycleFrequency = n.GetEnumValue<Marqeta.Core.Sdk.Models.ProductConfig_billing_cycle_frequency>(); } },
                { "fees", n => { Fees = n.GetCollectionOfEnumValues<Marqeta.Core.Sdk.Models.ProductFeeType>()?.ToList(); } },
                { "payment_due_day", n => { PaymentDueDay = n.GetIntValue(); } },
                { "payment_due_interval", n => { PaymentDueInterval = n.GetIntValue(); } },
                { "periodic_fees", n => { PeriodicFees = n.GetCollectionOfObjectValues<Marqeta.Core.Sdk.Models.ProductConfig_periodic_fees>(Marqeta.Core.Sdk.Models.ProductConfig_periodic_fees.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteEnumValue<Marqeta.Core.Sdk.Models.ProductConfig_billing_cycle_day_strategy>("billing_cycle_day_strategy", BillingCycleDayStrategy);
            writer.WriteEnumValue<Marqeta.Core.Sdk.Models.ProductConfig_billing_cycle_frequency>("billing_cycle_frequency", BillingCycleFrequency);
            writer.WriteCollectionOfEnumValues<Marqeta.Core.Sdk.Models.ProductFeeType>("fees", Fees);
            writer.WriteIntValue("payment_due_day", PaymentDueDay);
            writer.WriteIntValue("payment_due_interval", PaymentDueInterval);
            writer.WriteCollectionOfObjectValues<Marqeta.Core.Sdk.Models.ProductConfig_periodic_fees>("periodic_fees", PeriodicFees);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
