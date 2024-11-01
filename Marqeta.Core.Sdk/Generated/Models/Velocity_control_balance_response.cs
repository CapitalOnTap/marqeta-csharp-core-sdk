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
    public partial class Velocity_control_balance_response : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Indicates whether the velocity control is active.</summary>
        public bool? Active { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Maximum monetary sum that can be cleared within the time period defined by the `velocity_window` field.Refunds and reversals cannot exceed this limit.</summary>
        public double? AmountLimit { get; set; }
        /// <summary>If set to `true`, only approved transactions are subject to control.If set to `false`, only declined transactions are subject to control.</summary>
        public bool? ApprovalsOnly { get; set; }
        /// <summary>Defines the group of users to which the velocity control applies.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.Models.Spend_control_association? Association { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.Spend_control_association Association { get; set; }
#endif
        /// <summary>Specifies the available balances of the velocity controls associated with a user.This object is not returned if the velocity control window is `TRANSACTION`, because available balances do not apply to single-transaction velocity windows.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.Models.Available? Available { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.Available Available { get; set; }
#endif
        /// <summary>Three-character ISO 4217 currency code.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CurrencyCode { get; set; }
#nullable restore
#else
        public string CurrencyCode { get; set; }
#endif
        /// <summary>If set to `true`, the cashback components of point-of-sale transactions are subject to control.</summary>
        public bool? IncludeCashback { get; set; }
        /// <summary>If set to `true`, original credit transactions (OCT) are subject to control.</summary>
        public bool? IncludeCredits { get; set; }
        /// <summary>If set to `true`, the following transactions are subject to control:* *Account funding:* All account funding transactions* *Cashback:* Only the purchase component of cashback transactions* *Purchase transactions:* All authorizations, PIN debit transactions, and incremental transactions* *Quasi-cash:* All quasi-cash transactions* *Refunds:* All refund transactions (see &lt;&lt;/developer-guides/controlling-spending#_controls_to_limit_amount_and_frequency_of_spending, Controls to limit amount and frequency of spending&gt;&gt; for more information)* *Reversals:* All reversal transactions</summary>
        public bool? IncludePurchases { get; set; }
        /// <summary>If set to `true`, account-to-account transfers are subject to control.Account-to-account transfers are not currently supported.</summary>
        public bool? IncludeTransfers { get; set; }
        /// <summary>If set to `true`, ATM withdrawals are subject to control.</summary>
        public bool? IncludeWithdrawals { get; set; }
        /// <summary>Defines the group of merchants to which the velocity control applies.Populate no more than one field of the `merchant_scope` object.If no fields are populated, the velocity control applies to all merchants.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.Models.Merchant_scope? MerchantScope { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.Merchant_scope MerchantScope { get; set; }
#endif
        /// <summary>Defines the original credit transaction (OCT) types that are subject to velocity control.Your request can contain either a `money_in_transaction` object or the `include_credits` field, not both.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.Models.Money_in_transaction? MoneyInTransaction { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.Money_in_transaction MoneyInTransaction { get; set; }
#endif
        /// <summary>Description of how the velocity control restricts spending, for example, &quot;Max spend of $500 per day&quot; or &quot;Max spend of $5000 per month for non-exempt employees&quot;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Unique identifier of the velocity control.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>Maximum number of times a card can be used within the time period defined by the `velocity_window` field.</summary>
        public int? UsageLimit { get; set; }
        /// <summary>Defines the time period to which the `amount_limit` and `usage_limit` fields apply:* *DAY* – one day; days begin at 00:00:00 UTC.* *WEEK* – one week; weeks begin Sundays at 00:00:00 UTC.* *MONTH* – one month; months begin on the first day of month at 00:00:00 UTC.* *LIFETIME* – forever; time period never expires.* *TRANSACTION* – a single transaction.</summary>
        public global::Marqeta.Core.Sdk.Models.Velocity_control_balance_response_velocity_window? VelocityWindow { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.Velocity_control_balance_response"/> and sets the default values.
        /// </summary>
        public Velocity_control_balance_response()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.Velocity_control_balance_response"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.Velocity_control_balance_response CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.Velocity_control_balance_response();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "active", n => { Active = n.GetBoolValue(); } },
                { "amount_limit", n => { AmountLimit = n.GetDoubleValue(); } },
                { "approvals_only", n => { ApprovalsOnly = n.GetBoolValue(); } },
                { "association", n => { Association = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.Spend_control_association>(global::Marqeta.Core.Sdk.Models.Spend_control_association.CreateFromDiscriminatorValue); } },
                { "available", n => { Available = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.Available>(global::Marqeta.Core.Sdk.Models.Available.CreateFromDiscriminatorValue); } },
                { "currency_code", n => { CurrencyCode = n.GetStringValue(); } },
                { "include_cashback", n => { IncludeCashback = n.GetBoolValue(); } },
                { "include_credits", n => { IncludeCredits = n.GetBoolValue(); } },
                { "include_purchases", n => { IncludePurchases = n.GetBoolValue(); } },
                { "include_transfers", n => { IncludeTransfers = n.GetBoolValue(); } },
                { "include_withdrawals", n => { IncludeWithdrawals = n.GetBoolValue(); } },
                { "merchant_scope", n => { MerchantScope = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.Merchant_scope>(global::Marqeta.Core.Sdk.Models.Merchant_scope.CreateFromDiscriminatorValue); } },
                { "money_in_transaction", n => { MoneyInTransaction = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.Money_in_transaction>(global::Marqeta.Core.Sdk.Models.Money_in_transaction.CreateFromDiscriminatorValue); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "token", n => { Token = n.GetStringValue(); } },
                { "usage_limit", n => { UsageLimit = n.GetIntValue(); } },
                { "velocity_window", n => { VelocityWindow = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.Velocity_control_balance_response_velocity_window>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("active", Active);
            writer.WriteDoubleValue("amount_limit", AmountLimit);
            writer.WriteBoolValue("approvals_only", ApprovalsOnly);
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.Spend_control_association>("association", Association);
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.Available>("available", Available);
            writer.WriteStringValue("currency_code", CurrencyCode);
            writer.WriteBoolValue("include_cashback", IncludeCashback);
            writer.WriteBoolValue("include_credits", IncludeCredits);
            writer.WriteBoolValue("include_purchases", IncludePurchases);
            writer.WriteBoolValue("include_transfers", IncludeTransfers);
            writer.WriteBoolValue("include_withdrawals", IncludeWithdrawals);
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.Merchant_scope>("merchant_scope", MerchantScope);
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.Money_in_transaction>("money_in_transaction", MoneyInTransaction);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("token", Token);
            writer.WriteIntValue("usage_limit", UsageLimit);
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.Velocity_control_balance_response_velocity_window>("velocity_window", VelocityWindow);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
