// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Marqeta.Core.Sdk.SimulationsV2.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class PindebitAuthorizationClearingEvent : global::Marqeta.Core.Sdk.SimulationsV2.Models.CardTransactionSimulation, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Amount of the transaction.</summary>
        public double? Amount { get; set; }
        /// <summary>The card_acceptor property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.SimulationsV2.Models.Transaction_card_acceptor? CardAcceptor { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.SimulationsV2.Models.Transaction_card_acceptor CardAcceptor { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.SimulationsV2.Models.PindebitAuthorizationClearingEvent"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Marqeta.Core.Sdk.SimulationsV2.Models.PindebitAuthorizationClearingEvent CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.SimulationsV2.Models.PindebitAuthorizationClearingEvent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "amount", n => { Amount = n.GetDoubleValue(); } },
                { "card_acceptor", n => { CardAcceptor = n.GetObjectValue<global::Marqeta.Core.Sdk.SimulationsV2.Models.Transaction_card_acceptor>(global::Marqeta.Core.Sdk.SimulationsV2.Models.Transaction_card_acceptor.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDoubleValue("amount", Amount);
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.SimulationsV2.Models.Transaction_card_acceptor>("card_acceptor", CardAcceptor);
        }
    }
}
#pragma warning restore CS0618
