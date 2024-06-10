// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models
{
    #pragma warning disable CS1591
    public class AprScheduleCreateReq : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Contains one or more `schedule` objects, which contain information on the annual percentage rates (APRs) associated with the type of balance on the credit account and when they are effective.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Marqeta.Core.Sdk.Models.AprScheduleEntryCreateReq>? Schedule { get; set; }
#nullable restore
#else
        public List<Marqeta.Core.Sdk.Models.AprScheduleEntryCreateReq> Schedule { get; set; }
#endif
        /// <summary>Type of APR.* `GO_TO` - Default APR rate that is applicable when any promotional periods expire.* `PROMOTIONAL` - A temporary rate that is applicable for a specified period of time.</summary>
        public Marqeta.Core.Sdk.Models.AccountAprType? Type { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Models.AprScheduleCreateReq"/> and sets the default values.
        /// </summary>
        public AprScheduleCreateReq()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Models.AprScheduleCreateReq"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Marqeta.Core.Sdk.Models.AprScheduleCreateReq CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Marqeta.Core.Sdk.Models.AprScheduleCreateReq();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "schedule", n => { Schedule = n.GetCollectionOfObjectValues<Marqeta.Core.Sdk.Models.AprScheduleEntryCreateReq>(Marqeta.Core.Sdk.Models.AprScheduleEntryCreateReq.CreateFromDiscriminatorValue)?.ToList(); } },
                { "type", n => { Type = n.GetEnumValue<Marqeta.Core.Sdk.Models.AccountAprType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<Marqeta.Core.Sdk.Models.AprScheduleEntryCreateReq>("schedule", Schedule);
            writer.WriteEnumValue<Marqeta.Core.Sdk.Models.AccountAprType>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
