// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    /// <summary>
    /// Governs the behavior of JIT Funding.
    /// </summary>
    public class Jit_funding : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The paymentcard_funding_source property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Jit_funding_paymentcard_funding_source? PaymentcardFundingSource { get; set; }
#nullable restore
#else
        public Jit_funding_paymentcard_funding_source PaymentcardFundingSource { get; set; }
#endif
        /// <summary>The program_funding_source property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Jit_funding_program_funding_source? ProgramFundingSource { get; set; }
#nullable restore
#else
        public Jit_funding_program_funding_source ProgramFundingSource { get; set; }
#endif
        /// <summary>The programgateway_funding_source property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Jit_funding_programgateway_funding_source? ProgramgatewayFundingSource { get; set; }
#nullable restore
#else
        public Jit_funding_programgateway_funding_source ProgramgatewayFundingSource { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Jit_funding"/> and sets the default values.
        /// </summary>
        public Jit_funding() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Jit_funding"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Jit_funding CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Jit_funding();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"paymentcard_funding_source", n => { PaymentcardFundingSource = n.GetObjectValue<Jit_funding_paymentcard_funding_source>(Jit_funding_paymentcard_funding_source.CreateFromDiscriminatorValue); } },
                {"program_funding_source", n => { ProgramFundingSource = n.GetObjectValue<Jit_funding_program_funding_source>(Jit_funding_program_funding_source.CreateFromDiscriminatorValue); } },
                {"programgateway_funding_source", n => { ProgramgatewayFundingSource = n.GetObjectValue<Jit_funding_programgateway_funding_source>(Jit_funding_programgateway_funding_source.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Jit_funding_paymentcard_funding_source>("paymentcard_funding_source", PaymentcardFundingSource);
            writer.WriteObjectValue<Jit_funding_program_funding_source>("program_funding_source", ProgramFundingSource);
            writer.WriteObjectValue<Jit_funding_programgateway_funding_source>("programgateway_funding_source", ProgramgatewayFundingSource);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}