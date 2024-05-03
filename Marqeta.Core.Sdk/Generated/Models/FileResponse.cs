// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    #pragma warning disable CS1591
    public class FileResponse : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Type of file.* `SOCT` - The Summary of Credit Terms (SOCT), which outlines the interest rates, interest charges, and fees associated with the credit account being offered to the user.* `REWARDS_DISCLOSURE_PRE_TERMS` - The Rewards Disclosure Pre-terms, which discloses detailed information about the rewards program on the credit account being offered to the user before a decision is rendered on their application.* `REWARDS_DISCLOSURE_POST_TERMS` - The Rewards Disclosure Post-terms, which discloses detailed information about the rewards program on the user&apos;s credit account if their application is approved.* `BENEFITS_DISCLOSURE` - The Benefits Disclosure, which which is given to a user if their application is approved and discloses detailed information about the benefits on the user&apos;s credit account.* `CARD_MEMBER_AGREEMENT` - The Card Member Agreement, which specifies the terms and conditions of the user&apos;s credit account, including the interest rates, interest charges, fees, minimum payment calculations, and more.* `PRIVACY_POLICY` - The Privacy Policy, which explains how the information on the user&apos;s application is collected, handled, and processed.* `E_DISCLOSURE` - The eDisclosure, which states that the user has agreed to receive disclosures electronically.* `TERMS_SCHEDULE` - The Terms Schedule, which is given to a user if their application is approved and specifies the interest rate details on the user&apos;s credit account.* `NOAA` - The Notice of Adverse Action (NOAA), which is given to a user if their application is declined and informs them of the specific reasons why they were denied a credit account.</summary>
        public Marqeta.Core.Sdk.Models.FileType? FileType { get; set; }
        /// <summary>Contains links to the file in different formats.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public FileLinks? Links { get; set; }
#nullable restore
#else
        public FileLinks Links { get; set; }
#endif
        /// <summary>Unique identifier used to acknowledge that the file has been disclosed to the applicant.If the file was already disclosed, a null value is returned.*NOTE*: The tracking token is only valid for 14 calendar days.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TrackingToken { get; set; }
#nullable restore
#else
        public string TrackingToken { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="FileResponse"/> and sets the default values.
        /// </summary>
        public FileResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="FileResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static FileResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new FileResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"file_type", n => { FileType = n.GetEnumValue<FileType>(); } },
                {"links", n => { Links = n.GetObjectValue<FileLinks>(FileLinks.CreateFromDiscriminatorValue); } },
                {"tracking_token", n => { TrackingToken = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<FileType>("file_type", FileType);
            writer.WriteObjectValue<FileLinks>("links", Links);
            writer.WriteStringValue("tracking_token", TrackingToken);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
