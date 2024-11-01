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
    /// Contains information on how long after the date of issue for when the cards are valid.If this field is not specified, the card uses the `config.card_life_cycle.expiration_offset` of the bulk card order or card product as appropriate.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ExpirationOffset : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Units for the `value` field.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Unit { get; set; }
#nullable restore
#else
        public string Unit { get; set; }
#endif
        /// <summary>Specifies the number of time units (as defined by the `unit` field in this object) that this card is valid.In other words, cards expire `value` x `unit` after the date of issue.This number is rounded as follows:* *YEARS* - Rounds up to the last second of the last day of the month of expiration.For example, if the issue date is 1 Jan 2021 and `value = 1`, the cards expire on the last day of Jan 2022.* *MONTHS* - Rounds up to the last second of the last day of the month of expiration.For example, if the issue date is 1 May 2022 and `value = 1`, the cards expire on the last day of June 2022.* *DAYS* - Rounds up to the last second of the day of expiration.* *HOURS*, *MINUTES*, *SECONDS* - No rounding.</summary>
        public int? Value { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.ExpirationOffset"/> and sets the default values.
        /// </summary>
        public ExpirationOffset()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.ExpirationOffset"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.ExpirationOffset CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.ExpirationOffset();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "unit", n => { Unit = n.GetStringValue(); } },
                { "value", n => { Value = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("unit", Unit);
            writer.WriteIntValue("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
