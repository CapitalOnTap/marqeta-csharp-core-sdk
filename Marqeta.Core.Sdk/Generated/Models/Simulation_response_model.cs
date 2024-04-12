// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    public class Simulation_response_model : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The raw_iso8583 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Simulation_response_model_raw_iso8583? RawIso8583 { get; set; }
#nullable restore
#else
        public Simulation_response_model_raw_iso8583 RawIso8583 { get; set; }
#endif
        /// <summary>Transactions are represented by the `transaction` object.The Marqeta platform creates a separate `transaction` object for each transaction message received from the card network.The attributes of a given `transaction` object depend on the transaction type.This section documents all fields that might be included in a `transaction` object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Transaction_model? Transaction { get; set; }
#nullable restore
#else
        public Transaction_model Transaction { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Simulation_response_model"/> and sets the default values.
        /// </summary>
        public Simulation_response_model() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Simulation_response_model"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Simulation_response_model CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Simulation_response_model();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"raw_iso8583", n => { RawIso8583 = n.GetObjectValue<Simulation_response_model_raw_iso8583>(Simulation_response_model_raw_iso8583.CreateFromDiscriminatorValue); } },
                {"transaction", n => { Transaction = n.GetObjectValue<Transaction_model>(Transaction_model.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Simulation_response_model_raw_iso8583>("raw_iso8583", RawIso8583);
            writer.WriteObjectValue<Transaction_model>("transaction", Transaction);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
