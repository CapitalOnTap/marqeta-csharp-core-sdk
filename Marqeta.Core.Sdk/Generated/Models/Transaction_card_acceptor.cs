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
    /// Contains information about the merchant.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Transaction_card_acceptor : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Card acceptor&apos;s address.May be returned if the request uses Transaction Model v1 of the Marqeta Core API.Not returned for Transaction Model v2 requests.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Address { get; set; }
#nullable restore
#else
        public string Address { get; set; }
#endif
        /// <summary>Card acceptor&apos;s city.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? City { get; set; }
#nullable restore
#else
        public string City { get; set; }
#endif
        /// <summary>Card acceptor&apos;s country code.May be returned if the request uses Transaction Model v2 of the Marqeta Core API.Not returned for Transaction Model v1 requests.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CountryCode { get; set; }
#nullable restore
#else
        public string CountryCode { get; set; }
#endif
        /// <summary>The merchant&apos;s country of origin.A merchant&apos;s country of origin can be different from the country in which the merchant is located.For example, embassies are physically located in countries that are not their country of origin: a Mexican embassy might be physically located in Singapore, but the country of origin is Mexico.This field is included when the cardholder conducts a transaction with a government-controlled merchant using a Marqeta-issued card.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CountryOfOrigin { get; set; }
#nullable restore
#else
        public string CountryOfOrigin { get; set; }
#endif
        /// <summary>The customer_service_phone property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomerServicePhone { get; set; }
#nullable restore
#else
        public string CustomerServicePhone { get; set; }
#endif
        /// <summary>Geographic coordinates of the card acceptor in `latitudeE7,longitudeE7` format.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GeographicCoordinates { get; set; }
#nullable restore
#else
        public string GeographicCoordinates { get; set; }
#endif
        /// <summary>The independent_sales_organization_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IndependentSalesOrganizationId { get; set; }
#nullable restore
#else
        public string IndependentSalesOrganizationId { get; set; }
#endif
        /// <summary>Merchant category code (MCC).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Mcc { get; set; }
#nullable restore
#else
        public string Mcc { get; set; }
#endif
        /// <summary>An array of `mcc_groups`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? MccGroups { get; set; }
#nullable restore
#else
        public List<string> MccGroups { get; set; }
#endif
        /// <summary>The merchant_tax_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MerchantTaxId { get; set; }
#nullable restore
#else
        public string MerchantTaxId { get; set; }
#endif
        /// <summary>The VAT registration identifier of the merchant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MerchantVatRegistrationId { get; set; }
#nullable restore
#else
        public string MerchantVatRegistrationId { get; set; }
#endif
        /// <summary>The merchant identifier.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Mid { get; set; }
#nullable restore
#else
        public string Mid { get; set; }
#endif
        /// <summary>Card acceptor&apos;s name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Identifier assigned by the card network.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NetworkAssignedId { get; set; }
#nullable restore
#else
        public string NetworkAssignedId { get; set; }
#endif
        /// <summary>The merchant identifier on the card network.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NetworkMid { get; set; }
#nullable restore
#else
        public string NetworkMid { get; set; }
#endif
        /// <summary>The payment_facilitator_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PaymentFacilitatorId { get; set; }
#nullable restore
#else
        public string PaymentFacilitatorId { get; set; }
#endif
        /// <summary>The name of the payment facilitator, including the sub-merchant identifier, of an original credit transaction.This field is returned when a payment facilitator participates in the transaction.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PaymentFacilitatorName { get; set; }
#nullable restore
#else
        public string PaymentFacilitatorName { get; set; }
#endif
        /// <summary>The phone property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Phone { get; set; }
#nullable restore
#else
        public string Phone { get; set; }
#endif
        /// <summary>Contains information about the point of sale, including details on how the card was presented.Returned if provided by the card network, and the request uses Transaction Model v1 of the Marqeta Core API.Not returned for Transaction Model v2 requests.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.Models.Terminal_model? Poi { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.Terminal_model Poi { get; set; }
#endif
        /// <summary>Card acceptor&apos;s postal code.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PostalCode { get; set; }
#nullable restore
#else
        public string PostalCode { get; set; }
#endif
        /// <summary>Geographic coordinates of the service provider in `latitudeE7,longitudeE7` format.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServiceGeographicCoordinates { get; set; }
#nullable restore
#else
        public string ServiceGeographicCoordinates { get; set; }
#endif
        /// <summary>The special_merchant_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SpecialMerchantId { get; set; }
#nullable restore
#else
        public string SpecialMerchantId { get; set; }
#endif
        /// <summary>Two-character state, province, or territorial abbreviation.For a complete list of valid state and province abbreviations, see &lt;&lt;/core-api/kyc-verification#_valid_state_provincial_and_territorial_abbreviations, Valid state, provincial, and territorial abbreviations&gt;&gt;.*Note*: Non-US merchants may return more than 2 char for this field.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? State { get; set; }
