// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models
{
    /// <summary>
    /// Contains information on the credit product policy.
    /// </summary>
    public class PolicyProductResponse : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>One or more card products associated with the credit product policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Marqeta.Core.Sdk.Models.PolicyProductCardProductResponse>? CardProducts { get; set; }
#nullable restore
#else
        public List<Marqeta.Core.Sdk.Models.PolicyProductCardProductResponse> CardProducts { get; set; }
#endif
        /// <summary>Specifies for whom the credit product is intended.* `CONSUMER` - The credit product is intended for individual consumers.* `SMALL_AND_MEDIUM_BUSINESS` - The credit product is intended for small and medium business.</summary>
        public Marqeta.Core.Sdk.Models.ProductClassification? Classification { get; set; }
        /// <summary>Date and time when the credit product policy was created on Marqeta&apos;s credit platform, in UTC.</summary>
        public DateTimeOffset? CreatedTime { get; set; }
        /// <summary>Contains information on the credit line range.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Marqeta.Core.Sdk.Models.ProductCreditLine? CreditLine { get; set; }
#nullable restore
#else
        public Marqeta.Core.Sdk.Models.ProductCreditLine CreditLine { get; set; }
#endif
        /// <summary>Valid three-digit link:https://www.iso.org/iso-4217-currency-codes.html[ISO 4217 currency code, window=&quot;_blank&quot;].</summary>
        public Marqeta.Core.Sdk.Models.CurrencyCode? CurrencyCode { get; set; }
        /// <summary>Description of the credit product policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Contains the configurations for interest calculation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Marqeta.Core.Sdk.Models.InterestCalculation? InterestCalculation { get; set; }
#nullable restore
#else
        public Marqeta.Core.Sdk.Models.InterestCalculation InterestCalculation { get; set; }
#endif
        /// <summary>Name of the credit product policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Contains the configurations for billing cycle day, payment due day, and fees.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Marqeta.Core.Sdk.Models.PolicyProductPaymentConfiguration? Payments { get; set; }
#nullable restore
#else
        public Marqeta.Core.Sdk.Models.PolicyProductPaymentConfiguration Payments { get; set; }
#endif
        /// <summary>Subtype of the credit product type.`CREDIT_CARD` - Card that enables the cardholder to make purchases on credit.</summary>
        public Marqeta.Core.Sdk.Models.ProductSubType? ProductSubType { get; set; }
        /// <summary>Type of credit product.`REVOLVING` - Allows users to continuously borrow and pay debts up to the credit limit.</summary>
        public Marqeta.Core.Sdk.Models.ProductType? ProductType { get; set; }
        /// <summary>Unique identifier of the credit product policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>Date and time when the credit product policy was last updated on Marqeta&apos;s credit platform, in UTC.</summary>
        public DateTimeOffset? UpdatedTime { get; set; }
        /// <summary>One or more usage types for the credit product policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Marqeta.Core.Sdk.Models.BalanceType?>? Usage { get; set; }
#nullable restore
#else
        public List<Marqeta.Core.Sdk.Models.BalanceType?> Usage { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Models.PolicyProductResponse"/> and sets the default values.
        /// </summary>
        public PolicyProductResponse()
        {
            AdditionalData = new Dictionary<string, object>();
            Classification = Marqeta.Core.Sdk.Models.ProductClassification.CONSUMER;
            CurrencyCode = Marqeta.Core.Sdk.Models.CurrencyCode.USD;
            ProductSubType = Marqeta.Core.Sdk.Models.ProductSubType.CREDIT_CARD;
            ProductType = Marqeta.Core.Sdk.Models.ProductType.REVOLVING;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Models.PolicyProductResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Marqeta.Core.Sdk.Models.PolicyProductResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Marqeta.Core.Sdk.Models.PolicyProductResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "card_products", n => { CardProducts = n.GetCollectionOfObjectValues<Marqeta.Core.Sdk.Models.PolicyProductCardProductResponse>(Marqeta.Core.Sdk.Models.PolicyProductCardProductResponse.CreateFromDiscriminatorValue)?.ToList(); } },
                { "classification", n => { Classification = n.GetEnumValue<Marqeta.Core.Sdk.Models.ProductClassification>(); } },
                { "created_time", n => { CreatedTime = n.GetDateTimeOffsetValue(); } },
                { "credit_line", n => { CreditLine = n.GetObjectValue<Marqeta.Core.Sdk.Models.ProductCreditLine>(Marqeta.Core.Sdk.Models.ProductCreditLine.CreateFromDiscriminatorValue); } },
                { "currency_code", n => { CurrencyCode = n.GetEnumValue<Marqeta.Core.Sdk.Models.CurrencyCode>(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "interest_calculation", n => { InterestCalculation = n.GetObjectValue<Marqeta.Core.Sdk.Models.InterestCalculation>(Marqeta.Core.Sdk.Models.InterestCalculation.CreateFromDiscriminatorValue); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "payments", n => { Payments = n.GetObjectValue<Marqeta.Core.Sdk.Models.PolicyProductPaymentConfiguration>(Marqeta.Core.Sdk.Models.PolicyProductPaymentConfiguration.CreateFromDiscriminatorValue); } },
                { "product_sub_type", n => { ProductSubType = n.GetEnumValue<Marqeta.Core.Sdk.Models.ProductSubType>(); } },
                { "product_type", n => { ProductType = n.GetEnumValue<Marqeta.Core.Sdk.Models.ProductType>(); } },
                { "token", n => { Token = n.GetStringValue(); } },
                { "updated_time", n => { UpdatedTime = n.GetDateTimeOffsetValue(); } },
                { "usage", n => { Usage = n.GetCollectionOfEnumValues<Marqeta.Core.Sdk.Models.BalanceType>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<Marqeta.Core.Sdk.Models.PolicyProductCardProductResponse>("card_products", CardProducts);
            writer.WriteEnumValue<Marqeta.Core.Sdk.Models.ProductClassification>("classification", Classification);
            writer.WriteDateTimeOffsetValue("created_time", CreatedTime);
            writer.WriteObjectValue<Marqeta.Core.Sdk.Models.ProductCreditLine>("credit_line", CreditLine);
            writer.WriteEnumValue<Marqeta.Core.Sdk.Models.CurrencyCode>("currency_code", CurrencyCode);
            writer.WriteStringValue("description", Description);
            writer.WriteObjectValue<Marqeta.Core.Sdk.Models.InterestCalculation>("interest_calculation", InterestCalculation);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<Marqeta.Core.Sdk.Models.PolicyProductPaymentConfiguration>("payments", Payments);
            writer.WriteEnumValue<Marqeta.Core.Sdk.Models.ProductSubType>("product_sub_type", ProductSubType);
            writer.WriteEnumValue<Marqeta.Core.Sdk.Models.ProductType>("product_type", ProductType);
            writer.WriteStringValue("token", Token);
            writer.WriteDateTimeOffsetValue("updated_time", UpdatedTime);
            writer.WriteCollectionOfEnumValues<Marqeta.Core.Sdk.Models.BalanceType>("usage", Usage);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}