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
    /// Contains information about a cardholder.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class User_card_holder_response : IAdditionalDataHolder, IParsable
    {
        /// <summary>Associates the specified account holder group with the cardholder.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountHolderGroupToken { get; set; }
#nullable restore
#else
        public string AccountHolderGroupToken { get; set; }
#endif
        /// <summary>Specifies if the cardholder is in the `ACTIVE` state on the Marqeta platform.</summary>
        public bool? Active { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Cardholder&apos;s address.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Address1 { get; set; }
#nullable restore
#else
        public string Address1 { get; set; }
#endif
        /// <summary>Additional address information for the cardholder.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Address2 { get; set; }
#nullable restore
#else
        public string Address2 { get; set; }
#endif
        /// <summary>Contains the cardholder&apos;s email address and password information.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.Models.Authentication? Authentication { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.Authentication Authentication { get; set; }
#endif
        /// <summary>Cardholder&apos;s date of birth.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BirthDate { get; set; }
#nullable restore
#else
        public string BirthDate { get; set; }
#endif
        /// <summary>Unique identifier of the business resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BusinessToken { get; set; }
#nullable restore
#else
        public string BusinessToken { get; set; }
#endif
        /// <summary>City where the cardholder resides.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? City { get; set; }
#nullable restore
#else
        public string City { get; set; }
#endif
        /// <summary>Company name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Company { get; set; }
#nullable restore
#else
        public string Company { get; set; }
#endif
        /// <summary>Specifies if the cardholder holds a corporate card.</summary>
        public bool? CorporateCardHolder { get; set; }
        /// <summary>Country where the cardholder resides.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Country { get; set; }
#nullable restore
#else
        public string Country { get; set; }
#endif
        /// <summary>Date and time when the resource was created, in UTC.</summary>
        public DateTimeOffset? CreatedTime { get; set; }
        /// <summary>Valid email address of the cardholder.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email { get; set; }
#nullable restore
#else
        public string Email { get; set; }
#endif
        /// <summary>Cardholder&apos;s first name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FirstName { get; set; }
#nullable restore
#else
        public string FirstName { get; set; }
#endif
        /// <summary>Gender of the cardholder.</summary>
        public global::Marqeta.Core.Sdk.Models.User_card_holder_response_gender? Gender { get; set; }
        /// <summary>Cardholder&apos;s title or prefix: Dr., Miss, Mr., Ms., and so on.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Honorific { get; set; }
#nullable restore
#else
        public string Honorific { get; set; }
#endif
        /// <summary>Expiration date of the cardholder&apos;s identification.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IdCardExpirationDate { get; set; }
#nullable restore
#else
        public string IdCardExpirationDate { get; set; }
#endif
        /// <summary>Cardholder&apos;s identification card number.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IdCardNumber { get; set; }
#nullable restore
#else
        public string IdCardNumber { get; set; }
#endif
        /// <summary>One or more objects containing identifications associated with the cardholder.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Marqeta.Core.Sdk.Models.IdentificationResponseModel>? Identifications { get; set; }
#nullable restore
#else
        public List<global::Marqeta.Core.Sdk.Models.IdentificationResponseModel> Identifications { get; set; }
#endif
        /// <summary>Cardholder&apos;s IP address.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IpAddress { get; set; }
#nullable restore
#else
        public string IpAddress { get; set; }
#endif
        /// <summary>Date and time when the resource was last updated, in UTC.</summary>
        public DateTimeOffset? LastModifiedTime { get; set; }
        /// <summary>Cardholder&apos;s last name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastName { get; set; }
#nullable restore
#else
        public string LastName { get; set; }
#endif
        /// <summary>Associates any additional metadata you provide with the cardholder.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.Models.User_card_holder_response_metadata? Metadata { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.User_card_holder_response_metadata Metadata { get; set; }
#endif
        /// <summary>Cardholder&apos;s middle name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MiddleName { get; set; }
#nullable restore
#else
        public string MiddleName { get; set; }
#endif
        /// <summary>Cardholder&apos;s nationality.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Nationality { get; set; }
#nullable restore
#else
        public string Nationality { get; set; }
#endif
        /// <summary>Any additional information pertaining to the cardholder.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Notes { get; set; }
#nullable restore
#else
        public string Notes { get; set; }
#endif
        /// <summary>Unique identifier of the parent user or business resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ParentToken { get; set; }
#nullable restore
#else
        public string ParentToken { get; set; }
#endif
        /// <summary>Expiration date of the cardholder&apos;s passport.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PassportExpirationDate { get; set; }
#nullable restore
#else
        public string PassportExpirationDate { get; set; }
#endif
        /// <summary>Cardholder&apos;s passport number.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PassportNumber { get; set; }
#nullable restore
#else
        public string PassportNumber { get; set; }
#endif
        /// <summary>Password to the cardholder&apos;s user account on the Marqeta platform.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Password { get; set; }
#nullable restore
#else
        public string Password { get; set; }
#endif
        /// <summary>Cardholder&apos;s telephone number.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Phone { get; set; }
#nullable restore
#else
        public string Phone { get; set; }
#endif
        /// <summary>Postal code of the cardholder&apos;s address.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PostalCode { get; set; }
#nullable restore
#else
        public string PostalCode { get; set; }
#endif
        /// <summary>Cardholder&apos;s Social Security Number (SSN).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Ssn { get; set; }
#nullable restore
#else
        public string Ssn { get; set; }
#endif
        /// <summary>State or province where the cardholder resides.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? State { get; set; }
#nullable restore
#else
        public string State { get; set; }
#endif
        /// <summary>Specifies the status of the cardholder on the Marqeta platform.</summary>
        public global::Marqeta.Core.Sdk.Models.User_card_holder_response_status? Status { get; set; }
        /// <summary>Unique identifier of the cardholder.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>Indicates whether the child shares balances with the parent (`true`), or the child&apos;s balances are independent of the parent (`false`).</summary>
        public bool? UsesParentAccount { get; set; }
        /// <summary>United States ZIP code of the cardholder&apos;s address.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Zip { get; set; }
#nullable restore
#else
        public string Zip { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.User_card_holder_response"/> and sets the default values.
        /// </summary>
        public User_card_holder_response()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.User_card_holder_response"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.User_card_holder_response CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.User_card_holder_response();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "account_holder_group_token", n => { AccountHolderGroupToken = n.GetStringValue(); } },
                { "active", n => { Active = n.GetBoolValue(); } },
                { "address1", n => { Address1 = n.GetStringValue(); } },
                { "address2", n => { Address2 = n.GetStringValue(); } },
                { "authentication", n => { Authentication = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.Authentication>(global::Marqeta.Core.Sdk.Models.Authentication.CreateFromDiscriminatorValue); } },
                { "birth_date", n => { BirthDate = n.GetStringValue(); } },
                { "business_token", n => { BusinessToken = n.GetStringValue(); } },
                { "city", n => { City = n.GetStringValue(); } },
                { "company", n => { Company = n.GetStringValue(); } },
                { "corporate_card_holder", n => { CorporateCardHolder = n.GetBoolValue(); } },
                { "country", n => { Country = n.GetStringValue(); } },
                { "created_time", n => { CreatedTime = n.GetDateTimeOffsetValue(); } },
                { "email", n => { Email = n.GetStringValue(); } },
                { "first_name", n => { FirstName = n.GetStringValue(); } },
                { "gender", n => { Gender = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.User_card_holder_response_gender>(); } },
                { "honorific", n => { Honorific = n.GetStringValue(); } },
                { "id_card_expiration_date", n => { IdCardExpirationDate = n.GetStringValue(); } },
                { "id_card_number", n => { IdCardNumber = n.GetStringValue(); } },
                { "identifications", n => { Identifications = n.GetCollectionOfObjectValues<global::Marqeta.Core.Sdk.Models.IdentificationResponseModel>(global::Marqeta.Core.Sdk.Models.IdentificationResponseModel.CreateFromDiscriminatorValue)?.AsList(); } },
                { "ip_address", n => { IpAddress = n.GetStringValue(); } },
                { "last_modified_time", n => { LastModifiedTime = n.GetDateTimeOffsetValue(); } },
                { "last_name", n => { LastName = n.GetStringValue(); } },
                { "metadata", n => { Metadata = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.User_card_holder_response_metadata>(global::Marqeta.Core.Sdk.Models.User_card_holder_response_metadata.CreateFromDiscriminatorValue); } },
                { "middle_name", n => { MiddleName = n.GetStringValue(); } },
                { "nationality", n => { Nationality = n.GetStringValue(); } },
                { "notes", n => { Notes = n.GetStringValue(); } },
                { "parent_token", n => { ParentToken = n.GetStringValue(); } },
                { "passport_expiration_date", n => { PassportExpirationDate = n.GetStringValue(); } },
                { "passport_number", n => { PassportNumber = n.GetStringValue(); } },
                { "password", n => { Password = n.GetStringValue(); } },
                { "phone", n => { Phone = n.GetStringValue(); } },
                { "postal_code", n => { PostalCode = n.GetStringValue(); } },
                { "ssn", n => { Ssn = n.GetStringValue(); } },
                { "state", n => { State = n.GetStringValue(); } },
                { "status", n => { Status = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.User_card_holder_response_status>(); } },
                { "token", n => { Token = n.GetStringValue(); } },
                { "uses_parent_account", n => { UsesParentAccount = n.GetBoolValue(); } },
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
            writer.WriteStringValue("account_holder_group_token", AccountHolderGroupToken);
            writer.WriteBoolValue("active", Active);
            writer.WriteStringValue("address1", Address1);
            writer.WriteStringValue("address2", Address2);
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.Authentication>("authentication", Authentication);
            writer.WriteStringValue("birth_date", BirthDate);
            writer.WriteStringValue("business_token", BusinessToken);
            writer.WriteStringValue("city", City);
            writer.WriteStringValue("company", Company);
            writer.WriteBoolValue("corporate_card_holder", CorporateCardHolder);
            writer.WriteStringValue("country", Country);
            writer.WriteDateTimeOffsetValue("created_time", CreatedTime);
            writer.WriteStringValue("email", Email);
            writer.WriteStringValue("first_name", FirstName);
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.User_card_holder_response_gender>("gender", Gender);
            writer.WriteStringValue("honorific", Honorific);
            writer.WriteStringValue("id_card_expiration_date", IdCardExpirationDate);
            writer.WriteStringValue("id_card_number", IdCardNumber);
            writer.WriteCollectionOfObjectValues<global::Marqeta.Core.Sdk.Models.IdentificationResponseModel>("identifications", Identifications);
            writer.WriteStringValue("ip_address", IpAddress);
            writer.WriteDateTimeOffsetValue("last_modified_time", LastModifiedTime);
            writer.WriteStringValue("last_name", LastName);
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.User_card_holder_response_metadata>("metadata", Metadata);
            writer.WriteStringValue("middle_name", MiddleName);
            writer.WriteStringValue("nationality", Nationality);
            writer.WriteStringValue("notes", Notes);
            writer.WriteStringValue("parent_token", ParentToken);
            writer.WriteStringValue("passport_expiration_date", PassportExpirationDate);
            writer.WriteStringValue("passport_number", PassportNumber);
            writer.WriteStringValue("password", Password);
            writer.WriteStringValue("phone", Phone);
            writer.WriteStringValue("postal_code", PostalCode);
            writer.WriteStringValue("ssn", Ssn);
            writer.WriteStringValue("state", State);
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.User_card_holder_response_status>("status", Status);
            writer.WriteStringValue("token", Token);
            writer.WriteBoolValue("uses_parent_account", UsesParentAccount);
            writer.WriteStringValue("zip", Zip);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
