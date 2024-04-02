// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    /// <summary>
    /// Contains information about authorization decisions.
    /// </summary>
    public class Selective_auth : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Determines what type of merchant information is required for a match (authorization).Not relevant if `enable_regex_search_chain = false`.* *0* – Requires exact match on card acceptor name and postal code to existing entry in Marqeta Merchant database (most restrictive).* *1* – Partial match on card acceptor name (least restrictive).* *2* – Partial match on card acceptor name; exact match on card acceptor city.* *3* – Partial match on card acceptor name; exact match on card acceptor postal code.* *4* – Partial match on card acceptor name; exact match on street address 1 and postal code.</summary>
        public int? DmdLocationSensitivity { get; set; }
        /// <summary>Set to `true` to perform regular expression checking on the description received in the authorization.</summary>
        public bool? EnableRegexSearchChain { get; set; }
        /// <summary>Specifies the selective authorization mode.* *0* — Inactive* *1* — Active (attempts to authorize a merchant that does not have a recognized MID by matching other pieces of information)* *2* — Logging and notification (checks the transaction and logs results, but does not authorize)Selective authorization applies to transactions that are limited to specific merchants.Matching requirements for authorization are set by the `dmd_location_sensitivity` field.</summary>
        public int? SaMode { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="Selective_auth"/> and sets the default values.
        /// </summary>
        public Selective_auth() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Selective_auth"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Selective_auth CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Selective_auth();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"dmd_location_sensitivity", n => { DmdLocationSensitivity = n.GetIntValue(); } },
                {"enable_regex_search_chain", n => { EnableRegexSearchChain = n.GetBoolValue(); } },
                {"sa_mode", n => { SaMode = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("dmd_location_sensitivity", DmdLocationSensitivity);
            writer.WriteBoolValue("enable_regex_search_chain", EnableRegexSearchChain);
            writer.WriteIntValue("sa_mode", SaMode);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}