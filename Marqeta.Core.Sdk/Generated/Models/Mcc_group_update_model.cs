// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models
{
    #pragma warning disable CS1591
    public class Mcc_group_update_model : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Indicates whether the MCC group is active or inactive.</summary>
        public bool? Active { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Allows for configuration options for this group, including control over the expiration of authorizations and automatic increases to the authorization amount.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Marqeta.Core.Sdk.Models.Config? Config { get; set; }
#nullable restore
#else
        public Marqeta.Core.Sdk.Models.Config Config { get; set; }
#endif
        /// <summary>The set of merchant category codes that you want to include in this group.For each element, valid characters are 0-9, and the length must be 4 digits.You can also specify a range like &quot;9876-9880&quot;.An MCC can belong to more than one group.Updating the merchant category codes for the group completely replaces the group&apos;s existing codes.For example, if the current MCC group is `[&quot;1234&quot;]` and you want to add the 2345 code (while retaining the existing code), you must specify `[&quot;1234&quot;, &quot;2345&quot;]` in this field.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Mccs { get; set; }
#nullable restore
#else
        public List<string> Mccs { get; set; }
#endif
        /// <summary>The name of the MCC group.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Models.Mcc_group_update_model"/> and sets the default values.
        /// </summary>
        public Mcc_group_update_model()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Models.Mcc_group_update_model"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Marqeta.Core.Sdk.Models.Mcc_group_update_model CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Marqeta.Core.Sdk.Models.Mcc_group_update_model();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "active", n => { Active = n.GetBoolValue(); } },
                { "config", n => { Config = n.GetObjectValue<Marqeta.Core.Sdk.Models.Config>(Marqeta.Core.Sdk.Models.Config.CreateFromDiscriminatorValue); } },
                { "mccs", n => { Mccs = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "name", n => { Name = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("active", Active);
            writer.WriteObjectValue<Marqeta.Core.Sdk.Models.Config>("config", Config);
            writer.WriteCollectionOfPrimitiveValues<string>("mccs", Mccs);
            writer.WriteStringValue("name", Name);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
