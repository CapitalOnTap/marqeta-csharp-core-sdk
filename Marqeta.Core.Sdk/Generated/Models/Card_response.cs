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
    /// Contains information about the card used in the transaction.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Card_response : IAdditionalDataHolder, IParsable
    {
        /// <summary>Defines actions to execute when the card is activated.The fields in this object are mutually exclusive.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.Models.Activation_actions? ActivationActions { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.Activation_actions ActivationActions { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Barcode printed on the card, expressed as numerals.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Barcode { get; set; }
#nullable restore
#else
        public string Barcode { get; set; }
#endif
        /// <summary>Unique identifier of the bulk card order.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BulkIssuanceToken { get; set; }
#nullable restore
#else
        public string BulkIssuanceToken { get; set; }
#endif
        /// <summary>Unique identifier of the card product.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CardProductToken { get; set; }
#nullable restore
#else
        public string CardProductToken { get; set; }
#endif
        /// <summary>Three-digit card verification value (ICVV) stored on the chip of the card.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ChipCvvNumber { get; set; }
#nullable restore
#else
        public string ChipCvvNumber { get; set; }
#endif
        /// <summary>Running count of the contactless transactions successfully completed since the last strong customer authentication (SCA) challenge was issued.You can limit the number of contactless transactions that can be performed without issuing an SCA challenge at the card product level.For more information about strong customer authentication, see &lt;&lt;/core-api/card-products, Card Products&gt;&gt;.</summary>
        public int? ContactlessExemptionCounter { get; set; }
        /// <summary>Running total of the money spent in contactless transactions successfully completed since the last strong customer authentication (SCA) challenge was issued.You can limit the total amount that can be spent in contactless transactions without issuing an SCA challenge at the card product level.For more information about strong customer authentication, see &lt;&lt;/core-api/card-products, Card Products&gt;&gt;.</summary>
        public double? ContactlessExemptionTotalAmount { get; set; }
        /// <summary>Date and time when the resource was created, in UTC.</summary>
        public DateTimeOffset? CreatedTime { get; set; }
        /// <summary>Three-digit card verification value (CVV2 or CVC2) printed on the card.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CvvNumber { get; set; }
#nullable restore
#else
        public string CvvNumber { get; set; }
#endif
        /// <summary>A value of `true` indicates that you requested expedited processing of the card from your card fulfillment provider.</summary>
        public bool? Expedite { get; set; }
        /// <summary>Expiration date in `MMyy` format.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Expiration { get; set; }
#nullable restore
#else
        public string Expiration { get; set; }
#endif
        /// <summary>Expiration date and time, in UTC.</summary>
        public DateTimeOffset? ExpirationTime { get; set; }
        /// <summary>Determines physical characteristics of a card and shipment information.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.Models.CardFulfillmentResponse? Fulfillment { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.CardFulfillmentResponse Fulfillment { get; set; }
#endif
        /// <summary>Card fulfillment status:* *ISSUED:* Initial state of all newly created/issued cards.* *ORDERED:* Card ordered through the card fulfillment provider.* *REORDERED:* Card reordered through the card fulfillment provider.* *REJECTED:* Card rejected by the card fulfillment provider.* *SHIPPED:* Card shipped by the card fulfillment provider.* *DELIVERED:* Card delivered by the card fulfillment provider.* *DIGITALLY_PRESENTED:* Card digitally presented using the `/cards/{token}/showpan` endpoint; does not affect the delivery of physical cards.</summary>
        public global::Marqeta.Core.Sdk.Models.Card_response_fulfillment_status? FulfillmentStatus { get; set; }
        /// <summary>Instrument type of the card:* *PHYSICAL_MSR:* A physical card with a magnetic stripe. This is the default physical card type.* *PHYSICAL_ICC:* A physical card with an integrated circuit, or &quot;chip.&quot;* *PHYSICAL_CONTACTLESS:* A physical card that uses radio frequency identification (RFID) or near-field communication (NFC) to enable payment over a secure radio interface.* *PHYSICAL_COMBO:* A physical card with a chip that also supports contactless payments.* *VIRTUAL_PAN:* A virtual card with a primary account number (PAN).</summary>
        public global::Marqeta.Core.Sdk.Models.Card_response_instrument_type? InstrumentType { get; set; }
        /// <summary>Last four digits of the card primary account number (PAN).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastFour { get; set; }
#nullable restore
#else
        public string LastFour { get; set; }
#endif
        /// <summary>Date and time when the resource was last modified, in UTC.</summary>
        public DateTimeOffset? LastModifiedTime { get; set; }
        /// <summary>Associates customer-provided metadata with the card.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.Models.Card_response_metadata? Metadata { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.Card_response_metadata Metadata { get; set; }
#endif
        /// <summary>Reissues the specified card (known as the &quot;source&quot; card) with a new primary account number (PAN).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NewPanFromCardToken { get; set; }
#nullable restore
#else
        public string NewPanFromCardToken { get; set; }
#endif
        /// <summary>Primary account number (PAN) of the card.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Pan { get; set; }
#nullable restore
#else
        public string Pan { get; set; }
#endif
        /// <summary>Specifies if the personal identification number (PIN) has been set for the card.</summary>
        public bool? PinIsSet { get; set; }
        /// <summary>Reissues the specified card (known as the &quot;source&quot; card).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReissuePanFromCardToken { get; set; }
#nullable restore
#else
        public string ReissuePanFromCardToken { get; set; }
#endif
        /// <summary>Indicates the state of the card.</summary>
        public global::Marqeta.Core.Sdk.Models.Card_response_state? State { get; set; }
        /// <summary>Descriptive reason for why the card is in its current state.For example, &quot;Card activated by cardholder&quot;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StateReason { get; set; }
#nullable restore
#else
        public string StateReason { get; set; }
#endif
        /// <summary>Unique identifier of the card.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>Copies the personal identification number (PIN) from the specified source card to the newly created card.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TranslatePinFromCardToken { get; set; }
#nullable restore
#else
        public string TranslatePinFromCardToken { get; set; }
#endif
        /// <summary>Unique identifier of the cardholder.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserToken { get; set; }
#nullable restore
#else
        public string UserToken { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.Card_response"/> and sets the default values.
        /// </summary>
        public Card_response()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.Card_response"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.Card_response CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.Card_response();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "activation_actions", n => { ActivationActions = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.Activation_actions>(global::Marqeta.Core.Sdk.Models.Activation_actions.CreateFromDiscriminatorValue); } },
                { "barcode", n => { Barcode = n.GetStringValue(); } },
                { "bulk_issuance_token", n => { BulkIssuanceToken = n.GetStringValue(); } },
                { "card_product_token", n => { CardProductToken = n.GetStringValue(); } },
                { "chip_cvv_number", n => { ChipCvvNumber = n.GetStringValue(); } },
                { "contactless_exemption_counter", n => { ContactlessExemptionCounter = n.GetIntValue(); } },
                { "contactless_exemption_total_amount", n => { ContactlessExemptionTotalAmount = n.GetDoubleValue(); } },
                { "created_time", n => { CreatedTime = n.GetDateTimeOffsetValue(); } },
                { "cvv_number", n => { CvvNumber = n.GetStringValue(); } },
                { "expedite", n => { Expedite = n.GetBoolValue(); } },
                { "expiration", n => { Expiration = n.GetStringValue(); } },
                { "expiration_time", n => { ExpirationTime = n.GetDateTimeOffsetValue(); } },
                { "fulfillment", n => { Fulfillment = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.CardFulfillmentResponse>(global::Marqeta.Core.Sdk.Models.CardFulfillmentResponse.CreateFromDiscriminatorValue); } },
                { "fulfillment_status", n => { FulfillmentStatus = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.Card_response_fulfillment_status>(); } },
                { "instrument_type", n => { InstrumentType = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.Card_response_instrument_type>(); } },
                { "last_four", n => { LastFour = n.GetStringValue(); } },
                { "last_modified_time", n => { LastModifiedTime = n.GetDateTimeOffsetValue(); } },
                { "metadata", n => { Metadata = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.Card_response_metadata>(global::Marqeta.Core.Sdk.Models.Card_response_metadata.CreateFromDiscriminatorValue); } },
                { "new_pan_from_card_token", n => { NewPanFromCardToken = n.GetStringValue(); } },
                { "pan", n => { Pan = n.GetStringValue(); } },
                { "pin_is_set", n => { PinIsSet = n.GetBoolValue(); } },
                { "reissue_pan_from_card_token", n => { ReissuePanFromCardToken = n.GetStringValue(); } },
                { "state", n => { State = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.Card_response_state>(); } },
                { "state_reason", n => { StateReason = n.GetStringValue(); } },
                { "token", n => { Token = n.GetStringValue(); } },
                { "translate_pin_from_card_token", n => { TranslatePinFromCardToken = n.GetStringValue(); } },
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
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.Activation_actions>("activation_actions", ActivationActions);
            writer.WriteStringValue("barcode", Barcode);
            writer.WriteStringValue("bulk_issuance_token", BulkIssuanceToken);
            writer.WriteStringValue("card_product_token", CardProductToken);
            writer.WriteStringValue("chip_cvv_number", ChipCvvNumber);
            writer.WriteIntValue("contactless_exemption_counter", ContactlessExemptionCounter);
            writer.WriteDoubleValue("contactless_exemption_total_amount", ContactlessExemptionTotalAmount);
            writer.WriteDateTimeOffsetValue("created_time", CreatedTime);
            writer.WriteStringValue("cvv_number", CvvNumber);
            writer.WriteBoolValue("expedite", Expedite);
            writer.WriteStringValue("expiration", Expiration);
            writer.WriteDateTimeOffsetValue("expiration_time", ExpirationTime);
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.CardFulfillmentResponse>("fulfillment", Fulfillment);
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.Card_response_fulfillment_status>("fulfillment_status", FulfillmentStatus);
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.Card_response_instrument_type>("instrument_type", InstrumentType);
            writer.WriteStringValue("last_four", LastFour);
            writer.WriteDateTimeOffsetValue("last_modified_time", LastModifiedTime);
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.Card_response_metadata>("metadata", Metadata);
            writer.WriteStringValue("new_pan_from_card_token", NewPanFromCardToken);
            writer.WriteStringValue("pan", Pan);
            writer.WriteBoolValue("pin_is_set", PinIsSet);
            writer.WriteStringValue("reissue_pan_from_card_token", ReissuePanFromCardToken);
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.Card_response_state>("state", State);
            writer.WriteStringValue("state_reason", StateReason);
            writer.WriteStringValue("token", Token);
            writer.WriteStringValue("translate_pin_from_card_token", TranslatePinFromCardToken);
            writer.WriteStringValue("user_token", UserToken);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
