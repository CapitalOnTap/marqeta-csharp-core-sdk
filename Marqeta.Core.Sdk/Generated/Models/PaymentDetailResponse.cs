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
    /// Response containing payment details with transition history
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class PaymentDetailResponse : IAdditionalDataHolder, IParsable
    {
        /// <summary>Unique identifier of the credit account on which the payment is made.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountToken { get; set; }
#nullable restore
#else
        public string AccountToken { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>List of objects which contain information on how payment is allocated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Marqeta.Core.Sdk.Models.PaymentAllocationResponse>? Allocations { get; set; }
#nullable restore
#else
        public List<global::Marqeta.Core.Sdk.Models.PaymentAllocationResponse> Allocations { get; set; }
#endif
        /// <summary>Total amount of the payment.</summary>
        public double? Amount { get; set; }
        /// <summary>Date and time when the payment was created on Marqeta&apos;s credit platform, in UTC.</summary>
        public DateTimeOffset? CreatedTime { get; set; }
        /// <summary>Valid three-digit link:https://www.iso.org/iso-4217-currency-codes.html[ISO 4217 currency code, window=&quot;_blank&quot;].</summary>
        public global::Marqeta.Core.Sdk.Models.CurrencyCode? CurrencyCode { get; set; }
        /// <summary>Description of the payment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>After a payment completes, the number of days to hold the available credit on the account before increasing it.</summary>
        public int? HoldDays { get; set; }
        /// <summary>Date and time when the available credit hold is released.</summary>
        public DateTimeOffset? HoldEndTime { get; set; }
        /// <summary>Whether the available credit hold was manually released for this payment.</summary>
        public bool? IsManuallyReleased { get; set; }
        /// <summary>Customer-defined additional information about the payment (for example, a check number).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Metadata { get; set; }
#nullable restore
#else
        public string Metadata { get; set; }
#endif
        /// <summary>Method of payment.</summary>
        public global::Marqeta.Core.Sdk.Models.PaymentDetailResponse_method? Method { get; set; }
        /// <summary>Whether the available credit is on hold for this payment.</summary>
        public bool? OnHold { get; set; }
        /// <summary>Unique identifier of the payment schedule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PaymentScheduleToken { get; set; }
#nullable restore
#else
        public string PaymentScheduleToken { get; set; }
#endif
        /// <summary>Unique identifier of the payment source. Required for ACH payments.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PaymentSourceToken { get; set; }
#nullable restore
#else
        public string PaymentSourceToken { get; set; }
#endif
        /// <summary>Contains details for a refund.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.Models.RefundDetailsResponse? RefundDetails { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.RefundDetailsResponse RefundDetails { get; set; }
#endif
        /// <summary>Contains information on a returned payment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.Models.ReturnedDetails? ReturnedDetails { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.ReturnedDetails ReturnedDetails { get; set; }
#endif
        /// <summary>Current status of the payment or refund.</summary>
        public global::Marqeta.Core.Sdk.Models.PaymentStatus? Status { get; set; }
        /// <summary>Unique identifier of the payment.If in the `detail_object`, unique identifier of the detail object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>Contains one or more `transitions` objects, which contain information on a payment status transition.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Marqeta.Core.Sdk.Models.PaymentTransitionResponse>? Transitions { get; set; }
#nullable restore
#else
        public List<global::Marqeta.Core.Sdk.Models.PaymentTransitionResponse> Transitions { get; set; }
#endif
        /// <summary>Date and time when the payment was last updated on Marqeta&apos;s credit platform, in UTC.</summary>
        public DateTimeOffset? UpdatedTime { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.PaymentDetailResponse"/> and sets the default values.
        /// </summary>
        public PaymentDetailResponse()
        {
            AdditionalData = new Dictionary<string, object>();
            CurrencyCode = global::Marqeta.Core.Sdk.Models.CurrencyCode.USD;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.PaymentDetailResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.PaymentDetailResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.PaymentDetailResponse();
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
                { "allocations", n => { Allocations = n.GetCollectionOfObjectValues<global::Marqeta.Core.Sdk.Models.PaymentAllocationResponse>(global::Marqeta.Core.Sdk.Models.PaymentAllocationResponse.CreateFromDiscriminatorValue)?.AsList(); } },
                { "amount", n => { Amount = n.GetDoubleValue(); } },
                { "created_time", n => { CreatedTime = n.GetDateTimeOffsetValue(); } },
                { "currency_code", n => { CurrencyCode = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.CurrencyCode>(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "hold_days", n => { HoldDays = n.GetIntValue(); } },
                { "hold_end_time", n => { HoldEndTime = n.GetDateTimeOffsetValue(); } },
                { "is_manually_released", n => { IsManuallyReleased = n.GetBoolValue(); } },
                { "metadata", n => { Metadata = n.GetStringValue(); } },
                { "method", n => { Method = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.PaymentDetailResponse_method>(); } },
                { "on_hold", n => { OnHold = n.GetBoolValue(); } },
                { "payment_schedule_token", n => { PaymentScheduleToken = n.GetStringValue(); } },
                { "payment_source_token", n => { PaymentSourceToken = n.GetStringValue(); } },
                { "refund_details", n => { RefundDetails = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.RefundDetailsResponse>(global::Marqeta.Core.Sdk.Models.RefundDetailsResponse.CreateFromDiscriminatorValue); } },
                { "returned_details", n => { ReturnedDetails = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.ReturnedDetails>(global::Marqeta.Core.Sdk.Models.ReturnedDetails.CreateFromDiscriminatorValue); } },
                { "status", n => { Status = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.PaymentStatus>(); } },
                { "token", n => { Token = n.GetStringValue(); } },
                { "transitions", n => { Transitions = n.GetCollectionOfObjectValues<global::Marqeta.Core.Sdk.Models.PaymentTransitionResponse>(global::Marqeta.Core.Sdk.Models.PaymentTransitionResponse.CreateFromDiscriminatorValue)?.AsList(); } },
                { "updated_time", n => { UpdatedTime = n.GetDateTimeOffsetValue(); } },
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
            writer.WriteCollectionOfObjectValues<global::Marqeta.Core.Sdk.Models.PaymentAllocationResponse>("allocations", Allocations);
            writer.WriteDoubleValue("amount", Amount);
            writer.WriteDateTimeOffsetValue("created_time", CreatedTime);
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.CurrencyCode>("currency_code", CurrencyCode);
            writer.WriteStringValue("description", Description);
            writer.WriteIntValue("hold_days", HoldDays);
            writer.WriteDateTimeOffsetValue("hold_end_time", HoldEndTime);
            writer.WriteBoolValue("is_manually_released", IsManuallyReleased);
            writer.WriteStringValue("metadata", Metadata);
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.PaymentDetailResponse_method>("method", Method);
            writer.WriteBoolValue("on_hold", OnHold);
            writer.WriteStringValue("payment_schedule_token", PaymentScheduleToken);
            writer.WriteStringValue("payment_source_token", PaymentSourceToken);
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.RefundDetailsResponse>("refund_details", RefundDetails);
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.ReturnedDetails>("returned_details", ReturnedDetails);
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.PaymentStatus>("status", Status);
            writer.WriteStringValue("token", Token);
            writer.WriteCollectionOfObjectValues<global::Marqeta.Core.Sdk.Models.PaymentTransitionResponse>("transitions", Transitions);
            writer.WriteDateTimeOffsetValue("updated_time", UpdatedTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
