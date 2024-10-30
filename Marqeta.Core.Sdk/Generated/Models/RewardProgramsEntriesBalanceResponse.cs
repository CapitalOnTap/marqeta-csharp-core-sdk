// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Marqeta.Core.Sdk.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class RewardProgramsEntriesBalanceResponse : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Date and time the reward entries balance was created on the Marqeta platform, in UTC.</summary>
        public DateTimeOffset? CreatedDate { get; set; }
        /// <summary>The ending date (or date-time) of a date range from which to return accrued rewards, in UTC.Reward entries created on or before this date count toward the total reward balance.</summary>
        public DateTimeOffset? EndDate { get; set; }
        /// <summary>Unique identifier of the reward program for which to retrieve the reward entries balance.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RewardProgramToken { get; set; }
#nullable restore
#else
        public string RewardProgramToken { get; set; }
#endif
        /// <summary>The starting date (or date-time) of a date range from which to return accrued rewards, in UTC.Reward entries created on or after this date count toward the total reward balance.</summary>
        public DateTimeOffset? StartDate { get; set; }
        /// <summary>The total balance of rewards accrued within a date range.</summary>
        public decimal? TotalRewardBalance { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.RewardProgramsEntriesBalanceResponse"/> and sets the default values.
        /// </summary>
        public RewardProgramsEntriesBalanceResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.RewardProgramsEntriesBalanceResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.RewardProgramsEntriesBalanceResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.RewardProgramsEntriesBalanceResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "created_date", n => { CreatedDate = n.GetDateTimeOffsetValue(); } },
                { "end_date", n => { EndDate = n.GetDateTimeOffsetValue(); } },
                { "reward_program_token", n => { RewardProgramToken = n.GetStringValue(); } },
                { "start_date", n => { StartDate = n.GetDateTimeOffsetValue(); } },
                { "total_reward_balance", n => { TotalRewardBalance = n.GetDecimalValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("created_date", CreatedDate);
            writer.WriteDateTimeOffsetValue("end_date", EndDate);
            writer.WriteStringValue("reward_program_token", RewardProgramToken);
            writer.WriteDateTimeOffsetValue("start_date", StartDate);
            writer.WriteDecimalValue("total_reward_balance", TotalRewardBalance);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
