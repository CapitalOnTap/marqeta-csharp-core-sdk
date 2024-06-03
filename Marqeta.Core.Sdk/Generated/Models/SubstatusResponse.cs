// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    /// <summary>
    /// Contains information about the substatus.
    /// </summary>
    public class SubstatusResponse : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Additional dynamic attributes related to the substatus.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SubstatusResponse_attributes? Attributes { get; set; }
#nullable restore
#else
        public SubstatusResponse_attributes Attributes { get; set; }
#endif
        /// <summary>List of events related to the substatus.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SubstatusResponse_events>? Events { get; set; }
#nullable restore
#else
        public List<SubstatusResponse_events> Events { get; set; }
#endif
        /// <summary>Flag indicating whether the substatus is active (false when deactivated).</summary>
        public bool? IsActive { get; set; }
        /// <summary>substatus resource token</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceToken { get; set; }
#nullable restore
#else
        public string ResourceToken { get; set; }
#endif
        /// <summary>substatus resource type</summary>
        public SubstatusResponse_resource_type? ResourceType { get; set; }
        /// <summary>substatus</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Substatus { get; set; }
#nullable restore
#else
        public string Substatus { get; set; }
#endif
        /// <summary>substatus token</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="SubstatusResponse"/> and sets the default values.
        /// </summary>
        public SubstatusResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="SubstatusResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SubstatusResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SubstatusResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"attributes", n => { Attributes = n.GetObjectValue<SubstatusResponse_attributes>(SubstatusResponse_attributes.CreateFromDiscriminatorValue); } },
                {"events", n => { Events = n.GetCollectionOfObjectValues<SubstatusResponse_events>(SubstatusResponse_events.CreateFromDiscriminatorValue)?.ToList(); } },
                {"is_active", n => { IsActive = n.GetBoolValue(); } },
                {"resource_token", n => { ResourceToken = n.GetStringValue(); } },
                {"resource_type", n => { ResourceType = n.GetEnumValue<SubstatusResponse_resource_type>(); } },
                {"substatus", n => { Substatus = n.GetStringValue(); } },
                {"token", n => { Token = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<SubstatusResponse_attributes>("attributes", Attributes);
            writer.WriteCollectionOfObjectValues<SubstatusResponse_events>("events", Events);
            writer.WriteBoolValue("is_active", IsActive);
            writer.WriteStringValue("resource_token", ResourceToken);
            writer.WriteEnumValue<SubstatusResponse_resource_type>("resource_type", ResourceType);
            writer.WriteStringValue("substatus", Substatus);
            writer.WriteStringValue("token", Token);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
