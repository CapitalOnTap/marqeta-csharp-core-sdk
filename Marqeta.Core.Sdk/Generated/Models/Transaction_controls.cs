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
    public partial class Transaction_controls : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>50 char max (default = accept_us_only)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AcceptedCountriesToken { get; set; }
#nullable restore
#else
        public string AcceptedCountriesToken { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The address_verification property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.Models.Avs_controls? AddressVerification { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.Avs_controls AddressVerification { get; set; }
#endif
        /// <summary>The allow_chip_fallback property</summary>
        public bool? AllowChipFallback { get; set; }
        /// <summary>The allow_first_pin_set_via_financial_transaction property</summary>
        public bool? AllowFirstPinSetViaFinancialTransaction { get; set; }
        /// <summary>The allow_gpa_auth property</summary>
        public bool? AllowGpaAuth { get; set; }
        /// <summary>The allow_mcc_group_authorization_controls property</summary>
        public bool? AllowMccGroupAuthorizationControls { get; set; }
        /// <summary>The allow_network_load property</summary>
        public bool? AllowNetworkLoad { get; set; }
        /// <summary>The allow_network_load_card_activation property</summary>
        public bool? AllowNetworkLoadCardActivation { get; set; }
        /// <summary>The allow_quasi_cash property</summary>
        public bool? AllowQuasiCash { get; set; }
        /// <summary>The always_require_icc property</summary>
        public bool? AlwaysRequireIcc { get; set; }
        /// <summary>The always_require_pin property</summary>
        public bool? AlwaysRequirePin { get; set; }
        /// <summary>The enable_credit_service property</summary>
        public bool? EnableCreditService { get; set; }
        /// <summary>The enable_partial_auth_approval property</summary>
        public bool? EnablePartialAuthApproval { get; set; }
        /// <summary>The ignore_card_suspended_state property</summary>
        public bool? IgnoreCardSuspendedState { get; set; }
        /// <summary>The notification_language property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NotificationLanguage { get; set; }
#nullable restore
#else
        public string NotificationLanguage { get; set; }
#endif
        /// <summary>36 char max</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? QuasiCashExemptMerchantGroupToken { get; set; }
#nullable restore
#else
        public string QuasiCashExemptMerchantGroupToken { get; set; }
#endif
        /// <summary>The quasi_cash_exempt_mids property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? QuasiCashExemptMids { get; set; }
#nullable restore
#else
        public string QuasiCashExemptMids { get; set; }
#endif
        /// <summary>The require_card_not_present_card_security_code property</summary>
        public bool? RequireCardNotPresentCardSecurityCode { get; set; }
        /// <summary>The strong_customer_authentication_limits property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.Models.Strong_customer_authentication_limits? StrongCustomerAuthenticationLimits { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.Strong_customer_authentication_limits StrongCustomerAuthenticationLimits { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.Transaction_controls"/> and sets the default values.
        /// </summary>
        public Transaction_controls()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.Transaction_controls"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.Transaction_controls CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.Transaction_controls();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "accepted_countries_token", n => { AcceptedCountriesToken = n.GetStringValue(); } },
                { "address_verification", n => { AddressVerification = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.Avs_controls>(global::Marqeta.Core.Sdk.Models.Avs_controls.CreateFromDiscriminatorValue); } },
                { "allow_chip_fallback", n => { AllowChipFallback = n.GetBoolValue(); } },
                { "allow_first_pin_set_via_financial_transaction", n => { AllowFirstPinSetViaFinancialTransaction = n.GetBoolValue(); } },
                { "allow_gpa_auth", n => { AllowGpaAuth = n.GetBoolValue(); } },
                { "allow_mcc_group_authorization_controls", n => { AllowMccGroupAuthorizationControls = n.GetBoolValue(); } },
                { "allow_network_load", n => { AllowNetworkLoad = n.GetBoolValue(); } },
                { "allow_network_load_card_activation", n => { AllowNetworkLoadCardActivation = n.GetBoolValue(); } },
                { "allow_quasi_cash", n => { AllowQuasiCash = n.GetBoolValue(); } },
                { "always_require_icc", n => { AlwaysRequireIcc = n.GetBoolValue(); } },
                { "always_require_pin", n => { AlwaysRequirePin = n.GetBoolValue(); } },
                { "enable_credit_service", n => { EnableCreditService = n.GetBoolValue(); } },
                { "enable_partial_auth_approval", n => { EnablePartialAuthApproval = n.GetBoolValue(); } },
                { "ignore_card_suspended_state", n => { IgnoreCardSuspendedState = n.GetBoolValue(); } },
                { "notification_language", n => { NotificationLanguage = n.GetStringValue(); } },
                { "quasi_cash_exempt_merchant_group_token", n => { QuasiCashExemptMerchantGroupToken = n.GetStringValue(); } },
                { "quasi_cash_exempt_mids", n => { QuasiCashExemptMids = n.GetStringValue(); } },
                { "require_card_not_present_card_security_code", n => { RequireCardNotPresentCardSecurityCode = n.GetBoolValue(); } },
                { "strong_customer_authentication_limits", n => { StrongCustomerAuthenticationLimits = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.Strong_customer_authentication_limits>(global::Marqeta.Core.Sdk.Models.Strong_customer_authentication_limits.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("accepted_countries_token", AcceptedCountriesToken);
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.Avs_controls>("address_verification", AddressVerification);
            writer.WriteBoolValue("allow_chip_fallback", AllowChipFallback);
            writer.WriteBoolValue("allow_first_pin_set_via_financial_transaction", AllowFirstPinSetViaFinancialTransaction);
            writer.WriteBoolValue("allow_gpa_auth", AllowGpaAuth);
            writer.WriteBoolValue("allow_mcc_group_authorization_controls", AllowMccGroupAuthorizationControls);
            writer.WriteBoolValue("allow_network_load", AllowNetworkLoad);
            writer.WriteBoolValue("allow_network_load_card_activation", AllowNetworkLoadCardActivation);
            writer.WriteBoolValue("allow_quasi_cash", AllowQuasiCash);
            writer.WriteBoolValue("always_require_icc", AlwaysRequireIcc);
            writer.WriteBoolValue("always_require_pin", AlwaysRequirePin);
            writer.WriteBoolValue("enable_credit_service", EnableCreditService);
            writer.WriteBoolValue("enable_partial_auth_approval", EnablePartialAuthApproval);
            writer.WriteBoolValue("ignore_card_suspended_state", IgnoreCardSuspendedState);
            writer.WriteStringValue("notification_language", NotificationLanguage);
            writer.WriteStringValue("quasi_cash_exempt_merchant_group_token", QuasiCashExemptMerchantGroupToken);
            writer.WriteStringValue("quasi_cash_exempt_mids", QuasiCashExemptMids);
            writer.WriteBoolValue("require_card_not_present_card_security_code", RequireCardNotPresentCardSecurityCode);
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.Strong_customer_authentication_limits>("strong_customer_authentication_limits", StrongCustomerAuthenticationLimits);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
