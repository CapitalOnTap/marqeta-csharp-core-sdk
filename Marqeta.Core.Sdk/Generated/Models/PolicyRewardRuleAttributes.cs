// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models
{
    /// <summary>
    /// Additional properties for which the rule can be used to determine reward accrual eligibility for a transaction.
    /// </summary>
    public class PolicyRewardRuleAttributes : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Maximum spend amount.</summary>
        public double? MaxSpend { get; set; }
        /// <summary>List of merchant category codes (MCCs).MCCs must be a four-digit number, or a range of two four-digit numbers separated by a hyphen.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Mcc { get; set; }
#nullable restore
#else
        public List<string> Mcc { get; set; }
#endif
        /// <summary>Merchant ID for the rule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Mid { get; set; }
#nullable restore
#else
        public string Mid { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Models.PolicyRewardRuleAttributes"/> and sets the default values.
        /// </summary>
        public PolicyRewardRuleAttributes()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Models.PolicyRewardRuleAttributes"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Marqeta.Core.Sdk.Models.PolicyRewardRuleAttributes CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Marqeta.Core.Sdk.Models.PolicyRewardRuleAttributes();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "max_spend", n => { MaxSpend = n.GetDoubleValue(); } },
                { "mcc", n => { Mcc = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "mid", n => { Mid = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("max_spend", MaxSpend);
            writer.WriteCollectionOfPrimitiveValues<string>("mcc", Mcc);
            writer.WriteStringValue("mid", Mid);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}