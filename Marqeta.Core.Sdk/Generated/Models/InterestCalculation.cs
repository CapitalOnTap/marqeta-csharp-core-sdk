// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    /// <summary>
    /// Contains the configurations for interest calculation.
    /// </summary>
    public class InterestCalculation : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Contains information on the cycle type and billing cycle day when credits are applied in the daily balance calculation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Marqeta.Core.Sdk.Models.ApplicationOfCredits? ApplicationOfCredits { get; set; }
#nullable restore
#else
        public Marqeta.Core.Sdk.Models.ApplicationOfCredits ApplicationOfCredits { get; set; }
#endif
        /// <summary>Day-count convention.</summary>
        public InterestCalculation_day_count? DayCount { get; set; }
        /// <summary>One or more transactions that are excluded from current billing period&apos;s interest charge, but included in next.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<InterestCalculation_exclude_tran_types?>? ExcludeTranTypes { get; set; }
#nullable restore
#else
        public List<InterestCalculation_exclude_tran_types?> ExcludeTranTypes { get; set; }
#endif
        /// <summary>Determines the last day of grace period based on which interest charges are calculated.</summary>
        public InterestCalculation_grace_days_application? GraceDaysApplication { get; set; }
        /// <summary>One or more balance types on which interest is applied.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<InterestCalculation_interest_application?>? InterestApplication { get; set; }
#nullable restore
#else
        public List<InterestCalculation_interest_application?> InterestApplication { get; set; }
#endif
        /// <summary>Determines whether to charge or waive interest for the billing period when the balance is paid off.</summary>
        public InterestOnGraceReactivationEnum? InterestOnGraceReactivation { get; set; }
        /// <summary>Method of interest calculation.</summary>
        public InterestCalculation_method? Method { get; set; }
        /// <summary>When interest is applied, this value determines the minimum amount of interest that can be charged.</summary>
        public double? MinimumInterest { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="InterestCalculation"/> and sets the default values.
        /// </summary>
        public InterestCalculation()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="InterestCalculation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static InterestCalculation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InterestCalculation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"application_of_credits", n => { ApplicationOfCredits = n.GetObjectValue<Marqeta.Core.Sdk.Models.ApplicationOfCredits>(Marqeta.Core.Sdk.Models.ApplicationOfCredits.CreateFromDiscriminatorValue); } },
                {"day_count", n => { DayCount = n.GetEnumValue<InterestCalculation_day_count>(); } },
                {"exclude_tran_types", n => { ExcludeTranTypes = n.GetCollectionOfEnumValues<InterestCalculation_exclude_tran_types>()?.ToList(); } },
                {"grace_days_application", n => { GraceDaysApplication = n.GetEnumValue<InterestCalculation_grace_days_application>(); } },
                {"interest_application", n => { InterestApplication = n.GetCollectionOfEnumValues<InterestCalculation_interest_application>()?.ToList(); } },
                {"interest_on_grace_reactivation", n => { InterestOnGraceReactivation = n.GetEnumValue<InterestOnGraceReactivationEnum>(); } },
                {"method", n => { Method = n.GetEnumValue<InterestCalculation_method>(); } },
                {"minimum_interest", n => { MinimumInterest = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Marqeta.Core.Sdk.Models.ApplicationOfCredits>("application_of_credits", ApplicationOfCredits);
            writer.WriteEnumValue<InterestCalculation_day_count>("day_count", DayCount);
            writer.WriteCollectionOfEnumValues<InterestCalculation_exclude_tran_types>("exclude_tran_types", ExcludeTranTypes);
            writer.WriteEnumValue<InterestCalculation_grace_days_application>("grace_days_application", GraceDaysApplication);
            writer.WriteCollectionOfEnumValues<InterestCalculation_interest_application>("interest_application", InterestApplication);
            writer.WriteEnumValue<InterestOnGraceReactivationEnum>("interest_on_grace_reactivation", InterestOnGraceReactivation);
            writer.WriteEnumValue<InterestCalculation_method>("method", Method);
            writer.WriteDoubleValue("minimum_interest", MinimumInterest);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
