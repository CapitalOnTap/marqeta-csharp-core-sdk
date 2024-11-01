// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Marqeta.Core.Sdk.Models
{
    /// <summary>
    /// Return filtered transactions.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class JournalEntriesPage : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Number of resources returned.</summary>
        public int? Count { get; set; }
        /// <summary>Contains one or more journal entries on a credit account.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Marqeta.Core.Sdk.Models.JournalEntry>? Data { get; set; }
#nullable restore
#else
        public List<global::Marqeta.Core.Sdk.Models.JournalEntry> Data { get; set; }
#endif
        /// <summary>Sort order index of the last resource in the returned array.</summary>
        public int? EndIndex { get; set; }
        /// <summary>A value of `true` indicates that more unreturned resources exist.</summary>
        public bool? IsMore { get; set; }
        /// <summary>Sort order index of the first resource in the returned array.</summary>
        public int? StartIndex { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.JournalEntriesPage"/> and sets the default values.
        /// </summary>
        public JournalEntriesPage()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.JournalEntriesPage"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.JournalEntriesPage CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.JournalEntriesPage();
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
                { "data", n => { Data = n.GetCollectionOfObjectValues<global::Marqeta.Core.Sdk.Models.JournalEntry>(global::Marqeta.Core.Sdk.Models.JournalEntry.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::Marqeta.Core.Sdk.Models.JournalEntry>("data", Data);
            writer.WriteIntValue("end_index", EndIndex);
            writer.WriteBoolValue("is_more", IsMore);
            writer.WriteIntValue("start_index", StartIndex);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
