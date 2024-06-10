// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models
{
    /// <summary>
    /// Describes the Commando Mode control set&apos;s `current_state` object.
    /// </summary>
    public class Commando_mode_nested_transition : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Mechanism that changed the Commando Mode control set&apos;s state.</summary>
        public Marqeta.Core.Sdk.Models.Commando_mode_nested_transition_channel? Channel { get; set; }
        /// <summary>Indicates whether Commando Mode is enabled.* If `commando_enabled` is `true` and `COMMANDO_MANUAL` is configured, all transactions are processed via Commando Mode.* If `commando_enabled` is `true` and `COMMANDO_AUTO` is configured, Commando Mode is ready to intervene only when a transaction times out or encounters an error.</summary>
        public bool? CommandoEnabled { get; set; }
        /// <summary>Describes the reason why the current state of the Commando Mode control set was last changed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Reason { get; set; }
#nullable restore
#else
        public string Reason { get; set; }
#endif
        /// <summary>Identifies the user who last changed the Commando Mode control set&apos;s state.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Username { get; set; }
#nullable restore
#else
        public string Username { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Models.Commando_mode_nested_transition"/> and sets the default values.
        /// </summary>
        public Commando_mode_nested_transition()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Models.Commando_mode_nested_transition"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Marqeta.Core.Sdk.Models.Commando_mode_nested_transition CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Marqeta.Core.Sdk.Models.Commando_mode_nested_transition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "channel", n => { Channel = n.GetEnumValue<Marqeta.Core.Sdk.Models.Commando_mode_nested_transition_channel>(); } },
                { "commando_enabled", n => { CommandoEnabled = n.GetBoolValue(); } },
                { "reason", n => { Reason = n.GetStringValue(); } },
                { "username", n => { Username = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<Marqeta.Core.Sdk.Models.Commando_mode_nested_transition_channel>("channel", Channel);
            writer.WriteBoolValue("commando_enabled", CommandoEnabled);
            writer.WriteStringValue("reason", Reason);
            writer.WriteStringValue("username", Username);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
