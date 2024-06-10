// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models
{
    #pragma warning disable CS1591
    public class SubstatusResponse_events : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Details of an event related to a substatus.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Marqeta.Core.Sdk.Models.SubstatusEventResponseDetails? Activation { get; set; }
#nullable restore
#else
        public Marqeta.Core.Sdk.Models.SubstatusEventResponseDetails Activation { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Details of an event related to a substatus.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Marqeta.Core.Sdk.Models.SubstatusEventResponseDetails? Deactivation { get; set; }
#nullable restore
#else
        public Marqeta.Core.Sdk.Models.SubstatusEventResponseDetails Deactivation { get; set; }
#endif
        /// <summary>The state of the event (e.g., MLA, SCRA).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? State { get; set; }
#nullable restore
#else
        public string State { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Models.SubstatusResponse_events"/> and sets the default values.
        /// </summary>
        public SubstatusResponse_events()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Models.SubstatusResponse_events"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Marqeta.Core.Sdk.Models.SubstatusResponse_events CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Marqeta.Core.Sdk.Models.SubstatusResponse_events();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "activation", n => { Activation = n.GetObjectValue<Marqeta.Core.Sdk.Models.SubstatusEventResponseDetails>(Marqeta.Core.Sdk.Models.SubstatusEventResponseDetails.CreateFromDiscriminatorValue); } },
                { "deactivation", n => { Deactivation = n.GetObjectValue<Marqeta.Core.Sdk.Models.SubstatusEventResponseDetails>(Marqeta.Core.Sdk.Models.SubstatusEventResponseDetails.CreateFromDiscriminatorValue); } },
                { "state", n => { State = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Marqeta.Core.Sdk.Models.SubstatusEventResponseDetails>("activation", Activation);
            writer.WriteObjectValue<Marqeta.Core.Sdk.Models.SubstatusEventResponseDetails>("deactivation", Deactivation);
            writer.WriteStringValue("state", State);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
