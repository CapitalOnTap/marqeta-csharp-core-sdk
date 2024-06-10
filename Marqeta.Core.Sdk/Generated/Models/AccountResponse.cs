// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models
{
    /// <summary>
    /// Contains information on a credit account.
    /// </summary>
    public class AccountResponse : IAdditionalDataHolder, IParsable
    {
        /// <summary>Date and time when the credit account was activated on Marqeta&apos;s credit platform, in UTC.</summary>
        public DateTimeOffset? ActivationTime { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Amount of credit available for use on the credit account.</summary>
        public double? AvailableCredit { get; set; }
        /// <summary>Unique identifier of the associated bundle product.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BundleToken { get; set; }
#nullable restore
#else
        public string BundleToken { get; set; }
#endif
        /// <summary>Unique identifier of the parent business program.Either a `user_token` or `business_token` is returned, not both.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BusinessToken { get; set; }
#nullable restore
#else
        public string BusinessToken { get; set; }
#endif
        /// <summary>Contains information returned when configuring an account&apos;s billing cycle day, payment due day, fees, and more.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Marqeta.Core.Sdk.Models.AccountConfigResponse? Config { get; set; }
#nullable restore
#else
        public Marqeta.Core.Sdk.Models.AccountConfigResponse Config { get; set; }
#endif
        /// <summary>Date and time when the credit account was created on Marqeta&apos;s credit platform, in UTC.</summary>
        public DateTimeOffset? CreatedTime { get; set; }
        /// <summary>Maximum balance the credit account can carry.</summary>
        public double? CreditLimit { get; set; }
        /// <summary>Unique identifier of the associated credit product.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreditProductToken { get; set; }
#nullable restore
#else
        public string CreditProductToken { get; set; }
#endif
        /// <summary>Valid three-digit link:https://www.iso.org/iso-4217-currency-codes.html[ISO 4217 currency code, window=&quot;_blank&quot;].</summary>
        public Marqeta.Core.Sdk.Models.CurrencyCode? CurrencyCode { get; set; }
        /// <summary>Current purchase balance on the credit account.</summary>
        public double? CurrentBalance { get; set; }
        /// <summary>Description for the credit account.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Unique identifier you provide of the associated external credit offer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalOfferId { get; set; }
#nullable restore
#else
        public string ExternalOfferId { get; set; }
#endif
        /// <summary>Type of cycle.* `BEGINNING_REVOLVING` - Account is beginning to revolve and just started carrying a balancefrom the previous month.* `REVOLVING` - Account is revolving and has been carrying a balance from month to month for more than one month.* `END_REVOLVING` - Account is no longer revolving and the previous month&apos;s balance is paid off.* `TRANSACTING` - Account is not revolving and the balance is paid off each month.</summary>
        public Marqeta.Core.Sdk.Models.CycleType? LatestStatementCycleType { get; set; }
        /// <summary>Contains `max_apr_schedule` objects, which provide information about any temporary overrides of the APRs on the credit account. This could include special APR rates due to account/user sub status changes.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Marqeta.Core.Sdk.Models.MaxAPRSchedulesResponse>? MaxAprSchedules { get; set; }
#nullable restore
#else
        public List<Marqeta.Core.Sdk.Models.MaxAPRSchedulesResponse> MaxAprSchedules { get; set; }
#endif
        /// <summary>Name of the credit account.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Amount remaining on the latest statement&apos;s minimum payment, after it&apos;s adjusted for payments, returned payments, and applicable credits that occurred after the latest statement&apos;s closing date.</summary>
        public double? RemainingMinPaymentDue { get; set; }
        /// <summary>Amount remaining on the latest statement&apos;s balance, after it&apos;s adjusted for payments, returned payments, and applicable credits that occurred after the latest statement&apos;s closing date.</summary>
        public double? RemainingStatementBalance { get; set; }
        /// <summary>Status of the credit account.*NOTE* `CHARGE_OFF` is not an allowable value for `original_status`.</summary>
        public Marqeta.Core.Sdk.Models.AccountStatusEnum? Status { get; set; }
        /// <summary>Substatuses of the credit account.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Substatuses { get; set; }
#nullable restore
#else
        public List<string> Substatuses { get; set; }
#endif
        /// <summary>Unique identifier of the credit account.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>Type of credit account.</summary>
        public Marqeta.Core.Sdk.Models.AccountType? Type { get; set; }
        /// <summary>Date and time when the credit account was last updated on Marqeta&apos;s credit platform, in UTC.</summary>
        public DateTimeOffset? UpdatedTime { get; set; }
        /// <summary>Contains one or more `usages` objects that contain information on how a credit account is used and what types of balances are permitted on the account.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Marqeta.Core.Sdk.Models.AccountUsageResponse>? Usages { get; set; }
#nullable restore
#else
        public List<Marqeta.Core.Sdk.Models.AccountUsageResponse> Usages { get; set; }
#endif
        /// <summary>Substatuses of the users under the credit account.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? UserSubstatuses { get; set; }
#nullable restore
#else
        public List<string> UserSubstatuses { get; set; }
#endif
        /// <summary>Unique identifier of the primary account holder.Either a `user_token` or `business_token` is returned, not both.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserToken { get; set; }
#nullable restore
#else
        public string UserToken { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Models.AccountResponse"/> and sets the default values.
        /// </summary>
        public AccountResponse()
        {
            AdditionalData = new Dictionary<string, object>();
            CurrencyCode = Marqeta.Core.Sdk.Models.CurrencyCode.USD;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Models.AccountResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Marqeta.Core.Sdk.Models.AccountResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Marqeta.Core.Sdk.Models.AccountResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "activation_time", n => { ActivationTime = n.GetDateTimeOffsetValue(); } },
                { "available_credit", n => { AvailableCredit = n.GetDoubleValue(); } },
                { "bundle_token", n => { BundleToken = n.GetStringValue(); } },
                { "business_token", n => { BusinessToken = n.GetStringValue(); } },
                { "config", n => { Config = n.GetObjectValue<Marqeta.Core.Sdk.Models.AccountConfigResponse>(Marqeta.Core.Sdk.Models.AccountConfigResponse.CreateFromDiscriminatorValue); } },
                { "created_time", n => { CreatedTime = n.GetDateTimeOffsetValue(); } },
                { "credit_limit", n => { CreditLimit = n.GetDoubleValue(); } },
                { "credit_product_token", n => { CreditProductToken = n.GetStringValue(); } },
                { "currency_code", n => { CurrencyCode = n.GetEnumValue<Marqeta.Core.Sdk.Models.CurrencyCode>(); } },
                { "current_balance", n => { CurrentBalance = n.GetDoubleValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "external_offer_id", n => { ExternalOfferId = n.GetStringValue(); } },
                { "latest_statement_cycle_type", n => { LatestStatementCycleType = n.GetEnumValue<Marqeta.Core.Sdk.Models.CycleType>(); } },
                { "max_apr_schedules", n => { MaxAprSchedules = n.GetCollectionOfObjectValues<Marqeta.Core.Sdk.Models.MaxAPRSchedulesResponse>(Marqeta.Core.Sdk.Models.MaxAPRSchedulesResponse.CreateFromDiscriminatorValue)?.ToList(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "remaining_min_payment_due", n => { RemainingMinPaymentDue = n.GetDoubleValue(); } },
                { "remaining_statement_balance", n => { RemainingStatementBalance = n.GetDoubleValue(); } },
                { "status", n => { Status = n.GetEnumValue<Marqeta.Core.Sdk.Models.AccountStatusEnum>(); } },
                { "substatuses", n => { Substatuses = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "token", n => { Token = n.GetStringValue(); } },
                { "type", n => { Type = n.GetEnumValue<Marqeta.Core.Sdk.Models.AccountType>(); } },
                { "updated_time", n => { UpdatedTime = n.GetDateTimeOffsetValue(); } },
                { "usages", n => { Usages = n.GetCollectionOfObjectValues<Marqeta.Core.Sdk.Models.AccountUsageResponse>(Marqeta.Core.Sdk.Models.AccountUsageResponse.CreateFromDiscriminatorValue)?.ToList(); } },
                { "user_substatuses", n => { UserSubstatuses = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
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
            writer.WriteDateTimeOffsetValue("activation_time", ActivationTime);
            writer.WriteDoubleValue("available_credit", AvailableCredit);
            writer.WriteStringValue("bundle_token", BundleToken);
            writer.WriteStringValue("business_token", BusinessToken);
            writer.WriteObjectValue<Marqeta.Core.Sdk.Models.AccountConfigResponse>("config", Config);
            writer.WriteDateTimeOffsetValue("created_time", CreatedTime);
            writer.WriteDoubleValue("credit_limit", CreditLimit);
            writer.WriteStringValue("credit_product_token", CreditProductToken);
            writer.WriteEnumValue<Marqeta.Core.Sdk.Models.CurrencyCode>("currency_code", CurrencyCode);
            writer.WriteDoubleValue("current_balance", CurrentBalance);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("external_offer_id", ExternalOfferId);
            writer.WriteEnumValue<Marqeta.Core.Sdk.Models.CycleType>("latest_statement_cycle_type", LatestStatementCycleType);
            writer.WriteCollectionOfObjectValues<Marqeta.Core.Sdk.Models.MaxAPRSchedulesResponse>("max_apr_schedules", MaxAprSchedules);
            writer.WriteStringValue("name", Name);
            writer.WriteDoubleValue("remaining_min_payment_due", RemainingMinPaymentDue);
            writer.WriteDoubleValue("remaining_statement_balance", RemainingStatementBalance);
            writer.WriteEnumValue<Marqeta.Core.Sdk.Models.AccountStatusEnum>("status", Status);
            writer.WriteCollectionOfPrimitiveValues<string>("substatuses", Substatuses);
            writer.WriteStringValue("token", Token);
            writer.WriteEnumValue<Marqeta.Core.Sdk.Models.AccountType>("type", Type);
            writer.WriteDateTimeOffsetValue("updated_time", UpdatedTime);
            writer.WriteCollectionOfObjectValues<Marqeta.Core.Sdk.Models.AccountUsageResponse>("usages", Usages);
            writer.WriteCollectionOfPrimitiveValues<string>("user_substatuses", UserSubstatuses);
            writer.WriteStringValue("user_token", UserToken);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
