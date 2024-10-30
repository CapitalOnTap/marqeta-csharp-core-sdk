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
    public partial class Gpa_request : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Amount to fund.</summary>
        public double? Amount { get; set; }
        /// <summary>Unique identifier of the business.Pass either a `business_token` or a `user_token`, not both.Send a `GET` request to `/businesses` to retrieve business tokens.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BusinessToken { get; set; }
#nullable restore
#else
        public string BusinessToken { get; set; }
#endif
        /// <summary>Three-digit ISO 4217 currency code.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CurrencyCode { get; set; }
#nullable restore
#else
        public string CurrencyCode { get; set; }
#endif
        /// <summary>List of fees associated with the funding transaction.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Marqeta.Core.Sdk.Models.Fee_model>? Fees { get; set; }
#nullable restore
#else
        public List<global::Marqeta.Core.Sdk.Models.Fee_model> Fees { get; set; }
#endif
        /// <summary>Unique identifier of the funding source address to use for this order.If your funding source is an ACH account, then a funding source address is not required. If your funding source is a payment card, you must have at least one funding source address in order to create a GPA order.Send a `GET` request to `/fundingsources/addresses/user/{token}` to retrieve addresses for a specific user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FundingSourceAddressToken { get; set; }
#nullable restore
#else
        public string FundingSourceAddressToken { get; set; }
#endif
        /// <summary>Unique identifier of the funding source to use for this order.You do not have to supply a funding source token value in this call if you have a default funding source set up (verify the funding source&apos;s `is_default_account` field).If you have only one funding source, then this source is used as the default.If you have multiple funding sources and none are configured as the default, then an error is returned.Send a `GET` request to `/fundingsources/user/{user_token}` to retrieve funding source tokens for a user or to `/fundingsources/business/{business_token}` to retrieve funding source tokens for a business.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FundingSourceToken { get; set; }
#nullable restore
#else
        public string FundingSourceToken { get; set; }
#endif
        /// <summary>Additional descriptive text.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Memo { get; set; }
#nullable restore
#else
        public string Memo { get; set; }
#endif
        /// <summary>Comma-delimited list of tags describing the GPA order.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Tags { get; set; }
#nullable restore
#else
        public string Tags { get; set; }
#endif
        /// <summary>Unique identifier of the GPA order.If you do not include a token, the system will generate one automatically.This token is necessary for use in other calls, so we recommend that rather than let the system generate one, you use a simple string that is easy to remember.This value cannot be updated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>Unique identifier of the user.Pass either a `user_token` or a `business_token`, not both.Send a `GET` request to `/users` to retrieve business tokens.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserToken { get; set; }
#nullable restore
#else
        public string UserToken { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.Gpa_request"/> and sets the default values.
        /// </summary>
        public Gpa_request()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.Gpa_request"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.Gpa_request CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.Gpa_request();
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
                { "business_token", n => { BusinessToken = n.GetStringValue(); } },
                { "currency_code", n => { CurrencyCode = n.GetStringValue(); } },
                { "fees", n => { Fees = n.GetCollectionOfObjectValues<global::Marqeta.Core.Sdk.Models.Fee_model>(global::Marqeta.Core.Sdk.Models.Fee_model.CreateFromDiscriminatorValue)?.AsList(); } },
                { "funding_source_address_token", n => { FundingSourceAddressToken = n.GetStringValue(); } },
                { "funding_source_token", n => { FundingSourceToken = n.GetStringValue(); } },
                { "memo", n => { Memo = n.GetStringValue(); } },
                { "tags", n => { Tags = n.GetStringValue(); } },
                { "token", n => { Token = n.GetStringValue(); } },
                { "user_token", n => { UserToken = n.GetStringValue(); } },
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
            writer.WriteStringValue("business_token", BusinessToken);
            writer.WriteStringValue("currency_code", CurrencyCode);
            writer.WriteCollectionOfObjectValues<global::Marqeta.Core.Sdk.Models.Fee_model>("fees", Fees);
            writer.WriteStringValue("funding_source_address_token", FundingSourceAddressToken);
            writer.WriteStringValue("funding_source_token", FundingSourceToken);
            writer.WriteStringValue("memo", Memo);
            writer.WriteStringValue("tags", Tags);
            writer.WriteStringValue("token", Token);
            writer.WriteStringValue("user_token", UserToken);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
