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
    /// Contains information about a payment source.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class PaymentSourceResponse : IAdditionalDataHolder, IParsable
    {
        /// <summary>Last four digits of the payment source account number.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountSuffix { get; set; }
#nullable restore
#else
        public string AccountSuffix { get; set; }
#endif
        /// <summary>Unique identifier of the credit account receiving the payment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountToken { get; set; }
#nullable restore
#else
        public string AccountToken { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Name of the bank associated with the routing number</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BankName { get; set; }
#nullable restore
#else
        public string BankName { get; set; }
#endif
        /// <summary>Unique identifier of the business making the payment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BusinessToken { get; set; }
#nullable restore
#else
        public string BusinessToken { get; set; }
#endif
        /// <summary>Date and time when the payment source was created on Marqeta&apos;s credit platform, in UTC.</summary>
        public DateTimeOffset? CreatedTime { get; set; }
        /// <summary>Date and time when the payment source was last updated on Marqeta&apos;s credit platform, in UTC.</summary>
        public DateTimeOffset? LastModifiedTime { get; set; }
        /// <summary>Name of the individual or business who owns the payment source.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Type of payment source owner.</summary>
        public global::Marqeta.Core.Sdk.Models.PaymentSourceResponse_owner? Owner { get; set; }
        /// <summary>Routing number of the payment source.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RoutingNumber { get; set; }
#nullable restore
#else
        public string RoutingNumber { get; set; }
#endif
        /// <summary>Type of payment source.</summary>
        public global::Marqeta.Core.Sdk.Models.PaymentSourceResponse_source_type? SourceType { get; set; }
        /// <summary>Current status of the payment source.</summary>
        public global::Marqeta.Core.Sdk.Models.PaymentSourceStatusEnum? Status { get; set; }
        /// <summary>Unique identifier of the payment source.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>Unique identifier of the user making the payment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserToken { get; set; }
#nullable restore
#else
        public string UserToken { get; set; }
#endif
        /// <summary>Additional information on the verification (for example, an external verification identifier that&apos;s outside Marqeta&apos;s credit platform).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VerificationNotes { get; set; }
#nullable restore
#else
        public string VerificationNotes { get; set; }
#endif
        /// <summary>Status of the verification for the payment source.</summary>
        public global::Marqeta.Core.Sdk.Models.PaymentSourceResponse_verification_status? VerificationStatus { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.PaymentSourceResponse"/> and sets the default values.
        /// </summary>
        public PaymentSourceResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.PaymentSourceResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.PaymentSourceResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.PaymentSourceResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "account_suffix", n => { AccountSuffix = n.GetStringValue(); } },
                { "account_token", n => { AccountToken = n.GetStringValue(); } },
                { "bank_name", n => { BankName = n.GetStringValue(); } },
                { "business_token", n => { BusinessToken = n.GetStringValue(); } },
                { "created_time", n => { CreatedTime = n.GetDateTimeOffsetValue(); } },
                { "last_modified_time", n => { LastModifiedTime = n.GetDateTimeOffsetValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "owner", n => { Owner = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.PaymentSourceResponse_owner>(); } },
                { "routing_number", n => { RoutingNumber = n.GetStringValue(); } },
                { "source_type", n => { SourceType = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.PaymentSourceResponse_source_type>(); } },
                { "status", n => { Status = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.PaymentSourceStatusEnum>(); } },
                { "token", n => { Token = n.GetStringValue(); } },
                { "user_token", n => { UserToken = n.GetStringValue(); } },
                { "verification_notes", n => { VerificationNotes = n.GetStringValue(); } },
                { "verification_status", n => { VerificationStatus = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.PaymentSourceResponse_verification_status>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("account_suffix", AccountSuffix);
            writer.WriteStringValue("account_token", AccountToken);
            writer.WriteStringValue("bank_name", BankName);
            writer.WriteStringValue("business_token", BusinessToken);
            writer.WriteDateTimeOffsetValue("created_time", CreatedTime);
            writer.WriteDateTimeOffsetValue("last_modified_time", LastModifiedTime);
            writer.WriteStringValue("name", Name);
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.PaymentSourceResponse_owner>("owner", Owner);
            writer.WriteStringValue("routing_number", RoutingNumber);
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.PaymentSourceResponse_source_type>("source_type", SourceType);
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.PaymentSourceStatusEnum>("status", Status);
            writer.WriteStringValue("token", Token);
            writer.WriteStringValue("user_token", UserToken);
            writer.WriteStringValue("verification_notes", VerificationNotes);
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.PaymentSourceResponse_verification_status>("verification_status", VerificationStatus);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
