// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    /// <summary>
    /// Contains information about a verification check performed on the card&apos;s security code.
    /// </summary>
    public class Card_security_code_verification : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Response codes and memos for account name verification, address verification, card security verification, and transactions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Marqeta.Core.Sdk.Models.Response? Response { get; set; }
#nullable restore
#else
        public Marqeta.Core.Sdk.Models.Response Response { get; set; }
#endif
        /// <summary>Indicates the type of security code.Can have these possible values:* *CVV1* – the security code stored in the magnetic stripe on the card.* *CVV2* – the security code printed on the card.* *ICVV* – the security code stored on the chip of the card.* *DCVV* – a dynamic security code used in some contactless payments when a card or device is tapped against the card reader.</summary>
        public Card_security_code_verification_type? Type { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="Card_security_code_verification"/> and sets the default values.
        /// </summary>
        public Card_security_code_verification()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Card_security_code_verification"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Card_security_code_verification CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Card_security_code_verification();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"response", n => { Response = n.GetObjectValue<Marqeta.Core.Sdk.Models.Response>(Marqeta.Core.Sdk.Models.Response.CreateFromDiscriminatorValue); } },
                {"type", n => { Type = n.GetEnumValue<Card_security_code_verification_type>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Marqeta.Core.Sdk.Models.Response>("response", Response);
            writer.WriteEnumValue<Card_security_code_verification_type>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
