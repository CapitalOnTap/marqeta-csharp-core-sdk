// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    /// <summary>
    /// Contains information about a GPA order, including fees, funding sources, and addresses.See &lt;&lt;/core-api/gpa-orders, GPA Orders&gt;&gt; for more information.
    /// </summary>
    public class Gpa_response : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Amount funded.</summary>
        public double? Amount { get; set; }
        /// <summary>Unique identifier of the business.This field is returned if it exists in the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BusinessToken { get; set; }
#nullable restore
#else
        public string BusinessToken { get; set; }
#endif
        /// <summary>Date and time when the GPA order was created, in UTC.</summary>
        public DateTimeOffset? CreatedTime { get; set; }
        /// <summary>Three-digit ISO 4217 currency code.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CurrencyCode { get; set; }
#nullable restore
#else
        public string CurrencyCode { get; set; }
#endif
        /// <summary>List of fees associated with the funding transaction.This array is returned if it exists in the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Fee_detail>? Fees { get; set; }
#nullable restore
#else
        public List<Fee_detail> Fees { get; set; }
#endif
        /// <summary>Contains funding information for the transaction, including funding amount, type, and time.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Marqeta.Core.Sdk.Models.Funding? Funding { get; set; }
#nullable restore
#else
        public Marqeta.Core.Sdk.Models.Funding Funding { get; set; }
#endif
        /// <summary>Unique identifier of the funding source address to use for this order.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FundingSourceAddressToken { get; set; }
#nullable restore
#else
        public string FundingSourceAddressToken { get; set; }
#endif
        /// <summary>Unique identifier of the funding source to use for this order.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FundingSourceToken { get; set; }
#nullable restore
#else
        public string FundingSourceToken { get; set; }
#endif
        /// <summary>Message about the status of the funding request.Useful for determining whether it was approved and completed successfully, declined by the gateway, or timed out.This field is returned if it exists in the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GatewayMessage { get; set; }
#nullable restore
#else
        public string GatewayMessage { get; set; }
#endif
        /// <summary>Unique identifier of the JIT Funding request and response.This field is returned if it exists in the resource.</summary>
        public long? GatewayToken { get; set; }
        /// <summary>Contains information about the JIT Funding load event, in which funds are loaded into an account.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Jit_funding_api? JitFunding { get; set; }
#nullable restore
#else
        public Jit_funding_api JitFunding { get; set; }
#endif
        /// <summary>Date and time when the GPA order was last modified, in UTC.</summary>
        public DateTimeOffset? LastModifiedTime { get; set; }
        /// <summary>Additional descriptive text.This field is returned if it exists in the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Memo { get; set; }
#nullable restore
#else
        public string Memo { get; set; }
#endif
        /// <summary>Response codes and memos for address verification, card security verification, and transactions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Marqeta.Core.Sdk.Models.Response? Response { get; set; }
#nullable restore
#else
        public Marqeta.Core.Sdk.Models.Response Response { get; set; }
#endif
        /// <summary>Current status of the funding transaction.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? State { get; set; }
#nullable restore
#else
        public string State { get; set; }
#endif
        /// <summary>Comma-delimited list of tags describing the GPA order.This field is returned if it exists in the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Tags { get; set; }
#nullable restore
#else
        public string Tags { get; set; }
#endif
        /// <summary>Unique identifier of the GPA order.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>Unique identifier of the transaction being funded.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TransactionToken { get; set; }
#nullable restore
#else
        public string TransactionToken { get; set; }
#endif
        /// <summary>Unique identifier of the user resource.This field is returned if it exists in the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserToken { get; set; }
#nullable restore
#else
        public string UserToken { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Gpa_response"/> and sets the default values.
        /// </summary>
        public Gpa_response() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Gpa_response"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Gpa_response CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Gpa_response();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"amount", n => { Amount = n.GetDoubleValue(); } },
                {"business_token", n => { BusinessToken = n.GetStringValue(); } },
                {"created_time", n => { CreatedTime = n.GetDateTimeOffsetValue(); } },
                {"currency_code", n => { CurrencyCode = n.GetStringValue(); } },
                {"fees", n => { Fees = n.GetCollectionOfObjectValues<Fee_detail>(Fee_detail.CreateFromDiscriminatorValue)?.ToList(); } },
                {"funding", n => { Funding = n.GetObjectValue<Marqeta.Core.Sdk.Models.Funding>(Marqeta.Core.Sdk.Models.Funding.CreateFromDiscriminatorValue); } },
                {"funding_source_address_token", n => { FundingSourceAddressToken = n.GetStringValue(); } },
                {"funding_source_token", n => { FundingSourceToken = n.GetStringValue(); } },
                {"gateway_message", n => { GatewayMessage = n.GetStringValue(); } },
                {"gateway_token", n => { GatewayToken = n.GetLongValue(); } },
                {"jit_funding", n => { JitFunding = n.GetObjectValue<Jit_funding_api>(Jit_funding_api.CreateFromDiscriminatorValue); } },
                {"last_modified_time", n => { LastModifiedTime = n.GetDateTimeOffsetValue(); } },
                {"memo", n => { Memo = n.GetStringValue(); } },
                {"response", n => { Response = n.GetObjectValue<Marqeta.Core.Sdk.Models.Response>(Marqeta.Core.Sdk.Models.Response.CreateFromDiscriminatorValue); } },
                {"state", n => { State = n.GetStringValue(); } },
                {"tags", n => { Tags = n.GetStringValue(); } },
                {"token", n => { Token = n.GetStringValue(); } },
                {"transaction_token", n => { TransactionToken = n.GetStringValue(); } },
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
            writer.WriteDateTimeOffsetValue("created_time", CreatedTime);
            writer.WriteStringValue("currency_code", CurrencyCode);
            writer.WriteCollectionOfObjectValues<Fee_detail>("fees", Fees);
            writer.WriteObjectValue<Marqeta.Core.Sdk.Models.Funding>("funding", Funding);
            writer.WriteStringValue("funding_source_address_token", FundingSourceAddressToken);
            writer.WriteStringValue("funding_source_token", FundingSourceToken);
            writer.WriteStringValue("gateway_message", GatewayMessage);
            writer.WriteLongValue("gateway_token", GatewayToken);
            writer.WriteObjectValue<Jit_funding_api>("jit_funding", JitFunding);
            writer.WriteDateTimeOffsetValue("last_modified_time", LastModifiedTime);
            writer.WriteStringValue("memo", Memo);
            writer.WriteObjectValue<Marqeta.Core.Sdk.Models.Response>("response", Response);
            writer.WriteStringValue("state", State);
            writer.WriteStringValue("tags", Tags);
            writer.WriteStringValue("token", Token);
            writer.WriteStringValue("transaction_token", TransactionToken);
            writer.WriteStringValue("user_token", UserToken);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}