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
    /// Contains information on a periodic fee.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ProductConfig_periodic_fees : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>How frequently the fee is charged.</summary>
        public global::Marqeta.Core.Sdk.Models.ProductConfig_periodic_fees_frequency? Frequency { get; set; }
        /// <summary>Number of days after an account is activated that the initial fee is charged.For example, if the value in this field is `30`, then the initial fee is charged 30 days after an account is activated.</summary>
        public int? NumberOfDaysPostActivation { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.ProductConfig_periodic_fees"/> and sets the default values.
        /// </summary>
        public ProductConfig_periodic_fees()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.ProductConfig_periodic_fees"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.ProductConfig_periodic_fees CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.ProductConfig_periodic_fees();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "frequency", n => { Frequency = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.ProductConfig_periodic_fees_frequency>(); } },
                { "number_of_days_post_activation", n => { NumberOfDaysPostActivation = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.ProductConfig_periodic_fees_frequency>("frequency", Frequency);
            writer.WriteIntValue("number_of_days_post_activation", NumberOfDaysPostActivation);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
