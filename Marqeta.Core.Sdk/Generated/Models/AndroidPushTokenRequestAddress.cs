// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    /// <summary>
    /// Specifies the cardholder address.
    /// </summary>
    public class AndroidPushTokenRequestAddress : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Street address of the cardholder.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Address1 { get; set; }
#nullable restore
#else
        public string Address1 { get; set; }
#endif
        /// <summary>Additional address information for the cardholder, such as a suite or apartment number.`Suite 600`, for example.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Address2 { get; set; }
#nullable restore
#else
        public string Address2 { get; set; }
#endif
        /// <summary>City of the cardholder.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? City { get; set; }
#nullable restore
#else
        public string City { get; set; }
#endif
        /// <summary>Two-character link:https://www.iso.org/iso-3166-country-codes.html[ISO alpha-2 country code, window=&quot;_blank&quot;].`US`, for example.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Country { get; set; }
#nullable restore
#else
        public string Country { get; set; }
#endif
        /// <summary>Name of the cardholder.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Telephone number of the cardholder.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Phone { get; set; }
#nullable restore
#else
        public string Phone { get; set; }
#endif
        /// <summary>Postal code of the cardholder, such as a United States ZIP code.`94612`, for example.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PostalCode { get; set; }
#nullable restore
#else
        public string PostalCode { get; set; }
#endif
        /// <summary>Two-character &lt;&lt;/core-api/kyc-verification#_valid_state_provincial_and_territorial_abbreviations, state or province code&gt;&gt;.`CA`, for example.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? State { get; set; }
#nullable restore
#else
        public string State { get; set; }
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
        /// Instantiates a new <see cref="AndroidPushTokenRequestAddress"/> and sets the default values.
        /// </summary>
        public AndroidPushTokenRequestAddress()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AndroidPushTokenRequestAddress"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AndroidPushTokenRequestAddress CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidPushTokenRequestAddress();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"address1", n => { Address1 = n.GetStringValue(); } },
                {"address2", n => { Address2 = n.GetStringValue(); } },
                {"city", n => { City = n.GetStringValue(); } },
                {"country", n => { Country = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"phone", n => { Phone = n.GetStringValue(); } },
                {"postal_code", n => { PostalCode = n.GetStringValue(); } },
                {"state", n => { State = n.GetStringValue(); } },
                {"zip", n => { Zip = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("address1", Address1);
            writer.WriteStringValue("address2", Address2);
            writer.WriteStringValue("city", City);
            writer.WriteStringValue("country", Country);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("phone", Phone);
            writer.WriteStringValue("postal_code", PostalCode);
            writer.WriteStringValue("state", State);
            writer.WriteStringValue("zip", Zip);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
