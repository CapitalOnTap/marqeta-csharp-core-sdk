// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    #pragma warning disable CS1591
    public class Direct_deposit_account_request : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The allow_immediate_credit property</summary>
        public bool? AllowImmediateCredit { get; set; }
        /// <summary>Required if &apos;user_token&apos; is null</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BusinessToken { get; set; }
#nullable restore
#else
        public string BusinessToken { get; set; }
#endif
        /// <summary>Required if account type = Checking</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Customer_due_diligence_request>? CustomerDueDiligence { get; set; }
#nullable restore
#else
        public List<Customer_due_diligence_request> CustomerDueDiligence { get; set; }
#endif
        /// <summary>The token property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>The type property</summary>
        public Direct_deposit_account_request_type? Type { get; set; }
        /// <summary>Required if &apos;business_token&apos; is null</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserToken { get; set; }
#nullable restore
#else
        public string UserToken { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Direct_deposit_account_request"/> and sets the default values.
        /// </summary>
        public Direct_deposit_account_request()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Direct_deposit_account_request"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Direct_deposit_account_request CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Direct_deposit_account_request();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"allow_immediate_credit", n => { AllowImmediateCredit = n.GetBoolValue(); } },
                {"business_token", n => { BusinessToken = n.GetStringValue(); } },
                {"customer_due_diligence", n => { CustomerDueDiligence = n.GetCollectionOfObjectValues<Customer_due_diligence_request>(Customer_due_diligence_request.CreateFromDiscriminatorValue)?.ToList(); } },
                {"token", n => { Token = n.GetStringValue(); } },
                {"type", n => { Type = n.GetEnumValue<Direct_deposit_account_request_type>(); } },
                {"user_token", n => { UserToken = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allow_immediate_credit", AllowImmediateCredit);
            writer.WriteStringValue("business_token", BusinessToken);
            writer.WriteCollectionOfObjectValues<Customer_due_diligence_request>("customer_due_diligence", CustomerDueDiligence);
            writer.WriteStringValue("token", Token);
            writer.WriteEnumValue<Direct_deposit_account_request_type>("type", Type);
            writer.WriteStringValue("user_token", UserToken);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
