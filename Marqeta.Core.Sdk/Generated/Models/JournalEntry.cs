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
    /// Contains information about a journal entry.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class JournalEntry : IAdditionalDataHolder, IParsable
    {
        /// <summary>Unique identifier of the credit account associated with the credit card used to make the journal entry.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountToken { get; set; }
#nullable restore
#else
        public string AccountToken { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Amount of the journal entry.</summary>
        public double? Amount { get; set; }
        /// <summary>Unique identifier of the credit card used to make the journal entry.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CardToken { get; set; }
#nullable restore
#else
        public string CardToken { get; set; }
#endif
        /// <summary>Date and time when the journal entry was created on Marqeta&apos;s credit platform, in UTC.</summary>
        public DateTimeOffset? CreatedTime { get; set; }
        /// <summary>Valid three-digit link:https://www.iso.org/iso-4217-currency-codes.html[ISO 4217 currency code, window=&quot;_blank&quot;].</summary>
        public global::Marqeta.Core.Sdk.Models.CurrencyCode? CurrencyCode { get; set; }
        /// <summary>The detail_object property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.Models.JournalEntry_detail_object? DetailObject { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.JournalEntry_detail_object DetailObject { get; set; }
#endif
        /// <summary>Unique identifier of the journal entry&apos;s full details.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DetailToken { get; set; }
#nullable restore
#else
        public string DetailToken { get; set; }
#endif
        /// <summary>Unique identifier of the dispute, if the journal entry is disputed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisputeToken { get; set; }
#nullable restore
#else
        public string DisputeToken { get; set; }
#endif
        /// <summary>Group to which the journal entry belongs.</summary>
        public global::Marqeta.Core.Sdk.Models.JournalEntry_group? Group { get; set; }
        /// <summary>Eight-digit numeric identifier of the journal entry, an alternate identifier to the UUID that is useful for remembering and referencing.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>Date and time when the journal entry impacts the account balance.For purchases, this is the time of the authorization.For purchase authorization clearings, this is the time when the transaction is settled.</summary>
        public DateTimeOffset? ImpactTime { get; set; }
        /// <summary>Merchant name or description for the journal entry.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Memo { get; set; }
#nullable restore
#else
        public string Memo { get; set; }
#endif
        /// <summary>Original Currency</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.Models.OriginalCurrency? OriginalCurrency { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.OriginalCurrency OriginalCurrency { get; set; }
#endif
        /// <summary>Unique identifier of the original journal entry.If the current journal entry is the original, this field is returned empty.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RelatedToken { get; set; }
#nullable restore
#else
        public string RelatedToken { get; set; }
#endif
        /// <summary>For purchases, the date and time of the authorization, which is when the user initiates the journal entry.For other journal entry groups, equivalent to `impact_time`.</summary>
        public DateTimeOffset? RequestTime { get; set; }
        /// <summary>Unique identifier of the root journal entry.If the current journal entry is the root, this field is returned empty.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RootToken { get; set; }
#nullable restore
#else
        public string RootToken { get; set; }
#endif
        /// <summary>Status of the journal entry when it was initially recorded and had an impact on the balance, either `PENDING` or `POSTED`.This field is immutable and may not represent the current status.To view the current status of purchases, refunds, OCTs, and payments, see the `detail_object.state` field.These journal entries start in `PENDING` and can transition to `CLEARED`, `DECLINED`, or `ERROR`.This transition of status is only sent through webhook event notifications.Journal entries that are final transactions, such as clearings, start and remain in a `POSTED` state.*NOTE*:`CLEARED`, `DECLINED`, and `ERROR` are special statuses that do not have an impact on the account balance, and are not recorded in the journal.For these special statuses, `impact_time`, `request_time`, `created_time`, `token`, and `id` are returned blank.</summary>
        public global::Marqeta.Core.Sdk.Models.JournalEntry_status? Status { get; set; }
        /// <summary>Unique identifier of the journal entry.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>Journal entry event type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type { get; set; }
#nullable restore
#else
        public string Type { get; set; }
#endif
        /// <summary>Unique identifier of the credit user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserToken { get; set; }
#nullable restore
#else
        public string UserToken { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.JournalEntry"/> and sets the default values.
        /// </summary>
        public JournalEntry()
        {
            AdditionalData = new Dictionary<string, object>();
            CurrencyCode = global::Marqeta.Core.Sdk.Models.CurrencyCode.USD;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.JournalEntry"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.JournalEntry CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.JournalEntry();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "account_token", n => { AccountToken = n.GetStringValue(); } },
                { "amount", n => { Amount = n.GetDoubleValue(); } },
                { "card_token", n => { CardToken = n.GetStringValue(); } },
                { "created_time", n => { CreatedTime = n.GetDateTimeOffsetValue(); } },
                { "currency_code", n => { CurrencyCode = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.CurrencyCode>(); } },
                { "detail_object", n => { DetailObject = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.JournalEntry_detail_object>(global::Marqeta.Core.Sdk.Models.JournalEntry_detail_object.CreateFromDiscriminatorValue); } },
                { "detail_token", n => { DetailToken = n.GetStringValue(); } },
                { "dispute_token", n => { DisputeToken = n.GetStringValue(); } },
                { "group", n => { Group = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.JournalEntry_group>(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "impact_time", n => { ImpactTime = n.GetDateTimeOffsetValue(); } },
                { "memo", n => { Memo = n.GetStringValue(); } },
                { "original_currency", n => { OriginalCurrency = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.OriginalCurrency>(global::Marqeta.Core.Sdk.Models.OriginalCurrency.CreateFromDiscriminatorValue); } },
                { "related_token", n => { RelatedToken = n.GetStringValue(); } },
                { "request_time", n => { RequestTime = n.GetDateTimeOffsetValue(); } },
                { "root_token", n => { RootToken = n.GetStringValue(); } },
                { "status", n => { Status = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.JournalEntry_status>(); } },
                { "token", n => { Token = n.GetStringValue(); } },
                { "type", n => { Type = n.GetStringValue(); } },
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
            writer.WriteStringValue("account_token", AccountToken);
            writer.WriteDoubleValue("amount", Amount);
            writer.WriteStringValue("card_token", CardToken);
            writer.WriteDateTimeOffsetValue("created_time", CreatedTime);
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.CurrencyCode>("currency_code", CurrencyCode);
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.JournalEntry_detail_object>("detail_object", DetailObject);
            writer.WriteStringValue("detail_token", DetailToken);
            writer.WriteStringValue("dispute_token", DisputeToken);
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.JournalEntry_group>("group", Group);
            writer.WriteStringValue("id", Id);
            writer.WriteDateTimeOffsetValue("impact_time", ImpactTime);
            writer.WriteStringValue("memo", Memo);
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.OriginalCurrency>("original_currency", OriginalCurrency);
            writer.WriteStringValue("related_token", RelatedToken);
            writer.WriteDateTimeOffsetValue("request_time", RequestTime);
            writer.WriteStringValue("root_token", RootToken);
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.JournalEntry_status>("status", Status);
            writer.WriteStringValue("token", Token);
            writer.WriteStringValue("type", Type);
            writer.WriteStringValue("user_token", UserToken);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
