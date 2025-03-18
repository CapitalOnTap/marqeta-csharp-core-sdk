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
    public partial class Auth_control_request : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The active property</summary>
        public bool? Active { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Defines the group of users to which the velocity control applies.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.Models.Spend_control_association? Association { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.Spend_control_association Association { get; set; }
#endif
        /// <summary>The end_time property</summary>
        public DateTimeOffset? EndTime { get; set; }
        /// <summary>The merchant_scope property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.Models.Auth_control_merchant_scope? MerchantScope { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.Auth_control_merchant_scope MerchantScope { get; set; }
#endif
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The start_time property</summary>
        public DateTimeOffset? StartTime { get; set; }
        /// <summary>The token property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.Auth_control_request"/> and sets the default values.
        /// </summary>
        public Auth_control_request()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.Auth_control_request"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.Auth_control_request CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.Auth_control_request();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "active", n => { Active = n.GetBoolValue(); } },
                { "association", n => { Association = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.Spend_control_association>(global::Marqeta.Core.Sdk.Models.Spend_control_association.CreateFromDiscriminatorValue); } },
                { "end_time", n => { EndTime = n.GetDateTimeOffsetValue(); } },
                { "merchant_scope", n => { MerchantScope = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.Auth_control_merchant_scope>(global::Marqeta.Core.Sdk.Models.Auth_control_merchant_scope.CreateFromDiscriminatorValue); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "start_time", n => { StartTime = n.GetDateTimeOffsetValue(); } },
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
            writer.WriteBoolValue("active", Active);
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.Spend_control_association>("association", Association);
            writer.WriteDateTimeOffsetValue("end_time", EndTime);
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.Auth_control_merchant_scope>("merchant_scope", MerchantScope);
            writer.WriteStringValue("name", Name);
            writer.WriteDateTimeOffsetValue("start_time", StartTime);
            writer.WriteStringValue("token", Token);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
