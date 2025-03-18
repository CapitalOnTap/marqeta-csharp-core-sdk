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
    /// Contains merchant-provided metadata related to the transaction, including details about lodging- and transit-related purchases.May be returned if the request uses Transaction Model v2 of the Marqeta Core API.Not returned for Transaction Model v1 requests.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Transaction_metadata : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Contains information about airline-related transactions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.Models.Airline? Airline { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.Airline Airline { get; set; }
#endif
        /// <summary>Number of days the pre-authorization is in effect.</summary>
        public int? AuthorizationLifeCycle { get; set; }
        /// <summary>Whether the transaction is cross-border, i.e., when the merchant and the cardholder are located in two different countries.</summary>
        public bool? CrossBorderTransaction { get; set; }
        /// <summary>Indicates an offline authorization made during an interruption of card network connectivity, such as a purchase on a flight.</summary>
        public bool? IsDeferredAuthorization { get; set; }
        /// <summary>Whether the transaction is a lodging or vehicle rental.</summary>
        public bool? IsLodgingAutoRental { get; set; }
        /// <summary>Date and time when the lodging check-in or vehicle rental began.</summary>
        public DateTimeOffset? LodgingAutoRentalStartDate { get; set; }
        /// <summary>Indicates a credit or debit adjustment in a clearing transaction.</summary>
        public global::Marqeta.Core.Sdk.Models.Transaction_metadata_memo? Memo { get; set; }
        /// <summary>Indicates the type of mail or telephone order transaction.</summary>
        public global::Marqeta.Core.Sdk.Models.Transaction_metadata_moto_indicator? MotoIndicator { get; set; }
        /// <summary>The one_leg_out property</summary>
        public bool? OneLegOut { get; set; }
        /// <summary>Channel from which the transaction was originated.</summary>
        public global::Marqeta.Core.Sdk.Models.Transaction_metadata_payment_channel? PaymentChannel { get; set; }
        /// <summary>The special_purchase_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SpecialPurchaseId { get; set; }
#nullable restore
#else
        public string SpecialPurchaseId { get; set; }
#endif
        /// <summary>Type of product or service being purchased, if provided by the merchant.</summary>
        public global::Marqeta.Core.Sdk.Models.Transaction_metadata_transaction_category? TransactionCategory { get; set; }
        /// <summary>Contains merchant-provided, transit-related metadata related to the transaction.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.Models.Transit? Transit { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.Transit Transit { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.Transaction_metadata"/> and sets the default values.
        /// </summary>
        public Transaction_metadata()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.Transaction_metadata"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.Transaction_metadata CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.Transaction_metadata();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "airline", n => { Airline = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.Airline>(global::Marqeta.Core.Sdk.Models.Airline.CreateFromDiscriminatorValue); } },
                { "authorization_life_cycle", n => { AuthorizationLifeCycle = n.GetIntValue(); } },
                { "cross_border_transaction", n => { CrossBorderTransaction = n.GetBoolValue(); } },
                { "is_deferred_authorization", n => { IsDeferredAuthorization = n.GetBoolValue(); } },
                { "is_lodging_auto_rental", n => { IsLodgingAutoRental = n.GetBoolValue(); } },
                { "lodging_auto_rental_start_date", n => { LodgingAutoRentalStartDate = n.GetDateTimeOffsetValue(); } },
                { "memo", n => { Memo = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.Transaction_metadata_memo>(); } },
                { "moto_indicator", n => { MotoIndicator = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.Transaction_metadata_moto_indicator>(); } },
                { "one_leg_out", n => { OneLegOut = n.GetBoolValue(); } },
                { "payment_channel", n => { PaymentChannel = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.Transaction_metadata_payment_channel>(); } },
                { "special_purchase_id", n => { SpecialPurchaseId = n.GetStringValue(); } },
                { "transaction_category", n => { TransactionCategory = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.Transaction_metadata_transaction_category>(); } },
                { "transit", n => { Transit = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.Transit>(global::Marqeta.Core.Sdk.Models.Transit.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.Airline>("airline", Airline);
            writer.WriteIntValue("authorization_life_cycle", AuthorizationLifeCycle);
            writer.WriteBoolValue("cross_border_transaction", CrossBorderTransaction);
            writer.WriteBoolValue("is_deferred_authorization", IsDeferredAuthorization);
            writer.WriteBoolValue("is_lodging_auto_rental", IsLodgingAutoRental);
            writer.WriteDateTimeOffsetValue("lodging_auto_rental_start_date", LodgingAutoRentalStartDate);
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.Transaction_metadata_memo>("memo", Memo);
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.Transaction_metadata_moto_indicator>("moto_indicator", MotoIndicator);
            writer.WriteBoolValue("one_leg_out", OneLegOut);
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.Transaction_metadata_payment_channel>("payment_channel", PaymentChannel);
            writer.WriteStringValue("special_purchase_id", SpecialPurchaseId);
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.Transaction_metadata_transaction_category>("transaction_category", TransactionCategory);
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.Transit>("transit", Transit);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
