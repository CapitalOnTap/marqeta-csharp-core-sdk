// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    #pragma warning disable CS1591
    public class GPAUnloadListResponse : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Number of resources to retrieve.This field is returned if there are resources in your returned array.</summary>
        public int? Count { get; set; }
        /// <summary>Array of GPA unload order objects.Objects are returned as appropriate to your query.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Gpa_returns>? Data { get; set; }
#nullable restore
#else
        public List<Gpa_returns> Data { get; set; }
#endif
        /// <summary>Sort order index of the last resource in the returned array.This field is returned if there are resources in your returned array.</summary>
        public int? EndIndex { get; set; }
        /// <summary>A value of `true` indicates that more unreturned resources exist.A value of `false` indicates that no more unreturned resources exist.This field is returned if there are resources in your returned array.</summary>
        public bool? IsMore { get; set; }
        /// <summary>Sort order index of the first resource in the returned array.This field is returned if there are resources in your returned array.</summary>
        public int? StartIndex { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="GPAUnloadListResponse"/> and sets the default values.
        /// </summary>
        public GPAUnloadListResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="GPAUnloadListResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static GPAUnloadListResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GPAUnloadListResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"count", n => { Count = n.GetIntValue(); } },
                {"data", n => { Data = n.GetCollectionOfObjectValues<Gpa_returns>(Gpa_returns.CreateFromDiscriminatorValue)?.ToList(); } },
                {"end_index", n => { EndIndex = n.GetIntValue(); } },
                {"is_more", n => { IsMore = n.GetBoolValue(); } },
                {"start_index", n => { StartIndex = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("count", Count);
            writer.WriteCollectionOfObjectValues<Gpa_returns>("data", Data);
            writer.WriteIntValue("end_index", EndIndex);
            writer.WriteBoolValue("is_more", IsMore);
            writer.WriteIntValue("start_index", StartIndex);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
