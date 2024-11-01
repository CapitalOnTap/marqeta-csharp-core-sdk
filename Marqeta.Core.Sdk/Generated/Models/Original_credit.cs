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
    /// Contains information about an original credit transaction (OCT), which enables the cardholder to receive funds on the specified card from an external source via the card network.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Original_credit : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The deferred_hold_by property</summary>
        public global::Marqeta.Core.Sdk.Models.Original_credit_deferred_hold_by? DeferredHoldBy { get; set; }
        /// <summary>Indicates that Fast Funds are enabled for dual-message original credit transactions.If the value of this field is `true`, you must make the funds available to your cardholder within 30 minutes of the transaction.</summary>
        public bool? FastFundsEnabled { get; set; }
        /// <summary>Sender&apos;s account from which the OCT draws funds.</summary>
        public global::Marqeta.Core.Sdk.Models.Original_credit_funding_source? FundingSource { get; set; }
        /// <summary>Sanctions screening score to assist with meeting Anti-Money Laundering (AML) obligations.Higher scores indicate that the sender&apos;s data more closely resembles an entry on the regulatory watchlist.A value of 999 means that no screening score is available.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ScreeningScore { get; set; }
#nullable restore
#else
        public string ScreeningScore { get; set; }
#endif
        /// <summary>The type of account from which the OCT draws funds.</summary>
        public global::Marqeta.Core.Sdk.Models.Original_credit_sender_account_type? SenderAccountType { get; set; }
        /// <summary>Sender&apos;s street address.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SenderAddress { get; set; }
#nullable restore
#else
        public string SenderAddress { get; set; }
#endif
        /// <summary>Sender&apos;s city.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SenderCity { get; set; }
#nullable restore
#else
        public string SenderCity { get; set; }
#endif
        /// <summary>Sender&apos;s country.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SenderCountry { get; set; }
#nullable restore
#else
        public string SenderCountry { get; set; }
#endif
        /// <summary>Full name of the sender.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SenderName { get; set; }
#nullable restore
#else
        public string SenderName { get; set; }
#endif
        /// <summary>Sender&apos;s state.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SenderState { get; set; }
#nullable restore
#else
        public string SenderState { get; set; }
#endif
        /// <summary>The purpose of the original credit transaction.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TransactionPurpose { get; set; }
#nullable restore
#else
        public string TransactionPurpose { get; set; }
#endif
        /// <summary>Type of original credit transaction.</summary>
        public global::Marqeta.Core.Sdk.Models.Original_credit_transaction_type? TransactionType { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.Original_credit"/> and sets the default values.
        /// </summary>
        public Original_credit()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.Original_credit"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.Original_credit CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.Original_credit();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "deferred_hold_by", n => { DeferredHoldBy = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.Original_credit_deferred_hold_by>(); } },
                { "fast_funds_enabled", n => { FastFundsEnabled = n.GetBoolValue(); } },
                { "funding_source", n => { FundingSource = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.Original_credit_funding_source>(); } },
                { "screening_score", n => { ScreeningScore = n.GetStringValue(); } },
                { "sender_account_type", n => { SenderAccountType = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.Original_credit_sender_account_type>(); } },
                { "sender_address", n => { SenderAddress = n.GetStringValue(); } },
                { "sender_city", n => { SenderCity = n.GetStringValue(); } },
                { "sender_country", n => { SenderCountry = n.GetStringValue(); } },
                { "sender_name", n => { SenderName = n.GetStringValue(); } },
                { "sender_state", n => { SenderState = n.GetStringValue(); } },
                { "transaction_purpose", n => { TransactionPurpose = n.GetStringValue(); } },
                { "transaction_type", n => { TransactionType = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.Original_credit_transaction_type>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.Original_credit_deferred_hold_by>("deferred_hold_by", DeferredHoldBy);
            writer.WriteBoolValue("fast_funds_enabled", FastFundsEnabled);
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.Original_credit_funding_source>("funding_source", FundingSource);
            writer.WriteStringValue("screening_score", ScreeningScore);
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.Original_credit_sender_account_type>("sender_account_type", SenderAccountType);
            writer.WriteStringValue("sender_address", SenderAddress);
            writer.WriteStringValue("sender_city", SenderCity);
            writer.WriteStringValue("sender_country", SenderCountry);
            writer.WriteStringValue("sender_name", SenderName);
            writer.WriteStringValue("sender_state", SenderState);
            writer.WriteStringValue("transaction_purpose", TransactionPurpose);
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.Original_credit_transaction_type>("transaction_type", TransactionType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
