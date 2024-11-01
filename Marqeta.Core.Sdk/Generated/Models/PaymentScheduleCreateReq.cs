// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System;
namespace Marqeta.Core.Sdk.Models
{
    /// <summary>
    /// Information to create a payment schedule.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class PaymentScheduleCreateReq : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Amount of the payment.Required if `amount_category` is `FIXED`.</summary>
        public double? Amount { get; set; }
        /// <summary>A category used to determine the actual payment amount.</summary>
        public global::Marqeta.Core.Sdk.Models.PaymentScheduleAmountCategory? AmountCategory { get; set; }
        /// <summary>Valid three-digit link:https://www.iso.org/iso-4217-currency-codes.html[ISO 4217 currency code, window=&quot;_blank&quot;].</summary>
        public global::Marqeta.Core.Sdk.Models.CurrencyCode? CurrencyCode { get; set; }
        /// <summary>Description of the payment schedule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Defines how often to make a scheduled payment.</summary>
        public global::Marqeta.Core.Sdk.Models.PaymentScheduleFrequency? Frequency { get; set; }
        /// <summary>Date to make a one-time payment.Required if frequency is `ONCE`.</summary>
        public Date? NextPaymentImpactDate { get; set; }
        /// <summary>Day on which monthly payments are made.Required if `frequency` is `MONTHLY`.</summary>
        public global::Marqeta.Core.Sdk.Models.PaymentScheduleCreateReq_payment_day? PaymentDay { get; set; }
        /// <summary>Unique identifier of the payment source.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PaymentSourceToken { get; set; }
#nullable restore
#else
        public string PaymentSourceToken { get; set; }
#endif
        /// <summary>Unique identifier of the payment schedule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.PaymentScheduleCreateReq"/> and sets the default values.
        /// </summary>
        public PaymentScheduleCreateReq()
        {
            AdditionalData = new Dictionary<string, object>();
            CurrencyCode = global::Marqeta.Core.Sdk.Models.CurrencyCode.USD;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.PaymentScheduleCreateReq"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.PaymentScheduleCreateReq CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.PaymentScheduleCreateReq();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "amount", n => { Amount = n.GetDoubleValue(); } },
                { "amount_category", n => { AmountCategory = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.PaymentScheduleAmountCategory>(); } },
                { "currency_code", n => { CurrencyCode = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.CurrencyCode>(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "frequency", n => { Frequency = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.PaymentScheduleFrequency>(); } },
                { "next_payment_impact_date", n => { NextPaymentImpactDate = n.GetDateValue(); } },
                { "payment_day", n => { PaymentDay = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.PaymentScheduleCreateReq_payment_day>(); } },
                { "payment_source_token", n => { PaymentSourceToken = n.GetStringValue(); } },
                { "token", n => { Token = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("amount", Amount);
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.PaymentScheduleAmountCategory>("amount_category", AmountCategory);
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.CurrencyCode>("currency_code", CurrencyCode);
            writer.WriteStringValue("description", Description);
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.PaymentScheduleFrequency>("frequency", Frequency);
            writer.WriteDateValue("next_payment_impact_date", NextPaymentImpactDate);
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.PaymentScheduleCreateReq_payment_day>("payment_day", PaymentDay);
            writer.WriteStringValue("payment_source_token", PaymentSourceToken);
            writer.WriteStringValue("token", Token);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
