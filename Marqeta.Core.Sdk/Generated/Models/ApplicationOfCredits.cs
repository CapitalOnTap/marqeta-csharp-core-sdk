// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    /// <summary>
    /// Contains information on the cycle type and billing cycle day when credits are applied in the daily balance calculation.
    /// </summary>
    public class ApplicationOfCredits : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Type of cycle.* `BEGINNING_REVOLVING` - Account is beginning to revolve and just started carrying a balancefrom the previous month.* `REVOLVING` - Account is revolving and has been carrying a balance from month to month for more than one month.* `END_REVOLVING` - Account is no longer revolving and the previous month&apos;s balance is paid off.* `TRANSACTING` - Account is not revolving and the balance is paid off each month.</summary>
        public Marqeta.Core.Sdk.Models.CycleType? CycleType { get; set; }
        /// <summary>Day of the billing cycle when credits are applied.</summary>
        public int? Day { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="ApplicationOfCredits"/> and sets the default values.
        /// </summary>
        public ApplicationOfCredits()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ApplicationOfCredits"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ApplicationOfCredits CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ApplicationOfCredits();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"cycle_type", n => { CycleType = n.GetEnumValue<CycleType>(); } },
                {"day", n => { Day = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<CycleType>("cycle_type", CycleType);
            writer.WriteIntValue("day", Day);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
