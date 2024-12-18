// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Marqeta.Core.Sdk.Models
{
    /// <summary>
    /// Created when a user pays a portion or all of their statement balance. This is for immediate payments only; Once set to `ACTIVE`, cannot be edited or deleted.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class PaymentCreateReq : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Amount of the payment.</summary>
        public double? Amount { get; set; }
        /// <summary>Valid three-digit link:https://www.iso.org/iso-4217-currency-codes.html[ISO 4217 currency code, window=&quot;_blank&quot;].</summary>
        public global::Marqeta.Core.Sdk.Models.CurrencyCode? CurrencyCode { get; set; }
        /// <summary>Description of the payment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Date and time when the payment impacts the account balance and fee calculations.</summary>
        public DateTimeOffset? ImpactTime { get; set; }
        /// <summary>Customer-defined additional information about the payment (for example, a check number).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Metadata { get; set; }
#nullable restore
#else
        public string Metadata { get; set; }
#endif
        /// <summary>Method of payment.</summary>
        public global::Marqeta.Core.Sdk.Models.PaymentCreateReq_method? Method { get; set; }
        /// <summary>Unique identifier of the payment source. Required for ACH payments.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PaymentSourceToken { get; set; }
#nullable restore
#else
        public string PaymentSourceToken { get; set; }
#endif
        /// <summary>Unique identifier of the payment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.PaymentCreateReq"/> and sets the default values.
        /// </summary>
        public PaymentCreateReq()
        {
            AdditionalData = new Dictionary<string, object>();
            CurrencyCode = global::Marqeta.Core.Sdk.Models.CurrencyCode.USD;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.PaymentCreateReq"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.PaymentCreateReq CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.PaymentCreateReq();
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
                { "currency_code", n => { CurrencyCode = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.CurrencyCode>(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "impact_time", n => { ImpactTime = n.GetDateTimeOffsetValue(); } },
                { "metadata", n => { Metadata = n.GetStringValue(); } },
                { "method", n => { Method = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.PaymentCreateReq_method>(); } },
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
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.CurrencyCode>("currency_code", CurrencyCode);
            writer.WriteStringValue("description", Description);
            writer.WriteDateTimeOffsetValue("impact_time", ImpactTime);
            writer.WriteStringValue("metadata", Metadata);
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.PaymentCreateReq_method>("method", Method);
            writer.WriteStringValue("payment_source_token", PaymentSourceToken);
            writer.WriteStringValue("token", Token);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
