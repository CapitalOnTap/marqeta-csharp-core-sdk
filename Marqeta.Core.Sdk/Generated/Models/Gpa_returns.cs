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
    /// Contains information about a GPA unload order.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Gpa_returns : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Amount of funds returned to the funding source.</summary>
        public double? Amount { get; set; }
        /// <summary>Date and time when the GPA unload order was created, in UTC.</summary>
        public DateTimeOffset? CreatedTime { get; set; }
        /// <summary>Contains funding information for the transaction, including funding amount, type, and time.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.Models.Funding? Funding { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.Funding Funding { get; set; }
#endif
        /// <summary>Identifies the funding source used for this order.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FundingSourceAddressToken { get; set; }
#nullable restore
#else
        public string FundingSourceAddressToken { get; set; }
#endif
        /// <summary>Identifies the funding source used for this order.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FundingSourceToken { get; set; }
#nullable restore
#else
        public string FundingSourceToken { get; set; }
#endif
        /// <summary>Contains information about the JIT Funding load event, in which funds are loaded into an account.This object is returned if your program uses JIT Funding.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.Models.Jit_funding_api? JitFunding { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.Jit_funding_api JitFunding { get; set; }
#endif
        /// <summary>Date and time when the GPA unload order was last modified, in UTC.</summary>
        public DateTimeOffset? LastModifiedTime { get; set; }
        /// <summary>Additional descriptive text.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Memo { get; set; }
#nullable restore
#else
        public string Memo { get; set; }
#endif
        /// <summary>Identifies the original GPA order.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OriginalOrderToken { get; set; }
#nullable restore
#else
        public string OriginalOrderToken { get; set; }
#endif
        /// <summary>Response codes and memos for account name verification, address verification, card security verification, and transactions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.Models.Response? Response { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.Response Response { get; set; }
#endif
        /// <summary>Current status of the GPA unload order.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? State { get; set; }
#nullable restore
#else
        public string State { get; set; }
#endif
        /// <summary>Comma-delimited list of tags describing the GPA order.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Tags { get; set; }
#nullable restore
#else
        public string Tags { get; set; }
#endif
        /// <summary>Unique identifier of the GPA unload order.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>Unique identifier of the transaction.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TransactionToken { get; set; }
#nullable restore
#else
        public string TransactionToken { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.Gpa_returns"/> and sets the default values.
        /// </summary>
        public Gpa_returns()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.Gpa_returns"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.Gpa_returns CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.Gpa_returns();
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
                { "created_time", n => { CreatedTime = n.GetDateTimeOffsetValue(); } },
                { "funding", n => { Funding = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.Funding>(global::Marqeta.Core.Sdk.Models.Funding.CreateFromDiscriminatorValue); } },
                { "funding_source_address_token", n => { FundingSourceAddressToken = n.GetStringValue(); } },
                { "funding_source_token", n => { FundingSourceToken = n.GetStringValue(); } },
                { "jit_funding", n => { JitFunding = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.Jit_funding_api>(global::Marqeta.Core.Sdk.Models.Jit_funding_api.CreateFromDiscriminatorValue); } },
                { "last_modified_time", n => { LastModifiedTime = n.GetDateTimeOffsetValue(); } },
                { "memo", n => { Memo = n.GetStringValue(); } },
                { "original_order_token", n => { OriginalOrderToken = n.GetStringValue(); } },
                { "response", n => { Response = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.Response>(global::Marqeta.Core.Sdk.Models.Response.CreateFromDiscriminatorValue); } },
                { "state", n => { State = n.GetStringValue(); } },
                { "tags", n => { Tags = n.GetStringValue(); } },
                { "token", n => { Token = n.GetStringValue(); } },
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
            writer.WriteDateTimeOffsetValue("created_time", CreatedTime);
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.Funding>("funding", Funding);
            writer.WriteStringValue("funding_source_address_token", FundingSourceAddressToken);
            writer.WriteStringValue("funding_source_token", FundingSourceToken);
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.Jit_funding_api>("jit_funding", JitFunding);
            writer.WriteDateTimeOffsetValue("last_modified_time", LastModifiedTime);
            writer.WriteStringValue("memo", Memo);
            writer.WriteStringValue("original_order_token", OriginalOrderToken);
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.Response>("response", Response);
            writer.WriteStringValue("state", State);
            writer.WriteStringValue("tags", Tags);
            writer.WriteStringValue("token", Token);
            writer.WriteStringValue("transaction_token", TransactionToken);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
