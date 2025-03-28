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
    public partial class Business_incorporation_response : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The address_registered_under property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.Models.AddressResponseModel? AddressRegisteredUnder { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.AddressResponseModel AddressRegisteredUnder { get; set; }
#endif
        /// <summary>The incorporation_type property</summary>
        public global::Marqeta.Core.Sdk.Models.Business_incorporation_response_incorporation_type? IncorporationType { get; set; }
        /// <summary>The is_public property</summary>
        public bool? IsPublic { get; set; }
        /// <summary>The name_registered_under property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NameRegisteredUnder { get; set; }
#nullable restore
#else
        public string NameRegisteredUnder { get; set; }
#endif
        /// <summary>The state_of_incorporation property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StateOfIncorporation { get; set; }
#nullable restore
#else
        public string StateOfIncorporation { get; set; }
#endif
        /// <summary>The stock_symbol property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StockSymbol { get; set; }
#nullable restore
#else
        public string StockSymbol { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.Business_incorporation_response"/> and sets the default values.
        /// </summary>
        public Business_incorporation_response()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.Business_incorporation_response"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.Business_incorporation_response CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.Business_incorporation_response();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "address_registered_under", n => { AddressRegisteredUnder = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.AddressResponseModel>(global::Marqeta.Core.Sdk.Models.AddressResponseModel.CreateFromDiscriminatorValue); } },
                { "incorporation_type", n => { IncorporationType = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.Business_incorporation_response_incorporation_type>(); } },
                { "is_public", n => { IsPublic = n.GetBoolValue(); } },
                { "name_registered_under", n => { NameRegisteredUnder = n.GetStringValue(); } },
                { "state_of_incorporation", n => { StateOfIncorporation = n.GetStringValue(); } },
                { "stock_symbol", n => { StockSymbol = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.AddressResponseModel>("address_registered_under", AddressRegisteredUnder);
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.Business_incorporation_response_incorporation_type>("incorporation_type", IncorporationType);
            writer.WriteBoolValue("is_public", IsPublic);
            writer.WriteStringValue("name_registered_under", NameRegisteredUnder);
            writer.WriteStringValue("state_of_incorporation", StateOfIncorporation);
            writer.WriteStringValue("stock_symbol", StockSymbol);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
