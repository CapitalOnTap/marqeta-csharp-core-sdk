// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    public class AprScheduleResponse : IAdditionalDataHolder, IParsable {
        /// <summary>Whether the APR is active.</summary>
        public bool? Active { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Date and time when the APR was created on Marqeta&apos;s credit platform, in UTC.</summary>
        public DateTimeOffset? CreatedDate { get; set; }
        /// <summary>Contains one or more `schedule` objects, which contain information about the annual percentage rates (APRs) associated with the type of balance on the credit account and when they are effective.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AprScheduleEntryResponse>? Schedule { get; set; }
#nullable restore
#else
        public List<AprScheduleEntryResponse> Schedule { get; set; }
#endif
        /// <summary>Type of APR.* `GO_TO` - Default APR rate that is applicable when any promotional periods expire.* `PROMOTIONAL` - A temporary rate that is applicable for a specified period of time.</summary>
        public AccountAprType? Type { get; set; }
        /// <summary>Date and time when the APR was last updated on Marqeta&apos;s credit platform, in UTC.</summary>
        public DateTimeOffset? UpdatedDate { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="AprScheduleResponse"/> and sets the default values.
        /// </summary>
        public AprScheduleResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AprScheduleResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AprScheduleResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AprScheduleResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"active", n => { Active = n.GetBoolValue(); } },
                {"created_date", n => { CreatedDate = n.GetDateTimeOffsetValue(); } },
                {"schedule", n => { Schedule = n.GetCollectionOfObjectValues<AprScheduleEntryResponse>(AprScheduleEntryResponse.CreateFromDiscriminatorValue)?.ToList(); } },
                {"type", n => { Type = n.GetEnumValue<AccountAprType>(); } },
                {"updated_date", n => { UpdatedDate = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("active", Active);
            writer.WriteDateTimeOffsetValue("created_date", CreatedDate);
            writer.WriteCollectionOfObjectValues<AprScheduleEntryResponse>("schedule", Schedule);
            writer.WriteEnumValue<AccountAprType>("type", Type);
            writer.WriteDateTimeOffsetValue("updated_date", UpdatedDate);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}