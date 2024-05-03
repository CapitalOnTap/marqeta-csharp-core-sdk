// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    /// <summary>
    /// Contains information on statement rewards.
    /// </summary>
    public class StatementReward : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Date and time when the statement reward was created on Marqeta&apos;s credit platform, in UTC.</summary>
        public DateTimeOffset? CreatedTime { get; set; }
        /// <summary>Amount of rewards received in the current billing cycle.</summary>
        public double? CurrentBillingCycleReward { get; set; }
        /// <summary>Amount of rewards received in the previous billing cycle.</summary>
        public double? PreviousBillingCycleReward { get; set; }
        /// <summary>Unique identifier of the rewards for a specific statement.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="StatementReward"/> and sets the default values.
        /// </summary>
        public StatementReward()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="StatementReward"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static StatementReward CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new StatementReward();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"created_time", n => { CreatedTime = n.GetDateTimeOffsetValue(); } },
                {"current_billing_cycle_reward", n => { CurrentBillingCycleReward = n.GetDoubleValue(); } },
                {"previous_billing_cycle_reward", n => { PreviousBillingCycleReward = n.GetDoubleValue(); } },
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
            writer.WriteDateTimeOffsetValue("created_time", CreatedTime);
            writer.WriteDoubleValue("current_billing_cycle_reward", CurrentBillingCycleReward);
            writer.WriteDoubleValue("previous_billing_cycle_reward", PreviousBillingCycleReward);
            writer.WriteStringValue("token", Token);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
