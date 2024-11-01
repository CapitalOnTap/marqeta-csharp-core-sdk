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
    /// Contains authentication data for 3D Secure and digital wallet token transactions:* `electronic_commerce_indicator` – The level of verification performed.* `verification_result` – The result of the verification.* `verification_value_created_by` – The transaction participant who determined the verification result.* `three_ds_message_version` – The 3D Secure message version used for authentication.* `authentication_method` – The 3D Secure authentication method.* `authentication_status` – The 3D Secure authentication status.* `acquirer_exemption` – Indicates a 3D Secure authentication exemption from the acquirer.* `issuer_exemption` – Indicates a 3D Secure authentication exemption from the issuer.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Cardholder_authentication_data : IAdditionalDataHolder, IParsable
    {
        /// <summary>Indicates 3D Secure authentication exemptions from the acquirer.This array is returned if it is included in the transaction data from the card network.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AcquirerExemption { get; set; }
#nullable restore
#else
        public List<string> AcquirerExemption { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Specifies the 3D Secure authentication method.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AuthenticationMethod { get; set; }
#nullable restore
#else
        public string AuthenticationMethod { get; set; }
#endif
        /// <summary>Specifies the status of the 3D Secure authentication:* `ATTEMPTED`: Indicates that 3D Secure authentication was requested and processed by the card network.* `DATA_SHARE_EXEMPTION`: Indicates that 3D Secure authentication was for information only and exempted.* `EXEMPTED`: Indicates that 3D Secure authentication was requested but the challenge was exempted.* `EXEMPTION_CLAIMED`: Indicates that 3D Secure authentication was exempted because acquirer transaction risk analysis (TRA) was already performed.* `SCA_EXEMPTION`: Indicates that 3D Secure authentication was exempted because strong customer authentication (SCA) was already performed.* `SUCCESSFUL`: Indicates that 3D Secure authentication was successful.* `SUCCESSFUL_NON_PAYMENT`: Indicates that 3D Secure non-payment authentication was successful.* `THREEDS_REQUESTER_DATA_SHARE_EXEMPTION`: Status is deprecated and will be removed from a future release of the Marqeta platform.After June 2023, use `DATA_SHARE_EXEMPTION` instead.* `THREEDS_REQUESTER_SCA_EXEMPTION`: Status is deprecated and will be removed in a June 2023 release of the Marqeta platform.After June 2023, use `SCA_EXEMPTION` instead.* `THREEDS_REQUESTER_TRA_EXEMPTION`: Status is deprecated and will be removed in a June 2023 release of the Marqeta platform.After June 2023, use `EXEMPTION_CLAIMED` instead.* `UNAVAILABLE`:** For Visa transactions, this status indicates that 3D Secure authentication was requested, but Marqeta&apos;s access control server (ACS) was not available.** For Mastercard transactions, this status indicates that 3D Secure authentication was not available.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AuthenticationStatus { get; set; }
#nullable restore
#else
        public string AuthenticationStatus { get; set; }
#endif
        /// <summary>Authentication amount from the cardholder authentication verification value (CAVV) used to validate an authorization.This field is returned if it is included in the transaction data from the card network.To enable this field, contact your Marqeta representative.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CavvAuthenticationAmount { get; set; }
#nullable restore
#else
        public string CavvAuthenticationAmount { get; set; }
#endif
        /// <summary>Status of the 3D Secure or digital wallet token transaction authentication attempt, as provided by a transaction participant.* `authentication_attempted`: Merchant attempted to authenticate, but either the issuer or the cardholder does not participate in 3D Secure or card tokenization.* `authentication_successful`: Cardholder authentication successful.* `no_authentication`: Non-authenticated e-commerce transaction.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ElectronicCommerceIndicator { get; set; }
#nullable restore
#else
        public string ElectronicCommerceIndicator { get; set; }
#endif
        /// <summary>Indicates a 3D Secure authentication exemption from the issuer.This field is returned if it is included in the transaction data from the card network.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IssuerExemption { get; set; }
#nullable restore
#else
        public string IssuerExemption { get; set; }
#endif
        /// <summary>Raw cardholder authentication verification value provided by the card network.This field is returned if it is included in the transaction data from the card network.To enable this field, contact your Marqeta representative.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RawCavvData { get; set; }
#nullable restore
#else
        public string RawCavvData { get; set; }
#endif
        /// <summary>Specifies the 3D Secure message version used for authentication.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ThreeDsMessageVersion { get; set; }
#nullable restore
#else
        public string ThreeDsMessageVersion { get; set; }
#endif
        /// <summary>Result of cardholder authentication verification value (CAVV) or accountholder authentication value (AAV) verification performed by the card network.* `failed`* `not_present`* `not_provided`* `not_verified`* `not_verified_authentication_outage`* `verified`* `verified_amount_checked`* `verified_amount_greater_than_20_percent`: For Mastercard AAV verification, indicates that the original authentication amount and final authorization amount are mismatched, and that the final authorization amount exceeds the original authentication amount by more than 20%.This 20% margin falls outside Mastercard&apos;s suggested tolerance for what a European cardholder might reasonably expect when the total transaction amount is not known in advance.* `verified_amount_less_than_20_percent`: For Mastercard AAV verification, indicates that the original authentication amount and final authorization amount are mismatched, and that the final authorization amount exceeds the original authentication amount by 20% or less.This 20% margin falls within Mastercard&apos;s suggested tolerance for what a European cardholder might reasonably expect when the total transaction amount is not known in advance.* `not_verified_mac_key_validation_passed`: For Mastercard only.This field is present when the transaction passes MAC key validation but Dynamic Linking was not performed by the Mastercard card network due to system connectivity issues.* `not_verified_mac_key_validation_failed`: For Mastercard only.This field is present when the transaction fails MAC key validation and Dynamic Linking was not performed by the Mastercard card network due to system connectivity issues.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VerificationResult { get; set; }
#nullable restore
#else
        public string VerificationResult { get; set; }
#endif
        /// <summary>Transaction participant who determined the verification result.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VerificationValueCreatedBy { get; set; }
#nullable restore
#else
        public string VerificationValueCreatedBy { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.Cardholder_authentication_data"/> and sets the default values.
        /// </summary>
        public Cardholder_authentication_data()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.Cardholder_authentication_data"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.Cardholder_authentication_data CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.Cardholder_authentication_data();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "acquirer_exemption", n => { AcquirerExemption = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "authentication_method", n => { AuthenticationMethod = n.GetStringValue(); } },
                { "authentication_status", n => { AuthenticationStatus = n.GetStringValue(); } },
                { "cavv_authentication_amount", n => { CavvAuthenticationAmount = n.GetStringValue(); } },
                { "electronic_commerce_indicator", n => { ElectronicCommerceIndicator = n.GetStringValue(); } },
                { "issuer_exemption", n => { IssuerExemption = n.GetStringValue(); } },
                { "raw_cavv_data", n => { RawCavvData = n.GetStringValue(); } },
                { "three_ds_message_version", n => { ThreeDsMessageVersion = n.GetStringValue(); } },
                { "verification_result", n => { VerificationResult = n.GetStringValue(); } },
                { "verification_value_created_by", n => { VerificationValueCreatedBy = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("acquirer_exemption", AcquirerExemption);
            writer.WriteStringValue("authentication_method", AuthenticationMethod);
            writer.WriteStringValue("authentication_status", AuthenticationStatus);
            writer.WriteStringValue("cavv_authentication_amount", CavvAuthenticationAmount);
            writer.WriteStringValue("electronic_commerce_indicator", ElectronicCommerceIndicator);
            writer.WriteStringValue("issuer_exemption", IssuerExemption);
            writer.WriteStringValue("raw_cavv_data", RawCavvData);
            writer.WriteStringValue("three_ds_message_version", ThreeDsMessageVersion);
            writer.WriteStringValue("verification_result", VerificationResult);
            writer.WriteStringValue("verification_value_created_by", VerificationValueCreatedBy);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
