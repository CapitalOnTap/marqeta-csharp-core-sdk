// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models
{
    /// <summary>
    /// Contains information on the fees in an account&apos;s fee policy.
    /// </summary>
    public class PolicyFeeAccount : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Contains information on a specific periodic fee in a fee policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Marqeta.Core.Sdk.Models.PolicyFeePeriodic? AnnualFee { get; set; }
#nullable restore
#else
        public Marqeta.Core.Sdk.Models.PolicyFeePeriodic AnnualFee { get; set; }
#endif
        /// <summary>Contains information on a specific fee in a fee policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Marqeta.Core.Sdk.Models.PolicyFeeForeignTransaction? ForeignTransactionFee { get; set; }
#nullable restore
#else
        public Marqeta.Core.Sdk.Models.PolicyFeeForeignTransaction ForeignTransactionFee { get; set; }
#endif
        /// <summary>Contains information on a specific fee in a fee policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Marqeta.Core.Sdk.Models.PolicyFeePayment? LatePayment { get; set; }
#nullable restore
#else
        public Marqeta.Core.Sdk.Models.PolicyFeePayment LatePayment { get; set; }
#endif
        /// <summary>Contains information on a specific periodic fee in a fee policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Marqeta.Core.Sdk.Models.PolicyFeePeriodic? MonthlyFee { get; set; }
#nullable restore
#else
        public Marqeta.Core.Sdk.Models.PolicyFeePeriodic MonthlyFee { get; set; }
#endif
        /// <summary>Contains information on a specific fee in a fee policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Marqeta.Core.Sdk.Models.PolicyFeePayment? ReturnedPayment { get; set; }
#nullable restore
#else
        public Marqeta.Core.Sdk.Models.PolicyFeePayment ReturnedPayment { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Models.PolicyFeeAccount"/> and sets the default values.
        /// </summary>
        public PolicyFeeAccount()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Models.PolicyFeeAccount"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Marqeta.Core.Sdk.Models.PolicyFeeAccount CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Marqeta.Core.Sdk.Models.PolicyFeeAccount();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "annual_fee", n => { AnnualFee = n.GetObjectValue<Marqeta.Core.Sdk.Models.PolicyFeePeriodic>(Marqeta.Core.Sdk.Models.PolicyFeePeriodic.CreateFromDiscriminatorValue); } },
                { "foreign_transaction_fee", n => { ForeignTransactionFee = n.GetObjectValue<Marqeta.Core.Sdk.Models.PolicyFeeForeignTransaction>(Marqeta.Core.Sdk.Models.PolicyFeeForeignTransaction.CreateFromDiscriminatorValue); } },
                { "late_payment", n => { LatePayment = n.GetObjectValue<Marqeta.Core.Sdk.Models.PolicyFeePayment>(Marqeta.Core.Sdk.Models.PolicyFeePayment.CreateFromDiscriminatorValue); } },
                { "monthly_fee", n => { MonthlyFee = n.GetObjectValue<Marqeta.Core.Sdk.Models.PolicyFeePeriodic>(Marqeta.Core.Sdk.Models.PolicyFeePeriodic.CreateFromDiscriminatorValue); } },
                { "returned_payment", n => { ReturnedPayment = n.GetObjectValue<Marqeta.Core.Sdk.Models.PolicyFeePayment>(Marqeta.Core.Sdk.Models.PolicyFeePayment.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Marqeta.Core.Sdk.Models.PolicyFeePeriodic>("annual_fee", AnnualFee);
            writer.WriteObjectValue<Marqeta.Core.Sdk.Models.PolicyFeeForeignTransaction>("foreign_transaction_fee", ForeignTransactionFee);
            writer.WriteObjectValue<Marqeta.Core.Sdk.Models.PolicyFeePayment>("late_payment", LatePayment);
            writer.WriteObjectValue<Marqeta.Core.Sdk.Models.PolicyFeePeriodic>("monthly_fee", MonthlyFee);
            writer.WriteObjectValue<Marqeta.Core.Sdk.Models.PolicyFeePayment>("returned_payment", ReturnedPayment);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
