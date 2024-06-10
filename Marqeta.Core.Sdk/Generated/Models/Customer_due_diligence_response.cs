// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models
{
    #pragma warning disable CS1591
    public class Customer_due_diligence_response : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The account_token property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountToken { get; set; }
#nullable restore
#else
        public string AccountToken { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The answer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Answer { get; set; }
#nullable restore
#else
        public string Answer { get; set; }
#endif
        /// <summary>The bank property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Bank { get; set; }
#nullable restore
#else
        public string Bank { get; set; }
#endif
        /// <summary>The question property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Question { get; set; }
#nullable restore
#else
        public string Question { get; set; }
#endif
        /// <summary>The token property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>The type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type { get; set; }
#nullable restore
#else
        public string Type { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Models.Customer_due_diligence_response"/> and sets the default values.
        /// </summary>
        public Customer_due_diligence_response()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Models.Customer_due_diligence_response"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Marqeta.Core.Sdk.Models.Customer_due_diligence_response CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Marqeta.Core.Sdk.Models.Customer_due_diligence_response();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "account_token", n => { AccountToken = n.GetStringValue(); } },
                { "answer", n => { Answer = n.GetStringValue(); } },
                { "bank", n => { Bank = n.GetStringValue(); } },
                { "question", n => { Question = n.GetStringValue(); } },
                { "token", n => { Token = n.GetStringValue(); } },
                { "type", n => { Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("account_token", AccountToken);
            writer.WriteStringValue("answer", Answer);
            writer.WriteStringValue("bank", Bank);
            writer.WriteStringValue("question", Question);
            writer.WriteStringValue("token", Token);
            writer.WriteStringValue("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