#nullable restore
#else
        public string State { get; set; }
#endif
        /// <summary>The sub_merchant_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubMerchantId { get; set; }
#nullable restore
#else
        public string SubMerchantId { get; set; }
#endif
        /// <summary>The name of the transfer service provider of a money transfer original credit transaction.This field is included when a transfer service provider participates in the transaction.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TransferServiceProviderName { get; set; }
#nullable restore
#else
        public string TransferServiceProviderName { get; set; }
#endif
        /// <summary>The url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; set; }
#nullable restore
#else
        public string Url { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.Transaction_card_acceptor"/> and sets the default values.
        /// </summary>
        public Transaction_card_acceptor()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.Transaction_card_acceptor"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.Transaction_card_acceptor CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.Transaction_card_acceptor();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "address", n => { Address = n.GetStringValue(); } },
                { "city", n => { City = n.GetStringValue(); } },
                { "country_code", n => { CountryCode = n.GetStringValue(); } },
                { "country_of_origin", n => { CountryOfOrigin = n.GetStringValue(); } },
                { "customer_service_phone", n => { CustomerServicePhone = n.GetStringValue(); } },
                { "geographic_coordinates", n => { GeographicCoordinates = n.GetStringValue(); } },
                { "independent_sales_organization_id", n => { IndependentSalesOrganizationId = n.GetStringValue(); } },
                { "mcc", n => { Mcc = n.GetStringValue(); } },
                { "mcc_groups", n => { MccGroups = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "merchant_tax_id", n => { MerchantTaxId = n.GetStringValue(); } },
                { "merchant_vat_registration_id", n => { MerchantVatRegistrationId = n.GetStringValue(); } },
                { "mid", n => { Mid = n.GetStringValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "network_assigned_id", n => { NetworkAssignedId = n.GetStringValue(); } },
                { "network_mid", n => { NetworkMid = n.GetStringValue(); } },
                { "payment_facilitator_id", n => { PaymentFacilitatorId = n.GetStringValue(); } },
                { "payment_facilitator_name", n => { PaymentFacilitatorName = n.GetStringValue(); } },
                { "phone", n => { Phone = n.GetStringValue(); } },
                { "poi", n => { Poi = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.Terminal_model>(global::Marqeta.Core.Sdk.Models.Terminal_model.CreateFromDiscriminatorValue); } },
                { "postal_code", n => { PostalCode = n.GetStringValue(); } },
                { "service_geographic_coordinates", n => { ServiceGeographicCoordinates = n.GetStringValue(); } },
                { "special_merchant_id", n => { SpecialMerchantId = n.GetStringValue(); } },
                { "state", n => { State = n.GetStringValue(); } },
                { "sub_merchant_id", n => { SubMerchantId = n.GetStringValue(); } },
                { "transfer_service_provider_name", n => { TransferServiceProviderName = n.GetStringValue(); } },
                { "url", n => { Url = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("address", Address);
            writer.WriteStringValue("city", City);
            writer.WriteStringValue("country_code", CountryCode);
            writer.WriteStringValue("country_of_origin", CountryOfOrigin);
            writer.WriteStringValue("customer_service_phone", CustomerServicePhone);
            writer.WriteStringValue("geographic_coordinates", GeographicCoordinates);
            writer.WriteStringValue("independent_sales_organization_id", IndependentSalesOrganizationId);
            writer.WriteStringValue("mcc", Mcc);
            writer.WriteCollectionOfPrimitiveValues<string>("mcc_groups", MccGroups);
            writer.WriteStringValue("merchant_tax_id", MerchantTaxId);
            writer.WriteStringValue("merchant_vat_registration_id", MerchantVatRegistrationId);
            writer.WriteStringValue("mid", Mid);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("network_assigned_id", NetworkAssignedId);
            writer.WriteStringValue("network_mid", NetworkMid);
            writer.WriteStringValue("payment_facilitator_id", PaymentFacilitatorId);
            writer.WriteStringValue("payment_facilitator_name", PaymentFacilitatorName);
            writer.WriteStringValue("phone", Phone);
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.Terminal_model>("poi", Poi);
            writer.WriteStringValue("postal_code", PostalCode);
            writer.WriteStringValue("service_geographic_coordinates", ServiceGeographicCoordinates);
            writer.WriteStringValue("special_merchant_id", SpecialMerchantId);
            writer.WriteStringValue("state", State);
            writer.WriteStringValue("sub_merchant_id", SubMerchantId);
            writer.WriteStringValue("transfer_service_provider_name", TransferServiceProviderName);
            writer.WriteStringValue("url", Url);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
