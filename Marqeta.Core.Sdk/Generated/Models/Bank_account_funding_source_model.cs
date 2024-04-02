// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    public class Bank_account_funding_source_model : Funding_source_model, IParsable {
        /// <summary>The account_suffix property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountSuffix { get; set; }
#nullable restore
#else
        public string AccountSuffix { get; set; }
#endif
        /// <summary>The account_type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountType { get; set; }
#nullable restore
#else
        public string AccountType { get; set; }
#endif
        /// <summary>Required if &apos;user_token&apos; is null</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BusinessToken { get; set; }
#nullable restore
#else
        public string BusinessToken { get; set; }
#endif
        /// <summary>The name_on_account property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NameOnAccount { get; set; }
#nullable restore
#else
        public string NameOnAccount { get; set; }
#endif
        /// <summary>The routing_number property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RoutingNumber { get; set; }
#nullable restore
#else
        public string RoutingNumber { get; set; }
#endif
        /// <summary>Required if &apos;business_token&apos; is null</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserToken { get; set; }
#nullable restore
#else
        public string UserToken { get; set; }
#endif
        /// <summary>The verification_status property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VerificationStatus { get; set; }
#nullable restore
#else
        public string VerificationStatus { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Bank_account_funding_source_model"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Bank_account_funding_source_model CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Bank_account_funding_source_model();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"account_suffix", n => { AccountSuffix = n.GetStringValue(); } },
                {"account_type", n => { AccountType = n.GetStringValue(); } },
                {"business_token", n => { BusinessToken = n.GetStringValue(); } },
                {"name_on_account", n => { NameOnAccount = n.GetStringValue(); } },
                {"routing_number", n => { RoutingNumber = n.GetStringValue(); } },
                {"user_token", n => { UserToken = n.GetStringValue(); } },
                {"verification_status", n => { VerificationStatus = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("account_suffix", AccountSuffix);
            writer.WriteStringValue("account_type", AccountType);
            writer.WriteStringValue("business_token", BusinessToken);
            writer.WriteStringValue("name_on_account", NameOnAccount);
            writer.WriteStringValue("routing_number", RoutingNumber);
            writer.WriteStringValue("user_token", UserToken);
            writer.WriteStringValue("verification_status", VerificationStatus);
        }
    }
}