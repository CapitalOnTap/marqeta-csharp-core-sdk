// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    public class Gateway_program_funding_source_response : IAdditionalDataHolder, IParsable {
        /// <summary>Bank account number.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Account { get; set; }
#nullable restore
#else
        public string Account { get; set; }
#endif
        /// <summary>Indicates whether the program gateway funding source is active.This field is returned if it exists in the resource.</summary>
        public bool? Active { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Password for authenticating your environment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BasicAuthPassword { get; set; }
#nullable restore
#else
        public string BasicAuthPassword { get; set; }
#endif
        /// <summary>Username for authenticating your environment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BasicAuthUsername { get; set; }
#nullable restore
#else
        public string BasicAuthUsername { get; set; }
#endif
        /// <summary>Date and time when the resource was created, in UTC.</summary>
        public DateTimeOffset? CreatedTime { get; set; }
        /// <summary>Additional custom information included in the HTTP header.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Gateway_program_funding_source_response_custom_header? CustomHeader { get; set; }
#nullable restore
#else
        public Gateway_program_funding_source_response_custom_header CustomHeader { get; set; }
#endif
        /// <summary>Date and time when the resource was last modified, in UTC.</summary>
        public DateTimeOffset? LastModifiedTime { get; set; }
        /// <summary>Name of the program gateway funding source.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Total timeout in milliseconds for gateway processing.</summary>
        public long? TimeoutMillis { get; set; }
        /// <summary>Unique identifier of the program gateway funding source.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>URL of the gateway endpoint hosted in your environment, to which `POST` requests are submitted by the Marqeta platform.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; set; }
#nullable restore
#else
        public string Url { get; set; }
#endif
        /// <summary>Specifies whether or not to use mutual transport layer security (mTLS) authentication for the funding request.</summary>
        public bool? UseMtls { get; set; }
        /// <summary>Program gateway funding source object version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Version { get; set; }
#nullable restore
#else
        public string Version { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Gateway_program_funding_source_response"/> and sets the default values.
        /// </summary>
        public Gateway_program_funding_source_response() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Gateway_program_funding_source_response"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Gateway_program_funding_source_response CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Gateway_program_funding_source_response();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"account", n => { Account = n.GetStringValue(); } },
                {"active", n => { Active = n.GetBoolValue(); } },
                {"basic_auth_password", n => { BasicAuthPassword = n.GetStringValue(); } },
                {"basic_auth_username", n => { BasicAuthUsername = n.GetStringValue(); } },
                {"created_time", n => { CreatedTime = n.GetDateTimeOffsetValue(); } },
                {"custom_header", n => { CustomHeader = n.GetObjectValue<Gateway_program_funding_source_response_custom_header>(Gateway_program_funding_source_response_custom_header.CreateFromDiscriminatorValue); } },
                {"last_modified_time", n => { LastModifiedTime = n.GetDateTimeOffsetValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"timeout_millis", n => { TimeoutMillis = n.GetLongValue(); } },
                {"token", n => { Token = n.GetStringValue(); } },
                {"url", n => { Url = n.GetStringValue(); } },
                {"use_mtls", n => { UseMtls = n.GetBoolValue(); } },
                {"version", n => { Version = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("account", Account);
            writer.WriteBoolValue("active", Active);
            writer.WriteStringValue("basic_auth_password", BasicAuthPassword);
            writer.WriteStringValue("basic_auth_username", BasicAuthUsername);
            writer.WriteDateTimeOffsetValue("created_time", CreatedTime);
            writer.WriteObjectValue<Gateway_program_funding_source_response_custom_header>("custom_header", CustomHeader);
            writer.WriteDateTimeOffsetValue("last_modified_time", LastModifiedTime);
            writer.WriteStringValue("name", Name);
            writer.WriteLongValue("timeout_millis", TimeoutMillis);
            writer.WriteStringValue("token", Token);
            writer.WriteStringValue("url", Url);
            writer.WriteBoolValue("use_mtls", UseMtls);
            writer.WriteStringValue("version", Version);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
