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
    /// Contains information from the JIT Funding gateway in response to a funding request.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Gateway_log_model : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Length of time in milliseconds that the gateway took to respond to a funding request.</summary>
        public long? Duration { get; set; }
        /// <summary>Message about the status of the funding request.Useful for determining whether it was approved and completed successfully, declined by the gateway, or timed out.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Message { get; set; }
#nullable restore
#else
        public string Message { get; set; }
#endif
        /// <summary>Customer order number, same value as `transaction.token`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OrderNumber { get; set; }
#nullable restore
#else
        public string OrderNumber { get; set; }
#endif
        /// <summary>Contains information from the gateway in response to a funding request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.Models.Gateway_response? Response { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.Gateway_response Response { get; set; }
#endif
        /// <summary>Whether the gateway sent a response (`true`) or timed out (`false`).</summary>
        public bool? TimedOut { get; set; }
        /// <summary>Customer-defined identifier for the transaction.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TransactionId { get; set; }
#nullable restore
#else
        public string TransactionId { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.Gateway_log_model"/> and sets the default values.
        /// </summary>
        public Gateway_log_model()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.Gateway_log_model"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.Gateway_log_model CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.Gateway_log_model();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "duration", n => { Duration = n.GetLongValue(); } },
                { "message", n => { Message = n.GetStringValue(); } },
                { "order_number", n => { OrderNumber = n.GetStringValue(); } },
                { "response", n => { Response = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.Gateway_response>(global::Marqeta.Core.Sdk.Models.Gateway_response.CreateFromDiscriminatorValue); } },
                { "timed_out", n => { TimedOut = n.GetBoolValue(); } },
                { "transaction_id", n => { TransactionId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteLongValue("duration", Duration);
            writer.WriteStringValue("message", Message);
            writer.WriteStringValue("order_number", OrderNumber);
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.Gateway_response>("response", Response);
            writer.WriteBoolValue("timed_out", TimedOut);
            writer.WriteStringValue("transaction_id", TransactionId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
