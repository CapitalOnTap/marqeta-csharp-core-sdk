// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Marqeta.Core.Sdk.Models
{
    /// <summary>
    /// Contains information relevant for updating configurations for electronic disclosures, fees, payment holds, and minimum payment.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class AccountConfigUpdateReq : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A value of `true` indicates that the account holder consents to receiving disclosures and statements electronically.</summary>
        public bool? EDisclosureActive { get; set; }
        /// <summary>Contains one or more fees associated with the credit account.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Marqeta.Core.Sdk.Models.ConfigFeeScheduleReq>? Fees { get; set; }
#nullable restore
#else
        public List<global::Marqeta.Core.Sdk.Models.ConfigFeeScheduleReq> Fees { get; set; }
#endif
        /// <summary>Contains configurations for a minimum payment override on a credit account, which overrides the minimum payment configurations on the associated credit product.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.Models.AccountConfigMinPayment? MinPayment { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.AccountConfigMinPayment MinPayment { get; set; }
#endif
        /// <summary>Contains configurations for a payment hold.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.Models.AccountConfigPaymentHolds? PaymentHolds { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.AccountConfigPaymentHolds PaymentHolds { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.AccountConfigUpdateReq"/> and sets the default values.
        /// </summary>
        public AccountConfigUpdateReq()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.AccountConfigUpdateReq"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.AccountConfigUpdateReq CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.AccountConfigUpdateReq();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "e_disclosure_active", n => { EDisclosureActive = n.GetBoolValue(); } },
                { "fees", n => { Fees = n.GetCollectionOfObjectValues<global::Marqeta.Core.Sdk.Models.ConfigFeeScheduleReq>(global::Marqeta.Core.Sdk.Models.ConfigFeeScheduleReq.CreateFromDiscriminatorValue)?.AsList(); } },
                { "min_payment", n => { MinPayment = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.AccountConfigMinPayment>(global::Marqeta.Core.Sdk.Models.AccountConfigMinPayment.CreateFromDiscriminatorValue); } },
                { "payment_holds", n => { PaymentHolds = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.AccountConfigPaymentHolds>(global::Marqeta.Core.Sdk.Models.AccountConfigPaymentHolds.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("e_disclosure_active", EDisclosureActive);
            writer.WriteCollectionOfObjectValues<global::Marqeta.Core.Sdk.Models.ConfigFeeScheduleReq>("fees", Fees);
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.AccountConfigMinPayment>("min_payment", MinPayment);
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.AccountConfigPaymentHolds>("payment_holds", PaymentHolds);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
