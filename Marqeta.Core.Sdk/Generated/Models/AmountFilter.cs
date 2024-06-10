// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models
{
    /// <summary>
    /// Contains information on the minimum and maximum amounts that the balance for a billing cycle can be to earn the reward.
    /// </summary>
    public class AmountFilter : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Minimum amount that a balance for a billing cycle can be to earn the reward.</summary>
        public double? GreaterThan { get; set; }
        /// <summary>Maximum amount that a balance for a billing cycle can be to earn the reward.</summary>
        public double? LessThan { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Models.AmountFilter"/> and sets the default values.
        /// </summary>
        public AmountFilter()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Models.AmountFilter"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Marqeta.Core.Sdk.Models.AmountFilter CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Marqeta.Core.Sdk.Models.AmountFilter();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "greater_than", n => { GreaterThan = n.GetDoubleValue(); } },
                { "less_than", n => { LessThan = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("greater_than", GreaterThan);
            writer.WriteDoubleValue("less_than", LessThan);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
