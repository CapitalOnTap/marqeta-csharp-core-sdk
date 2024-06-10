// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models
{
    /// <summary>
    /// Specifies personalized images that appear on the card.
    /// </summary>
    public class Images : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Specifies personalized images that appear on the card.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Marqeta.Core.Sdk.Models.Images_card? Card { get; set; }
#nullable restore
#else
        public Marqeta.Core.Sdk.Models.Images_card Card { get; set; }
#endif
        /// <summary>Specifies personalized images that appear on the card carrier.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Marqeta.Core.Sdk.Models.ImagesCarrier? Carrier { get; set; }
#nullable restore
#else
        public Marqeta.Core.Sdk.Models.ImagesCarrier Carrier { get; set; }
#endif
        /// <summary>Specifies a custom image to display in the return address window of the card carrier envelope.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Marqeta.Core.Sdk.Models.Images_carrier_return_window? CarrierReturnWindow { get; set; }
#nullable restore
#else
        public Marqeta.Core.Sdk.Models.Images_carrier_return_window CarrierReturnWindow { get; set; }
#endif
        /// <summary>Specifies an image of the cardholder&apos;s signature.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Marqeta.Core.Sdk.Models.Images_signature? Signature { get; set; }
#nullable restore
#else
        public Marqeta.Core.Sdk.Models.Images_signature Signature { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Models.Images"/> and sets the default values.
        /// </summary>
        public Images()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Models.Images"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Marqeta.Core.Sdk.Models.Images CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Marqeta.Core.Sdk.Models.Images();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "card", n => { Card = n.GetObjectValue<Marqeta.Core.Sdk.Models.Images_card>(Marqeta.Core.Sdk.Models.Images_card.CreateFromDiscriminatorValue); } },
                { "carrier", n => { Carrier = n.GetObjectValue<Marqeta.Core.Sdk.Models.ImagesCarrier>(Marqeta.Core.Sdk.Models.ImagesCarrier.CreateFromDiscriminatorValue); } },
                { "carrier_return_window", n => { CarrierReturnWindow = n.GetObjectValue<Marqeta.Core.Sdk.Models.Images_carrier_return_window>(Marqeta.Core.Sdk.Models.Images_carrier_return_window.CreateFromDiscriminatorValue); } },
                { "signature", n => { Signature = n.GetObjectValue<Marqeta.Core.Sdk.Models.Images_signature>(Marqeta.Core.Sdk.Models.Images_signature.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Marqeta.Core.Sdk.Models.Images_card>("card", Card);
            writer.WriteObjectValue<Marqeta.Core.Sdk.Models.ImagesCarrier>("carrier", Carrier);
            writer.WriteObjectValue<Marqeta.Core.Sdk.Models.Images_carrier_return_window>("carrier_return_window", CarrierReturnWindow);
            writer.WriteObjectValue<Marqeta.Core.Sdk.Models.Images_signature>("signature", Signature);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
