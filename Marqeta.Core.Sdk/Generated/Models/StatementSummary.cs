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
    /// Contains the summary data for an account&apos;s monthly statement.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class StatementSummary : IAdditionalDataHolder, IParsable
    {
        /// <summary>Unique identifier of the credit account on which the statement summary is generated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountToken { get; set; }
#nullable restore
#else
        public string AccountToken { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Amount available to spend on the credit account, as of the statement closing date.</summary>
        public double? AvailableCredit { get; set; }
        /// <summary>Balance of the credit account when the statement period ended.</summary>
        public double? ClosingBalance { get; set; }
        /// <summary>Date and time when the statement period ended.</summary>
        public DateTimeOffset? ClosingDate { get; set; }
        /// <summary>Date and time when the statement summary was created on Marqeta&apos;s credit platform, in UTC.</summary>
        public DateTimeOffset? CreatedTime { get; set; }
        /// <summary>Maximum balance the credit account can carry, as of the statement closing date.</summary>
        public double? CreditLimit { get; set; }
        /// <summary>Total amount of credits received during the statement period.</summary>
        public double? Credits { get; set; }
        /// <summary>Type of cycle.* `BEGINNING_REVOLVING` - Account is beginning to revolve and just started carrying a balancefrom the previous month.* `REVOLVING` - Account is revolving and has been carrying a balance from month to month for more than one month.* `END_REVOLVING` - Account is no longer revolving and the previous month&apos;s balance is paid off.* `TRANSACTING` - Account is not revolving and the balance is paid off each month.</summary>
        public global::Marqeta.Core.Sdk.Models.CycleType? CycleType { get; set; }
        /// <summary>Number of days in the billing cycle, also known as the statement period.</summary>
        public int? DaysInBillingCycle { get; set; }
        /// <summary>Total amount of fees charged during the statement period.Does not include periodic fees.</summary>
        public double? Fees { get; set; }
        /// <summary>Total amount of interest charged during the statement period.</summary>
        public double? Interest { get; set; }
        /// <summary>Balance of the credit account when the statement period began.</summary>
        public double? OpeningBalance { get; set; }
        /// <summary>Date and time when the statement period began.</summary>
        public DateTimeOffset? OpeningDate { get; set; }
        /// <summary>Total payment amount, required to make the account current.</summary>
        public double? PastDueAmount { get; set; }
        /// <summary>Total amount of payments made during the statement period.</summary>
        public double? Payments { get; set; }
        /// <summary>Total amount of purchases made during the statement period.</summary>
        public double? Purchases { get; set; }
        /// <summary>Unique identifier of the statement summary.</summary>
        public Guid? Token { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.StatementSummary"/> and sets the default values.
        /// </summary>
        public StatementSummary()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.StatementSummary"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.StatementSummary CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.StatementSummary();
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
                { "available_credit", n => { AvailableCredit = n.GetDoubleValue(); } },
                { "closing_balance", n => { ClosingBalance = n.GetDoubleValue(); } },
                { "closing_date", n => { ClosingDate = n.GetDateTimeOffsetValue(); } },
                { "created_time", n => { CreatedTime = n.GetDateTimeOffsetValue(); } },
                { "credit_limit", n => { CreditLimit = n.GetDoubleValue(); } },
                { "credits", n => { Credits = n.GetDoubleValue(); } },
                { "cycle_type", n => { CycleType = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.CycleType>(); } },
                { "days_in_billing_cycle", n => { DaysInBillingCycle = n.GetIntValue(); } },
                { "fees", n => { Fees = n.GetDoubleValue(); } },
                { "interest", n => { Interest = n.GetDoubleValue(); } },
                { "opening_balance", n => { OpeningBalance = n.GetDoubleValue(); } },
                { "opening_date", n => { OpeningDate = n.GetDateTimeOffsetValue(); } },
                { "past_due_amount", n => { PastDueAmount = n.GetDoubleValue(); } },
                { "payments", n => { Payments = n.GetDoubleValue(); } },
                { "purchases", n => { Purchases = n.GetDoubleValue(); } },
                { "token", n => { Token = n.GetGuidValue(); } },
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
            writer.WriteDoubleValue("available_credit", AvailableCredit);
            writer.WriteDoubleValue("closing_balance", ClosingBalance);
            writer.WriteDateTimeOffsetValue("closing_date", ClosingDate);
            writer.WriteDateTimeOffsetValue("created_time", CreatedTime);
            writer.WriteDoubleValue("credit_limit", CreditLimit);
            writer.WriteDoubleValue("credits", Credits);
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.CycleType>("cycle_type", CycleType);
            writer.WriteIntValue("days_in_billing_cycle", DaysInBillingCycle);
            writer.WriteDoubleValue("fees", Fees);
            writer.WriteDoubleValue("interest", Interest);
            writer.WriteDoubleValue("opening_balance", OpeningBalance);
            writer.WriteDateTimeOffsetValue("opening_date", OpeningDate);
            writer.WriteDoubleValue("past_due_amount", PastDueAmount);
            writer.WriteDoubleValue("payments", Payments);
            writer.WriteDoubleValue("purchases", Purchases);
            writer.WriteGuidValue("token", Token);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
