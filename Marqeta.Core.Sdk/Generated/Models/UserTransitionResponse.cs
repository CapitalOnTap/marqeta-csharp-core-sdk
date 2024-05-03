// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    #pragma warning disable CS1591
    public class UserTransitionResponse : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Mechanism by which the transaction was initiated.</summary>
        public UserTransitionResponse_channel? Channel { get; set; }
        /// <summary>Date and time when the resource was created, in UTC.</summary>
        public DateTimeOffset? CreatedTime { get; set; }
        /// <summary>Date and time when the resource was last modified, in UTC.</summary>
        public DateTimeOffset? LastModifiedTime { get; set; }
        /// <summary>Additional information about the status change.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Reason { get; set; }
#nullable restore
#else
        public string Reason { get; set; }
#endif
        /// <summary>Identifies the standardized reason for the transition:*00:* Object activated for the first time.*01:* Requested by you.*02:* Inactivity over time.*03:* This address cannot accept mail or the addressee is unknown.*04:* Negative account balance.*05:* Account under review.*06:* Suspicious activity was identified.*07:* Activity outside the program parameters was identified.*08:* Confirmed fraud was identified.*09:* Matched with an Office of Foreign Assets Control list.*10:* Card was reported lost.*11:* Card information was cloned.*12:* Account or card information was compromised.*13:* Temporary status change while on hold/leave.*14:* Initiated by Marqeta.*15:* Initiated by issuer.*16:* Card expired.*17:* Failed KYC.*18:* Changed to `ACTIVE` because information was properly validated.*19:* Changed to `ACTIVE` because account activity was properly validated.*20:* Change occurred prior to the normalization of reason codes.*21:* Initiated by a third party, often a digital wallet provider.*22:* PIN retry limit reached.*23:* Card was reported stolen.*24:* Address issue.*25:* Name issue.*26:* SSN issue.*27:* DOB issue.*28:* Email issue.*29:* Phone issue.*30:* Account/fulfillment mismatch.*31:* Other reason.</summary>
        public UserTransitionResponse_reason_code? ReasonCode { get; set; }
        /// <summary>Specifies the new status of the user.</summary>
        public UserTransitionResponse_status? Status { get; set; }
        /// <summary>Unique identifier of the user transition.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>Unique identifier of the user whose status was transitioned.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserToken { get; set; }
#nullable restore
#else
        public string UserToken { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="UserTransitionResponse"/> and sets the default values.
        /// </summary>
        public UserTransitionResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="UserTransitionResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UserTransitionResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserTransitionResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"channel", n => { Channel = n.GetEnumValue<UserTransitionResponse_channel>(); } },
                {"created_time", n => { CreatedTime = n.GetDateTimeOffsetValue(); } },
                {"last_modified_time", n => { LastModifiedTime = n.GetDateTimeOffsetValue(); } },
                {"reason", n => { Reason = n.GetStringValue(); } },
                {"reason_code", n => { ReasonCode = n.GetEnumValue<UserTransitionResponse_reason_code>(); } },
                {"status", n => { Status = n.GetEnumValue<UserTransitionResponse_status>(); } },
                {"token", n => { Token = n.GetStringValue(); } },
                {"user_token", n => { UserToken = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<UserTransitionResponse_channel>("channel", Channel);
            writer.WriteDateTimeOffsetValue("created_time", CreatedTime);
            writer.WriteDateTimeOffsetValue("last_modified_time", LastModifiedTime);
            writer.WriteStringValue("reason", Reason);
            writer.WriteEnumValue<UserTransitionResponse_reason_code>("reason_code", ReasonCode);
            writer.WriteEnumValue<UserTransitionResponse_status>("status", Status);
            writer.WriteStringValue("token", Token);
            writer.WriteStringValue("user_token", UserToken);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
