// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    public class PostDecisionsResponse : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Unique identifier of the application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ApplicationToken { get; set; }
#nullable restore
#else
        public string ApplicationToken { get; set; }
#endif
        /// <summary>Unique identifier of the decision made based on the decision model.See `decision_model.status` for the current state of the application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DecisionId { get; set; }
#nullable restore
#else
        public string DecisionId { get; set; }
#endif
        /// <summary>Status of the decision on the application.</summary>
        public PostDecisionsResponse_status? Status { get; set; }
        /// <summary>Date and time when the decision was submitted, in UTC.</summary>
        public DateTimeOffset? SubmittedDateTime { get; set; }
        /// <summary>Unique identifier of the decision model.See `decision_model.status` for the current state of the application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>Unique identifier of the applicant, the user applying for a credit account.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserToken { get; set; }
#nullable restore
#else
        public string UserToken { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="PostDecisionsResponse"/> and sets the default values.
        /// </summary>
        public PostDecisionsResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PostDecisionsResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PostDecisionsResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PostDecisionsResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"application_token", n => { ApplicationToken = n.GetStringValue(); } },
                {"decision_id", n => { DecisionId = n.GetStringValue(); } },
                {"status", n => { Status = n.GetEnumValue<PostDecisionsResponse_status>(); } },
                {"submitted_date_time", n => { SubmittedDateTime = n.GetDateTimeOffsetValue(); } },
                {"token", n => { Token = n.GetStringValue(); } },
                {"user_token", n => { UserToken = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("application_token", ApplicationToken);
            writer.WriteStringValue("decision_id", DecisionId);
            writer.WriteEnumValue<PostDecisionsResponse_status>("status", Status);
            writer.WriteDateTimeOffsetValue("submitted_date_time", SubmittedDateTime);
            writer.WriteStringValue("token", Token);
            writer.WriteStringValue("user_token", UserToken);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}