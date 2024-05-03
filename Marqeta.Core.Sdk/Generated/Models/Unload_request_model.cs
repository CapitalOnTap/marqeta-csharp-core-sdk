// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    #pragma warning disable CS1591
    public class Unload_request_model : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Amount of funds to return to the funding source.</summary>
        public double? Amount { get; set; }
        /// <summary>Unique identifier of the funding source to use for this GPA unload order.Send a `GET` request to `/fundingsources/addresses/user/{token}` to retrieve addresses for a specific user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FundingSourceAddressToken { get; set; }
#nullable restore
#else
        public string FundingSourceAddressToken { get; set; }
#endif
        /// <summary>Additional descriptive text about the GPA unload.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Memo { get; set; }
#nullable restore
#else
        public string Memo { get; set; }
#endif
        /// <summary>Unique identifier of the original GPA order.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OriginalOrderToken { get; set; }
#nullable restore
#else
        public string OriginalOrderToken { get; set; }
#endif
        /// <summary>Comma-delimited list of tags describing the GPA unload order.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Tags { get; set; }
#nullable restore
#else
        public string Tags { get; set; }
#endif
        /// <summary>Unique identifier of the GPA unload order.If you do not include a token, the system will generate one automatically.This token is necessary for use in other calls, so we recommend that rather than let the system generate one, you use a simple string that is easy to remember.This value cannot be updated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Unload_request_model"/> and sets the default values.
        /// </summary>
        public Unload_request_model()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Unload_request_model"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Unload_request_model CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Unload_request_model();
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
                {"funding_source_address_token", n => { FundingSourceAddressToken = n.GetStringValue(); } },
                {"memo", n => { Memo = n.GetStringValue(); } },
                {"original_order_token", n => { OriginalOrderToken = n.GetStringValue(); } },
                {"tags", n => { Tags = n.GetStringValue(); } },
                {"token", n => { Token = n.GetStringValue(); } },
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
            writer.WriteStringValue("funding_source_address_token", FundingSourceAddressToken);
            writer.WriteStringValue("memo", Memo);
            writer.WriteStringValue("original_order_token", OriginalOrderToken);
            writer.WriteStringValue("tags", Tags);
            writer.WriteStringValue("token", Token);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
