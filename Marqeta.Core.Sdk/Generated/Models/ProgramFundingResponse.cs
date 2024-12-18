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
    /// Returns details of a program funding entry.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ProgramFundingResponse : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Amount of the funding.</summary>
        public double? Amount { get; set; }
        /// <summary>Timestamp when the funding entry was created.</summary>
        public DateTimeOffset? CreatedTime { get; set; }
        /// <summary>Valid three-digit link:https://www.iso.org/iso-4217-currency-codes.html[ISO 4217 currency code, window=&quot;_blank&quot;].</summary>
        public global::Marqeta.Core.Sdk.Models.CurrencyCode? CurrencyCode { get; set; }
        /// <summary>Additional notes for the funding entry.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Memo { get; set; }
#nullable restore
#else
        public string Memo { get; set; }
#endif
        /// <summary>Timestamp when the funding entry was posted.</summary>
        public DateTimeOffset? PostTime { get; set; }
        /// <summary>Unique identifier of the program.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ShortCode { get; set; }
#nullable restore
#else
        public string ShortCode { get; set; }
#endif
        /// <summary>Unique identifier of the funding entry.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>Timestamp when the funding entry was last updated.</summary>
        public DateTimeOffset? UpdatedTime { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.ProgramFundingResponse"/> and sets the default values.
        /// </summary>
        public ProgramFundingResponse()
        {
            AdditionalData = new Dictionary<string, object>();
            CurrencyCode = global::Marqeta.Core.Sdk.Models.CurrencyCode.USD;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.ProgramFundingResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.ProgramFundingResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.ProgramFundingResponse();
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
                { "created_time", n => { CreatedTime = n.GetDateTimeOffsetValue(); } },
                { "currency_code", n => { CurrencyCode = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.CurrencyCode>(); } },
                { "memo", n => { Memo = n.GetStringValue(); } },
                { "post_time", n => { PostTime = n.GetDateTimeOffsetValue(); } },
                { "short_code", n => { ShortCode = n.GetStringValue(); } },
                { "token", n => { Token = n.GetStringValue(); } },
                { "updated_time", n => { UpdatedTime = n.GetDateTimeOffsetValue(); } },
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
            writer.WriteDateTimeOffsetValue("created_time", CreatedTime);
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.CurrencyCode>("currency_code", CurrencyCode);
            writer.WriteStringValue("memo", Memo);
            writer.WriteDateTimeOffsetValue("post_time", PostTime);
            writer.WriteStringValue("short_code", ShortCode);
            writer.WriteStringValue("token", Token);
            writer.WriteDateTimeOffsetValue("updated_time", UpdatedTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
