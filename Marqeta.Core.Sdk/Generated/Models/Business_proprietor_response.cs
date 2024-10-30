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
    /// Contains information about the proprietor or officer of the business.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Business_proprietor_response : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Alternate names of the business proprietor or officer.This field is returned if it exists in the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AlternativeNames { get; set; }
#nullable restore
#else
        public string AlternativeNames { get; set; }
#endif
        /// <summary>Business proprietor or officer&apos;s date of birth.This field is returned if it exists in the resource.</summary>
        public DateTimeOffset? Dob { get; set; }
        /// <summary>Email address of the business proprietor or officer.This field is returned if it exists in the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email { get; set; }
#nullable restore
#else
        public string Email { get; set; }
#endif
        /// <summary>First name of the business proprietor or officer.This field is returned if it exists in the resource.</summary>
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
        public global::Marqeta.Core.Sdk.Models.AddressResponseModel? Home { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.AddressResponseModel Home { get; set; }
#endif
        /// <summary>One or more objects containing personal identifications of the business proprietor or officer.This field is returned if it exists in the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Marqeta.Core.Sdk.Models.IdentificationResponseModel>? Identifications { get; set; }
#nullable restore
#else
        public List<global::Marqeta.Core.Sdk.Models.IdentificationResponseModel> Identifications { get; set; }
#endif
        /// <summary>Last name of the business proprietor or officer.This field is returned if it exists in the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastName { get; set; }
#nullable restore
#else
        public string LastName { get; set; }
#endif
        /// <summary>Middle name of the business proprietor or officer.This field is returned if it exists in the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MiddleName { get; set; }
#nullable restore
#else
        public string MiddleName { get; set; }
#endif
        /// <summary>Telephone number of the business proprietor or officer.This field is returned if it exists in the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Phone { get; set; }
#nullable restore
#else
        public string Phone { get; set; }
#endif
        /// <summary>Social Security Number (SSN) of the business proprietor or officer.This field is returned if it exists in the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Ssn { get; set; }
#nullable restore
#else
        public string Ssn { get; set; }
#endif
        /// <summary>Title of the business proprietor or officer.This field is returned if it exists in the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title { get; set; }
#nullable restore
#else
        public string Title { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.Business_proprietor_response"/> and sets the default values.
        /// </summary>
        public Business_proprietor_response()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.Business_proprietor_response"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.Business_proprietor_response CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.Business_proprietor_response();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "alternative_names", n => { AlternativeNames = n.GetStringValue(); } },
                { "dob", n => { Dob = n.GetDateTimeOffsetValue(); } },
                { "email", n => { Email = n.GetStringValue(); } },
                { "first_name", n => { FirstName = n.GetStringValue(); } },
                { "home", n => { Home = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.AddressResponseModel>(global::Marqeta.Core.Sdk.Models.AddressResponseModel.CreateFromDiscriminatorValue); } },
                { "identifications", n => { Identifications = n.GetCollectionOfObjectValues<global::Marqeta.Core.Sdk.Models.IdentificationResponseModel>(global::Marqeta.Core.Sdk.Models.IdentificationResponseModel.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteStringValue("alternative_names", AlternativeNames);
            writer.WriteDateTimeOffsetValue("dob", Dob);
            writer.WriteStringValue("email", Email);
            writer.WriteStringValue("first_name", FirstName);
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.AddressResponseModel>("home", Home);
            writer.WriteCollectionOfObjectValues<global::Marqeta.Core.Sdk.Models.IdentificationResponseModel>("identifications", Identifications);
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
