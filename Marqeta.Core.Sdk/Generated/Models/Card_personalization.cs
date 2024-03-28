// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    /// <summary>
    /// Specifies personalized attributes to be added to the card.
    /// </summary>
    public class Card_personalization : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Specifies attributes of the card carrier.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Marqeta.Core.Sdk.Models.Carrier? Carrier { get; set; }
#nullable restore
#else
        public Marqeta.Core.Sdk.Models.Carrier Carrier { get; set; }
#endif
        /// <summary>Specifies personalized images that appear on the card.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Marqeta.Core.Sdk.Models.Images? Images { get; set; }
#nullable restore
#else
        public Marqeta.Core.Sdk.Models.Images Images { get; set; }
#endif
        /// <summary>Specifies the type of card personalization.</summary>
        public Card_personalization_perso_type? PersoType { get; set; }
        /// <summary>Specifies personalized text that appears on the card.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Marqeta.Core.Sdk.Models.Text? Text { get; set; }
#nullable restore
#else
        public Marqeta.Core.Sdk.Models.Text Text { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Card_personalization"/> and sets the default values.
        /// </summary>
        public Card_personalization() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Card_personalization"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Card_personalization CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Card_personalization();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"carrier", n => { Carrier = n.GetObjectValue<Marqeta.Core.Sdk.Models.Carrier>(Marqeta.Core.Sdk.Models.Carrier.CreateFromDiscriminatorValue); } },
                {"images", n => { Images = n.GetObjectValue<Marqeta.Core.Sdk.Models.Images>(Marqeta.Core.Sdk.Models.Images.CreateFromDiscriminatorValue); } },
                {"perso_type", n => { PersoType = n.GetEnumValue<Card_personalization_perso_type>(); } },
                {"text", n => { Text = n.GetObjectValue<Marqeta.Core.Sdk.Models.Text>(Marqeta.Core.Sdk.Models.Text.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Marqeta.Core.Sdk.Models.Carrier>("carrier", Carrier);
            writer.WriteObjectValue<Marqeta.Core.Sdk.Models.Images>("images", Images);
            writer.WriteEnumValue<Card_personalization_perso_type>("perso_type", PersoType);
            writer.WriteObjectValue<Marqeta.Core.Sdk.Models.Text>("text", Text);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
