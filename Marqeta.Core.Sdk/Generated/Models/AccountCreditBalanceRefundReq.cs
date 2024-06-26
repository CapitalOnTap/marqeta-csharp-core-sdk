// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models
{
    /// <summary>
    /// Contains details on a credit balance refund.
    /// </summary>
    public class AccountCreditBalanceRefundReq : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Amount of the credit balance refund.The maximum refund amount is the amount that brings the account balance to $0.For example, $4000 is the maximum refund amount for a -$4000 account balance.</summary>
        public double? Amount { get; set; }
        /// <summary>Valid three-digit link:https://www.iso.org/iso-4217-currency-codes.html[ISO 4217 currency code, window=&quot;_blank&quot;].</summary>
        public Marqeta.Core.Sdk.Models.CurrencyCode? CurrencyCode { get; set; }
        /// <summary>Description for the credit balance refund.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Method of the refund.</summary>
        public Marqeta.Core.Sdk.Models.RefundMethod? Method { get; set; }
        /// <summary>Unique identifier of the credit balance refund.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Models.AccountCreditBalanceRefundReq"/> and sets the default values.
        /// </summary>
        public AccountCreditBalanceRefundReq()
        {
            AdditionalData = new Dictionary<string, object>();
            CurrencyCode = Marqeta.Core.Sdk.Models.CurrencyCode.USD;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Models.AccountCreditBalanceRefundReq"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Marqeta.Core.Sdk.Models.AccountCreditBalanceRefundReq CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Marqeta.Core.Sdk.Models.AccountCreditBalanceRefundReq();
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
                { "currency_code", n => { CurrencyCode = n.GetEnumValue<Marqeta.Core.Sdk.Models.CurrencyCode>(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "method", n => { Method = n.GetEnumValue<Marqeta.Core.Sdk.Models.RefundMethod>(); } },
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
            writer.WriteEnumValue<Marqeta.Core.Sdk.Models.CurrencyCode>("currency_code", CurrencyCode);
            writer.WriteStringValue("description", Description);
            writer.WriteEnumValue<Marqeta.Core.Sdk.Models.RefundMethod>("method", Method);
            writer.WriteStringValue("token", Token);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
