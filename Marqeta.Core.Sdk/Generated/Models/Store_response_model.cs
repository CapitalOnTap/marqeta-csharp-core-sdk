// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models
{
    #pragma warning disable CS1591
    public class Store_response_model : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The active property</summary>
        public bool? Active { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The address1 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Address1 { get; set; }
#nullable restore
#else
        public string Address1 { get; set; }
#endif
        /// <summary>The address2 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Address2 { get; set; }
#nullable restore
#else
        public string Address2 { get; set; }
#endif
        /// <summary>The city property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? City { get; set; }
#nullable restore
#else
        public string City { get; set; }
#endif
        /// <summary>The contact property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Contact { get; set; }
#nullable restore
#else
        public string Contact { get; set; }
#endif
        /// <summary>The contact_email property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContactEmail { get; set; }
#nullable restore
#else
        public string ContactEmail { get; set; }
#endif
        /// <summary>The country property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Country { get; set; }
#nullable restore
#else
        public string Country { get; set; }
#endif
        /// <summary>yyyy-MM-ddTHH:mm:ssZ</summary>
        public DateTimeOffset? CreatedTime { get; set; }
        /// <summary>The keyed_auth_cvv_enforced property</summary>
        public bool? KeyedAuthCvvEnforced { get; set; }
        /// <summary>yyyy-MM-ddTHH:mm:ssZ</summary>
        public DateTimeOffset? LastModifiedTime { get; set; }
        /// <summary>The latitude property</summary>
        public float? Latitude { get; set; }
        /// <summary>The longitude property</summary>
        public float? Longitude { get; set; }
        /// <summary>The merchant_token property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MerchantToken { get; set; }
#nullable restore
#else
        public string MerchantToken { get; set; }
#endif
        /// <summary>The mid property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Mid { get; set; }
#nullable restore
#else
        public string Mid { get; set; }
#endif
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The network_mid property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NetworkMid { get; set; }
#nullable restore
#else
        public string NetworkMid { get; set; }
#endif
        /// <summary>The partial_approval_capable property</summary>
        public bool? PartialApprovalCapable { get; set; }
        /// <summary>1 char max</summary>
        public bool? PartialAuthFlag { get; set; }
        /// <summary>The phone property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Phone { get; set; }
#nullable restore
#else
        public string Phone { get; set; }
#endif
        /// <summary>The postal_code property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PostalCode { get; set; }
#nullable restore
#else
        public string PostalCode { get; set; }
#endif
        /// <summary>The province property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Province { get; set; }
#nullable restore
#else
        public string Province { get; set; }
#endif
        /// <summary>The state property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? State { get; set; }
#nullable restore
#else
        public string State { get; set; }
#endif
        /// <summary>The unique identifier of the merchant</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>The zip property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Zip { get; set; }
#nullable restore
#else
        public string Zip { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Models.Store_response_model"/> and sets the default values.
        /// </summary>
        public Store_response_model()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Models.Store_response_model"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Marqeta.Core.Sdk.Models.Store_response_model CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Marqeta.Core.Sdk.Models.Store_response_model();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "active", n => { Active = n.GetBoolValue(); } },
                { "address1", n => { Address1 = n.GetStringValue(); } },
                { "address2", n => { Address2 = n.GetStringValue(); } },
                { "city", n => { City = n.GetStringValue(); } },
                { "contact", n => { Contact = n.GetStringValue(); } },
                { "contact_email", n => { ContactEmail = n.GetStringValue(); } },
                { "country", n => { Country = n.GetStringValue(); } },
                { "created_time", n => { CreatedTime = n.GetDateTimeOffsetValue(); } },
                { "keyed_auth_cvv_enforced", n => { KeyedAuthCvvEnforced = n.GetBoolValue(); } },
                { "last_modified_time", n => { LastModifiedTime = n.GetDateTimeOffsetValue(); } },
                { "latitude", n => { Latitude = n.GetFloatValue(); } },
                { "longitude", n => { Longitude = n.GetFloatValue(); } },
                { "merchant_token", n => { MerchantToken = n.GetStringValue(); } },
                { "mid", n => { Mid = n.GetStringValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "network_mid", n => { NetworkMid = n.GetStringValue(); } },
                { "partial_approval_capable", n => { PartialApprovalCapable = n.GetBoolValue(); } },
                { "partial_auth_flag", n => { PartialAuthFlag = n.GetBoolValue(); } },
                { "phone", n => { Phone = n.GetStringValue(); } },
                { "postal_code", n => { PostalCode = n.GetStringValue(); } },
                { "province", n => { Province = n.GetStringValue(); } },
                { "state", n => { State = n.GetStringValue(); } },
                { "token", n => { Token = n.GetStringValue(); } },
                { "zip", n => { Zip = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("active", Active);
            writer.WriteStringValue("address1", Address1);
            writer.WriteStringValue("address2", Address2);
            writer.WriteStringValue("city", City);
            writer.WriteStringValue("contact", Contact);
            writer.WriteStringValue("contact_email", ContactEmail);
            writer.WriteStringValue("country", Country);
            writer.WriteDateTimeOffsetValue("created_time", CreatedTime);
            writer.WriteBoolValue("keyed_auth_cvv_enforced", KeyedAuthCvvEnforced);
            writer.WriteDateTimeOffsetValue("last_modified_time", LastModifiedTime);
            writer.WriteFloatValue("latitude", Latitude);
            writer.WriteFloatValue("longitude", Longitude);
            writer.WriteStringValue("merchant_token", MerchantToken);
            writer.WriteStringValue("mid", Mid);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("network_mid", NetworkMid);
            writer.WriteBoolValue("partial_approval_capable", PartialApprovalCapable);
            writer.WriteBoolValue("partial_auth_flag", PartialAuthFlag);
            writer.WriteStringValue("phone", Phone);
            writer.WriteStringValue("postal_code", PostalCode);
            writer.WriteStringValue("province", Province);
            writer.WriteStringValue("state", State);
            writer.WriteStringValue("token", Token);
            writer.WriteStringValue("zip", Zip);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
