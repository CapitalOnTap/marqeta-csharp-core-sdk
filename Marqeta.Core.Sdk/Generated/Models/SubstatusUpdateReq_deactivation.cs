// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models
{
    /// <summary>
    /// Details of the deactivation process.
    /// </summary>
    public class SubstatusUpdateReq_deactivation : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The channel through which deactivation is occurring:- **ADMIN**: Added through the Marqeta Dashboard.- **API**: Initiated through the Core API.- **FRAUD**: Determined by Marqeta or the card network.- **SYSTEM**: Initiated by Marqeta</summary>
        public Marqeta.Core.Sdk.Models.SubstatusUpdateReq_deactivation_channel? Channel { get; set; }
        /// <summary>Effective date of the deactivation, in UTC.</summary>
        public DateTimeOffset? EffectiveDate { get; set; }
        /// <summary>Reason for deactivating the substatus.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Reason { get; set; }
#nullable restore
#else
        public string Reason { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Models.SubstatusUpdateReq_deactivation"/> and sets the default values.
        /// </summary>
        public SubstatusUpdateReq_deactivation()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Models.SubstatusUpdateReq_deactivation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Marqeta.Core.Sdk.Models.SubstatusUpdateReq_deactivation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Marqeta.Core.Sdk.Models.SubstatusUpdateReq_deactivation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "channel", n => { Channel = n.GetEnumValue<Marqeta.Core.Sdk.Models.SubstatusUpdateReq_deactivation_channel>(); } },
                { "effective_date", n => { EffectiveDate = n.GetDateTimeOffsetValue(); } },
                { "reason", n => { Reason = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<Marqeta.Core.Sdk.Models.SubstatusUpdateReq_deactivation_channel>("channel", Channel);
            writer.WriteDateTimeOffsetValue("effective_date", EffectiveDate);
            writer.WriteStringValue("reason", Reason);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
