// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    /// <summary>
    /// Return details for a specific asset and the template on which it was based.
    /// </summary>
    public class PolicyDocumentAssetAndTemplateResponse : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Date and time when the asset was created.</summary>
        public DateTimeOffset? AssetCreatedTime { get; set; }
        /// <summary>Unique identifier of the asset, which is the version of a document that is based on the template and contains finalized values.The values are finalized when the bundle containing the document is created.</summary>
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
        /// <summary>Date and time when the template was created.</summary>
        public DateTimeOffset? TemplateCreatedTime { get; set; }
        /// <summary>Unique identifier of the template, which is the version of a document that serves as an initial disclosure but does not contain finalized values.Values are finalized in the asset version of the document.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TemplateToken { get; set; }
#nullable restore
#else
        public string TemplateToken { get; set; }
#endif
        /// <summary>Contains one or more URLs for a template.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PolicyDocumentTemplateURLs? TemplateUrls { get; set; }
#nullable restore
#else
        public PolicyDocumentTemplateURLs TemplateUrls { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="PolicyDocumentAssetAndTemplateResponse"/> and sets the default values.
        /// </summary>
        public PolicyDocumentAssetAndTemplateResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PolicyDocumentAssetAndTemplateResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PolicyDocumentAssetAndTemplateResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PolicyDocumentAssetAndTemplateResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"asset_created_time", n => { AssetCreatedTime = n.GetDateTimeOffsetValue(); } },
                {"asset_token", n => { AssetToken = n.GetStringValue(); } },
                {"asset_urls", n => { AssetUrls = n.GetObjectValue<PolicyDocumentAssetURLs>(PolicyDocumentAssetURLs.CreateFromDiscriminatorValue); } },
                {"template_created_time", n => { TemplateCreatedTime = n.GetDateTimeOffsetValue(); } },
                {"template_token", n => { TemplateToken = n.GetStringValue(); } },
                {"template_urls", n => { TemplateUrls = n.GetObjectValue<PolicyDocumentTemplateURLs>(PolicyDocumentTemplateURLs.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("asset_created_time", AssetCreatedTime);
            writer.WriteStringValue("asset_token", AssetToken);
            writer.WriteObjectValue<PolicyDocumentAssetURLs>("asset_urls", AssetUrls);
            writer.WriteDateTimeOffsetValue("template_created_time", TemplateCreatedTime);
            writer.WriteStringValue("template_token", TemplateToken);
            writer.WriteObjectValue<PolicyDocumentTemplateURLs>("template_urls", TemplateUrls);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
