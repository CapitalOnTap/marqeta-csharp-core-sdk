// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    /// <summary>
    /// Contains information about the beneficial owner of the business, if applicable.
    /// </summary>
    public class Beneficial_owner_response : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>First name of the beneficial owner.This field is returned if it exists in the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FirstName { get; set; }
#nullable restore
#else
        public string FirstName { get; set; }
#endif
        /// <summary>Date of birth of the beneficial owner.This field is returned if it exists in the resource.</summary>
        public DateTimeOffset? Getdob { get; set; }
        /// <summary>Address associated with the business.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AddressResponseModel? Home { get; set; }
#nullable restore
#else
        public AddressResponseModel Home { get; set; }
#endif
        /// <summary>Last name of the beneficial owner.This field is returned if it exists in the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastName { get; set; }
#nullable restore
#else
        public string LastName { get; set; }
#endif
        /// <summary>Middle name of the beneficial owner.This field is returned if it exists in the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MiddleName { get; set; }
#nullable restore
#else
        public string MiddleName { get; set; }
#endif
        /// <summary>Ten-digit phone number of the beneficial owner.This field is returned if it exists in the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Phone { get; set; }
#nullable restore
#else
        public string Phone { get; set; }
#endif
        /// <summary>Title of the beneficial owner.This field is returned if it exists in the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title { get; set; }
#nullable restore
#else
        public string Title { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Beneficial_owner_response"/> and sets the default values.
        /// </summary>
        public Beneficial_owner_response() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Beneficial_owner_response"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Beneficial_owner_response CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Beneficial_owner_response();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"first_name", n => { FirstName = n.GetStringValue(); } },
                {"getdob", n => { Getdob = n.GetDateTimeOffsetValue(); } },
                {"home", n => { Home = n.GetObjectValue<AddressResponseModel>(AddressResponseModel.CreateFromDiscriminatorValue); } },
                {"last_name", n => { LastName = n.GetStringValue(); } },
                {"middle_name", n => { MiddleName = n.GetStringValue(); } },
                {"phone", n => { Phone = n.GetStringValue(); } },
                {"title", n => { Title = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("first_name", FirstName);
            writer.WriteDateTimeOffsetValue("getdob", Getdob);
            writer.WriteObjectValue<AddressResponseModel>("home", Home);
            writer.WriteStringValue("last_name", LastName);
            writer.WriteStringValue("middle_name", MiddleName);
            writer.WriteStringValue("phone", Phone);
            writer.WriteStringValue("title", Title);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}