// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    /// <summary>
    /// Collection of statement files.
    /// </summary>
    public class StatementFile : IAdditionalDataHolder, IParsable {
        /// <summary>Unique identifier of the credit account on which the statement PDF file is generated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountToken { get; set; }
#nullable restore
#else
        public string AccountToken { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Date and time when the statement period ended.</summary>
        public DateTimeOffset? ClosingDate { get; set; }
        /// <summary>Date and time when the statement period began.</summary>
        public DateTimeOffset? OpeningDate { get; set; }
        /// <summary>Signed URL to retrieve the statement PDF file.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SignedUrl { get; set; }
#nullable restore
#else
        public string SignedUrl { get; set; }
#endif
        /// <summary>Unique identifier of the statement summary.</summary>
        public Guid? StatementSummaryToken { get; set; }
        /// <summary>Unique identifier of the statement file.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>Type of file.</summary>
        public StatementFile_type? Type { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="StatementFile"/> and sets the default values.
        /// </summary>
        public StatementFile() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="StatementFile"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static StatementFile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new StatementFile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"account_token", n => { AccountToken = n.GetStringValue(); } },
                {"closing_date", n => { ClosingDate = n.GetDateTimeOffsetValue(); } },
                {"opening_date", n => { OpeningDate = n.GetDateTimeOffsetValue(); } },
                {"signed_url", n => { SignedUrl = n.GetStringValue(); } },
                {"statement_summary_token", n => { StatementSummaryToken = n.GetGuidValue(); } },
                {"token", n => { Token = n.GetStringValue(); } },
                {"type", n => { Type = n.GetEnumValue<StatementFile_type>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("account_token", AccountToken);
            writer.WriteDateTimeOffsetValue("closing_date", ClosingDate);
            writer.WriteDateTimeOffsetValue("opening_date", OpeningDate);
            writer.WriteStringValue("signed_url", SignedUrl);
            writer.WriteGuidValue("statement_summary_token", StatementSummaryToken);
            writer.WriteStringValue("token", Token);
            writer.WriteEnumValue<StatementFile_type>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
