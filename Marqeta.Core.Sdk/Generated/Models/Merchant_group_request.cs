// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    #pragma warning disable CS1591
    public class Merchant_group_request : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Indicates if the merchant group is active or not.</summary>
        public bool? Active { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Comma-separated list of alphanumeric merchant identifiers.You can include merchant identifiers in multiple merchant groups.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Mids { get; set; }
#nullable restore
#else
        public List<string> Mids { get; set; }
#endif
        /// <summary>Name of the merchant group.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Unique identifier of the group.If you do not include a token, the system will generate one automatically.This token is necessary for use in other API calls, so we recommend that rather than let the system generate one, you use a simple string that is easy to remember.This value cannot be updated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Merchant_group_request"/> and sets the default values.
        /// </summary>
        public Merchant_group_request()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Merchant_group_request"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Merchant_group_request CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Merchant_group_request();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"active", n => { Active = n.GetBoolValue(); } },
                {"mids", n => { Mids = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"name", n => { Name = n.GetStringValue(); } },
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
            writer.WriteBoolValue("active", Active);
            writer.WriteCollectionOfPrimitiveValues<string>("mids", Mids);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("token", Token);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
