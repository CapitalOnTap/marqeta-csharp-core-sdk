// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Marqeta.Core.Sdk.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class DirectDepositRequest : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The account_number property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountNumber { get; set; }
#nullable restore
#else
        public string AccountNumber { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The amount property</summary>
        public double? Amount { get; set; }
        /// <summary>The company_discretionary_data property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CompanyDiscretionaryData { get; set; }
#nullable restore
#else
        public string CompanyDiscretionaryData { get; set; }
#endif
        /// <summary>The company_entry_description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CompanyEntryDescription { get; set; }
#nullable restore
#else
        public string CompanyEntryDescription { get; set; }
#endif
        /// <summary>The company_identification property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CompanyIdentification { get; set; }
#nullable restore
#else
        public string CompanyIdentification { get; set; }
#endif
        /// <summary>The company_name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CompanyName { get; set; }
#nullable restore
#else
        public string CompanyName { get; set; }
#endif
        /// <summary>The earlyPayEligible property</summary>
        public bool? EarlyPayEligible { get; set; }
        /// <summary>The individual_identification_number property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IndividualIdentificationNumber { get; set; }
#nullable restore
#else
        public string IndividualIdentificationNumber { get; set; }
#endif
        /// <summary>The individual_name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IndividualName { get; set; }
#nullable restore
#else
        public string IndividualName { get; set; }
#endif
        /// <summary>The settlement_date property</summary>
        public DateTimeOffset? SettlementDate { get; set; }
        /// <summary>The standard_entry_class_code property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StandardEntryClassCode { get; set; }
#nullable restore
#else
        public string StandardEntryClassCode { get; set; }
#endif
        /// <summary>The token property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>The type property</summary>
        public global::Marqeta.Core.Sdk.Models.DirectDepositRequest_type? Type { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.DirectDepositRequest"/> and sets the default values.
        /// </summary>
        public DirectDepositRequest()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.DirectDepositRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.DirectDepositRequest CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.DirectDepositRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "account_number", n => { AccountNumber = n.GetStringValue(); } },
                { "amount", n => { Amount = n.GetDoubleValue(); } },
                { "company_discretionary_data", n => { CompanyDiscretionaryData = n.GetStringValue(); } },
                { "company_entry_description", n => { CompanyEntryDescription = n.GetStringValue(); } },
                { "company_identification", n => { CompanyIdentification = n.GetStringValue(); } },
                { "company_name", n => { CompanyName = n.GetStringValue(); } },
                { "earlyPayEligible", n => { EarlyPayEligible = n.GetBoolValue(); } },
                { "individual_identification_number", n => { IndividualIdentificationNumber = n.GetStringValue(); } },
                { "individual_name", n => { IndividualName = n.GetStringValue(); } },
                { "settlement_date", n => { SettlementDate = n.GetDateTimeOffsetValue(); } },
                { "standard_entry_class_code", n => { StandardEntryClassCode = n.GetStringValue(); } },
                { "token", n => { Token = n.GetStringValue(); } },
                { "type", n => { Type = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.DirectDepositRequest_type>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("account_number", AccountNumber);
            writer.WriteDoubleValue("amount", Amount);
            writer.WriteStringValue("company_discretionary_data", CompanyDiscretionaryData);
            writer.WriteStringValue("company_entry_description", CompanyEntryDescription);
            writer.WriteStringValue("company_identification", CompanyIdentification);
            writer.WriteStringValue("company_name", CompanyName);
            writer.WriteBoolValue("earlyPayEligible", EarlyPayEligible);
            writer.WriteStringValue("individual_identification_number", IndividualIdentificationNumber);
            writer.WriteStringValue("individual_name", IndividualName);
            writer.WriteDateTimeOffsetValue("settlement_date", SettlementDate);
            writer.WriteStringValue("standard_entry_class_code", StandardEntryClassCode);
            writer.WriteStringValue("token", Token);
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.DirectDepositRequest_type>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
