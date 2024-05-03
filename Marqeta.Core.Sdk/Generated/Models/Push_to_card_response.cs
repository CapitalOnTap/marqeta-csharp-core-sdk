// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    #pragma warning disable CS1591
    public class Push_to_card_response : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The address_1 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Address1 { get; set; }
#nullable restore
#else
        public string Address1 { get; set; }
#endif
        /// <summary>The address_2 property</summary>
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
        /// <summary>The exp_date property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExpDate { get; set; }
#nullable restore
#else
        public string ExpDate { get; set; }
#endif
        /// <summary>The fast_fund_transfer_eligible property</summary>
        public bool? FastFundTransferEligible { get; set; }
        /// <summary>The gambling_fund_transfer_eligible property</summary>
        public bool? GamblingFundTransferEligible { get; set; }
        /// <summary>The last_four property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastFour { get; set; }
#nullable restore
#else
        public string LastFour { get; set; }
#endif
        /// <summary>yyyy-MM-ddTHH:mm:ssZ</summary>
        public DateTimeOffset? LastModifiedTime { get; set; }
        /// <summary>The last_name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastName { get; set; }
#nullable restore
#else
        public string LastName { get; set; }
#endif
        /// <summary>The name_on_card property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NameOnCard { get; set; }
#nullable restore
#else
        public string NameOnCard { get; set; }
#endif
        /// <summary>The postal_code property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PostalCode { get; set; }
#nullable restore
#else
        public string PostalCode { get; set; }
#endif
        /// <summary>The state property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? State { get; set; }
#nullable restore
#else
        public string State { get; set; }
#endif
        /// <summary>The token property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Push_to_card_response"/> and sets the default values.
        /// </summary>
        public Push_to_card_response()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Push_to_card_response"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Push_to_card_response CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Push_to_card_response();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"address_1", n => { Address1 = n.GetStringValue(); } },
                {"address_2", n => { Address2 = n.GetStringValue(); } },
                {"city", n => { City = n.GetStringValue(); } },
                {"country", n => { Country = n.GetStringValue(); } },
                {"created_time", n => { CreatedTime = n.GetDateTimeOffsetValue(); } },
                {"exp_date", n => { ExpDate = n.GetStringValue(); } },
                {"fast_fund_transfer_eligible", n => { FastFundTransferEligible = n.GetBoolValue(); } },
                {"gambling_fund_transfer_eligible", n => { GamblingFundTransferEligible = n.GetBoolValue(); } },
                {"last_four", n => { LastFour = n.GetStringValue(); } },
                {"last_modified_time", n => { LastModifiedTime = n.GetDateTimeOffsetValue(); } },
                {"last_name", n => { LastName = n.GetStringValue(); } },
                {"name_on_card", n => { NameOnCard = n.GetStringValue(); } },
                {"postal_code", n => { PostalCode = n.GetStringValue(); } },
                {"state", n => { State = n.GetStringValue(); } },
                {"token", n => { Token = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("address_1", Address1);
            writer.WriteStringValue("address_2", Address2);
            writer.WriteStringValue("city", City);
            writer.WriteStringValue("country", Country);
            writer.WriteDateTimeOffsetValue("created_time", CreatedTime);
            writer.WriteStringValue("exp_date", ExpDate);
            writer.WriteBoolValue("fast_fund_transfer_eligible", FastFundTransferEligible);
            writer.WriteBoolValue("gambling_fund_transfer_eligible", GamblingFundTransferEligible);
            writer.WriteStringValue("last_four", LastFour);
            writer.WriteDateTimeOffsetValue("last_modified_time", LastModifiedTime);
            writer.WriteStringValue("last_name", LastName);
            writer.WriteStringValue("name_on_card", NameOnCard);
            writer.WriteStringValue("postal_code", PostalCode);
            writer.WriteStringValue("state", State);
            writer.WriteStringValue("token", Token);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
