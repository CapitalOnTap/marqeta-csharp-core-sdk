// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    public class RewardProgramsRulesConfigsResponse : IAdditionalDataHolder, IParsable {
        /// <summary>Type of reward accrued.</summary>
        public Marqeta.Core.Sdk.Models.AccrualType? AccrualType { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Date and time when the reward rules config was created on the Marqeta platform, in UTC.</summary>
        public DateTimeOffset? CreatedTime { get; set; }
        /// <summary>Minimum amount that the balance for a billing cycle can be to apply the specified reward percentage.For example, if the `greater_than` value is `500`, the account holder earns _x_% of the account balance if they spend over $500 during a billing cycle.</summary>
        public decimal? GreaterThan { get; set; }
        /// <summary>A value of `true` indicates that the reward rules config is active.</summary>
        public bool? IsActive { get; set; }
        /// <summary>Maximum amount that the balance for a billing cycle can be to apply the specified reward percentage.For example, if the `less_than` value is `1500`, the account holder earns _x_% of the account balance if they spend under $1500 during a billing cycle.</summary>
        public decimal? LessThan { get; set; }
        /// <summary>The reward percentage applied when the balance for a billing cycle is within the range specified in the `less_than` and `greater_than` fields.For example, if the `percentage` is `1`, the account holder earns 1% of the account balance if they spend between the `less_than` and `greater_than` amounts during a billing cycle.</summary>
        public int? Percentage { get; set; }
        /// <summary>Unique identifier of the reward program on which the rules config is applied.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RewardProgramToken { get; set; }
#nullable restore
#else
        public string RewardProgramToken { get; set; }
#endif
        /// <summary>Unique identifier of the reward rules config.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>Date and time when the reward rules config was last updated on the Marqeta platform, in UTC.</summary>
        public DateTimeOffset? UpdatedTime { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="RewardProgramsRulesConfigsResponse"/> and sets the default values.
        /// </summary>
        public RewardProgramsRulesConfigsResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="RewardProgramsRulesConfigsResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static RewardProgramsRulesConfigsResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RewardProgramsRulesConfigsResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"accrual_type", n => { AccrualType = n.GetEnumValue<AccrualType>(); } },
                {"created_time", n => { CreatedTime = n.GetDateTimeOffsetValue(); } },
                {"greater_than", n => { GreaterThan = n.GetDecimalValue(); } },
                {"is_active", n => { IsActive = n.GetBoolValue(); } },
                {"less_than", n => { LessThan = n.GetDecimalValue(); } },
                {"percentage", n => { Percentage = n.GetIntValue(); } },
                {"reward_program_token", n => { RewardProgramToken = n.GetStringValue(); } },
                {"token", n => { Token = n.GetStringValue(); } },
                {"updated_time", n => { UpdatedTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<AccrualType>("accrual_type", AccrualType);
            writer.WriteDateTimeOffsetValue("created_time", CreatedTime);
            writer.WriteDecimalValue("greater_than", GreaterThan);
            writer.WriteBoolValue("is_active", IsActive);
            writer.WriteDecimalValue("less_than", LessThan);
            writer.WriteIntValue("percentage", Percentage);
            writer.WriteStringValue("reward_program_token", RewardProgramToken);
            writer.WriteStringValue("token", Token);
            writer.WriteDateTimeOffsetValue("updated_time", UpdatedTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}