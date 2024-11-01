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
    /// Contains information used to calculate the minimum payment amount when expressed as a percentage.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class PolicyProductMinPaymentPercentage : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Whether to include all fees charged when calculating the minimum payment.</summary>
        public bool? IncludeAllFeesCharged { get; set; }
        /// <summary>One or more fee types to include when calculating the minimum payment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Marqeta.Core.Sdk.Models.PolicyProductMinPaymentPercentage_include_fees_charged?>? IncludeFeesCharged { get; set; }
#nullable restore
#else
        public List<global::Marqeta.Core.Sdk.Models.PolicyProductMinPaymentPercentage_include_fees_charged?> IncludeFeesCharged { get; set; }
#endif
        /// <summary>Whether to include the amount of interest charged when calculating the minimum payment.</summary>
        public bool? IncludeInterestCharged { get; set; }
        /// <summary>Minimum payment, expressed as a percentage of the total statement balance, due on the payment due day.</summary>
        public double? PercentageOfBalance { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.PolicyProductMinPaymentPercentage"/> and sets the default values.
        /// </summary>
        public PolicyProductMinPaymentPercentage()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.PolicyProductMinPaymentPercentage"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.PolicyProductMinPaymentPercentage CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.PolicyProductMinPaymentPercentage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "include_all_fees_charged", n => { IncludeAllFeesCharged = n.GetBoolValue(); } },
                { "include_fees_charged", n => { IncludeFeesCharged = n.GetCollectionOfEnumValues<global::Marqeta.Core.Sdk.Models.PolicyProductMinPaymentPercentage_include_fees_charged>()?.AsList(); } },
                { "include_interest_charged", n => { IncludeInterestCharged = n.GetBoolValue(); } },
                { "percentage_of_balance", n => { PercentageOfBalance = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("include_all_fees_charged", IncludeAllFeesCharged);
            writer.WriteCollectionOfEnumValues<global::Marqeta.Core.Sdk.Models.PolicyProductMinPaymentPercentage_include_fees_charged>("include_fees_charged", IncludeFeesCharged);
            writer.WriteBoolValue("include_interest_charged", IncludeInterestCharged);
            writer.WriteDoubleValue("percentage_of_balance", PercentageOfBalance);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
