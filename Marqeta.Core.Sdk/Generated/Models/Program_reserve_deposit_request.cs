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
    public partial class Program_reserve_deposit_request : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Amount of the deposit.</summary>
        public double? Amount { get; set; }
        /// <summary>Three-digit ISO 4217 currency code.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CurrencyCode { get; set; }
#nullable restore
#else
        public string CurrencyCode { get; set; }
#endif
        /// <summary>Idempotent hash value associated with the deposit request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IdempotentHash { get; set; }
#nullable restore
#else
        public string IdempotentHash { get; set; }
#endif
        /// <summary>The is_collateral property</summary>
        public bool? IsCollateral { get; set; }
        /// <summary>Memo or note describing the deposit request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Memo { get; set; }
#nullable restore
#else
        public string Memo { get; set; }
#endif
        /// <summary>Comma-delimited list of tags describing the deposit request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Tags { get; set; }
#nullable restore
#else
        public string Tags { get; set; }
#endif
        /// <summary>Unique identifier of the deposit request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.Program_reserve_deposit_request"/> and sets the default values.
        /// </summary>
        public Program_reserve_deposit_request()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.Program_reserve_deposit_request"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.Program_reserve_deposit_request CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.Program_reserve_deposit_request();
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
                { "currency_code", n => { CurrencyCode = n.GetStringValue(); } },
                { "idempotentHash", n => { IdempotentHash = n.GetStringValue(); } },
                { "is_collateral", n => { IsCollateral = n.GetBoolValue(); } },
                { "memo", n => { Memo = n.GetStringValue(); } },
                { "tags", n => { Tags = n.GetStringValue(); } },
                { "token", n => { Token = n.GetStringValue(); } },
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
            writer.WriteStringValue("currency_code", CurrencyCode);
            writer.WriteStringValue("idempotentHash", IdempotentHash);
            writer.WriteBoolValue("is_collateral", IsCollateral);
            writer.WriteStringValue("memo", Memo);
            writer.WriteStringValue("tags", Tags);
            writer.WriteStringValue("token", Token);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
