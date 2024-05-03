// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    #pragma warning disable CS1591
    public class Base_ach_response_model : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>ACH account identifier appended to the bank account number.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountSuffix { get; set; }
#nullable restore
#else
        public string AccountSuffix { get; set; }
#endif
        /// <summary>Type of account.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountType { get; set; }
#nullable restore
#else
        public string AccountType { get; set; }
#endif
        /// <summary>Specifies whether the account is active.</summary>
        public bool? Active { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Name of the bank holding the account.This field is returned if it exists in the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BankName { get; set; }
#nullable restore
#else
        public string BankName { get; set; }
#endif
        /// <summary>Date and time when the resource was created, in UTC.</summary>
        public DateTimeOffset? CreatedTime { get; set; }
        /// <summary>Date and time in UTC when either the request for account validation was sent to the third-party partner, or when the funding source was verified by microdeposits.`2022-02-26T20:03:05Z`, for example.This field is returned if it exists in the resource.</summary>
        public DateTimeOffset? DateSentForVerification { get; set; }
        /// <summary>Date and time when the account was verified, in UTC.This field is returned if it exists in the resource.</summary>
        public DateTimeOffset? DateVerified { get; set; }
        /// <summary>If there are multiple funding sources, this field specifies which source is used by default in funding calls.If there is only one funding source, the system ignores this field and always uses that source.</summary>
        public bool? IsDefaultAccount { get; set; }
        /// <summary>Date and time when the resource was last modified, in UTC.</summary>
        public DateTimeOffset? LastModifiedTime { get; set; }
        /// <summary>Name on the ACH account.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NameOnAccount { get; set; }
#nullable restore
#else
        public string NameOnAccount { get; set; }
#endif
        /// <summary>The partner property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Partner { get; set; }
#nullable restore
#else
        public string Partner { get; set; }
#endif
        /// <summary>The partner_account_link_reference_token property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PartnerAccountLinkReferenceToken { get; set; }
#nullable restore
#else
        public string PartnerAccountLinkReferenceToken { get; set; }
#endif
        /// <summary>Unique identifier of the funding source.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>Free-form text field for holding notes about verification.This field is returned only if `verification_override = true`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VerificationNotes { get; set; }
#nullable restore
#else
        public string VerificationNotes { get; set; }
#endif
        /// <summary>Allows the ACH funding source to be used regardless of its verification status.This field is returned if it exists in the resource.*NOTE:* When using `PLAID` to validate a funding source, this field is always set to `true`.</summary>
        public bool? VerificationOverride { get; set; }
        /// <summary>Account verification status.This field is returned if it exists in the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VerificationStatus { get; set; }
#nullable restore
#else
        public string VerificationStatus { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Base_ach_response_model"/> and sets the default values.
        /// </summary>
        public Base_ach_response_model()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Base_ach_response_model"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Base_ach_response_model CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Base_ach_response_model();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"account_suffix", n => { AccountSuffix = n.GetStringValue(); } },
                {"account_type", n => { AccountType = n.GetStringValue(); } },
                {"active", n => { Active = n.GetBoolValue(); } },
                {"bank_name", n => { BankName = n.GetStringValue(); } },
                {"created_time", n => { CreatedTime = n.GetDateTimeOffsetValue(); } },
                {"date_sent_for_verification", n => { DateSentForVerification = n.GetDateTimeOffsetValue(); } },
                {"date_verified", n => { DateVerified = n.GetDateTimeOffsetValue(); } },
                {"is_default_account", n => { IsDefaultAccount = n.GetBoolValue(); } },
                {"last_modified_time", n => { LastModifiedTime = n.GetDateTimeOffsetValue(); } },
                {"name_on_account", n => { NameOnAccount = n.GetStringValue(); } },
                {"partner", n => { Partner = n.GetStringValue(); } },
                {"partner_account_link_reference_token", n => { PartnerAccountLinkReferenceToken = n.GetStringValue(); } },
                {"token", n => { Token = n.GetStringValue(); } },
                {"verification_notes", n => { VerificationNotes = n.GetStringValue(); } },
                {"verification_override", n => { VerificationOverride = n.GetBoolValue(); } },
                {"verification_status", n => { VerificationStatus = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("account_suffix", AccountSuffix);
            writer.WriteStringValue("account_type", AccountType);
            writer.WriteBoolValue("active", Active);
            writer.WriteStringValue("bank_name", BankName);
            writer.WriteDateTimeOffsetValue("created_time", CreatedTime);
            writer.WriteDateTimeOffsetValue("date_sent_for_verification", DateSentForVerification);
            writer.WriteDateTimeOffsetValue("date_verified", DateVerified);
            writer.WriteBoolValue("is_default_account", IsDefaultAccount);
            writer.WriteDateTimeOffsetValue("last_modified_time", LastModifiedTime);
            writer.WriteStringValue("name_on_account", NameOnAccount);
            writer.WriteStringValue("partner", Partner);
            writer.WriteStringValue("partner_account_link_reference_token", PartnerAccountLinkReferenceToken);
            writer.WriteStringValue("token", Token);
            writer.WriteStringValue("verification_notes", VerificationNotes);
            writer.WriteBoolValue("verification_override", VerificationOverride);
            writer.WriteStringValue("verification_status", VerificationStatus);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
