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
    /// Defines the group of merchants to which the velocity control applies.Populate no more than one field of the `merchant_scope` object.If no fields are populated, the velocity control applies to all merchants.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Merchant_scope : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Merchant Category Code (MCC).Identifies the type of products or services provided by the merchant.Enter a value to control spending on a particular type of product or service.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Mcc { get; set; }
#nullable restore
#else
        public string Mcc { get; set; }
#endif
        /// <summary>Token identifying a group of MCCs.Enter a value to control spending on a group of product or service types.Send a `GET` request to `/mccgroups` to retrieve MCC group tokens.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MccGroup { get; set; }
#nullable restore
#else
        public string MccGroup { get; set; }
#endif
        /// <summary>Merchant identifier (MID).Identifies a specific merchant.Enter a value to control spending with a particular merchant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Mid { get; set; }
#nullable restore
#else
        public string Mid { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.Merchant_scope"/> and sets the default values.
        /// </summary>
        public Merchant_scope()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.Merchant_scope"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.Merchant_scope CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.Merchant_scope();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "mcc", n => { Mcc = n.GetStringValue(); } },
                { "mcc_group", n => { MccGroup = n.GetStringValue(); } },
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
            writer.WriteStringValue("mcc", Mcc);
            writer.WriteStringValue("mcc_group", MccGroup);
            writer.WriteStringValue("mid", Mid);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
