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
    /// Contains information about the digital wallet that funded the transaction.Returned for all transactions funded by a digital wallet or related to digital wallet token provisioning.For more on digital wallets, see the &lt;&lt;/core-api/digital-wallets-management, Digital Wallets Management&gt;&gt; API reference and &lt;&lt;/developer-guides/digital-wallets-and-tokenization, Digital Wallets and Tokenization&gt;&gt; developer guide.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Digital_wallet_token : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Contains address verification information.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.Models.Address_verification? AddressVerification { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.Address_verification AddressVerification { get; set; }
#endif
        /// <summary>Unique identifier of the card.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CardToken { get; set; }
#nullable restore
#else
        public string CardToken { get; set; }
#endif
        /// <summary>Date and time when the digital wallet token object was created, in UTC.</summary>
        public DateTimeOffset? CreatedTime { get; set; }
        /// <summary>Contains information related to the device being provisioned.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.Models.Device? Device { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.Device Device { get; set; }
#endif
        /// <summary>Digital wallet token&apos;s provisioning status.For fulfillment status descriptions, see &lt;&lt;/core-api/digital-wallets-management#postDigitalwallettokentransitions, Create digital wallet token transition&gt;&gt;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FulfillmentStatus { get; set; }
#nullable restore
#else
        public string FulfillmentStatus { get; set; }
#endif
        /// <summary>The Marqeta platform&apos;s decision as to whether the digital wallet token should be provisioned.* *0000* – The token should be provisioned.* *token.activation.verification.required* – Provisioning is pending; further action is required for completion.For all other values, check the value of the `fulfillment_status` field to definitively ascertain the provisioning outcome.*NOTE:* The value `invalid.cid` indicates an invalid CVV2 number.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IssuerEligibilityDecision { get; set; }
#nullable restore
#else
        public string IssuerEligibilityDecision { get; set; }
#endif
        /// <summary>Date and time when the digital wallet token object was last modified, in UTC.</summary>
        public DateTimeOffset? LastModifiedTime { get; set; }
        /// <summary>Contains additional information about the digital wallet token.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.Models.Digital_wallet_token_metadata? Metadata { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.Digital_wallet_token_metadata Metadata { get; set; }
#endif
        /// <summary>State of the digital wallet token.For state descriptions, see &lt;&lt;/developer-guides/managing-the-digital-wallet-token-lifecycle#_transitioning_token_states, Transitioning Token States&gt;&gt;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? State { get; set; }
#nullable restore
#else
        public string State { get; set; }
#endif
        /// <summary>Reason why the digital wallet token transitioned to its current state.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StateReason { get; set; }
#nullable restore
#else
        public string StateReason { get; set; }
#endif
        /// <summary>Unique identifier of the digital wallet token.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>Contains information held and provided by the token service provider (card network).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.Models.Token_service_provider? TokenServiceProvider { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.Token_service_provider TokenServiceProvider { get; set; }
#endif
        /// <summary>Contains information about the device used in the transaction to enhance the risk decisioning process.Use this data to improve fraud prevention and dispute resolution.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.Models.Transaction_device? TransactionDevice { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.Transaction_device TransactionDevice { get; set; }
#endif
        /// <summary>Contains information about a cardholder.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.Models.User_card_holder_response? User { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.User_card_holder_response User { get; set; }
#endif
        /// <summary>Contains information held and provided by the digital wallet provider.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.Models.Wallet_provider_profile? WalletProviderProfile { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.Wallet_provider_profile WalletProviderProfile { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.Digital_wallet_token"/> and sets the default values.
        /// </summary>
        public Digital_wallet_token()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.Digital_wallet_token"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.Digital_wallet_token CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.Digital_wallet_token();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "address_verification", n => { AddressVerification = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.Address_verification>(global::Marqeta.Core.Sdk.Models.Address_verification.CreateFromDiscriminatorValue); } },
                { "card_token", n => { CardToken = n.GetStringValue(); } },
                { "created_time", n => { CreatedTime = n.GetDateTimeOffsetValue(); } },
                { "device", n => { Device = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.Device>(global::Marqeta.Core.Sdk.Models.Device.CreateFromDiscriminatorValue); } },
                { "fulfillment_status", n => { FulfillmentStatus = n.GetStringValue(); } },
                { "issuer_eligibility_decision", n => { IssuerEligibilityDecision = n.GetStringValue(); } },
                { "last_modified_time", n => { LastModifiedTime = n.GetDateTimeOffsetValue(); } },
                { "metadata", n => { Metadata = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.Digital_wallet_token_metadata>(global::Marqeta.Core.Sdk.Models.Digital_wallet_token_metadata.CreateFromDiscriminatorValue); } },
                { "state", n => { State = n.GetStringValue(); } },
                { "state_reason", n => { StateReason = n.GetStringValue(); } },
                { "token", n => { Token = n.GetStringValue(); } },
                { "token_service_provider", n => { TokenServiceProvider = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.Token_service_provider>(global::Marqeta.Core.Sdk.Models.Token_service_provider.CreateFromDiscriminatorValue); } },
                { "transaction_device", n => { TransactionDevice = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.Transaction_device>(global::Marqeta.Core.Sdk.Models.Transaction_device.CreateFromDiscriminatorValue); } },
                { "user", n => { User = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.User_card_holder_response>(global::Marqeta.Core.Sdk.Models.User_card_holder_response.CreateFromDiscriminatorValue); } },
                { "wallet_provider_profile", n => { WalletProviderProfile = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.Wallet_provider_profile>(global::Marqeta.Core.Sdk.Models.Wallet_provider_profile.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.Address_verification>("address_verification", AddressVerification);
            writer.WriteStringValue("card_token", CardToken);
            writer.WriteDateTimeOffsetValue("created_time", CreatedTime);
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.Device>("device", Device);
            writer.WriteStringValue("fulfillment_status", FulfillmentStatus);
            writer.WriteStringValue("issuer_eligibility_decision", IssuerEligibilityDecision);
            writer.WriteDateTimeOffsetValue("last_modified_time", LastModifiedTime);
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.Digital_wallet_token_metadata>("metadata", Metadata);
            writer.WriteStringValue("state", State);
            writer.WriteStringValue("state_reason", StateReason);
            writer.WriteStringValue("token", Token);
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.Token_service_provider>("token_service_provider", TokenServiceProvider);
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.Transaction_device>("transaction_device", TransactionDevice);
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.User_card_holder_response>("user", User);
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.Wallet_provider_profile>("wallet_provider_profile", WalletProviderProfile);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
