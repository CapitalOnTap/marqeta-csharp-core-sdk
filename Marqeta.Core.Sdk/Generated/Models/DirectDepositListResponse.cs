// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    public class DirectDepositListResponse : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The count property</summary>
        public int? Count { get; set; }
        /// <summary>The data property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DirectDepositResponse>? Data { get; set; }
#nullable restore
#else
        public List<DirectDepositResponse> Data { get; set; }
#endif
        /// <summary>The end_index property</summary>
        public int? EndIndex { get; set; }
        /// <summary>The is_more property</summary>
        public bool? IsMore { get; set; }
        /// <summary>The start_index property</summary>
        public int? StartIndex { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="DirectDepositListResponse"/> and sets the default values.
        /// </summary>
        public DirectDepositListResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DirectDepositListResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DirectDepositListResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DirectDepositListResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"count", n => { Count = n.GetIntValue(); } },
                {"data", n => { Data = n.GetCollectionOfObjectValues<DirectDepositResponse>(DirectDepositResponse.CreateFromDiscriminatorValue)?.ToList(); } },
                {"end_index", n => { EndIndex = n.GetIntValue(); } },
                {"is_more", n => { IsMore = n.GetBoolValue(); } },
                {"start_index", n => { StartIndex = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("count", Count);
            writer.WriteCollectionOfObjectValues<DirectDepositResponse>("data", Data);
            writer.WriteIntValue("end_index", EndIndex);
            writer.WriteBoolValue("is_more", IsMore);
            writer.WriteIntValue("start_index", StartIndex);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
