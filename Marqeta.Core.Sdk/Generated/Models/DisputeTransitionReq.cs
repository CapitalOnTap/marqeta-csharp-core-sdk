// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    /// <summary>
    /// Information about a transaction dispute update request.
    /// </summary>
    public class DisputeTransitionReq : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Updated amount of the dispute, based on the resolution.</summary>
        public double? Amount { get; set; }
        /// <summary>Additional information on the dispute update (for example, a reason for the dispute update).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Notes { get; set; }
#nullable restore
#else
        public string Notes { get; set; }
#endif
        /// <summary>Status of the dispute.* `ACTIVE` - The dispute is active and awaiting resolution.* `REVERSED` - The dispute has been reversed and is no longer active.* `AH_WON` - The account holder won the dispute.* `AH_LOST` - The account holder lost the dispute.</summary>
        public DisputeStatus? Status { get; set; }
        /// <summary>Unique identifier of the dispute update.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="DisputeTransitionReq"/> and sets the default values.
        /// </summary>
        public DisputeTransitionReq()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DisputeTransitionReq"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DisputeTransitionReq CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DisputeTransitionReq();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"amount", n => { Amount = n.GetDoubleValue(); } },
                {"notes", n => { Notes = n.GetStringValue(); } },
                {"status", n => { Status = n.GetEnumValue<DisputeStatus>(); } },
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
            writer.WriteDoubleValue("amount", Amount);
            writer.WriteStringValue("notes", Notes);
            writer.WriteEnumValue<DisputeStatus>("status", Status);
            writer.WriteStringValue("token", Token);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
