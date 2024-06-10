// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models
{
    #pragma warning disable CS1591
    public class MaxAPRSchedulesResponse : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Date and time when the override APR ends, in UTC.</summary>
        public DateTimeOffset? EndDate { get; set; }
        /// <summary>Reason for the override APR.</summary>
        public Marqeta.Core.Sdk.Models.MaxAPRSchedulesResponse_reason? Reason { get; set; }
        /// <summary>Date and time when the override APR goes into effect, in UTC.</summary>
        public DateTimeOffset? StartDate { get; set; }
        /// <summary>The APR percentage value. This is the value of the fixed rate during the override period. The APR value must adhere to the constraints of the main schedule, such as maximum allowable values.</summary>
        public double? Value { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Models.MaxAPRSchedulesResponse"/> and sets the default values.
        /// </summary>
        public MaxAPRSchedulesResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Models.MaxAPRSchedulesResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Marqeta.Core.Sdk.Models.MaxAPRSchedulesResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Marqeta.Core.Sdk.Models.MaxAPRSchedulesResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "end_date", n => { EndDate = n.GetDateTimeOffsetValue(); } },
                { "reason", n => { Reason = n.GetEnumValue<Marqeta.Core.Sdk.Models.MaxAPRSchedulesResponse_reason>(); } },
                { "start_date", n => { StartDate = n.GetDateTimeOffsetValue(); } },
                { "value", n => { Value = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("end_date", EndDate);
            writer.WriteEnumValue<Marqeta.Core.Sdk.Models.MaxAPRSchedulesResponse_reason>("reason", Reason);
            writer.WriteDateTimeOffsetValue("start_date", StartDate);
            writer.WriteDoubleValue("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
