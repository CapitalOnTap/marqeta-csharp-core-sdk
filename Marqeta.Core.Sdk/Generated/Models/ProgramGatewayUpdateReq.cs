// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models
{
    /// <summary>
    /// Contains information relevant to updating a Program Gateway.
    /// </summary>
    public class ProgramGatewayUpdateReq : IAdditionalDataHolder, IParsable
    {
        /// <summary>Indicates whether the Program Gateway is active.</summary>
        public bool? Active { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Basic Authentication password for authenticating your environment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BasicAuthPassword { get; set; }
#nullable restore
#else
        public string BasicAuthPassword { get; set; }
#endif
        /// <summary>Basic Authentication username for authenticating your environment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BasicAuthUsername { get; set; }
#nullable restore
#else
        public string BasicAuthUsername { get; set; }
#endif
        /// <summary>Additional custom information included in the HTTP header.For example, this might contain security information, along with Basic Authentication, when making a Program Gateway request.Custom headers also appear in the associated webhook&apos;s notifications.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Marqeta.Core.Sdk.Models.ProgramGatewayCustomHeaderCreateReq? CustomHeader { get; set; }
#nullable restore
#else
        public Marqeta.Core.Sdk.Models.ProgramGatewayCustomHeaderCreateReq CustomHeader { get; set; }
#endif
        /// <summary>Indicates whether the Program Gateway uses mutual Transport Layer Security (mTLS).</summary>
        public bool? Mtls { get; set; }
        /// <summary>Name of the Program Gateway.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Total timeout for Program Gateway calls, in milliseconds.</summary>
        public int? TimeoutMillis { get; set; }
        /// <summary>Unique identifier of the Program Gateway.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>URL of the Program Gateway endpoint hosted in your environment and configured to receive authorization requests made by the Marqeta platform.Must be HTTPS.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; set; }
#nullable restore
#else
        public string Url { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Models.ProgramGatewayUpdateReq"/> and sets the default values.
        /// </summary>
        public ProgramGatewayUpdateReq()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Models.ProgramGatewayUpdateReq"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Marqeta.Core.Sdk.Models.ProgramGatewayUpdateReq CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Marqeta.Core.Sdk.Models.ProgramGatewayUpdateReq();
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
                { "basic_auth_password", n => { BasicAuthPassword = n.GetStringValue(); } },
                { "basic_auth_username", n => { BasicAuthUsername = n.GetStringValue(); } },
                { "custom_header", n => { CustomHeader = n.GetObjectValue<Marqeta.Core.Sdk.Models.ProgramGatewayCustomHeaderCreateReq>(Marqeta.Core.Sdk.Models.ProgramGatewayCustomHeaderCreateReq.CreateFromDiscriminatorValue); } },
                { "mtls", n => { Mtls = n.GetBoolValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "timeout_millis", n => { TimeoutMillis = n.GetIntValue(); } },
                { "token", n => { Token = n.GetStringValue(); } },
                { "url", n => { Url = n.GetStringValue(); } },
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
            writer.WriteStringValue("basic_auth_password", BasicAuthPassword);
            writer.WriteStringValue("basic_auth_username", BasicAuthUsername);
            writer.WriteObjectValue<Marqeta.Core.Sdk.Models.ProgramGatewayCustomHeaderCreateReq>("custom_header", CustomHeader);
            writer.WriteBoolValue("mtls", Mtls);
            writer.WriteStringValue("name", Name);
            writer.WriteIntValue("timeout_millis", TimeoutMillis);
            writer.WriteStringValue("token", Token);
            writer.WriteStringValue("url", Url);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
