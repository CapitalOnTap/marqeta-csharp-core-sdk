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
    /// Contains information about the merchant&apos;s financial institution.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Acquirer : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>City of the merchant&apos;s financial institution.This field appears only in account funding and original credit transactions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? City { get; set; }
#nullable restore
#else
        public string City { get; set; }
#endif
        /// <summary>Country code of the merchant&apos;s financial institution.This field appears only in account funding and original credit transactions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CountryCode { get; set; }
#nullable restore
#else
        public string CountryCode { get; set; }
#endif
        /// <summary>Country code of the merchant&apos;s financial institution.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InstitutionCountry { get; set; }
#nullable restore
#else
        public string InstitutionCountry { get; set; }
#endif
        /// <summary>Identifier code of the merchant&apos;s financial institution.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InstitutionIdCode { get; set; }
#nullable restore
#else
        public string InstitutionIdCode { get; set; }
#endif
        /// <summary>Street address of the merchant.This field appears only in account funding and original credit transactions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MerchantStreetAddress { get; set; }
#nullable restore
#else
        public string MerchantStreetAddress { get; set; }
#endif
        /// <summary>Name of the merchant&apos;s financial institution.This field appears only in account funding and original credit transactions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>International network identifier.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NetworkInternationalId { get; set; }
#nullable restore
#else
        public string NetworkInternationalId { get; set; }
#endif
        /// <summary>Postal code of the merchant&apos;s financial institution.This field appears only in account funding and original credit transactions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PostalCode { get; set; }
#nullable restore
#else
        public string PostalCode { get; set; }
#endif
        /// <summary>Retrieval reference number of the merchant&apos;s financial institution.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RetrievalReferenceNumber { get; set; }
#nullable restore
#else
        public string RetrievalReferenceNumber { get; set; }
#endif
        /// <summary>State where the merchant&apos;s financial institution is located.This field appears only in account funding and original credit transactions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? State { get; set; }
#nullable restore
#else
        public string State { get; set; }
#endif
        /// <summary>The street_address property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StreetAddress { get; set; }
#nullable restore
#else
        public string StreetAddress { get; set; }
#endif
        /// <summary>System trace audit number of the merchant&apos;s financial institution.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SystemTraceAuditNumber { get; set; }
#nullable restore
#else
        public string SystemTraceAuditNumber { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.Acquirer"/> and sets the default values.
        /// </summary>
        public Acquirer()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.Acquirer"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.Acquirer CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.Acquirer();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "city", n => { City = n.GetStringValue(); } },
                { "country_code", n => { CountryCode = n.GetStringValue(); } },
                { "institution_country", n => { InstitutionCountry = n.GetStringValue(); } },
                { "institution_id_code", n => { InstitutionIdCode = n.GetStringValue(); } },
                { "merchant_street_address", n => { MerchantStreetAddress = n.GetStringValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "network_international_id", n => { NetworkInternationalId = n.GetStringValue(); } },
                { "postal_code", n => { PostalCode = n.GetStringValue(); } },
                { "retrieval_reference_number", n => { RetrievalReferenceNumber = n.GetStringValue(); } },
                { "state", n => { State = n.GetStringValue(); } },
                { "street_address", n => { StreetAddress = n.GetStringValue(); } },
                { "system_trace_audit_number", n => { SystemTraceAuditNumber = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("city", City);
            writer.WriteStringValue("country_code", CountryCode);
            writer.WriteStringValue("institution_country", InstitutionCountry);
            writer.WriteStringValue("institution_id_code", InstitutionIdCode);
            writer.WriteStringValue("merchant_street_address", MerchantStreetAddress);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("network_international_id", NetworkInternationalId);
            writer.WriteStringValue("postal_code", PostalCode);
            writer.WriteStringValue("retrieval_reference_number", RetrievalReferenceNumber);
            writer.WriteStringValue("state", State);
            writer.WriteStringValue("street_address", StreetAddress);
            writer.WriteStringValue("system_trace_audit_number", SystemTraceAuditNumber);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
