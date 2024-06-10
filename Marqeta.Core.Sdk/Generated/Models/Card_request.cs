// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models
{
    #pragma warning disable CS1591
    public class Card_request : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Defines actions to execute when the card is activated.The fields in this object are mutually exclusive.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Marqeta.Core.Sdk.Models.Activation_actions? ActivationActions { get; set; }
#nullable restore
#else
        public Marqeta.Core.Sdk.Models.Activation_actions ActivationActions { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Associates the card with the specified bulk card order.This field cannot be updated.</summary>
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
        /// <summary>Set to `true` to request expedited processing of the card by your card fulfillment provider.This expedited service is available for cards fulfilled by link:http://perfectplastic.com/[Perfect Plastic Printing, window=&quot;_blank&quot;], link:http://www.idemia.com[IDEMIA, window=&quot;_blank&quot;], and link:https://www.arroweye.com/[Arroweye Solutions, window=&quot;_blank&quot;].*NOTE:* Contact your Marqeta representative for information regarding the cost of expedited service.</summary>
        public bool? Expedite { get; set; }
        /// <summary>Specifies the length of time after the date of issue for which the cards are valid.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Marqeta.Core.Sdk.Models.Expiration_offset? ExpirationOffset { get; set; }
#nullable restore
#else
        public Marqeta.Core.Sdk.Models.Expiration_offset ExpirationOffset { get; set; }
#endif
        /// <summary>Specifies certain physical characteristics of a card, as well as shipment information.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Marqeta.Core.Sdk.Models.CardFulfillmentRequest? Fulfillment { get; set; }
#nullable restore
#else
        public Marqeta.Core.Sdk.Models.CardFulfillmentRequest Fulfillment { get; set; }
#endif
        /// <summary>Associates customer-provided metadata with the card.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Marqeta.Core.Sdk.Models.Card_request_metadata? Metadata { get; set; }
#nullable restore
#else
        public Marqeta.Core.Sdk.Models.Card_request_metadata Metadata { get; set; }
#endif
        /// <summary>Reissues the specified card (known as the &quot;source&quot; card) with a new primary account number (PAN).This field reissues a card with a new PAN from the specified source card.The source card is automatically terminated when the card is reissued with the new PAN.Use this field when reissuing a lost or stolen card.Send a `GET` request to `/cards/user/{token}` to retrieve card tokens for a particular user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NewPanFromCardToken { get; set; }
#nullable restore
#else
        public string NewPanFromCardToken { get; set; }
#endif
        /// <summary>Reissues the specified card (known as the &quot;source&quot; card).This field reissues a card by copying the primary account number (PAN) and personal identification number (PIN) from the specified source card to the newly created card.The reissued card has the same PAN and PIN as the source card but a new expiration date and CVV2 number.Send a `GET` request to `/cards/user/{token}` to retrieve card tokens for a particular user.*NOTE:* By default, the source card is automatically terminated when the reissued card is activated.However, if your program is configured for multiple active cards, you can prevent the source card from being automatically terminated by setting the `activation_actions.terminate_reissued_source_card` field to `false`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReissuePanFromCardToken { get; set; }
#nullable restore
#else
        public string ReissuePanFromCardToken { get; set; }
#endif
        /// <summary>Unique identifier of the card.If you do not include a token, the system will generate one automatically.Other API calls will require this token, so we recommend creating a token that is easy to remember rather than letting the system generate one.This value cannot be updated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>Copies the PIN from the specified card to the newly created card.Both cards must belong to the same user.Populating this field will raise an error if `reissue_pan_from_card_token` is also set.Send a `GET` request to `/cards/user/{token}` to retrieve card tokens for a particular user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TranslatePinFromCardToken { get; set; }
#nullable restore
#else
        public string TranslatePinFromCardToken { get; set; }
#endif
        /// <summary>Unique identifier of the authorized user of the card.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserToken { get; set; }
#nullable restore
#else
        public string UserToken { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Models.Card_request"/> and sets the default values.
        /// </summary>
        public Card_request()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Models.Card_request"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Marqeta.Core.Sdk.Models.Card_request CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Marqeta.Core.Sdk.Models.Card_request();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "activation_actions", n => { ActivationActions = n.GetObjectValue<Marqeta.Core.Sdk.Models.Activation_actions>(Marqeta.Core.Sdk.Models.Activation_actions.CreateFromDiscriminatorValue); } },
                { "bulk_issuance_token", n => { BulkIssuanceToken = n.GetStringValue(); } },
                { "card_product_token", n => { CardProductToken = n.GetStringValue(); } },
                { "expedite", n => { Expedite = n.GetBoolValue(); } },
                { "expiration_offset", n => { ExpirationOffset = n.GetObjectValue<Marqeta.Core.Sdk.Models.Expiration_offset>(Marqeta.Core.Sdk.Models.Expiration_offset.CreateFromDiscriminatorValue); } },
                { "fulfillment", n => { Fulfillment = n.GetObjectValue<Marqeta.Core.Sdk.Models.CardFulfillmentRequest>(Marqeta.Core.Sdk.Models.CardFulfillmentRequest.CreateFromDiscriminatorValue); } },
                { "metadata", n => { Metadata = n.GetObjectValue<Marqeta.Core.Sdk.Models.Card_request_metadata>(Marqeta.Core.Sdk.Models.Card_request_metadata.CreateFromDiscriminatorValue); } },
                { "new_pan_from_card_token", n => { NewPanFromCardToken = n.GetStringValue(); } },
                { "reissue_pan_from_card_token", n => { ReissuePanFromCardToken = n.GetStringValue(); } },
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
            writer.WriteObjectValue<Marqeta.Core.Sdk.Models.Activation_actions>("activation_actions", ActivationActions);
            writer.WriteStringValue("bulk_issuance_token", BulkIssuanceToken);
            writer.WriteStringValue("card_product_token", CardProductToken);
            writer.WriteBoolValue("expedite", Expedite);
            writer.WriteObjectValue<Marqeta.Core.Sdk.Models.Expiration_offset>("expiration_offset", ExpirationOffset);
            writer.WriteObjectValue<Marqeta.Core.Sdk.Models.CardFulfillmentRequest>("fulfillment", Fulfillment);
            writer.WriteObjectValue<Marqeta.Core.Sdk.Models.Card_request_metadata>("metadata", Metadata);
            writer.WriteStringValue("new_pan_from_card_token", NewPanFromCardToken);
            writer.WriteStringValue("reissue_pan_from_card_token", ReissuePanFromCardToken);
            writer.WriteStringValue("token", Token);
            writer.WriteStringValue("translate_pin_from_card_token", TranslatePinFromCardToken);
            writer.WriteStringValue("user_token", UserToken);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
