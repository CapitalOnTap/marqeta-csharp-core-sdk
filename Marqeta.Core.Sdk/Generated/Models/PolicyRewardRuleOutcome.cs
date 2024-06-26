// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models
{
    /// <summary>
    /// Contains information on the outcome of a reward rule.
    /// </summary>
    public class PolicyRewardRuleOutcome : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Max amount of the reward.</summary>
        public double? MaxAmount { get; set; }
        /// <summary>Reward percentage applied when the balance for a billing cycle is within the range specified in the `filters.amount.greater_than` and `filters.amount.less_than` fields.For example, if the percentage is `1`, the account holder earns 1% of the account balance if they spend between the `greater_than` and `less_than` amounts during a billing cycle.</summary>
        public double? Percentage { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Models.PolicyRewardRuleOutcome"/> and sets the default values.
        /// </summary>
        public PolicyRewardRuleOutcome()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Models.PolicyRewardRuleOutcome"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Marqeta.Core.Sdk.Models.PolicyRewardRuleOutcome CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Marqeta.Core.Sdk.Models.PolicyRewardRuleOutcome();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "max_amount", n => { MaxAmount = n.GetDoubleValue(); } },
                { "percentage", n => { Percentage = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("max_amount", MaxAmount);
            writer.WriteDoubleValue("percentage", Percentage);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
