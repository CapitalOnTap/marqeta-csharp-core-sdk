// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models
{
    #pragma warning disable CS1591
    public class Business_card_holder_update : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Associates the specified account holder group with the business.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountHolderGroupToken { get; set; }
#nullable restore
#else
        public string AccountHolderGroupToken { get; set; }
#endif
        /// <summary>Specifies if the business is in the `ACTIVE` state on the Marqeta platform.</summary>
        public bool? Active { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Indicates that the attester agrees that the information provided is correct and truthful.This field is required for KYC verification (US-based accounts only).</summary>
        public bool? AttestationConsent { get; set; }
        /// <summary>Timestamp of the attestation.This field is required for KYC verification (US-based accounts only).</summary>
        public DateTimeOffset? AttestationDate { get; set; }
        /// <summary>Name of the attester for KYC verification.This field is required for KYC verification (US-based accounts only).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AttesterName { get; set; }
#nullable restore
#else
        public string AttesterName { get; set; }
#endif
        /// <summary>Title of the attester for KYC verification.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AttesterTitle { get; set; }
#nullable restore
#else
        public string AttesterTitle { get; set; }
#endif
        /// <summary>Contains information about the beneficial owner of the business, if applicable.This object is required for KYC verification in the United States if the business is private and has a beneficial owner.This object is not required for publicly held businesses.Do not include information about the proprietor or business officer in a `beneficial_owner` object.If the proprietor or officer of the business is also a beneficial owner, you must indicate that in the `proprietor_is_beneficial_owner` field in the body field details of the business.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Marqeta.Core.Sdk.Models.Beneficial_owner_request? BeneficialOwner1 { get; set; }
#nullable restore
#else
        public Marqeta.Core.Sdk.Models.Beneficial_owner_request BeneficialOwner1 { get; set; }
#endif
        /// <summary>Contains information about the beneficial owner of the business, if applicable.This object is required for KYC verification in the United States if the business is private and has a beneficial owner.This object is not required for publicly held businesses.Do not include information about the proprietor or business officer in a `beneficial_owner` object.If the proprietor or officer of the business is also a beneficial owner, you must indicate that in the `proprietor_is_beneficial_owner` field in the body field details of the business.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Marqeta.Core.Sdk.Models.Beneficial_owner_request? BeneficialOwner2 { get; set; }
#nullable restore
#else
        public Marqeta.Core.Sdk.Models.Beneficial_owner_request BeneficialOwner2 { get; set; }
#endif
        /// <summary>Contains information about the beneficial owner of the business, if applicable.This object is required for KYC verification in the United States if the business is private and has a beneficial owner.This object is not required for publicly held businesses.Do not include information about the proprietor or business officer in a `beneficial_owner` object.If the proprietor or officer of the business is also a beneficial owner, you must indicate that in the `proprietor_is_beneficial_owner` field in the body field details of the business.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Marqeta.Core.Sdk.Models.Beneficial_owner_request? BeneficialOwner3 { get; set; }
#nullable restore
#else
        public Marqeta.Core.Sdk.Models.Beneficial_owner_request BeneficialOwner3 { get; set; }
#endif
        /// <summary>Contains information about the beneficial owner of the business, if applicable.This object is required for KYC verification in the United States if the business is private and has a beneficial owner.This object is not required for publicly held businesses.Do not include information about the proprietor or business officer in a `beneficial_owner` object.If the proprietor or officer of the business is also a beneficial owner, you must indicate that in the `proprietor_is_beneficial_owner` field in the body field details of the business.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Marqeta.Core.Sdk.Models.Beneficial_owner_request? BeneficialOwner4 { get; set; }
#nullable restore
#else
        public Marqeta.Core.Sdk.Models.Beneficial_owner_request BeneficialOwner4 { get; set; }
#endif
        /// <summary>Fictitious business name (&quot;Doing Business As&quot; or DBA).This field is required for KYC verification (US-based accounts only).If your business does not use a fictitious business name, enter your legal business name again in this field.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BusinessNameDba { get; set; }
#nullable restore
#else
        public string BusinessNameDba { get; set; }
#endif
        /// <summary>Legal name of business.This field is required for KYC verification (US-based accounts only).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BusinessNameLegal { get; set; }
#nullable restore
#else
        public string BusinessNameLegal { get; set; }
#endif
        /// <summary>Indicates the type of business, for example business-to-business (B2B) or business-to-consumer (B2C).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BusinessType { get; set; }
#nullable restore
#else
        public string BusinessType { get; set; }
#endif
        /// <summary>Date when the business was established.</summary>
        public DateTimeOffset? DateEstablished { get; set; }
        /// <summary>Data Universal Numbering System (DUNS) number of the business.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DunsNumber { get; set; }
#nullable restore
#else
        public string DunsNumber { get; set; }
#endif
        /// <summary>General description of the business.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GeneralBusinessDescription { get; set; }
#nullable restore
#else
        public string GeneralBusinessDescription { get; set; }
#endif
        /// <summary>History of the business.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? History { get; set; }
#nullable restore
#else
        public string History { get; set; }
#endif
        /// <summary>One or more objects containing identifications associated with the business.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Marqeta.Core.Sdk.Models.IdentificationRequestModel>? Identifications { get; set; }
#nullable restore
#else
        public List<Marqeta.Core.Sdk.Models.IdentificationRequestModel> Identifications { get; set; }
#endif
        /// <summary>Contains information about the organizational structure of the business.This object is required for KYC verification (US-based accounts only).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Marqeta.Core.Sdk.Models.Business_incorporation? Incorporation { get; set; }
#nullable restore
#else
        public Marqeta.Core.Sdk.Models.Business_incorporation Incorporation { get; set; }
#endif
        /// <summary>Date on which the business office opened in its current location.</summary>
        public DateTimeOffset? InCurrentLocationSince { get; set; }
        /// <summary>Locations of the business&apos; offices outside the United States.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InternationalOfficeLocations { get; set; }
#nullable restore
#else
        public string InternationalOfficeLocations { get; set; }
#endif
        /// <summary>IP address of the business.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IpAddress { get; set; }
#nullable restore
#else
        public string IpAddress { get; set; }
#endif
        /// <summary>Associates any additional metadata you provide with the business.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Marqeta.Core.Sdk.Models.Business_card_holder_update_metadata? Metadata { get; set; }
#nullable restore
#else
        public Marqeta.Core.Sdk.Models.Business_card_holder_update_metadata Metadata { get; set; }
#endif
        /// <summary>Any additional information pertaining to the business.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Notes { get; set; }
#nullable restore
#else
        public string Notes { get; set; }
#endif
        /// <summary>Address associated with the business.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Marqeta.Core.Sdk.Models.AddressRequestModel? OfficeLocation { get; set; }
#nullable restore
#else
        public Marqeta.Core.Sdk.Models.AddressRequestModel OfficeLocation { get; set; }
#endif
        /// <summary>Password for the business account on the Marqeta platform.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Password { get; set; }
#nullable restore
#else
        public string Password { get; set; }
#endif
        /// <summary>10-digit telephone number of business.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Phone { get; set; }
#nullable restore
#else
        public string Phone { get; set; }
#endif
        /// <summary>Describes the business&apos; primary contact person.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Marqeta.Core.Sdk.Models.PrimaryContactInfoModel? PrimaryContact { get; set; }
#nullable restore
#else
        public Marqeta.Core.Sdk.Models.PrimaryContactInfoModel PrimaryContact { get; set; }
#endif
        /// <summary>Indicates that the proprietor or officer of the business is also a beneficial owner.This field is required for KYC verification in the United States if the business proprietor or officer is also a beneficial owner.If the proprietor or business officer is a beneficial owner, use this field to indicate their beneficial ownership.Do not include information about the proprietor or business officer in a `beneficial_owner` object.</summary>
        public bool? ProprietorIsBeneficialOwner { get; set; }
        /// <summary>Contains information about the proprietor or officer of the business.This object is required for KYC verification of proprietors or officers of privately held businesses in the United States.This object is not required for publicly held businesses.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Marqeta.Core.Sdk.Models.Business_proprietor? ProprietorOrOfficer { get; set; }
#nullable restore
#else
        public Marqeta.Core.Sdk.Models.Business_proprietor ProprietorOrOfficer { get; set; }
#endif
        /// <summary>Taxpayer identifier of the business.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TaxpayerId { get; set; }
#nullable restore
#else
        public string TaxpayerId { get; set; }
#endif
        /// <summary>Unique identifier of the business.Send a `GET` request to `/businesses` to retrieve business tokens.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>URL of the business&apos; website.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Website { get; set; }
#nullable restore
#else
        public string Website { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Models.Business_card_holder_update"/> and sets the default values.
        /// </summary>
        public Business_card_holder_update()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Models.Business_card_holder_update"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Marqeta.Core.Sdk.Models.Business_card_holder_update CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Marqeta.Core.Sdk.Models.Business_card_holder_update();
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
                { "attestation_consent", n => { AttestationConsent = n.GetBoolValue(); } },
                { "attestation_date", n => { AttestationDate = n.GetDateTimeOffsetValue(); } },
                { "attester_name", n => { AttesterName = n.GetStringValue(); } },
                { "attester_title", n => { AttesterTitle = n.GetStringValue(); } },
                { "beneficial_owner1", n => { BeneficialOwner1 = n.GetObjectValue<Marqeta.Core.Sdk.Models.Beneficial_owner_request>(Marqeta.Core.Sdk.Models.Beneficial_owner_request.CreateFromDiscriminatorValue); } },
                { "beneficial_owner2", n => { BeneficialOwner2 = n.GetObjectValue<Marqeta.Core.Sdk.Models.Beneficial_owner_request>(Marqeta.Core.Sdk.Models.Beneficial_owner_request.CreateFromDiscriminatorValue); } },
                { "beneficial_owner3", n => { BeneficialOwner3 = n.GetObjectValue<Marqeta.Core.Sdk.Models.Beneficial_owner_request>(Marqeta.Core.Sdk.Models.Beneficial_owner_request.CreateFromDiscriminatorValue); } },
                { "beneficial_owner4", n => { BeneficialOwner4 = n.GetObjectValue<Marqeta.Core.Sdk.Models.Beneficial_owner_request>(Marqeta.Core.Sdk.Models.Beneficial_owner_request.CreateFromDiscriminatorValue); } },
                { "business_name_dba", n => { BusinessNameDba = n.GetStringValue(); } },
                { "business_name_legal", n => { BusinessNameLegal = n.GetStringValue(); } },
                { "business_type", n => { BusinessType = n.GetStringValue(); } },
                { "date_established", n => { DateEstablished = n.GetDateTimeOffsetValue(); } },
                { "duns_number", n => { DunsNumber = n.GetStringValue(); } },
                { "general_business_description", n => { GeneralBusinessDescription = n.GetStringValue(); } },
                { "history", n => { History = n.GetStringValue(); } },
                { "identifications", n => { Identifications = n.GetCollectionOfObjectValues<Marqeta.Core.Sdk.Models.IdentificationRequestModel>(Marqeta.Core.Sdk.Models.IdentificationRequestModel.CreateFromDiscriminatorValue)?.ToList(); } },
                { "in_current_location_since", n => { InCurrentLocationSince = n.GetDateTimeOffsetValue(); } },
                { "incorporation", n => { Incorporation = n.GetObjectValue<Marqeta.Core.Sdk.Models.Business_incorporation>(Marqeta.Core.Sdk.Models.Business_incorporation.CreateFromDiscriminatorValue); } },
                { "international_office_locations", n => { InternationalOfficeLocations = n.GetStringValue(); } },
                { "ip_address", n => { IpAddress = n.GetStringValue(); } },
                { "metadata", n => { Metadata = n.GetObjectValue<Marqeta.Core.Sdk.Models.Business_card_holder_update_metadata>(Marqeta.Core.Sdk.Models.Business_card_holder_update_metadata.CreateFromDiscriminatorValue); } },
                { "notes", n => { Notes = n.GetStringValue(); } },
                { "office_location", n => { OfficeLocation = n.GetObjectValue<Marqeta.Core.Sdk.Models.AddressRequestModel>(Marqeta.Core.Sdk.Models.AddressRequestModel.CreateFromDiscriminatorValue); } },
                { "password", n => { Password = n.GetStringValue(); } },
                { "phone", n => { Phone = n.GetStringValue(); } },
                { "primary_contact", n => { PrimaryContact = n.GetObjectValue<Marqeta.Core.Sdk.Models.PrimaryContactInfoModel>(Marqeta.Core.Sdk.Models.PrimaryContactInfoModel.CreateFromDiscriminatorValue); } },
                { "proprietor_is_beneficial_owner", n => { ProprietorIsBeneficialOwner = n.GetBoolValue(); } },
                { "proprietor_or_officer", n => { ProprietorOrOfficer = n.GetObjectValue<Marqeta.Core.Sdk.Models.Business_proprietor>(Marqeta.Core.Sdk.Models.Business_proprietor.CreateFromDiscriminatorValue); } },
                { "taxpayer_id", n => { TaxpayerId = n.GetStringValue(); } },
                { "token", n => { Token = n.GetStringValue(); } },
                { "website", n => { Website = n.GetStringValue(); } },
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
            writer.WriteBoolValue("attestation_consent", AttestationConsent);
            writer.WriteDateTimeOffsetValue("attestation_date", AttestationDate);
            writer.WriteStringValue("attester_name", AttesterName);
            writer.WriteStringValue("attester_title", AttesterTitle);
            writer.WriteObjectValue<Marqeta.Core.Sdk.Models.Beneficial_owner_request>("beneficial_owner1", BeneficialOwner1);
            writer.WriteObjectValue<Marqeta.Core.Sdk.Models.Beneficial_owner_request>("beneficial_owner2", BeneficialOwner2);
            writer.WriteObjectValue<Marqeta.Core.Sdk.Models.Beneficial_owner_request>("beneficial_owner3", BeneficialOwner3);
            writer.WriteObjectValue<Marqeta.Core.Sdk.Models.Beneficial_owner_request>("beneficial_owner4", BeneficialOwner4);
            writer.WriteStringValue("business_name_dba", BusinessNameDba);
            writer.WriteStringValue("business_name_legal", BusinessNameLegal);
            writer.WriteStringValue("business_type", BusinessType);
            writer.WriteDateTimeOffsetValue("date_established", DateEstablished);
            writer.WriteStringValue("duns_number", DunsNumber);
            writer.WriteStringValue("general_business_description", GeneralBusinessDescription);
            writer.WriteStringValue("history", History);
            writer.WriteCollectionOfObjectValues<Marqeta.Core.Sdk.Models.IdentificationRequestModel>("identifications", Identifications);
            writer.WriteObjectValue<Marqeta.Core.Sdk.Models.Business_incorporation>("incorporation", Incorporation);
            writer.WriteDateTimeOffsetValue("in_current_location_since", InCurrentLocationSince);
            writer.WriteStringValue("international_office_locations", InternationalOfficeLocations);
            writer.WriteStringValue("ip_address", IpAddress);
            writer.WriteObjectValue<Marqeta.Core.Sdk.Models.Business_card_holder_update_metadata>("metadata", Metadata);
            writer.WriteStringValue("notes", Notes);
            writer.WriteObjectValue<Marqeta.Core.Sdk.Models.AddressRequestModel>("office_location", OfficeLocation);
            writer.WriteStringValue("password", Password);
            writer.WriteStringValue("phone", Phone);
            writer.WriteObjectValue<Marqeta.Core.Sdk.Models.PrimaryContactInfoModel>("primary_contact", PrimaryContact);
            writer.WriteBoolValue("proprietor_is_beneficial_owner", ProprietorIsBeneficialOwner);
            writer.WriteObjectValue<Marqeta.Core.Sdk.Models.Business_proprietor>("proprietor_or_officer", ProprietorOrOfficer);
            writer.WriteStringValue("taxpayer_id", TaxpayerId);
            writer.WriteStringValue("token", Token);
            writer.WriteStringValue("website", Website);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
