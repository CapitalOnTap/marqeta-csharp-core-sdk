// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models
{
    /// <summary>
    /// Contains information on the pricing strategy for purchases.
    /// </summary>
    public class PolicyAprPurchaseReq : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Unique identifier of the external pricing strategy for the credit program.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalToken { get; set; }
#nullable restore
#else
        public string ExternalToken { get; set; }
#endif
        /// <summary>Name of the pricing strategy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>One or more risk tiers for a pricing strategy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Marqeta.Core.Sdk.Models.PolicyAprTierReq>? Tiers { get; set; }
#nullable restore
#else
        public List<Marqeta.Core.Sdk.Models.PolicyAprTierReq> Tiers { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Models.PolicyAprPurchaseReq"/> and sets the default values.
        /// </summary>
        public PolicyAprPurchaseReq()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Models.PolicyAprPurchaseReq"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Marqeta.Core.Sdk.Models.PolicyAprPurchaseReq CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Marqeta.Core.Sdk.Models.PolicyAprPurchaseReq();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "external_token", n => { ExternalToken = n.GetStringValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "tiers", n => { Tiers = n.GetCollectionOfObjectValues<Marqeta.Core.Sdk.Models.PolicyAprTierReq>(Marqeta.Core.Sdk.Models.PolicyAprTierReq.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("external_token", ExternalToken);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfObjectValues<Marqeta.Core.Sdk.Models.PolicyAprTierReq>("tiers", Tiers);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
