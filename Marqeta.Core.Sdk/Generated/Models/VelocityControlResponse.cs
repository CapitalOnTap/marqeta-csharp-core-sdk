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
    public partial class VelocityControlResponse : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Indicates whether the velocity control is active.</summary>
        public bool? Active { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Maximum monetary sum that can be cleared within the time period defined by velocity period.</summary>
        public double? AmountLimit { get; set; }
        /// <summary>Defines to which the velocity control applies.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.Models.Association? Association { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.Association Association { get; set; }
#endif
        /// <summary>Three-character ISO 4217 currency code.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CurrencyCode { get; set; }
#nullable restore
#else
        public string CurrencyCode { get; set; }
#endif
        /// <summary>Defines the group of merchants to which the velocity control applies.If no fields are populated, the velocity control applies to all merchants.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Marqeta.Core.Sdk.Models.MerchantScope? MerchantScope { get; set; }
#nullable restore
#else
        public global::Marqeta.Core.Sdk.Models.MerchantScope MerchantScope { get; set; }
#endif
        /// <summary>Description of how the velocity control restricts spending.For example, &quot;Max spend of $500 per day&quot; or &quot;Max spend of $5000 per month for non-exempt employees&quot;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Unique identifier of the velocity control.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>Maximum number of times a card can be used within the time period defined by the `velocity_window` field.Leave `null` to indicate that the card can be used an unlimited number of times.</summary>
        public int? UsageLimit { get; set; }
        /// <summary>Defines the time period to which the `amount_limit` and `usage_limit` fields apply:* *MONTH* – one month; months begin on the first day of month at 00:00:00 ET.</summary>
        public global::Marqeta.Core.Sdk.Models.VelocityWindow? VelocityWindow { get; set; }
        /// <summary>Start day of the velocity window defined by the `velocity_window` field.Default value is `1`</summary>
        public int? VelocityWindowStartDay { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Models.VelocityControlResponse"/> and sets the default values.
        /// </summary>
        public VelocityControlResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.VelocityControlResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Marqeta.Core.Sdk.Models.VelocityControlResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Marqeta.Core.Sdk.Models.VelocityControlResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "active", n => { Active = n.GetBoolValue(); } },
                { "amount_limit", n => { AmountLimit = n.GetDoubleValue(); } },
                { "association", n => { Association = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.Association>(global::Marqeta.Core.Sdk.Models.Association.CreateFromDiscriminatorValue); } },
                { "currency_code", n => { CurrencyCode = n.GetStringValue(); } },
                { "merchant_scope", n => { MerchantScope = n.GetObjectValue<global::Marqeta.Core.Sdk.Models.MerchantScope>(global::Marqeta.Core.Sdk.Models.MerchantScope.CreateFromDiscriminatorValue); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "token", n => { Token = n.GetStringValue(); } },
                { "usage_limit", n => { UsageLimit = n.GetIntValue(); } },
                { "velocity_window", n => { VelocityWindow = n.GetEnumValue<global::Marqeta.Core.Sdk.Models.VelocityWindow>(); } },
                { "velocity_window_start_day", n => { VelocityWindowStartDay = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("active", Active);
            writer.WriteDoubleValue("amount_limit", AmountLimit);
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.Association>("association", Association);
            writer.WriteStringValue("currency_code", CurrencyCode);
            writer.WriteObjectValue<global::Marqeta.Core.Sdk.Models.MerchantScope>("merchant_scope", MerchantScope);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("token", Token);
            writer.WriteIntValue("usage_limit", UsageLimit);
            writer.WriteEnumValue<global::Marqeta.Core.Sdk.Models.VelocityWindow>("velocity_window", VelocityWindow);
            writer.WriteIntValue("velocity_window_start_day", VelocityWindowStartDay);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
