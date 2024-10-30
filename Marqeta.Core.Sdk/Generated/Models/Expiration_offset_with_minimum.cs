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
    /// Specifies the length of time after the date of issue for which cards of this card product type are valid.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Expiration_offset_with_minimum : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Specifies the minimum length of time after the date of issue for which the cards are valid.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.Models.Min_offset? MinOffset { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.Min_offset MinOffset { get; set; }
#endif
        /// <summary>Specifies the units for the `value` field.</summary>
        public global::Marqeta.Core.Sdk.Models.Expiration_offset_with_minimum_unit? Unit { get; set; }
        /// <summary>Specifies the number of time units (as defined by the `unit` field in this object) for which cards of this card product type are valid.In other words, cards expire `value` x `unit` after the date of issue.This number is rounded as follows:* *YEARS* – Rounds up to the last second of the last day of the month of expiration.For example, if the issue date is 1 Jan 2021 and `value = 1`, the cards expire on the last day of Jan 2022.* *MONTHS* – Rounds up to the last second of the last day of the month of expiration.For example, if the issue date is 1 May 2022 and `value = 1`, the cards expire on the last day of June 2022.* *DAYS* – Rounds up to the last second of the day of expiration.* *HOURS*, *MINUTES*, *SECONDS* – No rounding.</summary>
        public int? Value { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.Expiration_offset_with_minimum"/> and sets the default values.
        /// </summary>
        public Expiration_offset_with_minimum()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.Expiration_offset_with_minimum"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.Expiration_offset_with_minimum CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.Expiration_offset_with_minimum();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "min_offset", n => { MinOffset = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.Min_offset>(global::Marqeta.Core.Sdk.Models.Min_offset.CreateFromDiscriminatorValue); } },
                { "unit", n => { Unit = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.Expiration_offset_with_minimum_unit>(); } },
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
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.Min_offset>("min_offset", MinOffset);
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.Expiration_offset_with_minimum_unit>("unit", Unit);
            writer.WriteIntValue("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
