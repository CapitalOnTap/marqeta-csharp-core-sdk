// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    /// <summary>
    /// Contains information on the decision model returned by the issuing bank if a decision has been rendered.Returned when retrieving an application after a decision has been rendered.
    /// </summary>
    public class DecisionsResponse : PostDecisionsResponse, IParsable 
    {
        /// <summary>Indicates the version of the Notice of Adverse Action (NOAA) template used.Can have these possible values:* `AA0` - score denial with score disclosure* `AA1` - individual reason with score disclosure* `AA2` - individual reason without score disclosure* `AA3` - locked and frozen* `AA4` - fraud related</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AdverseActionTemplateCode { get; set; }
#nullable restore
#else
        public string AdverseActionTemplateCode { get; set; }
#endif
        /// <summary>The tier of the card product.</summary>
        public DecisionsResponse_card_product_level? CardProductLevel { get; set; }
        /// <summary>Date and time when the decision model was created on the Marqeta platform, in UTC.</summary>
        public DateTimeOffset? CreatedDate { get; set; }
        /// <summary>Contains information on the credit bureau.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Marqeta.Core.Sdk.Models.CreditBureau? CreditBureau { get; set; }
#nullable restore
#else
        public Marqeta.Core.Sdk.Models.CreditBureau CreditBureau { get; set; }
#endif
        /// <summary>The maximum line of credit extended to the user, also the maximum balance the credit account can carry.</summary>
        public int? CreditLimit { get; set; }
        /// <summary>The user&apos;s credit score.</summary>
        public int? CreditScore { get; set; }
        /// <summary>Date and time when the credit score went into effect.</summary>
        public Date? CreditScoreDate { get; set; }
        /// <summary>Date and time when the decision on the application was rendered, in UTC.</summary>
        public DateTimeOffset? DecisionDate { get; set; }
        /// <summary>An array of reasons that explain why the application was declined.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DenialReasons { get; set; }
#nullable restore
#else
        public List<string> DenialReasons { get; set; }
#endif
        /// <summary>Date when the decision model expires.</summary>
        public Date? ExpireDate { get; set; }
        /// <summary>Number of percentage points added to the prime rate, used to calculate the purchase APR.</summary>
        public decimal? Margin { get; set; }
        /// <summary>The current prime rate set by the Fed.</summary>
        public decimal? PrimeRate { get; set; }
        /// <summary>The purchase APR approved for the user.</summary>
        public decimal? PurchaseApr { get; set; }
        /// <summary>A value of `true` indicates that the user received the credit product&apos;s best APR.If `false`, you must display to the user the following: `score_factors`, `credit_score`, `credit_score_date`, `credit_bureau`, `score_range`.</summary>
        public bool? ReceivedBestRate { get; set; }
        /// <summary>Factors that the bureau used to determine the user&apos;s credit score.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ScoreFactors { get; set; }
#nullable restore
#else
        public List<string> ScoreFactors { get; set; }
#endif
        /// <summary>The range in which the user&apos;s credit score falls.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ScoreRange { get; set; }
#nullable restore
#else
        public string ScoreRange { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DecisionsResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DecisionsResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DecisionsResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"adverse_action_template_code", n => { AdverseActionTemplateCode = n.GetStringValue(); } },
                {"card_product_level", n => { CardProductLevel = n.GetEnumValue<DecisionsResponse_card_product_level>(); } },
                {"created_date", n => { CreatedDate = n.GetDateTimeOffsetValue(); } },
                {"credit_bureau", n => { CreditBureau = n.GetObjectValue<Marqeta.Core.Sdk.Models.CreditBureau>(Marqeta.Core.Sdk.Models.CreditBureau.CreateFromDiscriminatorValue); } },
                {"credit_limit", n => { CreditLimit = n.GetIntValue(); } },
                {"credit_score", n => { CreditScore = n.GetIntValue(); } },
                {"credit_score_date", n => { CreditScoreDate = n.GetDateValue(); } },
                {"decision_date", n => { DecisionDate = n.GetDateTimeOffsetValue(); } },
                {"denial_reasons", n => { DenialReasons = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"expire_date", n => { ExpireDate = n.GetDateValue(); } },
                {"margin", n => { Margin = n.GetDecimalValue(); } },
                {"prime_rate", n => { PrimeRate = n.GetDecimalValue(); } },
                {"purchase_apr", n => { PurchaseApr = n.GetDecimalValue(); } },
                {"received_best_rate", n => { ReceivedBestRate = n.GetBoolValue(); } },
                {"score_factors", n => { ScoreFactors = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"score_range", n => { ScoreRange = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("adverse_action_template_code", AdverseActionTemplateCode);
            writer.WriteEnumValue<DecisionsResponse_card_product_level>("card_product_level", CardProductLevel);
            writer.WriteDateTimeOffsetValue("created_date", CreatedDate);
            writer.WriteObjectValue<Marqeta.Core.Sdk.Models.CreditBureau>("credit_bureau", CreditBureau);
            writer.WriteIntValue("credit_limit", CreditLimit);
            writer.WriteIntValue("credit_score", CreditScore);
            writer.WriteDateValue("credit_score_date", CreditScoreDate);
            writer.WriteDateTimeOffsetValue("decision_date", DecisionDate);
            writer.WriteCollectionOfPrimitiveValues<string>("denial_reasons", DenialReasons);
            writer.WriteDateValue("expire_date", ExpireDate);
            writer.WriteDecimalValue("margin", Margin);
            writer.WriteDecimalValue("prime_rate", PrimeRate);
            writer.WriteDecimalValue("purchase_apr", PurchaseApr);
            writer.WriteBoolValue("received_best_rate", ReceivedBestRate);
            writer.WriteCollectionOfPrimitiveValues<string>("score_factors", ScoreFactors);
            writer.WriteStringValue("score_range", ScoreRange);
        }
    }
}
