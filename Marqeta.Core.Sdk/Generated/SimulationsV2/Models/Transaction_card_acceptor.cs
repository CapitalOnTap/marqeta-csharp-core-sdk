// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Marqeta.Core.Sdk.SimulationsV2.Models
{
    /// <summary>
    /// Contains information about the merchant.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Transaction_card_acceptor : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Card acceptor&apos;s address.May be returned if the request uses Transaction Model v1 of the Marqeta Core API.Not returned for Transaction Model v2 requests.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Address { get; set; }
#nullable restore
#else
        public string Address { get; set; }
#endif
        /// <summary>Card acceptor&apos;s city.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? City { get; set; }
#nullable restore
#else
        public string City { get; set; }
#endif
        /// <summary>Card acceptor&apos;s country code.May be returned if the request uses Transaction Model v2 of the Marqeta Core API.Not returned for Transaction Model v1 requests.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CountryCode { get; set; }
#nullable restore
#else
        public string CountryCode { get; set; }
#endif
        /// <summary>Merchant category code (MCC).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Mcc { get; set; }
#nullable restore
#else
        public string Mcc { get; set; }
#endif
        /// <summary>The merchant identifier.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Mid { get; set; }
#nullable restore
#else
        public string Mid { get; set; }
#endif
        /// <summary>Card acceptor&apos;s name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The poi property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.SimulationsV2.Models.Terminal_model? Poi { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.SimulationsV2.Models.Terminal_model Poi { get; set; }
#endif
        /// <summary>Card acceptor&apos;s postal code.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PostalCode { get; set; }
#nullable restore
#else
        public string PostalCode { get; set; }
#endif
        /// <summary>Two-character state, province, or territorial abbreviation.For a complete list of valid state and province abbreviations, see &lt;&lt;/core-api/kyc-verification#_valid_state_provincial_and_territorial_abbreviations, Valid state, provincial, and territorial abbreviations&gt;&gt;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? State { get; set; }
#nullable restore
#else
        public string State { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.SimulationsV2.Models.Transaction_card_acceptor"/> and sets the default values.
        /// </summary>
        public Transaction_card_acceptor()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.SimulationsV2.Models.Transaction_card_acceptor"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.SimulationsV2.Models.Transaction_card_acceptor CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.SimulationsV2.Models.Transaction_card_acceptor();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "address", n => { Address = n.GetStringValue(); } },
                { "city", n => { City = n.GetStringValue(); } },
                { "country_code", n => { CountryCode = n.GetStringValue(); } },
                { "mcc", n => { Mcc = n.GetStringValue(); } },
                { "mid", n => { Mid = n.GetStringValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "poi", n => { Poi = n.GetObjectValue<global::Marqeta.Core.Sdk.SimulationsV2.Models.Terminal_model>(global::Marqeta.Core.Sdk.SimulationsV2.Models.Terminal_model.CreateFromDiscriminatorValue); } },
                { "postal_code", n => { PostalCode = n.GetStringValue(); } },
                { "state", n => { State = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("address", Address);
            writer.WriteStringValue("city", City);
            writer.WriteStringValue("country_code", CountryCode);
            writer.WriteStringValue("mcc", Mcc);
            writer.WriteStringValue("mid", Mid);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.SimulationsV2.Models.Terminal_model>("poi", Poi);
            writer.WriteStringValue("postal_code", PostalCode);
            writer.WriteStringValue("state", State);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
