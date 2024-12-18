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
    /// Contains details of the account&apos;s delinquency state transition.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DelinquencyTransitionResponse : IAdditionalDataHolder, IParsable
    {
        /// <summary>Unique identifier of the credit account.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountToken { get; set; }
#nullable restore
#else
        public string AccountToken { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Number of buckets for the account after the triggering event occurred.</summary>
        public double? BucketCount { get; set; }
        /// <summary>Date and time when the delinquency state transition was created on Marqeta&apos;s credit platform, in UTC.</summary>
        public DateTimeOffset? CreatedTime { get; set; }
        /// <summary>Current amount that is due after the triggering event occurred.Equivalent to `current_due` for the account&apos;s most recent delinquency bucket.To retrieve delinquency buckets for an account, send a `GET` request to `/credit/accounts/{account_token}/delinquencystate`.</summary>
        public double? CurrentDue { get; set; }
        /// <summary>Date and time when the triggering event impacted the account, in UTC.</summary>
        public DateTimeOffset? ImpactTime { get; set; }
        /// <summary>A value of `true` indicates that the system invalidated and rolled back the delinquency transition.This is a temporary field that allows Marqeta to handle occasional cases of out-of-order processing.This can occur when two delinquency state transition webhooks are sent near-simultaneously.For example, if a credit and a payment that bring an account current are made around the same time, two delinquency state transitions are sent very close together.In these cases, one of the transitions is rolled back and invalidated.For the transition that is rolled back, `is_rolled_back` is `true` and the transition should be ignored.This field is temporary and to be deprecated when out-of-order processing is addressed in a future release.</summary>
        public bool? IsRolledBack { get; set; }
        /// <summary>Payment due date of the account&apos;s oldest delinquency bucket, in UTC.Useful when used with the delinquency state transition&apos;s `created_time` to determine the total number of days a payment is past due.</summary>
        public DateTimeOffset? OldestPaymentDueDate { get; set; }
        /// <summary>Delinquency status of an account.</summary>
        public global::Marqeta.Core.Sdk.Models.DelinquencyStatus? OriginalStatus { get; set; }
        /// <summary>Delinquency status of an account.</summary>
        public global::Marqeta.Core.Sdk.Models.DelinquencyStatus? Status { get; set; }
        /// <summary>Unique identifier of the delinquency state transition.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>Total amount that is due after the triggering event occurred; the sum of `total_past_due` and `current_due`.Equivalent to `total_due` for the account&apos;s most recent delinquency bucket.To retrieve delinquency buckets for an account, send a `GET` request to `/credit/accounts/{account_token}/delinquencystate`.</summary>
        public double? TotalDue { get; set; }
        /// <summary>Total amount that is past due after the triggering event occurred.Equivalent to `past_due_carried_forward` for the account&apos;s most recent delinquency bucket.To retrieve delinquency buckets for an account, send a `GET` request to `/credit/accounts/{account_token}/delinquencystate`.</summary>
        public double? TotalPastDue { get; set; }
        /// <summary>Event that triggered an update to the account&apos;s delinquency state.</summary>
        public global::Marqeta.Core.Sdk.Models.DelinquencyTransitionTriggerReason? TransitionTriggerReason { get; set; }
        /// <summary>Date and time when the triggering event caused the account&apos;s delinquency state to transition, in UTC.For &lt;&lt;/core-api/credit-account-journal-entries, journal entries&gt;&gt;, equivalent to `request_time`.For &lt;&lt;/core-api/credit-account-statements#listStatementJournalEntries, statement journal entries&gt;&gt;, equivalent to `impact_time`,</summary>
        public DateTimeOffset? TransitionTriggerTime { get; set; }
        /// <summary>Date and time when the delinquency state transition was last updated on Marqeta&apos;s credit platform, in UTC.</summary>
        public DateTimeOffset? UpdatedTime { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.DelinquencyTransitionResponse"/> and sets the default values.
        /// </summary>
        public DelinquencyTransitionResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.DelinquencyTransitionResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.DelinquencyTransitionResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.DelinquencyTransitionResponse();
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
                { "bucket_count", n => { BucketCount = n.GetDoubleValue(); } },
                { "created_time", n => { CreatedTime = n.GetDateTimeOffsetValue(); } },
                { "current_due", n => { CurrentDue = n.GetDoubleValue(); } },
                { "impact_time", n => { ImpactTime = n.GetDateTimeOffsetValue(); } },
                { "is_rolled_back", n => { IsRolledBack = n.GetBoolValue(); } },
                { "oldest_payment_due_date", n => { OldestPaymentDueDate = n.GetDateTimeOffsetValue(); } },
                { "original_status", n => { OriginalStatus = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.DelinquencyStatus>(); } },
                { "status", n => { Status = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.DelinquencyStatus>(); } },
                { "token", n => { Token = n.GetStringValue(); } },
                { "total_due", n => { TotalDue = n.GetDoubleValue(); } },
                { "total_past_due", n => { TotalPastDue = n.GetDoubleValue(); } },
                { "transition_trigger_reason", n => { TransitionTriggerReason = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.DelinquencyTransitionTriggerReason>(); } },
                { "transition_trigger_time", n => { TransitionTriggerTime = n.GetDateTimeOffsetValue(); } },
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
            writer.WriteDoubleValue("bucket_count", BucketCount);
            writer.WriteDateTimeOffsetValue("created_time", CreatedTime);
            writer.WriteDoubleValue("current_due", CurrentDue);
            writer.WriteDateTimeOffsetValue("impact_time", ImpactTime);
            writer.WriteBoolValue("is_rolled_back", IsRolledBack);
            writer.WriteDateTimeOffsetValue("oldest_payment_due_date", OldestPaymentDueDate);
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.DelinquencyStatus>("original_status", OriginalStatus);
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.DelinquencyStatus>("status", Status);
            writer.WriteStringValue("token", Token);
            writer.WriteDoubleValue("total_due", TotalDue);
            writer.WriteDoubleValue("total_past_due", TotalPastDue);
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.DelinquencyTransitionTriggerReason>("transition_trigger_reason", TransitionTriggerReason);
            writer.WriteDateTimeOffsetValue("transition_trigger_time", TransitionTriggerTime);
            writer.WriteDateTimeOffsetValue("updated_time", UpdatedTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
