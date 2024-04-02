// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    /// <summary>
    /// Details of a billing cycle.
    /// </summary>
    public class AccountBillingCycleResponse : IAdditionalDataHolder, IParsable {
        /// <summary>Token of the associated account.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountToken { get; set; }
#nullable restore
#else
        public string AccountToken { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Date and time when the Billing Cycle was created on Marqeta&apos;s credit platform</summary>
        public DateTimeOffset? CreatedTime { get; set; }
        /// <summary>End time of the current billing cycle.</summary>
        public DateTimeOffset? CurrentEndTime { get; set; }
        /// <summary>Payment due date for the current billing cycle.</summary>
        public DateTimeOffset? CurrentPaymentDueDate { get; set; }
        /// <summary>Start time of the current billing cycle.</summary>
        public DateTimeOffset? CurrentStartTime { get; set; }
        /// <summary>End time of the next billing cycle.</summary>
        public DateTimeOffset? NextEndTime { get; set; }
        /// <summary>Payment due date for the next billing cycle.</summary>
        public DateTimeOffset? NextPaymentDueDate { get; set; }
        /// <summary>Start time of the next billing cycle.</summary>
        public DateTimeOffset? NextStartTime { get; set; }
        /// <summary>Unique identifier of the billing cycle&apos;s short code.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ShortCode { get; set; }
#nullable restore
#else
        public string ShortCode { get; set; }
#endif
        /// <summary>Date and time when the BillingCycle was last updated on Marqeta&apos;s credit platform</summary>
        public DateTimeOffset? UpdatedTime { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="AccountBillingCycleResponse"/> and sets the default values.
        /// </summary>
        public AccountBillingCycleResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AccountBillingCycleResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AccountBillingCycleResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccountBillingCycleResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"account_token", n => { AccountToken = n.GetStringValue(); } },
                {"created_time", n => { CreatedTime = n.GetDateTimeOffsetValue(); } },
                {"current_end_time", n => { CurrentEndTime = n.GetDateTimeOffsetValue(); } },
                {"current_payment_due_date", n => { CurrentPaymentDueDate = n.GetDateTimeOffsetValue(); } },
                {"current_start_time", n => { CurrentStartTime = n.GetDateTimeOffsetValue(); } },
                {"next_end_time", n => { NextEndTime = n.GetDateTimeOffsetValue(); } },
                {"next_payment_due_date", n => { NextPaymentDueDate = n.GetDateTimeOffsetValue(); } },
                {"next_start_time", n => { NextStartTime = n.GetDateTimeOffsetValue(); } },
                {"short_code", n => { ShortCode = n.GetStringValue(); } },
                {"updated_time", n => { UpdatedTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("account_token", AccountToken);
            writer.WriteDateTimeOffsetValue("created_time", CreatedTime);
            writer.WriteDateTimeOffsetValue("current_end_time", CurrentEndTime);
            writer.WriteDateTimeOffsetValue("current_payment_due_date", CurrentPaymentDueDate);
            writer.WriteDateTimeOffsetValue("current_start_time", CurrentStartTime);
            writer.WriteDateTimeOffsetValue("next_end_time", NextEndTime);
            writer.WriteDateTimeOffsetValue("next_payment_due_date", NextPaymentDueDate);
            writer.WriteDateTimeOffsetValue("next_start_time", NextStartTime);
            writer.WriteStringValue("short_code", ShortCode);
            writer.WriteDateTimeOffsetValue("updated_time", UpdatedTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}