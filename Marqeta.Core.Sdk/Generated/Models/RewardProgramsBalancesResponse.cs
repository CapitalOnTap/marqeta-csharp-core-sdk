// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    #pragma warning disable CS1591
    public class RewardProgramsBalancesResponse : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Closing date of the billing cycle for which rewards were accrued, in UTC.</summary>
        public DateTimeOffset? BillingCycleClosingDate { get; set; }
        /// <summary>Opening date of the billing cycle for which rewards were accrued, in UTC.</summary>
        public DateTimeOffset? BillingCycleOpeningDate { get; set; }
        /// <summary>The net balance for a billing cycle, which is total amount spent during a billing cycle, minus any refunds or reversals.Used to determine reward accrual.</summary>
        public decimal? NetBalance { get; set; }
        /// <summary>The pending balance of the rewards accrued for the current billing cycle.Pending rewards cannot be redeemed.</summary>
        public decimal? PendingRewardBalance { get; set; }
        /// <summary>The reward percentage applied to the balance for the current billing cycle.Determined by the reward rules config.</summary>
        public decimal? Percentage { get; set; }
        /// <summary>Unique identifier of reward program for which to return balances.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RewardProgramToken { get; set; }
#nullable restore
#else
        public string RewardProgramToken { get; set; }
#endif
        /// <summary>The total balance of the rewards accrued to date minus the rewards redeemed to date.</summary>
        public decimal? TotalRewardBalance { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="RewardProgramsBalancesResponse"/> and sets the default values.
        /// </summary>
        public RewardProgramsBalancesResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="RewardProgramsBalancesResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static RewardProgramsBalancesResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RewardProgramsBalancesResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"billing_cycle_closing_date", n => { BillingCycleClosingDate = n.GetDateTimeOffsetValue(); } },
                {"billing_cycle_opening_date", n => { BillingCycleOpeningDate = n.GetDateTimeOffsetValue(); } },
                {"net_balance", n => { NetBalance = n.GetDecimalValue(); } },
                {"pending_reward_balance", n => { PendingRewardBalance = n.GetDecimalValue(); } },
                {"percentage", n => { Percentage = n.GetDecimalValue(); } },
                {"reward_program_token", n => { RewardProgramToken = n.GetStringValue(); } },
                {"total_reward_balance", n => { TotalRewardBalance = n.GetDecimalValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("billing_cycle_closing_date", BillingCycleClosingDate);
            writer.WriteDateTimeOffsetValue("billing_cycle_opening_date", BillingCycleOpeningDate);
            writer.WriteDecimalValue("net_balance", NetBalance);
            writer.WriteDecimalValue("pending_reward_balance", PendingRewardBalance);
            writer.WriteDecimalValue("percentage", Percentage);
            writer.WriteStringValue("reward_program_token", RewardProgramToken);
            writer.WriteDecimalValue("total_reward_balance", TotalRewardBalance);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
