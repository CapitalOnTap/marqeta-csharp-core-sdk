// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Marqeta.Core.Sdk.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class Chargeback_transition_response : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The amount property</summary>
        public double? Amount { get; set; }
        /// <summary>The channel property</summary>
        public global::Marqeta.Core.Sdk.Models.Chargeback_transition_response_channel? Channel { get; set; }
        /// <summary>The chargeback_token property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ChargebackToken { get; set; }
#nullable restore
#else
        public string ChargebackToken { get; set; }
#endif
        /// <summary>yyyy-MM-ddTHH:mm:ssZ</summary>
        public DateTimeOffset? CreatedTime { get; set; }
        /// <summary>yyyy-MM-ddTHH:mm:ssZ</summary>
        public DateTimeOffset? LastModifiedTime { get; set; }
        /// <summary>The previous_state property</summary>
        public global::Marqeta.Core.Sdk.Models.Chargeback_transition_response_previous_state? PreviousState { get; set; }
        /// <summary>The reason property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Reason { get; set; }
#nullable restore
#else
        public string Reason { get; set; }
#endif
        /// <summary>The state property</summary>
        public global::Marqeta.Core.Sdk.Models.Chargeback_transition_response_state? State { get; set; }
        /// <summary>The token property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>The transaction_token property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TransactionToken { get; set; }
#nullable restore
#else
        public string TransactionToken { get; set; }
#endif
        /// <summary>The type property</summary>
        public global::Marqeta.Core.Sdk.Models.Chargeback_transition_response_type? Type { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.Chargeback_transition_response"/> and sets the default values.
        /// </summary>
        public Chargeback_transition_response()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.Chargeback_transition_response"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.Chargeback_transition_response CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.Chargeback_transition_response();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "amount", n => { Amount = n.GetDoubleValue(); } },
                { "channel", n => { Channel = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.Chargeback_transition_response_channel>(); } },
                { "chargeback_token", n => { ChargebackToken = n.GetStringValue(); } },
                { "created_time", n => { CreatedTime = n.GetDateTimeOffsetValue(); } },
                { "last_modified_time", n => { LastModifiedTime = n.GetDateTimeOffsetValue(); } },
                { "previous_state", n => { PreviousState = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.Chargeback_transition_response_previous_state>(); } },
                { "reason", n => { Reason = n.GetStringValue(); } },
                { "state", n => { State = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.Chargeback_transition_response_state>(); } },
                { "token", n => { Token = n.GetStringValue(); } },
                { "transaction_token", n => { TransactionToken = n.GetStringValue(); } },
                { "type", n => { Type = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.Chargeback_transition_response_type>(); } },
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
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.Chargeback_transition_response_channel>("channel", Channel);
            writer.WriteStringValue("chargeback_token", ChargebackToken);
            writer.WriteDateTimeOffsetValue("created_time", CreatedTime);
            writer.WriteDateTimeOffsetValue("last_modified_time", LastModifiedTime);
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.Chargeback_transition_response_previous_state>("previous_state", PreviousState);
            writer.WriteStringValue("reason", Reason);
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.Chargeback_transition_response_state>("state", State);
            writer.WriteStringValue("token", Token);
            writer.WriteStringValue("transaction_token", TransactionToken);
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.Chargeback_transition_response_type>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
