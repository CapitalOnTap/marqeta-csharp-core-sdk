// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    /// <summary>
    /// Contains funding information for the transaction, including funding amount, type, and time.
    /// </summary>
    public class Funding : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Amount of funds loaded into the GPA.</summary>
        public double? Amount { get; set; }
        /// <summary>Contains information from the JIT Funding gateway in response to a funding request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Gateway_log_model? GatewayLog { get; set; }
#nullable restore
#else
        public Gateway_log_model GatewayLog { get; set; }
#endif
        /// <summary>Contains funding source information for the transaction, including the funding type and time.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Funding_source_model? Source { get; set; }
#nullable restore
#else
        public Funding_source_model Source { get; set; }
#endif
        /// <summary>Contains information about the billing address of the funding source.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CardholderAddressResponse? SourceAddress { get; set; }
#nullable restore
#else
        public CardholderAddressResponse SourceAddress { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Funding"/> and sets the default values.
        /// </summary>
        public Funding() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Funding"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Funding CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Funding();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"amount", n => { Amount = n.GetDoubleValue(); } },
                {"gateway_log", n => { GatewayLog = n.GetObjectValue<Gateway_log_model>(Gateway_log_model.CreateFromDiscriminatorValue); } },
                {"source", n => { Source = n.GetObjectValue<Funding_source_model>(Funding_source_model.CreateFromDiscriminatorValue); } },
                {"source_address", n => { SourceAddress = n.GetObjectValue<CardholderAddressResponse>(CardholderAddressResponse.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("amount", Amount);
            writer.WriteObjectValue<Gateway_log_model>("gateway_log", GatewayLog);
            writer.WriteObjectValue<Funding_source_model>("source", Source);
            writer.WriteObjectValue<CardholderAddressResponse>("source_address", SourceAddress);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}