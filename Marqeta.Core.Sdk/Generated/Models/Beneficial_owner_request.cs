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
    /// Contains information about the beneficial owner of the business, if applicable.This object is required for KYC verification in the United States if the business is private and has a beneficial owner.This object is not required for publicly held businesses.Do not include information about the proprietor or business officer in a `beneficial_owner` object.If the proprietor or officer of the business is also a beneficial owner, you must indicate that in the `proprietor_is_beneficial_owner` field in the body field details of the business.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Beneficial_owner_request : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Date of birth of the beneficial owner.</summary>
        public DateTimeOffset? Dob { get; set; }
        /// <summary>First name of the beneficial owner.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FirstName { get; set; }
#nullable restore
#else
        public string FirstName { get; set; }
#endif
        /// <summary>Address associated with the business.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.Models.AddressRequestModel? Home { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.AddressRequestModel Home { get; set; }
#endif
        /// <summary>Last name of the beneficial owner.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastName { get; set; }
#nullable restore
#else
        public string LastName { get; set; }
#endif
        /// <summary>Middle name of the beneficial owner.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MiddleName { get; set; }
#nullable restore
#else
        public string MiddleName { get; set; }
#endif
        /// <summary>Ten-digit phone number of the beneficial owner.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Phone { get; set; }
#nullable restore
#else
        public string Phone { get; set; }
#endif
        /// <summary>Nine-digit Social Security Number (SSN) of the beneficial owner.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Ssn { get; set; }
#nullable restore
#else
        public string Ssn { get; set; }
#endif
        /// <summary>Title of the beneficial owner.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title { get; set; }
#nullable restore
#else
        public string Title { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.Beneficial_owner_request"/> and sets the default values.
        /// </summary>
        public Beneficial_owner_request()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.Beneficial_owner_request"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.Beneficial_owner_request CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.Beneficial_owner_request();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "dob", n => { Dob = n.GetDateTimeOffsetValue(); } },
                { "first_name", n => { FirstName = n.GetStringValue(); } },
                { "home", n => { Home = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.AddressRequestModel>(global::Marqeta.Core.Sdk.Models.AddressRequestModel.CreateFromDiscriminatorValue); } },
                { "last_name", n => { LastName = n.GetStringValue(); } },
                { "middle_name", n => { MiddleName = n.GetStringValue(); } },
                { "phone", n => { Phone = n.GetStringValue(); } },
                { "ssn", n => { Ssn = n.GetStringValue(); } },
                { "title", n => { Title = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("dob", Dob);
            writer.WriteStringValue("first_name", FirstName);
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.AddressRequestModel>("home", Home);
            writer.WriteStringValue("last_name", LastName);
            writer.WriteStringValue("middle_name", MiddleName);
            writer.WriteStringValue("phone", Phone);
            writer.WriteStringValue("ssn", Ssn);
            writer.WriteStringValue("title", Title);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
