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
    public partial class Bulk_issuance_request : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Number of cards in the order.</summary>
        public int? CardAllocation { get; set; }
        /// <summary>Specifies the card product from which to create your cards.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CardProductToken { get; set; }
#nullable restore
#else
        public string CardProductToken { get; set; }
#endif
        /// <summary>Set to `true` to request expedited processing of the order by your card fulfillment provider.This expedited service is available for cards fulfilled by link:http://perfectplastic.com/[Perfect Plastic Printing, window=&quot;_blank&quot;], link:http://www.idemia.com[IDEMIA, window=&quot;_blank&quot;], and link:https://www.arroweye.com/[Arroweye Solutions, window=&quot;_blank&quot;].*NOTE:* Contact your Marqeta representative for information regarding the cost of expedited service.</summary>
        public bool? Expedite { get; set; }
        /// <summary>Specifies the length of time after the date of issue for which the cards are valid.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.Models.Expiration_offset? ExpirationOffset { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.Expiration_offset ExpirationOffset { get; set; }
#endif
        /// <summary>Specifies certain physical characteristics of a card, as well as bulk shipment information.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.Models.FulfillmentRequest? Fulfillment { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.FulfillmentRequest Fulfillment { get; set; }
#endif
        /// <summary>If set to `true`, the unique numeric postfix appended to each card&apos;s token field is also appended to the card&apos;s `fulfillment.card_personalization.text.name_line_1.value` field.</summary>
        public bool? NameLine1NumericPostfix { get; set; }
        /// <summary>If set to `true`, the unique random postfix appended to each card&apos;s token field is also appended to the card&apos;s `fulfillment.card_personalization.text.name_line_1.value` field.</summary>
        public bool? NameLine1RandomPostfix { get; set; }
        /// <summary>If you do not include a token, the system will generate one automatically.This token is necessary for use in other API calls, so we recommend that rather than let the system generate one, you use a simple string that is easy to remember.This value cannot be updated.</summary>
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
        public global::Marqeta.Core.Sdk.Models.User_association? UserAssociation { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.User_association UserAssociation { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.Bulk_issuance_request"/> and sets the default values.
        /// </summary>
        public Bulk_issuance_request()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.Bulk_issuance_request"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.Bulk_issuance_request CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.Bulk_issuance_request();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "card_allocation", n => { CardAllocation = n.GetIntValue(); } },
                { "card_product_token", n => { CardProductToken = n.GetStringValue(); } },
                { "expedite", n => { Expedite = n.GetBoolValue(); } },
                { "expiration_offset", n => { ExpirationOffset = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.Expiration_offset>(global::Marqeta.Core.Sdk.Models.Expiration_offset.CreateFromDiscriminatorValue); } },
                { "fulfillment", n => { Fulfillment = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.FulfillmentRequest>(global::Marqeta.Core.Sdk.Models.FulfillmentRequest.CreateFromDiscriminatorValue); } },
                { "name_line_1_numeric_postfix", n => { NameLine1NumericPostfix = n.GetBoolValue(); } },
                { "name_line_1_random_postfix", n => { NameLine1RandomPostfix = n.GetBoolValue(); } },
                { "token", n => { Token = n.GetStringValue(); } },
                { "user_association", n => { UserAssociation = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.User_association>(global::Marqeta.Core.Sdk.Models.User_association.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("card_allocation", CardAllocation);
            writer.WriteStringValue("card_product_token", CardProductToken);
            writer.WriteBoolValue("expedite", Expedite);
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.Expiration_offset>("expiration_offset", ExpirationOffset);
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.FulfillmentRequest>("fulfillment", Fulfillment);
            writer.WriteBoolValue("name_line_1_numeric_postfix", NameLine1NumericPostfix);
            writer.WriteBoolValue("name_line_1_random_postfix", NameLine1RandomPostfix);
            writer.WriteStringValue("token", Token);
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.User_association>("user_association", UserAssociation);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
