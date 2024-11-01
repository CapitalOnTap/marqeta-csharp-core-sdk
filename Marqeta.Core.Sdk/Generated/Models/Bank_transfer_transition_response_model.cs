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
    public partial class Bank_transfer_transition_response_model : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The amount property</summary>
        public double? Amount { get; set; }
        /// <summary>Unique identifier of the ACH transfer being transitioned.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BankTransferToken { get; set; }
#nullable restore
#else
        public string BankTransferToken { get; set; }
#endif
        /// <summary>Field required in older versions of the API, but no longer used.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BatchNumber { get; set; }
#nullable restore
#else
        public string BatchNumber { get; set; }
#endif
        /// <summary>Mechanism by which the transaction was initiated.</summary>
        public global::Marqeta.Core.Sdk.Models.Bank_transfer_transition_response_model_channel? Channel { get; set; }
        /// <summary>Date and time when the ACH transfer was created, in UTC.</summary>
        public DateTimeOffset? CreatedTime { get; set; }
        /// <summary>The effective_date property</summary>
        public DateTimeOffset? EffectiveDate { get; set; }
        /// <summary>Date and time when the ACH transfer was last modified.</summary>
        public DateTimeOffset? LastModifiedTime { get; set; }
        /// <summary>Not currently used.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProgramReserveToken { get; set; }
#nullable restore
#else
        public string ProgramReserveToken { get; set; }
#endif
        /// <summary>Explanation of why the transition is being made, for example &quot;Created by POST call on API&quot;.Returned if this information was supplied when the transition was originally created.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Reason { get; set; }
#nullable restore
#else
        public string Reason { get; set; }
#endif
        /// <summary>Standardized ACH return code for a returned transaction, generally sent by the RDFI.Transactions can be returned for any of the reasons listed in the &lt;&lt;/developer-guides/ach-origination#_nacha_ach_return_codes, NACHA ACH return codes table&gt;&gt; of the ACH Origination Guide.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReturnCode { get; set; }
#nullable restore
#else
        public string ReturnCode { get; set; }
#endif
        /// <summary>Human-readable description correlating to the `return_code`, such as `Insufficient funds`, if a return code is present in the response.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReturnReason { get; set; }
#nullable restore
#else
        public string ReturnReason { get; set; }
#endif
        /// <summary>The reversal_after_45_days property</summary>
        public bool? ReversalAfter45Days { get; set; }
        /// <summary>New state of the ACH transfer.</summary>
        public global::Marqeta.Core.Sdk.Models.Bank_transfer_transition_response_model_status? Status { get; set; }
        /// <summary>Unique identifier of the bank transfer transition.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>Transaction token for JIT-related ledger entries for the ACH transfer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TransactionJitToken { get; set; }
#nullable restore
#else
        public string TransactionJitToken { get; set; }
#endif
        /// <summary>Transaction token for *non*-JIT-related ledger entries for the ACH transfer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TransactionToken { get; set; }
#nullable restore
#else
        public string TransactionToken { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.Bank_transfer_transition_response_model"/> and sets the default values.
        /// </summary>
        public Bank_transfer_transition_response_model()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.Bank_transfer_transition_response_model"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.Bank_transfer_transition_response_model CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.Bank_transfer_transition_response_model();
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
                { "bank_transfer_token", n => { BankTransferToken = n.GetStringValue(); } },
                { "batch_number", n => { BatchNumber = n.GetStringValue(); } },
                { "channel", n => { Channel = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.Bank_transfer_transition_response_model_channel>(); } },
                { "created_time", n => { CreatedTime = n.GetDateTimeOffsetValue(); } },
                { "effective_date", n => { EffectiveDate = n.GetDateTimeOffsetValue(); } },
                { "last_modified_time", n => { LastModifiedTime = n.GetDateTimeOffsetValue(); } },
                { "program_reserve_token", n => { ProgramReserveToken = n.GetStringValue(); } },
                { "reason", n => { Reason = n.GetStringValue(); } },
                { "return_code", n => { ReturnCode = n.GetStringValue(); } },
                { "return_reason", n => { ReturnReason = n.GetStringValue(); } },
                { "reversal_after_45_days", n => { ReversalAfter45Days = n.GetBoolValue(); } },
                { "status", n => { Status = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.Bank_transfer_transition_response_model_status>(); } },
                { "token", n => { Token = n.GetStringValue(); } },
                { "transaction_jit_token", n => { TransactionJitToken = n.GetStringValue(); } },
                { "transaction_token", n => { TransactionToken = n.GetStringValue(); } },
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
            writer.WriteStringValue("bank_transfer_token", BankTransferToken);
            writer.WriteStringValue("batch_number", BatchNumber);
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.Bank_transfer_transition_response_model_channel>("channel", Channel);
            writer.WriteDateTimeOffsetValue("created_time", CreatedTime);
            writer.WriteDateTimeOffsetValue("effective_date", EffectiveDate);
            writer.WriteDateTimeOffsetValue("last_modified_time", LastModifiedTime);
            writer.WriteStringValue("program_reserve_token", ProgramReserveToken);
            writer.WriteStringValue("reason", Reason);
            writer.WriteStringValue("return_code", ReturnCode);
            writer.WriteStringValue("return_reason", ReturnReason);
            writer.WriteBoolValue("reversal_after_45_days", ReversalAfter45Days);
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.Bank_transfer_transition_response_model_status>("status", Status);
            writer.WriteStringValue("token", Token);
            writer.WriteStringValue("transaction_jit_token", TransactionJitToken);
            writer.WriteStringValue("transaction_token", TransactionToken);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
