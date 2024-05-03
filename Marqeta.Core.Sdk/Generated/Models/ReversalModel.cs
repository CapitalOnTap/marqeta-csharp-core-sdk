// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    #pragma warning disable CS1591
    public class ReversalModel : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The amount property</summary>
        public double? Amount { get; set; }
        /// <summary>The find_original_window_days property</summary>
        public int? FindOriginalWindowDays { get; set; }
        /// <summary>The is_advice property</summary>
        public bool? IsAdvice { get; set; }
        /// <summary>The network_fees property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Network_fee_model>? NetworkFees { get; set; }
#nullable restore
#else
        public List<Network_fee_model> NetworkFees { get; set; }
#endif
        /// <summary>The original_transaction_token property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OriginalTransactionToken { get; set; }
#nullable restore
#else
        public string OriginalTransactionToken { get; set; }
#endif
        /// <summary>The webhook property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Marqeta.Core.Sdk.Models.Webhook? Webhook { get; set; }
#nullable restore
#else
        public Marqeta.Core.Sdk.Models.Webhook Webhook { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="ReversalModel"/> and sets the default values.
        /// </summary>
        public ReversalModel()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ReversalModel"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ReversalModel CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ReversalModel();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"amount", n => { Amount = n.GetDoubleValue(); } },
                {"find_original_window_days", n => { FindOriginalWindowDays = n.GetIntValue(); } },
                {"is_advice", n => { IsAdvice = n.GetBoolValue(); } },
                {"network_fees", n => { NetworkFees = n.GetCollectionOfObjectValues<Network_fee_model>(Network_fee_model.CreateFromDiscriminatorValue)?.ToList(); } },
                {"original_transaction_token", n => { OriginalTransactionToken = n.GetStringValue(); } },
                {"webhook", n => { Webhook = n.GetObjectValue<Marqeta.Core.Sdk.Models.Webhook>(Marqeta.Core.Sdk.Models.Webhook.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("amount", Amount);
            writer.WriteIntValue("find_original_window_days", FindOriginalWindowDays);
            writer.WriteBoolValue("is_advice", IsAdvice);
            writer.WriteCollectionOfObjectValues<Network_fee_model>("network_fees", NetworkFees);
            writer.WriteStringValue("original_transaction_token", OriginalTransactionToken);
            writer.WriteObjectValue<Marqeta.Core.Sdk.Models.Webhook>("webhook", Webhook);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
