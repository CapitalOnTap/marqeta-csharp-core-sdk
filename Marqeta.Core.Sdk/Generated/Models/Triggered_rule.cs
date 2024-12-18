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
    /// Provides a list of rules triggered by a fraud event, along with the information on tags and rule characteristics.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Triggered_rule : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Indicates if the rule triggered an alert.</summary>
        public bool? Alert { get; set; }
        /// <summary>The entity type where the triggered rule was defined.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EntityType { get; set; }
#nullable restore
#else
        public string EntityType { get; set; }
#endif
        /// <summary>Name of the rule, as defined in the Real-Time Decisioning dashboard that was triggered.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RuleName { get; set; }
#nullable restore
#else
        public string RuleName { get; set; }
#endif
        /// <summary>Indicates if the triggered rule has `suppress_alert` in the definition.</summary>
        public bool? SuppressAlert { get; set; }
        /// <summary>All the tags defined in the triggered rule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Marqeta.Core.Sdk.Models.Tag>? Tags { get; set; }
#nullable restore
#else
        public List<global::Marqeta.Core.Sdk.Models.Tag> Tags { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.Triggered_rule"/> and sets the default values.
        /// </summary>
        public Triggered_rule()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.Triggered_rule"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.Triggered_rule CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.Triggered_rule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "alert", n => { Alert = n.GetBoolValue(); } },
                { "entity_type", n => { EntityType = n.GetStringValue(); } },
                { "rule_name", n => { RuleName = n.GetStringValue(); } },
                { "suppress_alert", n => { SuppressAlert = n.GetBoolValue(); } },
                { "tags", n => { Tags = n.GetCollectionOfObjectValues<global::Marqeta.Core.Sdk.Models.Tag>(global::Marqeta.Core.Sdk.Models.Tag.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("alert", Alert);
            writer.WriteStringValue("entity_type", EntityType);
            writer.WriteStringValue("rule_name", RuleName);
            writer.WriteBoolValue("suppress_alert", SuppressAlert);
            writer.WriteCollectionOfObjectValues<global::Marqeta.Core.Sdk.Models.Tag>("tags", Tags);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
