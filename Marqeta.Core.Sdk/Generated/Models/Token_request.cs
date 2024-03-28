// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    public class Token_request : IAdditionalDataHolder, IParsable {
        /// <summary>Payment card account number.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountNumber { get; set; }
#nullable restore
#else
        public string AccountNumber { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Unique identifier of the business account holder.This token is required if the `user_token` is not included.Send a `GET` request to `/businesses` to retrieve business tokens.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BusinessToken { get; set; }
#nullable restore
#else
        public string BusinessToken { get; set; }
#endif
        /// <summary>Payment card CVV2 number.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CvvNumber { get; set; }
#nullable restore
#else
        public string CvvNumber { get; set; }
#endif
        /// <summary>Payment card expiration date.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExpDate { get; set; }
#nullable restore
#else
        public string ExpDate { get; set; }
#endif
        /// <summary>If there are multiple funding sources, this field specifies which source is used by default in funding calls.If there is only one funding source, the system ignores this field and always uses that source.</summary>
        public bool? IsDefaultAccount { get; set; }
        /// <summary>Postal code of the account holder (user or business).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PostalCode { get; set; }
#nullable restore
#else
        public string PostalCode { get; set; }
#endif
        /// <summary>Unique identifier of the funding account.If you do not include a token, the system will generate one automatically.As this token is necessary for use in other calls, we recommend that you define a simple and easy to remember string rather than letting the system generate a token for you.This value cannot be updated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>Unique identifier of the user account holder.This token is required if the `business_token` is not included.Send a `GET` request to `/users` to retrieve user tokens.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserToken { get; set; }
#nullable restore
#else
        public string UserToken { get; set; }
#endif
        /// <summary>United States ZIP code of the account holder (user or business).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Zip { get; set; }
#nullable restore
#else
        public string Zip { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Token_request"/> and sets the default values.
        /// </summary>
        public Token_request() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Token_request"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Token_request CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Token_request();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"account_number", n => { AccountNumber = n.GetStringValue(); } },
                {"business_token", n => { BusinessToken = n.GetStringValue(); } },
                {"cvv_number", n => { CvvNumber = n.GetStringValue(); } },
                {"exp_date", n => { ExpDate = n.GetStringValue(); } },
                {"is_default_account", n => { IsDefaultAccount = n.GetBoolValue(); } },
                {"postal_code", n => { PostalCode = n.GetStringValue(); } },
                {"token", n => { Token = n.GetStringValue(); } },
                {"user_token", n => { UserToken = n.GetStringValue(); } },
                {"zip", n => { Zip = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("account_number", AccountNumber);
            writer.WriteStringValue("business_token", BusinessToken);
            writer.WriteStringValue("cvv_number", CvvNumber);
            writer.WriteStringValue("exp_date", ExpDate);
            writer.WriteBoolValue("is_default_account", IsDefaultAccount);
            writer.WriteStringValue("postal_code", PostalCode);
            writer.WriteStringValue("token", Token);
            writer.WriteStringValue("user_token", UserToken);
            writer.WriteStringValue("zip", Zip);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
