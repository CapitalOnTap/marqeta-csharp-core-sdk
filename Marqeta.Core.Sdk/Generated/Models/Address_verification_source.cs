// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    /// <summary>
    /// Contains address verification data consisting of address data entered by the cardholder, address data held by the Marqeta platform, and an assertion by the Marqeta platform as to whether the two sets of data match.
    /// </summary>
    public class Address_verification_source : IAdditionalDataHolder, IParsable 
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Contains address verification information.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Avs_information? OnFile { get; set; }
#nullable restore
#else
        public Avs_information OnFile { get; set; }
#endif
        /// <summary>Response codes and memos for account name verification, address verification, card security verification, and transactions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Marqeta.Core.Sdk.Models.Response? Response { get; set; }
#nullable restore
#else
        public Marqeta.Core.Sdk.Models.Response Response { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Address_verification_source"/> and sets the default values.
        /// </summary>
        public Address_verification_source()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Address_verification_source"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Address_verification_source CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Address_verification_source();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"on_file", n => { OnFile = n.GetObjectValue<Avs_information>(Avs_information.CreateFromDiscriminatorValue); } },
                {"response", n => { Response = n.GetObjectValue<Marqeta.Core.Sdk.Models.Response>(Marqeta.Core.Sdk.Models.Response.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Avs_information>("on_file", OnFile);
            writer.WriteObjectValue<Marqeta.Core.Sdk.Models.Response>("response", Response);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
