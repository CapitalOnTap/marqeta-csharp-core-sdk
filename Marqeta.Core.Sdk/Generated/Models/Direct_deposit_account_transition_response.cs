// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models
{
    #pragma warning disable CS1591
    public class Direct_deposit_account_transition_response : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The account_token property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountToken { get; set; }
#nullable restore
#else
        public string AccountToken { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The business_token property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BusinessToken { get; set; }
#nullable restore
#else
        public string BusinessToken { get; set; }
#endif
        /// <summary>The channel property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Channel { get; set; }
#nullable restore
#else
        public string Channel { get; set; }
#endif
        /// <summary>yyyy-MM-ddTHH:mm:ssZ</summary>
        public DateTimeOffset? CreatedTime { get; set; }
        /// <summary>The reason property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Reason { get; set; }
#nullable restore
#else
        public string Reason { get; set; }
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
        /// <summary>The user_token property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserToken { get; set; }
#nullable restore
#else
        public string UserToken { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Models.Direct_deposit_account_transition_response"/> and sets the default values.
        /// </summary>
        public Direct_deposit_account_transition_response()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Models.Direct_deposit_account_transition_response"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Marqeta.Core.Sdk.Models.Direct_deposit_account_transition_response CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Marqeta.Core.Sdk.Models.Direct_deposit_account_transition_response();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "account_token", n => { AccountToken = n.GetStringValue(); } },
                { "business_token", n => { BusinessToken = n.GetStringValue(); } },
                { "channel", n => { Channel = n.GetStringValue(); } },
                { "created_time", n => { CreatedTime = n.GetDateTimeOffsetValue(); } },
                { "reason", n => { Reason = n.GetStringValue(); } },
                { "state", n => { State = n.GetStringValue(); } },
                { "token", n => { Token = n.GetStringValue(); } },
                { "user_token", n => { UserToken = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("account_token", AccountToken);
            writer.WriteStringValue("business_token", BusinessToken);
            writer.WriteStringValue("channel", Channel);
            writer.WriteDateTimeOffsetValue("created_time", CreatedTime);
            writer.WriteStringValue("reason", Reason);
            writer.WriteStringValue("state", State);
            writer.WriteStringValue("token", Token);
            writer.WriteStringValue("user_token", UserToken);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
