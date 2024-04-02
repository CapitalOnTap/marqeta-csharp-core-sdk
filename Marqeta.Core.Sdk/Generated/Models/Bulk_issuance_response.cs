// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    public class Bulk_issuance_response : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Number of cards in the order.</summary>
        public int? CardAllocation { get; set; }
        /// <summary>Date and time when the bulk card order was fulfilled, in UTC.This field is included if your bulk card order has been processed.</summary>
        public DateTimeOffset? CardFulfillmentTime { get; set; }
        /// <summary>Specifies the card product from which the cards are created.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CardProductToken { get; set; }
#nullable restore
#else
        public string CardProductToken { get; set; }
#endif
        /// <summary>Number of cards processed in the bulk card order.This field is returned if it exists in the resource.</summary>
        public int? CardsProcessed { get; set; }
        /// <summary>Date and time when the resource was created, in UTC.This field is returned if it exists in the resource.</summary>
        public DateTimeOffset? CreatedTime { get; set; }
        /// <summary>Indicates if expedited processing of this bulk card order was requested.This field is returned if it exists in the resource.</summary>
        public bool? Expedite { get; set; }
        /// <summary>Specifies the length of time after the date of issue for which the cards are valid.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Expiration_offset? ExpirationOffset { get; set; }
#nullable restore
#else
        public Expiration_offset ExpirationOffset { get; set; }
#endif
        /// <summary>Specifies certain physical characteristics of a card, as well as bulk shipment information.This object is returned if it exists in the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public FulfillmentResponse? Fulfillment { get; set; }
#nullable restore
#else
        public FulfillmentResponse Fulfillment { get; set; }
#endif
        /// <summary>This field is included if your bulk card order has been processed.You can use the `name_line1_start_index` and `name_line1_end_index` fields to identify the cards and users associated with the order.For example, if the start index is &quot;1&quot; and the end index is &quot;3&quot;, the card tokens are &quot;card-1&quot;, &quot;card-2&quot;, and &quot;card-3&quot;, and the user tokens are &quot;user-1&quot;, &quot;user-2&quot;, and &quot;user-3&quot;.See &lt;&lt;/core-api/bulk-card-orders#create_bulk_card_order, Create bulk card order&gt;&gt; for more information about the automatic generation and naming of cards and users.</summary>
        public int? NameLine1EndIndex { get; set; }
        /// <summary>If set to `true`, the unique numeric postfix appended to each card&apos;s token field is also appended to the card&apos;s `fulfillment.card_personalization.text.name_line_1.value` field.</summary>
        public bool? NameLine1NumericPostfix { get; set; }
        /// <summary>If set to `true`, the unique random postfix appended to each card&apos;s token field is also appended to the card&apos;s `fulfillment.card_personalization.text.name_line_1.value` field.This field is returned if it exists in the resource.</summary>
        public bool? NameLine1RandomPostfix { get; set; }
        /// <summary>This field is included if your bulk card order has been processed.You can use the `name_line1_start_index` and `name_line1_end_index` fields to identify the cards and users associated with the order.For example, if the start index is &quot;1&quot; and the end index is &quot;3&quot;, the card tokens are &quot;card-1&quot;, &quot;card-2&quot;, and &quot;card-3&quot;, and the user tokens are &quot;user-1&quot;, &quot;user-2&quot;, and &quot;user-3&quot;.See &lt;&lt;/core-api/bulk-card-orders#create_bulk_card_order, Create bulk card order&gt;&gt; for more information about the automatic generation and naming of cards and users.</summary>
        public int? NameLine1StartIndex { get; set; }
        /// <summary>Date and time when the card provider shipped the bulk card order, in UTC.This field is included if your bulk card order has shipped.</summary>
        public DateTimeOffset? ProviderShipDate { get; set; }
        /// <summary>Shipping method used by the card provider.`United_Postal_Service`, for example.This field is included if your bulk card order has shipped.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProviderShippingMethod { get; set; }
