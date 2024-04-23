// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    public class DirectDepositResponse : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The amount property</summary>
        public double? Amount { get; set; }
        /// <summary>The business_token property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BusinessToken { get; set; }
#nullable restore
#else
        public string BusinessToken { get; set; }
#endif
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
        /// <summary>The created_time property</summary>
        public DateTimeOffset? CreatedTime { get; set; }
        /// <summary>The direct_deposit_account_token property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DirectDepositAccountToken { get; set; }
#nullable restore
#else
        public string DirectDepositAccountToken { get; set; }
#endif
        /// <summary>The early_direct_deposit property</summary>
        public bool? EarlyDirectDeposit { get; set; }
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
        /// <summary>The last_modified_time property</summary>
        public DateTimeOffset? LastModifiedTime { get; set; }
        /// <summary>The originator_status_code property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OriginatorStatusCode { get; set; }
#nullable restore
#else
        public string OriginatorStatusCode { get; set; }
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
        /// <summary>The state property</summary>
        public DirectDepositResponse_state? State { get; set; }
        /// <summary>The state_reason property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StateReason { get; set; }
#nullable restore
#else
        public string StateReason { get; set; }
#endif
        /// <summary>The state_reason_code property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StateReasonCode { get; set; }
#nullable restore
#else
        public string StateReasonCode { get; set; }
#endif
        /// <summary>The token property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>The trace_number property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TraceNumber { get; set; }
#nullable restore
#else
        public string TraceNumber { get; set; }
#endif
        /// <summary>The type property</summary>
        public DirectDepositResponse_type? Type { get; set; }
        /// <summary>The user_token property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserToken { get; set; }
#nullable restore
#else
        public string UserToken { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="DirectDepositResponse"/> and sets the default values.
        /// </summary>
        public DirectDepositResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DirectDepositResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DirectDepositResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DirectDepositResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"amount", n => { Amount = n.GetDoubleValue(); } },
                {"business_token", n => { BusinessToken = n.GetStringValue(); } },
                {"company_discretionary_data", n => { CompanyDiscretionaryData = n.GetStringValue(); } },
                {"company_entry_description", n => { CompanyEntryDescription = n.GetStringValue(); } },
                {"company_identification", n => { CompanyIdentification = n.GetStringValue(); } },
                {"company_name", n => { CompanyName = n.GetStringValue(); } },
                {"created_time", n => { CreatedTime = n.GetDateTimeOffsetValue(); } },
                {"direct_deposit_account_token", n => { DirectDepositAccountToken = n.GetStringValue(); } },
                {"early_direct_deposit", n => { EarlyDirectDeposit = n.GetBoolValue(); } },
                {"individual_identification_number", n => { IndividualIdentificationNumber = n.GetStringValue(); } },
                {"individual_name", n => { IndividualName = n.GetStringValue(); } },
                {"last_modified_time", n => { LastModifiedTime = n.GetDateTimeOffsetValue(); } },
                {"originator_status_code", n => { OriginatorStatusCode = n.GetStringValue(); } },
                {"settlement_date", n => { SettlementDate = n.GetDateTimeOffsetValue(); } },
                {"standard_entry_class_code", n => { StandardEntryClassCode = n.GetStringValue(); } },
                {"state", n => { State = n.GetEnumValue<DirectDepositResponse_state>(); } },
                {"state_reason", n => { StateReason = n.GetStringValue(); } },
                {"state_reason_code", n => { StateReasonCode = n.GetStringValue(); } },
                {"token", n => { Token = n.GetStringValue(); } },
                {"trace_number", n => { TraceNumber = n.GetStringValue(); } },
                {"type", n => { Type = n.GetEnumValue<DirectDepositResponse_type>(); } },
                {"user_token", n => { UserToken = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("amount", Amount);
            writer.WriteStringValue("business_token", BusinessToken);
            writer.WriteStringValue("company_discretionary_data", CompanyDiscretionaryData);
            writer.WriteStringValue("company_entry_description", CompanyEntryDescription);
            writer.WriteStringValue("company_identification", CompanyIdentification);
            writer.WriteStringValue("company_name", CompanyName);
            writer.WriteDateTimeOffsetValue("created_time", CreatedTime);
            writer.WriteStringValue("direct_deposit_account_token", DirectDepositAccountToken);
            writer.WriteBoolValue("early_direct_deposit", EarlyDirectDeposit);
            writer.WriteStringValue("individual_identification_number", IndividualIdentificationNumber);
            writer.WriteStringValue("individual_name", IndividualName);
            writer.WriteDateTimeOffsetValue("last_modified_time", LastModifiedTime);
            writer.WriteStringValue("originator_status_code", OriginatorStatusCode);
            writer.WriteDateTimeOffsetValue("settlement_date", SettlementDate);
            writer.WriteStringValue("standard_entry_class_code", StandardEntryClassCode);
            writer.WriteEnumValue<DirectDepositResponse_state>("state", State);
            writer.WriteStringValue("state_reason", StateReason);
            writer.WriteStringValue("state_reason_code", StateReasonCode);
            writer.WriteStringValue("token", Token);
            writer.WriteStringValue("trace_number", TraceNumber);
            writer.WriteEnumValue<DirectDepositResponse_type>("type", Type);
            writer.WriteStringValue("user_token", UserToken);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}