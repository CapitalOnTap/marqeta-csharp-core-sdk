// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    /// <summary>
    /// Response codes and memos for address verification, card security verification, and transactions.
    /// </summary>
    public class Response : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Information about the velocity control applied to the transaction.*NOTE:* This field is returned only in transaction response objects.It is not returned in address verification or card security verification response objects.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AdditionalInformation { get; set; }
#nullable restore
#else
        public string AdditionalInformation { get; set; }
#endif
        /// <summary>Four-digit response code for address verification, card security code verification, or transactions.For address verification responses, the code is an assertion by the Marqeta platform as to whether its address verification data matches that provided by the cardholder:[cols=&quot;2,3,3&quot;]!===! Code ! Address ! Postal Code! 0000! Match! Match! 0001! Match! Unmatched! 0100! Unmatched! Match! 0101! Unmatched! Unmatched! 0200! Data Not Present! Match! 0201! Data Not Present! Unmatched! 0002! Match! Data Not Present! 0102! Unmatched! Data Not Present! 0303! Not Validated! Not Validated!===For card security verification, the code indicates whether the verification check passed and can have these possible values:* 0000 – passed* 0001 – did not passFor a transaction, the code describes the outcome of the attempted transaction.For the full list of transaction codes, see &lt;&lt;/developer-guides/about-transactions#_transaction_response_codes, Transaction response codes&gt;&gt;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Code { get; set; }
#nullable restore
#else
        public string Code { get; set; }
#endif
        /// <summary>Additional text that describes the response.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Memo { get; set; }
#nullable restore
#else
        public string Memo { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Response"/> and sets the default values.
        /// </summary>
        public Response() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Response"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Response CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Response();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"additional_information", n => { AdditionalInformation = n.GetStringValue(); } },
                {"code", n => { Code = n.GetStringValue(); } },
                {"memo", n => { Memo = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("additional_information", AdditionalInformation);
            writer.WriteStringValue("code", Code);
            writer.WriteStringValue("memo", Memo);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
