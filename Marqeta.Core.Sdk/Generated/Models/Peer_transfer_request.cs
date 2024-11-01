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
    public partial class Peer_transfer_request : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Amount of the transfer.</summary>
        public double? Amount { get; set; }
        /// <summary>Three-digit ISO 4217 currency code.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CurrencyCode { get; set; }
#nullable restore
#else
        public string CurrencyCode { get; set; }
#endif
        /// <summary>Additional descriptive text about the transfer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Memo { get; set; }
#nullable restore
#else
        public string Memo { get; set; }
#endif
        /// <summary>Specifies the business account holder that receives funds.Send a `GET` request to `/businesses` to retrieve business tokens.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecipientBusinessToken { get; set; }
#nullable restore
#else
        public string RecipientBusinessToken { get; set; }
#endif
        /// <summary>Specifies the user account holder that receives funds.Send a `GET` request to `/users` to retrieve user tokens.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecipientUserToken { get; set; }
#nullable restore
#else
        public string RecipientUserToken { get; set; }
#endif
        /// <summary>Specifies the business account holder that sends funds.Send a `GET` request to `/businesses` to retrieve business tokens.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SenderBusinessToken { get; set; }
#nullable restore
#else
        public string SenderBusinessToken { get; set; }
#endif
        /// <summary>Specifies the user account holder that sends funds.Send a `GET` request to `/users` to retrieve user tokens.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SenderUserToken { get; set; }
#nullable restore
#else
        public string SenderUserToken { get; set; }
#endif
        /// <summary>Metadata about the peer transfer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Tags { get; set; }
#nullable restore
#else
        public string Tags { get; set; }
#endif
        /// <summary>Unique identifier of the peer transfer request.If you do not include a token, the system will generate one automatically.This token is necessary for use in other API calls, so we recommend that rather than let the system generate one, you use a simple string that is easy to remember.This value cannot be updated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.Peer_transfer_request"/> and sets the default values.
        /// </summary>
        public Peer_transfer_request()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.Peer_transfer_request"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.Peer_transfer_request CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.Peer_transfer_request();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "amount", n => { Amount = n.GetDoubleValue(); } },
                { "currency_code", n => { CurrencyCode = n.GetStringValue(); } },
                { "memo", n => { Memo = n.GetStringValue(); } },
                { "recipient_business_token", n => { RecipientBusinessToken = n.GetStringValue(); } },
                { "recipient_user_token", n => { RecipientUserToken = n.GetStringValue(); } },
                { "sender_business_token", n => { SenderBusinessToken = n.GetStringValue(); } },
                { "sender_user_token", n => { SenderUserToken = n.GetStringValue(); } },
                { "tags", n => { Tags = n.GetStringValue(); } },
                { "token", n => { Token = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("amount", Amount);
            writer.WriteStringValue("currency_code", CurrencyCode);
            writer.WriteStringValue("memo", Memo);
            writer.WriteStringValue("recipient_business_token", RecipientBusinessToken);
            writer.WriteStringValue("recipient_user_token", RecipientUserToken);
            writer.WriteStringValue("sender_business_token", SenderBusinessToken);
            writer.WriteStringValue("sender_user_token", SenderUserToken);
            writer.WriteStringValue("tags", Tags);
            writer.WriteStringValue("token", Token);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
