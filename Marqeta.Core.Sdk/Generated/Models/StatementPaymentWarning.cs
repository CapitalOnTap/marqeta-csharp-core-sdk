// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models
{
    /// <summary>
    /// Contains information on statement payment warnings.
    /// </summary>
    public class StatementPaymentWarning : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Statement disclosure in the case of negative or no amortization, or no lifetime repayment for the minimum payment warning type.* `NEGATIVE_OR_NO_AMORTIZATION` - Occurs when the interest amount is higher than the minimum payment; results in the outstanding balance remaining in perpetuity.* `NO_LIFETIME_REPAYMENT` - Occurs when the interest amount is just below the minimum payment; results in the outstanding balance taking longer than a lifetime to pay off.</summary>
        public Marqeta.Core.Sdk.Models.StatementPaymentWarning_disclosure? Disclosure { get; set; }
        /// <summary>For the minimum payment warning type, this value represents the total amount of interest to pay off the statement balance if only making the minimum payment each month.For the 3 Year warning type, this value represents the total amount of interest if paying off the statement balance in three years.</summary>
        public double? InterestPaid { get; set; }
        /// <summary>For the minimum payment warning type, this value is 0.For the 3 Year warning type, this value represents the fixed monthly payment amount required to pay off the statement balance in three years.</summary>
        public double? MonthlyPayment { get; set; }
        /// <summary>For the minimum payment warning type, this value represents the number of periods required to pay off the statement balance.For the 3 Year warning type, this value is 36 (months).</summary>
        public int? PayOffPeriod { get; set; }
        /// <summary>Time unit of the pay off period.</summary>
        public Marqeta.Core.Sdk.Models.StatementPaymentWarning_period_type? PeriodType { get; set; }
        /// <summary>For the minimum payment warning type, this value represents the total amount of principal and interest to pay off the statement balance if only making the minimum payment each month.For the 3 Year warning type, this value represents the total amount of principal and interest if paying off the statement balance in three years.</summary>
        public double? TotalPaid { get; set; }
        /// <summary>Type of statement warning.* `MIN_PAYMENT` - Displays the total estimated payment amount and how long it would take to pay off the statement balance if only making minimum payments.* `3_YEAR` - Displays the monthly payment amount and total estimated payment amount if paying off the statement balance in three years.</summary>
        public Marqeta.Core.Sdk.Models.StatementPaymentWarning_type? Type { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Models.StatementPaymentWarning"/> and sets the default values.
        /// </summary>
        public StatementPaymentWarning()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Models.StatementPaymentWarning"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Marqeta.Core.Sdk.Models.StatementPaymentWarning CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Marqeta.Core.Sdk.Models.StatementPaymentWarning();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "disclosure", n => { Disclosure = n.GetEnumValue<Marqeta.Core.Sdk.Models.StatementPaymentWarning_disclosure>(); } },
                { "interest_paid", n => { InterestPaid = n.GetDoubleValue(); } },
                { "monthly_payment", n => { MonthlyPayment = n.GetDoubleValue(); } },
                { "pay_off_period", n => { PayOffPeriod = n.GetIntValue(); } },
                { "period_type", n => { PeriodType = n.GetEnumValue<Marqeta.Core.Sdk.Models.StatementPaymentWarning_period_type>(); } },
                { "total_paid", n => { TotalPaid = n.GetDoubleValue(); } },
                { "type", n => { Type = n.GetEnumValue<Marqeta.Core.Sdk.Models.StatementPaymentWarning_type>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<Marqeta.Core.Sdk.Models.StatementPaymentWarning_disclosure>("disclosure", Disclosure);
            writer.WriteDoubleValue("interest_paid", InterestPaid);
            writer.WriteDoubleValue("monthly_payment", MonthlyPayment);
            writer.WriteIntValue("pay_off_period", PayOffPeriod);
            writer.WriteEnumValue<Marqeta.Core.Sdk.Models.StatementPaymentWarning_period_type>("period_type", PeriodType);
            writer.WriteDoubleValue("total_paid", TotalPaid);
            writer.WriteEnumValue<Marqeta.Core.Sdk.Models.StatementPaymentWarning_type>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}