// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    #pragma warning disable CS1591
    public class BillPayResponse : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The amount property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Amount { get; set; }
#nullable restore
#else
        public string Amount { get; set; }
#endif
        /// <summary>The biller_token property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BillerToken { get; set; }
#nullable restore
#else
        public string BillerToken { get; set; }
#endif
        /// <summary>The created_time property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedTime { get; set; }
#nullable restore
#else
        public string CreatedTime { get; set; }
#endif
        /// <summary>The delivery_date property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeliveryDate { get; set; }
#nullable restore
#else
        public string DeliveryDate { get; set; }
#endif
        /// <summary>The last_modified_time property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastModifiedTime { get; set; }
#nullable restore
#else
        public string LastModifiedTime { get; set; }
#endif
        /// <summary>The payment_token property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PaymentToken { get; set; }
#nullable restore
#else
        public string PaymentToken { get; set; }
#endif
        /// <summary>The payment_type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PaymentType { get; set; }
#nullable restore
#else
        public string PaymentType { get; set; }
#endif
        /// <summary>The processing_date property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProcessingDate { get; set; }
#nullable restore
#else
        public string ProcessingDate { get; set; }
#endif
        /// <summary>The status property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Status { get; set; }
#nullable restore
#else
        public string Status { get; set; }
#endif
        /// <summary>The user_token property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserToken { get; set; }
#nullable restore
#else
        public string UserToken { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="BillPayResponse"/> and sets the default values.
        /// </summary>
        public BillPayResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="BillPayResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static BillPayResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BillPayResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"amount", n => { Amount = n.GetStringValue(); } },
                {"biller_token", n => { BillerToken = n.GetStringValue(); } },
                {"created_time", n => { CreatedTime = n.GetStringValue(); } },
                {"delivery_date", n => { DeliveryDate = n.GetStringValue(); } },
                {"last_modified_time", n => { LastModifiedTime = n.GetStringValue(); } },
                {"payment_token", n => { PaymentToken = n.GetStringValue(); } },
                {"payment_type", n => { PaymentType = n.GetStringValue(); } },
                {"processing_date", n => { ProcessingDate = n.GetStringValue(); } },
                {"status", n => { Status = n.GetStringValue(); } },
                {"user_token", n => { UserToken = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("amount", Amount);
            writer.WriteStringValue("biller_token", BillerToken);
            writer.WriteStringValue("created_time", CreatedTime);
            writer.WriteStringValue("delivery_date", DeliveryDate);
            writer.WriteStringValue("last_modified_time", LastModifiedTime);
            writer.WriteStringValue("payment_token", PaymentToken);
            writer.WriteStringValue("payment_type", PaymentType);
            writer.WriteStringValue("processing_date", ProcessingDate);
            writer.WriteStringValue("status", Status);
            writer.WriteStringValue("user_token", UserToken);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
