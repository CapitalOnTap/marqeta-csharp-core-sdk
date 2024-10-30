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
    public partial class Transaction_options : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The additional_dataProperty property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AdditionalDataProperty { get; set; }
#nullable restore
#else
        public string AdditionalDataProperty { get; set; }
#endif
        /// <summary>The card_expiration_date_yymm property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CardExpirationDateYymm { get; set; }
#nullable restore
#else
        public string CardExpirationDateYymm { get; set; }
#endif
        /// <summary>The database_transaction_timeout property</summary>
        public int? DatabaseTransactionTimeout { get; set; }
        /// <summary>The encryption_key_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EncryptionKeyId { get; set; }
#nullable restore
#else
        public string EncryptionKeyId { get; set; }
#endif
        /// <summary>The is_async property</summary>
        public bool? IsAsync { get; set; }
        /// <summary>The pre_auth_time_limit property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PreAuthTimeLimit { get; set; }
#nullable restore
#else
        public string PreAuthTimeLimit { get; set; }
#endif
        /// <summary>The send_expiration_date property</summary>
        public bool? SendExpirationDate { get; set; }
        /// <summary>The send_track_data property</summary>
        public bool? SendTrackData { get; set; }
        /// <summary>The transaction_timeout_threshold_seconds property</summary>
        public long? TransactionTimeoutThresholdSeconds { get; set; }
        /// <summary>The transaction_token property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TransactionToken { get; set; }
#nullable restore
#else
        public string TransactionToken { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.Transaction_options"/> and sets the default values.
        /// </summary>
        public Transaction_options()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.Transaction_options"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.Transaction_options CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.Transaction_options();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "additional_data", n => { AdditionalDataProperty = n.GetStringValue(); } },
                { "card_expiration_date_yymm", n => { CardExpirationDateYymm = n.GetStringValue(); } },
                { "database_transaction_timeout", n => { DatabaseTransactionTimeout = n.GetIntValue(); } },
                { "encryption_key_id", n => { EncryptionKeyId = n.GetStringValue(); } },
                { "is_async", n => { IsAsync = n.GetBoolValue(); } },
                { "pre_auth_time_limit", n => { PreAuthTimeLimit = n.GetStringValue(); } },
                { "send_expiration_date", n => { SendExpirationDate = n.GetBoolValue(); } },
                { "send_track_data", n => { SendTrackData = n.GetBoolValue(); } },
                { "transaction_timeout_threshold_seconds", n => { TransactionTimeoutThresholdSeconds = n.GetLongValue(); } },
                { "transaction_token", n => { TransactionToken = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("additional_data", AdditionalDataProperty);
            writer.WriteStringValue("card_expiration_date_yymm", CardExpirationDateYymm);
            writer.WriteIntValue("database_transaction_timeout", DatabaseTransactionTimeout);
            writer.WriteStringValue("encryption_key_id", EncryptionKeyId);
            writer.WriteBoolValue("is_async", IsAsync);
            writer.WriteStringValue("pre_auth_time_limit", PreAuthTimeLimit);
            writer.WriteBoolValue("send_expiration_date", SendExpirationDate);
            writer.WriteBoolValue("send_track_data", SendTrackData);
            writer.WriteLongValue("transaction_timeout_threshold_seconds", TransactionTimeoutThresholdSeconds);
            writer.WriteStringValue("transaction_token", TransactionToken);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
