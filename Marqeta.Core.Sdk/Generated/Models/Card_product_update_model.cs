// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System;
namespace Marqeta.Core.Sdk.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class Card_product_update_model : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Indicates whether the card product is active.*NOTE:* This field has no effect on the ability to create cards from this card product.Use the `config.fulfillment.allow_card_creation` field to allow/disallow card creation.</summary>
        public bool? Active { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Defines the characteristics of the card product.Configurations are conditionally required based on program setup.For more information, contact your Marqeta representative.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.Models.Card_product_config? Config { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.Card_product_config Config { get; set; }
#endif
        /// <summary>End date of the range over which the card product can be active.</summary>
        public Date? EndDate { get; set; }
        /// <summary>Name of the card product.Marqeta recommends that you use a unique string.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Date the card product becomes active.If the start date has passed and the card is set to `active = false`, then the card will not be activated.</summary>
        public Date? StartDate { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.Card_product_update_model"/> and sets the default values.
        /// </summary>
        public Card_product_update_model()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.Card_product_update_model"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.Card_product_update_model CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.Card_product_update_model();
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
                { "config", n => { Config = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.Card_product_config>(global::Marqeta.Core.Sdk.Models.Card_product_config.CreateFromDiscriminatorValue); } },
                { "end_date", n => { EndDate = n.GetDateValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "start_date", n => { StartDate = n.GetDateValue(); } },
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
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.Card_product_config>("config", Config);
            writer.WriteDateValue("end_date", EndDate);
            writer.WriteStringValue("name", Name);
            writer.WriteDateValue("start_date", StartDate);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
