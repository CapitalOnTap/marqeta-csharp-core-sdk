// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    /// <summary>
    /// Contains fee configurations on a credit account.
    /// </summary>
    public class AccountFee : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Method, either a flat amount or a percentage.*NOTE:*Only `FLAT` is currently supported.</summary>
        public MethodObject? Method { get; set; }
        /// <summary>Type of fee.*NOTE:*Only `RETURNED_PAYMENT_FEE`, `LATE_PAYMENT_FEE`, `ANNUAL_FEE`, and `MONTHLY_FEE` are currently supported.Do not pass other fees types.</summary>
        public FeeType? Type { get; set; }
        /// <summary>Value of the fee, either a flat fee amount or percentage value.</summary>
        public double? Value { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="AccountFee"/> and sets the default values.
        /// </summary>
        public AccountFee() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AccountFee"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AccountFee CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccountFee();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"method", n => { Method = n.GetEnumValue<MethodObject>(); } },
                {"type", n => { Type = n.GetEnumValue<FeeType>(); } },
                {"value", n => { Value = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<MethodObject>("method", Method);
            writer.WriteEnumValue<FeeType>("type", Type);
            writer.WriteDoubleValue("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
