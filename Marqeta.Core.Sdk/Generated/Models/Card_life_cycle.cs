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
    /// Defines characteristics of the lifecycle of cards of this card product type.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Card_life_cycle : IAdditionalDataHolder, IParsable
    {
        /// <summary>A value of `true` indicates that cards of this card product type are active once they are issued.</summary>
        public bool? ActivateUponIssue { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Sequence of three digits that defines various services, differentiates card usage in international or domestic interchange, designates personal identification number (PIN) and authorization requirements, and identifies card restrictions.The following values are commonly used:*First digit** *1* — International interchange OK* *2* — International interchange, use IC (chip) where feasible* *5* — National interchange only except under bilateral agreement* *6* — National interchange only except under bilateral agreement, use IC (chip) where feasible* *7* — No interchange except under bilateral agreement (closed loop)* *9* — Test*Second digit** *0* — Normal* *2* — Contact issuer via online means* *4* — Contact issuer via online means except under bilateral agreement*Third digit** *0* — No restrictions, PIN required* *1* — No restrictions* *2* — Goods and services only (no cash)* *3* — ATM only, PIN required* *4* — Cash only* *5* — Goods and services only (no cash), PIN required* *6* — No restrictions, use PIN where feasible* *7* — Goods and services only (no cash), use PIN where feasible</summary>
        public int? CardServiceCode { get; set; }
        /// <summary>Specifies the length of time after the date of issue for which cards of this card product type are valid.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.Models.Expiration_offset_with_minimum? ExpirationOffset { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.Expiration_offset_with_minimum ExpirationOffset { get; set; }
#endif
        /// <summary>The reloadability property</summary>
        public global::Marqeta.Core.Sdk.Models.Card_life_cycle_reloadability? Reloadability { get; set; }
        /// <summary>Normally, the `expiration_offset` is measured from the date of issue.Set this field to `true` to measure `expiration_offset` from the date of activation instead.</summary>
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
                { "expiration_offset", n => { ExpirationOffset = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.Expiration_offset_with_minimum>(global::Marqeta.Core.Sdk.Models.Expiration_offset_with_minimum.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.Expiration_offset_with_minimum>("expiration_offset", ExpirationOffset);
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.Card_life_cycle_reloadability>("reloadability", Reloadability);
            writer.WriteBoolValue("update_expiration_upon_activation", UpdateExpirationUponActivation);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
