// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models
{
    #pragma warning disable CS1591
    public class Auth_control_exempt_mids_response : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Indicates whether the merchant identifier authorization control exception is active.This field is returned if it exists in the resource.</summary>
        public bool? Active { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Defines the group of users to which the velocity control applies.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Marqeta.Core.Sdk.Models.Spend_control_association? Association { get; set; }
#nullable restore
#else
        public Marqeta.Core.Sdk.Models.Spend_control_association Association { get; set; }
#endif
        /// <summary>Date and time when the resource was created, in UTC.This field is returned if it exists in the resource.</summary>
        public DateTimeOffset? Created { get; set; }
        /// <summary>Date and time when the exception ends, in UTC.This field is returned if it exists in the resource.</summary>
        public DateTimeOffset? EndTime { get; set; }
        /// <summary>Date and time when the resource was last updated, in UTC.This field is returned if it exists in the resource.</summary>
        public DateTimeOffset? LastUpdated { get; set; }
        /// <summary>Unique identifier of the merchant group to be exempted.This field is returned if it exists in the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MerchantGroupToken { get; set; }
#nullable restore
#else
        public string MerchantGroupToken { get; set; }
#endif
        /// <summary>Merchant to be exempted.This field is returned if it exists in the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Mid { get; set; }
#nullable restore
#else
        public string Mid { get; set; }
#endif
        /// <summary>Name of the merchant identifier authorization control exemption.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Date and time when the exception starts, in UTC.This field is returned if it exists in the resource.</summary>
        public DateTimeOffset? StartTime { get; set; }
        /// <summary>Unique identifier of the merchant identifier authorization control exemption.This field is always returned.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Models.Auth_control_exempt_mids_response"/> and sets the default values.
        /// </summary>
        public Auth_control_exempt_mids_response()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Models.Auth_control_exempt_mids_response"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Marqeta.Core.Sdk.Models.Auth_control_exempt_mids_response CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Marqeta.Core.Sdk.Models.Auth_control_exempt_mids_response();
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
                { "association", n => { Association = n.GetObjectValue<Marqeta.Core.Sdk.Models.Spend_control_association>(Marqeta.Core.Sdk.Models.Spend_control_association.CreateFromDiscriminatorValue); } },
                { "created", n => { Created = n.GetDateTimeOffsetValue(); } },
                { "end_time", n => { EndTime = n.GetDateTimeOffsetValue(); } },
                { "last_updated", n => { LastUpdated = n.GetDateTimeOffsetValue(); } },
                { "merchant_group_token", n => { MerchantGroupToken = n.GetStringValue(); } },
                { "mid", n => { Mid = n.GetStringValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "start_time", n => { StartTime = n.GetDateTimeOffsetValue(); } },
                { "token", n => { Token = n.GetStringValue(); } },
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
            writer.WriteObjectValue<Marqeta.Core.Sdk.Models.Spend_control_association>("association", Association);
            writer.WriteDateTimeOffsetValue("created", Created);
            writer.WriteDateTimeOffsetValue("end_time", EndTime);
            writer.WriteDateTimeOffsetValue("last_updated", LastUpdated);
            writer.WriteStringValue("merchant_group_token", MerchantGroupToken);
            writer.WriteStringValue("mid", Mid);
            writer.WriteStringValue("name", Name);
            writer.WriteDateTimeOffsetValue("start_time", StartTime);
            writer.WriteStringValue("token", Token);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
