// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    #pragma warning disable CS1591
    public class Webhook_base_model : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Indicates whether the webhook is active.</summary>
        public bool? Active { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Contains the configuration information for the webhook.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Webhook_config_model? Config { get; set; }
#nullable restore
#else
        public Webhook_config_model Config { get; set; }
#endif
        /// <summary>Specifies the types of events for which notifications are sent.The wildcard character `\*` indicates that you receive all webhook notifications, or all notifications of a specified category.For example, `\*` indicates that you receive all webhook notifications; `transaction.*` indicates that you receive all `transaction` webhook notifications.*NOTE:* You can only use the wildcard character with the _base_ type events, not subcategories.For example, you cannot subscribe to `cardtransition.fulfillment.\*` events, but you can subscribe to `cardtransition.*`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Events { get; set; }
#nullable restore
#else
        public List<string> Events { get; set; }
#endif
        /// <summary>Descriptive name of the webhook.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Webhook_base_model"/> and sets the default values.
        /// </summary>
        public Webhook_base_model()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Webhook_base_model"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Webhook_base_model CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Webhook_base_model();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"active", n => { Active = n.GetBoolValue(); } },
                {"config", n => { Config = n.GetObjectValue<Webhook_config_model>(Webhook_config_model.CreateFromDiscriminatorValue); } },
                {"events", n => { Events = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"name", n => { Name = n.GetStringValue(); } },
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
            writer.WriteObjectValue<Webhook_config_model>("config", Config);
            writer.WriteCollectionOfPrimitiveValues<string>("events", Events);
            writer.WriteStringValue("name", Name);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
