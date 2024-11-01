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
    /// Contains account name verification data used to make JIT Funding decisions.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Account_name_verification_source : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>First or given name of the cardholder.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FirstName { get; set; }
#nullable restore
#else
        public string FirstName { get; set; }
#endif
        /// <summary>Last or family name of the cardholder.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastName { get; set; }
#nullable restore
#else
        public string LastName { get; set; }
#endif
        /// <summary>Middle name of the cardholder.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MiddleName { get; set; }
#nullable restore
#else
        public string MiddleName { get; set; }
#endif
        /// <summary>Contains the name of the cardholder for account name verification.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.Models.Ani_information? OnFile { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.Ani_information OnFile { get; set; }
#endif
        /// <summary>Response codes and memos for account name verification, address verification, card security verification, and transactions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.Models.Response? Response { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.Response Response { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.Account_name_verification_source"/> and sets the default values.
        /// </summary>
        public Account_name_verification_source()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.Account_name_verification_source"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.Account_name_verification_source CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.Account_name_verification_source();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "first_name", n => { FirstName = n.GetStringValue(); } },
                { "last_name", n => { LastName = n.GetStringValue(); } },
                { "middle_name", n => { MiddleName = n.GetStringValue(); } },
                { "on_file", n => { OnFile = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.Ani_information>(global::Marqeta.Core.Sdk.Models.Ani_information.CreateFromDiscriminatorValue); } },
                { "response", n => { Response = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.Response>(global::Marqeta.Core.Sdk.Models.Response.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("first_name", FirstName);
            writer.WriteStringValue("last_name", LastName);
            writer.WriteStringValue("middle_name", MiddleName);
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.Ani_information>("on_file", OnFile);
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.Response>("response", Response);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
