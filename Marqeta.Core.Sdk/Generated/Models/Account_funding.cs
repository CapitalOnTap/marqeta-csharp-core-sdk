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
    /// Contains details about account funding transactions.Account funding transactions move money into a cardholder&apos;s general purpose account (GPA).
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Account_funding : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Specifies the type of account from which the transaction was funded.</summary>
        public global::Marqeta.Core.Sdk.Models.Account_funding_funding_source? FundingSource { get; set; }
        /// <summary>Specifies the type of account receiving the funding.</summary>
        public global::Marqeta.Core.Sdk.Models.Account_funding_receiver_account_type? ReceiverAccountType { get; set; }
        /// <summary>Specifies the name of the account holder receiving the funding.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReceiverName { get; set; }
#nullable restore
#else
        public string ReceiverName { get; set; }
#endif
        /// <summary>Sanctions screening score to assist with meeting Anti-Money Laundering (AML) obligations.Higher scores indicate that the sender&apos;s data more closely resembles an entry on the regulatory watchlist.A value of 999 means no score was available.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ScreeningScore { get; set; }
#nullable restore
#else
        public string ScreeningScore { get; set; }
#endif
        /// <summary>Account number of the sender funding the transaction.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SenderAccountNumber { get; set; }
#nullable restore
#else
        public string SenderAccountNumber { get; set; }
#endif
        /// <summary>Street address of the sender funding the transaction.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SenderAddress { get; set; }
#nullable restore
#else
        public string SenderAddress { get; set; }
#endif
        /// <summary>City of the sender funding the transaction.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SenderCity { get; set; }
#nullable restore
#else
        public string SenderCity { get; set; }
#endif
        /// <summary>Country of the sender funding the transaction.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SenderCountry { get; set; }
#nullable restore
#else
        public string SenderCountry { get; set; }
#endif
        /// <summary>Name of the sender funding the transaction.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SenderName { get; set; }
#nullable restore
#else
        public string SenderName { get; set; }
#endif
        /// <summary>State or province of the sender funding the transaction.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SenderState { get; set; }
#nullable restore
#else
        public string SenderState { get; set; }
#endif
        /// <summary>Describes the purpose of the account funding transaction.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TransactionPurpose { get; set; }
#nullable restore
#else
        public string TransactionPurpose { get; set; }
#endif
        /// <summary>Specifies the account funding transaction type.</summary>
        public global::Marqeta.Core.Sdk.Models.Account_funding_transaction_type? TransactionType { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.Account_funding"/> and sets the default values.
        /// </summary>
        public Account_funding()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.Account_funding"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.Account_funding CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.Account_funding();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "funding_source", n => { FundingSource = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.Account_funding_funding_source>(); } },
                { "receiver_account_type", n => { ReceiverAccountType = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.Account_funding_receiver_account_type>(); } },
                { "receiver_name", n => { ReceiverName = n.GetStringValue(); } },
                { "screening_score", n => { ScreeningScore = n.GetStringValue(); } },
                { "sender_account_number", n => { SenderAccountNumber = n.GetStringValue(); } },
                { "sender_address", n => { SenderAddress = n.GetStringValue(); } },
                { "sender_city", n => { SenderCity = n.GetStringValue(); } },
                { "sender_country", n => { SenderCountry = n.GetStringValue(); } },
                { "sender_name", n => { SenderName = n.GetStringValue(); } },
                { "sender_state", n => { SenderState = n.GetStringValue(); } },
                { "transaction_purpose", n => { TransactionPurpose = n.GetStringValue(); } },
                { "transaction_type", n => { TransactionType = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.Account_funding_transaction_type>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.Account_funding_funding_source>("funding_source", FundingSource);
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.Account_funding_receiver_account_type>("receiver_account_type", ReceiverAccountType);
            writer.WriteStringValue("receiver_name", ReceiverName);
            writer.WriteStringValue("screening_score", ScreeningScore);
            writer.WriteStringValue("sender_account_number", SenderAccountNumber);
            writer.WriteStringValue("sender_address", SenderAddress);
            writer.WriteStringValue("sender_city", SenderCity);
            writer.WriteStringValue("sender_country", SenderCountry);
            writer.WriteStringValue("sender_name", SenderName);
            writer.WriteStringValue("sender_state", SenderState);
            writer.WriteStringValue("transaction_purpose", TransactionPurpose);
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.Account_funding_transaction_type>("transaction_type", TransactionType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
