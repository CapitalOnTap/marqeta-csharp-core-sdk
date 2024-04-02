// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    /// <summary>
    /// Contains information about the JIT Funding load event, in which funds are loaded into an account.
    /// </summary>
    public class Jit_funding_api : IAdditionalDataHolder, IParsable {
        /// <summary>User who conducted the transaction.Can be a child user configured to share its parent&apos;s account balance.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ActingUserToken { get; set; }
#nullable restore
#else
        public string ActingUserToken { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Contains address verification data used to make JIT funding decisions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Jit_address_verification? AddressVerification { get; set; }
#nullable restore
#else
        public Jit_address_verification AddressVerification { get; set; }
#endif
        /// <summary>Requested amount of funding.</summary>
        public double? Amount { get; set; }
        /// <summary>Contains the GPA&apos;s balance details.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Jit_funding_api_balances? Balances { get; set; }
#nullable restore
#else
        public Jit_funding_api_balances Balances { get; set; }
#endif
        /// <summary>Holder of the business account that was funded.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BusinessToken { get; set; }
#nullable restore
#else
        public string BusinessToken { get; set; }
#endif
        /// <summary>Reason why the transaction was declined.</summary>
        public Jit_funding_api_decline_reason? DeclineReason { get; set; }
        /// <summary>Array of tokens referencing the JIT Funding tokens of all previous associated incremental authorization JIT Funding requests.Useful for ascertaining the final transaction amount when the original amount was incremented.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? IncrementalAuthorizationJitFundingTokens { get; set; }
#nullable restore
#else
        public List<string> IncrementalAuthorizationJitFundingTokens { get; set; }
#endif
        /// <summary>Additional information that describes the JIT Funding transaction.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Memo { get; set; }
#nullable restore
#else
        public string Memo { get; set; }
#endif
        /// <summary>JIT Funding response type.See &lt;&lt;/core-api/gateway-jit-funding-messages#_the_jit_funding_object, The jit_funding object&gt;&gt; for the purpose, funding event type, and description of each method.</summary>
        public Jit_funding_api_method? Method { get; set; }
        /// <summary>Unique identifier of the first associated JIT Funding message.Useful for correlating related JIT Funding messages (that is, those associated with the same GPA order).Not included in the first of any set of related messages.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OriginalJitFundingToken { get; set; }
#nullable restore
#else
        public string OriginalJitFundingToken { get; set; }
#endif
        /// <summary>Customer-defined tags related to the JIT Funding transaction.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Tags { get; set; }
#nullable restore
#else
        public string Tags { get; set; }
#endif
        /// <summary>Existing JIT Funding token matching the `funding.gateway_log.transaction_id` field of the associated GPA order.*NOTE:* The `transaction_id` field updates if a subsequent JIT Funding message associated with that GPA order is sent.If multiple JIT Funding messages are associated with the same GPA order, the `transaction_id` field matches the token of the most recent message.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>Holder of the user account that was funded.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserToken { get; set; }
#nullable restore
#else
        public string UserToken { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Jit_funding_api"/> and sets the default values.
        /// </summary>
        public Jit_funding_api() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Jit_funding_api"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Jit_funding_api CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Jit_funding_api();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"acting_user_token", n => { ActingUserToken = n.GetStringValue(); } },
                {"address_verification", n => { AddressVerification = n.GetObjectValue<Jit_address_verification>(Jit_address_verification.CreateFromDiscriminatorValue); } },
                {"amount", n => { Amount = n.GetDoubleValue(); } },
                {"balances", n => { Balances = n.GetObjectValue<Jit_funding_api_balances>(Jit_funding_api_balances.CreateFromDiscriminatorValue); } },
                {"business_token", n => { BusinessToken = n.GetStringValue(); } },
                {"decline_reason", n => { DeclineReason = n.GetEnumValue<Jit_funding_api_decline_reason>(); } },
                {"incremental_authorization_jit_funding_tokens", n => { IncrementalAuthorizationJitFundingTokens = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"memo", n => { Memo = n.GetStringValue(); } },
                {"method", n => { Method = n.GetEnumValue<Jit_funding_api_method>(); } },
                {"original_jit_funding_token", n => { OriginalJitFundingToken = n.GetStringValue(); } },
                {"tags", n => { Tags = n.GetStringValue(); } },
                {"token", n => { Token = n.GetStringValue(); } },
                {"user_token", n => { UserToken = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("acting_user_token", ActingUserToken);
            writer.WriteObjectValue<Jit_address_verification>("address_verification", AddressVerification);
            writer.WriteDoubleValue("amount", Amount);
            writer.WriteObjectValue<Jit_funding_api_balances>("balances", Balances);
            writer.WriteStringValue("business_token", BusinessToken);
            writer.WriteEnumValue<Jit_funding_api_decline_reason>("decline_reason", DeclineReason);
            writer.WriteCollectionOfPrimitiveValues<string>("incremental_authorization_jit_funding_tokens", IncrementalAuthorizationJitFundingTokens);
            writer.WriteStringValue("memo", Memo);
            writer.WriteEnumValue<Jit_funding_api_method>("method", Method);
            writer.WriteStringValue("original_jit_funding_token", OriginalJitFundingToken);
            writer.WriteStringValue("tags", Tags);
            writer.WriteStringValue("token", Token);
            writer.WriteStringValue("user_token", UserToken);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
