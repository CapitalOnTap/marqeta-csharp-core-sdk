// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models
{
    /// <summary>
    /// Contains information about a direct deposit.
    /// </summary>
    public class DepositDepositResponse : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Amount being debited or credited.</summary>
        public double? Amount { get; set; }
        /// <summary>The unique identifier of the business account holder.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BusinessToken { get; set; }
#nullable restore
#else
        public string BusinessToken { get; set; }
#endif
        /// <summary>Company-specific data provided by the direct deposit originator.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CompanyDiscretionaryData { get; set; }
#nullable restore
#else
        public string CompanyDiscretionaryData { get; set; }
#endif
        /// <summary>Company-specific data provided by the direct deposit originator.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CompanyEntryDescription { get; set; }
#nullable restore
#else
        public string CompanyEntryDescription { get; set; }
#endif
        /// <summary>Alphanumeric code that identifies the direct deposit originator.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CompanyIdentification { get; set; }
#nullable restore
#else
        public string CompanyIdentification { get; set; }
#endif
        /// <summary>Name of the direct deposit originator.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CompanyName { get; set; }
#nullable restore
#else
        public string CompanyName { get; set; }
#endif
        /// <summary>Date and time when the direct deposit account was created.</summary>
        public DateTimeOffset? CreatedTime { get; set; }
        /// <summary>The unique identifier of the direct deposit account.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DirectDepositAccountToken { get; set; }
#nullable restore
#else
        public string DirectDepositAccountToken { get; set; }
#endif
        /// <summary>Accounting number by which the recipient is known to the direct deposit originator.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IndividualIdentificationNumber { get; set; }
#nullable restore
#else
        public string IndividualIdentificationNumber { get; set; }
#endif
        /// <summary>Name of the direct deposit recipient.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IndividualName { get; set; }
#nullable restore
#else
        public string IndividualName { get; set; }
#endif
        /// <summary>Date and time when the direct deposit account was last modified.</summary>
        public DateTimeOffset? LastModifiedTime { get; set; }
        /// <summary>Date and time when the credit or debit is applied.</summary>
        public DateTimeOffset? SettlementDate { get; set; }
        /// <summary>Three-letter code identifying the type of entry.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StandardEntryClassCode { get; set; }
#nullable restore
#else
        public string StandardEntryClassCode { get; set; }
#endif
        /// <summary>Current status of the direct deposit record.</summary>
        public Marqeta.Core.Sdk.Models.DepositDepositResponse_state? State { get; set; }
        /// <summary>Explanation for why the direct deposit record is in the current state.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StateReason { get; set; }
#nullable restore
#else
        public string StateReason { get; set; }
#endif
        /// <summary>Standard code describing the reason for the current state.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StateReasonCode { get; set; }
#nullable restore
#else
        public string StateReasonCode { get; set; }
#endif
        /// <summary>The unique identifier of the direct deposit record.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>Determines whether funds are being debited from or credited to the account.</summary>
        public Marqeta.Core.Sdk.Models.DepositDepositResponse_type? Type { get; set; }
        /// <summary>The unique identifier of the user account holder.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserToken { get; set; }
#nullable restore
#else
        public string UserToken { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Models.DepositDepositResponse"/> and sets the default values.
        /// </summary>
        public DepositDepositResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Models.DepositDepositResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Marqeta.Core.Sdk.Models.DepositDepositResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Marqeta.Core.Sdk.Models.DepositDepositResponse();
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
                { "business_token", n => { BusinessToken = n.GetStringValue(); } },
                { "company_discretionary_data", n => { CompanyDiscretionaryData = n.GetStringValue(); } },
                { "company_entry_description", n => { CompanyEntryDescription = n.GetStringValue(); } },
                { "company_identification", n => { CompanyIdentification = n.GetStringValue(); } },
                { "company_name", n => { CompanyName = n.GetStringValue(); } },
                { "created_time", n => { CreatedTime = n.GetDateTimeOffsetValue(); } },
                { "direct_deposit_account_token", n => { DirectDepositAccountToken = n.GetStringValue(); } },
                { "individual_identification_number", n => { IndividualIdentificationNumber = n.GetStringValue(); } },
                { "individual_name", n => { IndividualName = n.GetStringValue(); } },
                { "last_modified_time", n => { LastModifiedTime = n.GetDateTimeOffsetValue(); } },
                { "settlement_date", n => { SettlementDate = n.GetDateTimeOffsetValue(); } },
                { "standard_entry_class_code", n => { StandardEntryClassCode = n.GetStringValue(); } },
                { "state", n => { State = n.GetEnumValue<Marqeta.Core.Sdk.Models.DepositDepositResponse_state>(); } },
                { "state_reason", n => { StateReason = n.GetStringValue(); } },
                { "state_reason_code", n => { StateReasonCode = n.GetStringValue(); } },
                { "token", n => { Token = n.GetStringValue(); } },
                { "type", n => { Type = n.GetEnumValue<Marqeta.Core.Sdk.Models.DepositDepositResponse_type>(); } },
                { "user_token", n => { UserToken = n.GetStringValue(); } },
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
            writer.WriteStringValue("business_token", BusinessToken);
            writer.WriteStringValue("company_discretionary_data", CompanyDiscretionaryData);
            writer.WriteStringValue("company_entry_description", CompanyEntryDescription);
            writer.WriteStringValue("company_identification", CompanyIdentification);
            writer.WriteStringValue("company_name", CompanyName);
            writer.WriteDateTimeOffsetValue("created_time", CreatedTime);
            writer.WriteStringValue("direct_deposit_account_token", DirectDepositAccountToken);
            writer.WriteStringValue("individual_identification_number", IndividualIdentificationNumber);
            writer.WriteStringValue("individual_name", IndividualName);
            writer.WriteDateTimeOffsetValue("last_modified_time", LastModifiedTime);
            writer.WriteDateTimeOffsetValue("settlement_date", SettlementDate);
            writer.WriteStringValue("standard_entry_class_code", StandardEntryClassCode);
            writer.WriteEnumValue<Marqeta.Core.Sdk.Models.DepositDepositResponse_state>("state", State);
            writer.WriteStringValue("state_reason", StateReason);
            writer.WriteStringValue("state_reason_code", StateReasonCode);
            writer.WriteStringValue("token", Token);
            writer.WriteEnumValue<Marqeta.Core.Sdk.Models.DepositDepositResponse_type>("type", Type);
            writer.WriteStringValue("user_token", UserToken);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
