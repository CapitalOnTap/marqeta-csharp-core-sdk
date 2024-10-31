// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models
{
    /// <summary>
    /// Contains network-related metadata for the transaction, including details about the card program and the card product.Returned if provided by the card network
    /// </summary>
    public class Network_metadata : IAdditionalDataHolder, IParsable
    {
        /// <summary>The account_identification_1 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountIdentification1 { get; set; }
#nullable restore
#else
        public string AccountIdentification1 { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Visa Risk Management esponse code `59`, indicating suspected fraud.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IncomingResponseCode { get; set; }
#nullable restore
#else
        public string IncomingResponseCode { get; set; }
#endif
        /// <summary>Transaction type indicator provided by the card network for original credit and account funding transactions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NetworkFundingTxnType { get; set; }
#nullable restore
#else
        public string NetworkFundingTxnType { get; set; }
#endif
        /// <summary>Product identification value assigned by the card network to each card product.Can be used to track card-level activity by individual account number for premium card products.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductId { get; set; }
#nullable restore
#else
        public string ProductId { get; set; }
#endif
        /// <summary>Program identification number used with `product_id` that identifies the programs associated with a card within a program registered by the issuer with the card network.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProgramId { get; set; }
#nullable restore
#else
        public string ProgramId { get; set; }
#endif
        /// <summary>Indicates whether or not the base spend-assessment threshold defined by the card network has been met.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SpendQualifier { get; set; }
#nullable restore
#else
        public string SpendQualifier { get; set; }
#endif
        /// <summary>Name of the surcharge-free ATM network used to complete the transaction.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SurchargeFreeAtmNetwork { get; set; }
#nullable restore
#else
        public string SurchargeFreeAtmNetwork { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Models.Network_metadata"/> and sets the default values.
        /// </summary>
        public Network_metadata()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Models.Network_metadata"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Marqeta.Core.Sdk.Models.Network_metadata CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Marqeta.Core.Sdk.Models.Network_metadata();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "account_identification_1", n => { AccountIdentification1 = n.GetStringValue(); } },
                { "incoming_response_code", n => { IncomingResponseCode = n.GetStringValue(); } },
                { "network_funding_txn_type", n => { NetworkFundingTxnType = n.GetStringValue(); } },
                { "product_id", n => { ProductId = n.GetStringValue(); } },
                { "program_id", n => { ProgramId = n.GetStringValue(); } },
                { "spend_qualifier", n => { SpendQualifier = n.GetStringValue(); } },
                { "surcharge_free_atm_network", n => { SurchargeFreeAtmNetwork = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("account_identification_1", AccountIdentification1);
            writer.WriteStringValue("incoming_response_code", IncomingResponseCode);
            writer.WriteStringValue("network_funding_txn_type", NetworkFundingTxnType);
            writer.WriteStringValue("product_id", ProductId);
            writer.WriteStringValue("program_id", ProgramId);
            writer.WriteStringValue("spend_qualifier", SpendQualifier);
            writer.WriteStringValue("surcharge_free_atm_network", SurchargeFreeAtmNetwork);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
