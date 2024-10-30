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
        /// <summary>The international network identifier.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NetworkInternationalId { get; set; }
#nullable restore
#else
        public string NetworkInternationalId { get; set; }
#endif
        /// <summary>Retrieval reference number of the merchant&apos;s financial institution.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RetrievalReferenceNumber { get; set; }
#nullable restore
#else
        public string RetrievalReferenceNumber { get; set; }
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
                { "institution_country", n => { InstitutionCountry = n.GetStringValue(); } },
                { "institution_id_code", n => { InstitutionIdCode = n.GetStringValue(); } },
                { "network_international_id", n => { NetworkInternationalId = n.GetStringValue(); } },
                { "retrieval_reference_number", n => { RetrievalReferenceNumber = n.GetStringValue(); } },
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
            writer.WriteStringValue("institution_country", InstitutionCountry);
            writer.WriteStringValue("institution_id_code", InstitutionIdCode);
            writer.WriteStringValue("network_international_id", NetworkInternationalId);
            writer.WriteStringValue("retrieval_reference_number", RetrievalReferenceNumber);
            writer.WriteStringValue("system_trace_audit_number", SystemTraceAuditNumber);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