#nullable restore
#else
        public string ProviderShippingMethod { get; set; }
#endif
        /// <summary>A tracking number is included only if your card provider is Arroweye Solutions.This field is included if your bulk card order has shipped.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProviderTrackingNumber { get; set; }
#nullable restore
#else
        public string ProviderTrackingNumber { get; set; }
#endif
        /// <summary>Unique identifier of the bulk card order.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>Associates each card with a user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public User_association? UserAssociation { get; set; }
#nullable restore
#else
        public User_association UserAssociation { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Bulk_issuance_response"/> and sets the default values.
        /// </summary>
        public Bulk_issuance_response() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Bulk_issuance_response"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Bulk_issuance_response CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Bulk_issuance_response();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"card_allocation", n => { CardAllocation = n.GetIntValue(); } },
                {"card_fulfillment_time", n => { CardFulfillmentTime = n.GetDateTimeOffsetValue(); } },
                {"card_product_token", n => { CardProductToken = n.GetStringValue(); } },
                {"cards_processed", n => { CardsProcessed = n.GetIntValue(); } },
                {"created_time", n => { CreatedTime = n.GetDateTimeOffsetValue(); } },
                {"expedite", n => { Expedite = n.GetBoolValue(); } },
                {"expiration_offset", n => { ExpirationOffset = n.GetObjectValue<Expiration_offset>(Expiration_offset.CreateFromDiscriminatorValue); } },
                {"fulfillment", n => { Fulfillment = n.GetObjectValue<FulfillmentResponse>(FulfillmentResponse.CreateFromDiscriminatorValue); } },
                {"name_line1_end_index", n => { NameLine1EndIndex = n.GetIntValue(); } },
                {"name_line_1_numeric_postfix", n => { NameLine1NumericPostfix = n.GetBoolValue(); } },
                {"name_line_1_random_postfix", n => { NameLine1RandomPostfix = n.GetBoolValue(); } },
                {"name_line1_start_index", n => { NameLine1StartIndex = n.GetIntValue(); } },
                {"provider_ship_date", n => { ProviderShipDate = n.GetDateTimeOffsetValue(); } },
                {"provider_shipping_method", n => { ProviderShippingMethod = n.GetStringValue(); } },
                {"provider_tracking_number", n => { ProviderTrackingNumber = n.GetStringValue(); } },
                {"token", n => { Token = n.GetStringValue(); } },
                {"user_association", n => { UserAssociation = n.GetObjectValue<User_association>(User_association.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("card_allocation", CardAllocation);
            writer.WriteDateTimeOffsetValue("card_fulfillment_time", CardFulfillmentTime);
            writer.WriteStringValue("card_product_token", CardProductToken);
            writer.WriteIntValue("cards_processed", CardsProcessed);
            writer.WriteDateTimeOffsetValue("created_time", CreatedTime);
            writer.WriteBoolValue("expedite", Expedite);
            writer.WriteObjectValue<Expiration_offset>("expiration_offset", ExpirationOffset);
            writer.WriteObjectValue<FulfillmentResponse>("fulfillment", Fulfillment);
            writer.WriteIntValue("name_line1_end_index", NameLine1EndIndex);
            writer.WriteBoolValue("name_line_1_numeric_postfix", NameLine1NumericPostfix);
            writer.WriteBoolValue("name_line_1_random_postfix", NameLine1RandomPostfix);
            writer.WriteIntValue("name_line1_start_index", NameLine1StartIndex);
            writer.WriteDateTimeOffsetValue("provider_ship_date", ProviderShipDate);
            writer.WriteStringValue("provider_shipping_method", ProviderShippingMethod);
            writer.WriteStringValue("provider_tracking_number", ProviderTrackingNumber);
            writer.WriteStringValue("token", Token);
            writer.WriteObjectValue<User_association>("user_association", UserAssociation);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}