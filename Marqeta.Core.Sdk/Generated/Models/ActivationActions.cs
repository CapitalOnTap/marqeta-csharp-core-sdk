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
    /// Contains information on actions that can be performed when a card is activated.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ActivationActions : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Token of the card from which to move digital wallet tokens.All digital wallet tokens are move from the card specified in this field to the new card.Not relevant when `reissue_pan_from_card_token` is set.Send a `GET` request to `/cards/user/{token}` to retrieve card tokens for a particular user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SwapDigitalWalletTokensFromCardToken { get; set; }
#nullable restore
#else
        public string SwapDigitalWalletTokensFromCardToken { get; set; }
#endif
        /// <summary>If you are reissuing a card, the source card is terminated by default.To prevent the source card from being terminated, set this field to `false`.Only relevant when `reissue_pan_from_card_token` is set.</summary>
        public bool? TerminateReissuedSourceCard { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.ActivationActions"/> and sets the default values.
        /// </summary>
        public ActivationActions()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.ActivationActions"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.ActivationActions CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.ActivationActions();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "swap_digital_wallet_tokens_from_card_token", n => { SwapDigitalWalletTokensFromCardToken = n.GetStringValue(); } },
                { "terminate_reissued_source_card", n => { TerminateReissuedSourceCard = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("swap_digital_wallet_tokens_from_card_token", SwapDigitalWalletTokensFromCardToken);
            writer.WriteBoolValue("terminate_reissued_source_card", TerminateReissuedSourceCard);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
