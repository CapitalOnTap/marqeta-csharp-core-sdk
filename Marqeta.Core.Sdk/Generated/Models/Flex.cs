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
    /// Contains information about a Marqeta Flex transaction.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Flex : IAdditionalDataHolder, IParsable
    {
        /// <summary>Indicates if the Marqeta Flex object is an actionable `inquiry` or merely informative `advice`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Action { get; set; }
#nullable restore
#else
        public string Action { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Indicates if the transaction is eligible for Marqeta Flex or not.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Eligible { get; set; }
#nullable restore
#else
        public string Eligible { get; set; }
#endif
        /// <summary>A value of `DEBIT` indicates that the primary credential of the payment instrument is eligible for this transaction.A value of `LOAN` indicates that the secondary credential of the payment instrument is eligible for this transaction.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? EligibleProducts { get; set; }
#nullable restore
#else
        public List<string> EligibleProducts { get; set; }
#endif
        /// <summary>Identifies the secondary credential used in the transaction, if applicable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SecondaryCredentialIdentifier { get; set; }
#nullable restore
#else
        public string SecondaryCredentialIdentifier { get; set; }
#endif
        /// <summary>Indicates the eligible product that was used in the transaction.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SelectedProduct { get; set; }
#nullable restore
#else
        public string SelectedProduct { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.Flex"/> and sets the default values.
        /// </summary>
        public Flex()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.Flex"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.Flex CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.Flex();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "action", n => { Action = n.GetStringValue(); } },
                { "eligible", n => { Eligible = n.GetStringValue(); } },
                { "eligible_products", n => { EligibleProducts = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "secondary_credential_identifier", n => { SecondaryCredentialIdentifier = n.GetStringValue(); } },
                { "selected_product", n => { SelectedProduct = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("action", Action);
            writer.WriteStringValue("eligible", Eligible);
            writer.WriteCollectionOfPrimitiveValues<string>("eligible_products", EligibleProducts);
            writer.WriteStringValue("secondary_credential_identifier", SecondaryCredentialIdentifier);
            writer.WriteStringValue("selected_product", SelectedProduct);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
