// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    /// <summary>
    /// Account document response.
    /// </summary>
    public class AccountDocumentResponse : IAdditionalDataHolder, IParsable {
        /// <summary>Date and time when the user accepted the document on Marqeta&apos;s credit platform, in UTC.</summary>
        public DateTimeOffset? AcceptedAt { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Unique identifier of the document on a credit account.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssetToken { get; set; }
#nullable restore
#else
        public string AssetToken { get; set; }
#endif
        /// <summary>Contains one or more URLs for an asset.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PolicyDocumentAssetURLs? AssetUrls { get; set; }
#nullable restore
#else
        public PolicyDocumentAssetURLs AssetUrls { get; set; }
#endif
        /// <summary>Date and time when the document goes into effect on Marqeta&apos;s credit platform, in UTC.</summary>
        public DateTimeOffset? EffectiveFrom { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="AccountDocumentResponse"/> and sets the default values.
        /// </summary>
        public AccountDocumentResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AccountDocumentResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AccountDocumentResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccountDocumentResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"accepted_at", n => { AcceptedAt = n.GetDateTimeOffsetValue(); } },
                {"asset_token", n => { AssetToken = n.GetStringValue(); } },
                {"asset_urls", n => { AssetUrls = n.GetObjectValue<PolicyDocumentAssetURLs>(PolicyDocumentAssetURLs.CreateFromDiscriminatorValue); } },
                {"effective_from", n => { EffectiveFrom = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("accepted_at", AcceptedAt);
            writer.WriteStringValue("asset_token", AssetToken);
            writer.WriteObjectValue<PolicyDocumentAssetURLs>("asset_urls", AssetUrls);
            writer.WriteDateTimeOffsetValue("effective_from", EffectiveFrom);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
