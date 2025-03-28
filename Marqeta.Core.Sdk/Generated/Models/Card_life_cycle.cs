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
    public partial class Card_life_cycle : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The activate_upon_issue property</summary>
        public bool? ActivateUponIssue { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The card_service_code property</summary>
        public int? CardServiceCode { get; set; }
        /// <summary>The expiration_offset property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.Models.ExpirationOffset? ExpirationOffset { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.ExpirationOffset ExpirationOffset { get; set; }
#endif
        /// <summary>The reloadability property</summary>
        public global::Marqeta.Core.Sdk.Models.Card_life_cycle_reloadability? Reloadability { get; set; }
        /// <summary>The update_expiration_upon_activation property</summary>
        public bool? UpdateExpirationUponActivation { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.Card_life_cycle"/> and sets the default values.
        /// </summary>
        public Card_life_cycle()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.Card_life_cycle"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.Card_life_cycle CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.Card_life_cycle();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "activate_upon_issue", n => { ActivateUponIssue = n.GetBoolValue(); } },
                { "card_service_code", n => { CardServiceCode = n.GetIntValue(); } },
                { "expiration_offset", n => { ExpirationOffset = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.ExpirationOffset>(global::Marqeta.Core.Sdk.Models.ExpirationOffset.CreateFromDiscriminatorValue); } },
                { "reloadability", n => { Reloadability = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.Card_life_cycle_reloadability>(); } },
                { "update_expiration_upon_activation", n => { UpdateExpirationUponActivation = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("activate_upon_issue", ActivateUponIssue);
            writer.WriteIntValue("card_service_code", CardServiceCode);
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.ExpirationOffset>("expiration_offset", ExpirationOffset);
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.Card_life_cycle_reloadability>("reloadability", Reloadability);
            writer.WriteBoolValue("update_expiration_upon_activation", UpdateExpirationUponActivation);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
