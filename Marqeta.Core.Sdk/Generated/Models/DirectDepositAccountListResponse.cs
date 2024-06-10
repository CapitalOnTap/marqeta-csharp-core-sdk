// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models
{
    #pragma warning disable CS1591
    public class DirectDepositAccountListResponse : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The count property</summary>
        public int? Count { get; set; }
        /// <summary>The data property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Marqeta.Core.Sdk.Models.Direct_deposit_account_response>? Data { get; set; }
#nullable restore
#else
        public List<Marqeta.Core.Sdk.Models.Direct_deposit_account_response> Data { get; set; }
#endif
        /// <summary>The end_index property</summary>
        public int? EndIndex { get; set; }
        /// <summary>The is_more property</summary>
        public bool? IsMore { get; set; }
        /// <summary>The start_index property</summary>
        public int? StartIndex { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Models.DirectDepositAccountListResponse"/> and sets the default values.
        /// </summary>
        public DirectDepositAccountListResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Models.DirectDepositAccountListResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Marqeta.Core.Sdk.Models.DirectDepositAccountListResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Marqeta.Core.Sdk.Models.DirectDepositAccountListResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "count", n => { Count = n.GetIntValue(); } },
                { "data", n => { Data = n.GetCollectionOfObjectValues<Marqeta.Core.Sdk.Models.Direct_deposit_account_response>(Marqeta.Core.Sdk.Models.Direct_deposit_account_response.CreateFromDiscriminatorValue)?.ToList(); } },
                { "end_index", n => { EndIndex = n.GetIntValue(); } },
                { "is_more", n => { IsMore = n.GetBoolValue(); } },
                { "start_index", n => { StartIndex = n.GetIntValue(); } },
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
            writer.WriteCollectionOfObjectValues<Marqeta.Core.Sdk.Models.Direct_deposit_account_response>("data", Data);
            writer.WriteIntValue("end_index", EndIndex);
            writer.WriteBoolValue("is_more", IsMore);
            writer.WriteIntValue("start_index", StartIndex);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
