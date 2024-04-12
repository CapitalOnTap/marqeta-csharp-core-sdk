// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    /// <summary>
    /// Contains information about a program transfer, which moves funds from an account holder&apos;s GPA to a program funding source.
    /// </summary>
    public class Program_transfer_response : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Amount of program transfer.</summary>
        public double? Amount { get; set; }
        /// <summary>Unique identifier of the business account holder.Returned if `user_token` is not specified.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BusinessToken { get; set; }
#nullable restore
#else
        public string BusinessToken { get; set; }
#endif
        /// <summary>Date and time when the program transfer object was created, in UTC.</summary>
        public DateTimeOffset? CreatedTime { get; set; }
        /// <summary>Three-digit ISO 4217 currency code.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CurrencyCode { get; set; }
#nullable restore
#else
        public string CurrencyCode { get; set; }
#endif
        /// <summary>Contains attributes that define characteristics of one or more fees.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Fee_detail>? Fees { get; set; }
#nullable restore
#else
        public List<Fee_detail> Fees { get; set; }
#endif
        /// <summary>Contains information about the JIT Funding load event, in which funds are loaded into an account.This object is returned if your program uses JIT Funding.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Jit_funding_api? JitFunding { get; set; }
#nullable restore
#else
        public Jit_funding_api JitFunding { get; set; }
#endif
        /// <summary>Additional description of the program transfer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Memo { get; set; }
#nullable restore
#else
        public string Memo { get; set; }
#endif
        /// <summary>Comma-delimited list of tags describing the program transfer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Tags { get; set; }
#nullable restore
#else
        public string Tags { get; set; }
#endif
        /// <summary>Unique identifier of the program transfer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>Unique identifier of the transaction.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TransactionToken { get; set; }
#nullable restore
#else
        public string TransactionToken { get; set; }
#endif
        /// <summary>Unique identifier of the program transfer type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TypeToken { get; set; }
#nullable restore
#else
        public string TypeToken { get; set; }
#endif
        /// <summary>Unique identifier of the user account holder.Returned if `business_token` is not specified.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserToken { get; set; }
#nullable restore
#else
        public string UserToken { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Program_transfer_response"/> and sets the default values.
        /// </summary>
        public Program_transfer_response() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Program_transfer_response"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Program_transfer_response CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Program_transfer_response();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"amount", n => { Amount = n.GetDoubleValue(); } },
                {"business_token", n => { BusinessToken = n.GetStringValue(); } },
                {"created_time", n => { CreatedTime = n.GetDateTimeOffsetValue(); } },
                {"currency_code", n => { CurrencyCode = n.GetStringValue(); } },
                {"fees", n => { Fees = n.GetCollectionOfObjectValues<Fee_detail>(Fee_detail.CreateFromDiscriminatorValue)?.ToList(); } },
                {"jit_funding", n => { JitFunding = n.GetObjectValue<Jit_funding_api>(Jit_funding_api.CreateFromDiscriminatorValue); } },
                {"memo", n => { Memo = n.GetStringValue(); } },
                {"tags", n => { Tags = n.GetStringValue(); } },
                {"token", n => { Token = n.GetStringValue(); } },
                {"transaction_token", n => { TransactionToken = n.GetStringValue(); } },
                {"type_token", n => { TypeToken = n.GetStringValue(); } },
                {"user_token", n => { UserToken = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("amount", Amount);
            writer.WriteStringValue("business_token", BusinessToken);
            writer.WriteDateTimeOffsetValue("created_time", CreatedTime);
            writer.WriteStringValue("currency_code", CurrencyCode);
            writer.WriteCollectionOfObjectValues<Fee_detail>("fees", Fees);
            writer.WriteObjectValue<Jit_funding_api>("jit_funding", JitFunding);
            writer.WriteStringValue("memo", Memo);
            writer.WriteStringValue("tags", Tags);
            writer.WriteStringValue("token", Token);
            writer.WriteStringValue("transaction_token", TransactionToken);
            writer.WriteStringValue("type_token", TypeToken);
            writer.WriteStringValue("user_token", UserToken);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
