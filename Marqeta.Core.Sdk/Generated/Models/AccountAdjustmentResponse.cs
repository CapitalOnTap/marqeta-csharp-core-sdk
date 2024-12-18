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
    /// Contains information returned for account adjustment.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class AccountAdjustmentResponse : IAdditionalDataHolder, IParsable
    {
        /// <summary>Unique identifier of the credit account on which the adjustment was made.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountToken { get; set; }
#nullable restore
#else
        public string AccountToken { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Contains the adjustment&apos;s full details.The fields returned in this object depend on the adjustment type.Interest returns interest details.For the specific fields returned, see the `detail_object` fields marked &quot;Returned for interest journal entries&quot; in the &lt;&lt;/core-api/credit-account-journal-entries#getAccountJournalEntry, account journal entry response fields&gt;&gt;.Disputes return dispute details.For the specific fields returned, see the &lt;&lt;/core-api/credit-disputes#retrieveDispute, dispute response fields&gt;&gt;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.Models.AccountAdjustmentResponse_adjustment_detail_object? AdjustmentDetailObject { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.AccountAdjustmentResponse_adjustment_detail_object AdjustmentDetailObject { get; set; }
#endif
        /// <summary>Amount of the adjustment.</summary>
        public double? Amount { get; set; }
        /// <summary>Date and time when the account adjustment was applied, in UTC.</summary>
        public DateTimeOffset? CreatedTime { get; set; }
        /// <summary>Valid three-digit link:https://www.iso.org/iso-4217-currency-codes.html[ISO 4217 currency code, window=&quot;_blank&quot;].</summary>
        public global::Marqeta.Core.Sdk.Models.CurrencyCode? CurrencyCode { get; set; }
        /// <summary>Description of the adjustment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Unique identifier of the adjustment detail.For example, the token of the dispute, the interest charge, or the returned payment that prompted the adjustment.Returned when the system automatically applies an adjustment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DetailToken { get; set; }
#nullable restore
#else
        public string DetailToken { get; set; }
#endif
        /// <summary>Unique identifier you provide of an associated external adjustment that exists outside Marqeta&apos;s credit platform.</summary>
        public Guid? ExternalAdjustmentId { get; set; }
        /// <summary>Additional information on the adjustment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Note { get; set; }
#nullable restore
#else
        public string Note { get; set; }
#endif
        /// <summary>Unique identifier of the original journal entry needing the adjustment.</summary>
        public Guid? OriginalLedgerEntryToken { get; set; }
        /// <summary>Reason for the adjustment.* `DISPUTE` - The adjustment occurred because a dispute was initiated.* `DISPUTE_RESOLUTION` - The adjustment occurred because of the result of a dispute resolution.* `RETURNED_OR_CANCELED_PAYMENT` - The adjustment occurred because a payment was returned or canceled.* `OTHER` - Any other reason the adjustment occurred. For example, a waived fee.</summary>
        public global::Marqeta.Core.Sdk.Models.AccountAdjustmentResponse_reason? Reason { get; set; }
        /// <summary>Contains full details of the related dispute or returned payment.The fields returned in this object depend on whether a dispute or returned payment led to the interest adjustment.A dispute returns dispute details; a returned payment returns payment details.For more on the dispute details returned, see the &lt;&lt;/core-api/credit-disputes#retrieveDispute, dispute response fields&gt;&gt;.For more on the returned payment details returned, see the &lt;&lt;/core-api/credit-account-payments#retrievePayment, payment response fields&gt;&gt;.This field is returned for interest adjustments only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.Models.AccountAdjustmentResponse_related_detail_object? RelatedDetailObject { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.AccountAdjustmentResponse_related_detail_object RelatedDetailObject { get; set; }
#endif
        /// <summary>Unique identifier of the dispute or returned payment that prompted the interest adjustment.This field is returned for interest adjustments only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RelatedDetailToken { get; set; }
#nullable restore
#else
        public string RelatedDetailToken { get; set; }
#endif
        /// <summary>Unique identifier of the adjustment.If in the `detail_object`, unique identifier of the detail object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>Type of adjustment.The adjustment is made on its correlating amount (for example, purchase adjustments are made on purchase amounts).You can use general adjustments for standalone adjustments made on the credit account balance itself, which includes account write-offs, credits, and more.</summary>
        public global::Marqeta.Core.Sdk.Models.AccountAdjustmentResponse_type? Type { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.AccountAdjustmentResponse"/> and sets the default values.
        /// </summary>
        public AccountAdjustmentResponse()
        {
            AdditionalData = new Dictionary<string, object>();
            CurrencyCode = global::Marqeta.Core.Sdk.Models.CurrencyCode.USD;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.AccountAdjustmentResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.AccountAdjustmentResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.AccountAdjustmentResponse();
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
                { "adjustment_detail_object", n => { AdjustmentDetailObject = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.AccountAdjustmentResponse_adjustment_detail_object>(global::Marqeta.Core.Sdk.Models.AccountAdjustmentResponse_adjustment_detail_object.CreateFromDiscriminatorValue); } },
                { "amount", n => { Amount = n.GetDoubleValue(); } },
                { "created_time", n => { CreatedTime = n.GetDateTimeOffsetValue(); } },
                { "currency_code", n => { CurrencyCode = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.CurrencyCode>(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "detail_token", n => { DetailToken = n.GetStringValue(); } },
                { "external_adjustment_id", n => { ExternalAdjustmentId = n.GetGuidValue(); } },
                { "note", n => { Note = n.GetStringValue(); } },
                { "original_ledger_entry_token", n => { OriginalLedgerEntryToken = n.GetGuidValue(); } },
                { "reason", n => { Reason = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.AccountAdjustmentResponse_reason>(); } },
                { "related_detail_object", n => { RelatedDetailObject = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.AccountAdjustmentResponse_related_detail_object>(global::Marqeta.Core.Sdk.Models.AccountAdjustmentResponse_related_detail_object.CreateFromDiscriminatorValue); } },
                { "related_detail_token", n => { RelatedDetailToken = n.GetStringValue(); } },
                { "token", n => { Token = n.GetStringValue(); } },
                { "type", n => { Type = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.AccountAdjustmentResponse_type>(); } },
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
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.AccountAdjustmentResponse_adjustment_detail_object>("adjustment_detail_object", AdjustmentDetailObject);
            writer.WriteDoubleValue("amount", Amount);
            writer.WriteDateTimeOffsetValue("created_time", CreatedTime);
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.CurrencyCode>("currency_code", CurrencyCode);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("detail_token", DetailToken);
            writer.WriteGuidValue("external_adjustment_id", ExternalAdjustmentId);
            writer.WriteStringValue("note", Note);
            writer.WriteGuidValue("original_ledger_entry_token", OriginalLedgerEntryToken);
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.AccountAdjustmentResponse_reason>("reason", Reason);
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.AccountAdjustmentResponse_related_detail_object>("related_detail_object", RelatedDetailObject);
            writer.WriteStringValue("related_detail_token", RelatedDetailToken);
            writer.WriteStringValue("token", Token);
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.AccountAdjustmentResponse_type>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
