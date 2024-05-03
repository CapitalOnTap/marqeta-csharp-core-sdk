// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    /// <summary>
    /// Contains the chargeback object associated with this transaction if a chargeback has been initiated.
    /// </summary>
    public class Chargeback_response : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Amount of the chargeback.</summary>
        public double? Amount { get; set; }
        /// <summary>Channel the chargeback came through.</summary>
        public Chargeback_response_channel? Channel { get; set; }
        /// <summary>Date and time when the chargeback was created.Not returned for transactions when the associated chargeback is in the `INITIATED` state.</summary>
        public DateTimeOffset? CreatedTime { get; set; }
        /// <summary>Whether to credit the user for the chargeback amount.</summary>
        public bool? CreditUser { get; set; }
        /// <summary>Date and time when the chargeback was last modified.Not returned for transactions when the associated chargeback is in the `INITIATED` state.</summary>
        public DateTimeOffset? LastModifiedTime { get; set; }
        /// <summary>Additional comments about the chargeback.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Memo { get; set; }
#nullable restore
#else
        public string Memo { get; set; }
#endif
        /// <summary>Network handling the chargeback.</summary>
        public Chargeback_response_network? Network { get; set; }
        /// <summary>Network-assigned identifier of the chargeback.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NetworkCaseId { get; set; }
#nullable restore
#else
        public string NetworkCaseId { get; set; }
#endif
        /// <summary>Identifies the standardized reason for the chargeback.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReasonCode { get; set; }
#nullable restore
#else
        public string ReasonCode { get; set; }
#endif
        /// <summary>State of the case.</summary>
        public Chargeback_response_state? State { get; set; }
        /// <summary>Unique identifier of the chargeback.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>Unique identifier of the transaction being charged back.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TransactionToken { get; set; }
#nullable restore
#else
        public string TransactionToken { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Chargeback_response"/> and sets the default values.
        /// </summary>
        public Chargeback_response()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Chargeback_response"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Chargeback_response CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Chargeback_response();
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
                {"channel", n => { Channel = n.GetEnumValue<Chargeback_response_channel>(); } },
                {"created_time", n => { CreatedTime = n.GetDateTimeOffsetValue(); } },
                {"credit_user", n => { CreditUser = n.GetBoolValue(); } },
                {"last_modified_time", n => { LastModifiedTime = n.GetDateTimeOffsetValue(); } },
                {"memo", n => { Memo = n.GetStringValue(); } },
                {"network", n => { Network = n.GetEnumValue<Chargeback_response_network>(); } },
                {"network_case_id", n => { NetworkCaseId = n.GetStringValue(); } },
                {"reason_code", n => { ReasonCode = n.GetStringValue(); } },
                {"state", n => { State = n.GetEnumValue<Chargeback_response_state>(); } },
                {"token", n => { Token = n.GetStringValue(); } },
                {"transaction_token", n => { TransactionToken = n.GetStringValue(); } },
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
            writer.WriteEnumValue<Chargeback_response_channel>("channel", Channel);
            writer.WriteDateTimeOffsetValue("created_time", CreatedTime);
            writer.WriteBoolValue("credit_user", CreditUser);
            writer.WriteDateTimeOffsetValue("last_modified_time", LastModifiedTime);
            writer.WriteStringValue("memo", Memo);
            writer.WriteEnumValue<Chargeback_response_network>("network", Network);
            writer.WriteStringValue("network_case_id", NetworkCaseId);
            writer.WriteStringValue("reason_code", ReasonCode);
            writer.WriteEnumValue<Chargeback_response_state>("state", State);
            writer.WriteStringValue("token", Token);
            writer.WriteStringValue("transaction_token", TransactionToken);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
