// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models {
    #pragma warning disable CS1591
    public class Commando_mode_response : IAdditionalDataHolder, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Defines program behavior when Commando Mode is enabled.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Commando_mode_enables? CommandoModeEnables { get; set; }
#nullable restore
#else
        public Commando_mode_enables CommandoModeEnables { get; set; }
#endif
        /// <summary>Date and time when the resource was created, in UTC.</summary>
        public DateTimeOffset? CreatedTime { get; set; }
        /// <summary>Describes the Commando Mode control set&apos;s `current_state` object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Commando_mode_nested_transition? CurrentState { get; set; }
#nullable restore
#else
        public Commando_mode_nested_transition CurrentState { get; set; }
#endif
        /// <summary>Date and time when the resource was last updated, in UTC.</summary>
        public DateTimeOffset? LastModifiedTime { get; set; }
        /// <summary>Unique identifier of the associated program gateway funding source.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProgramGatewayFundingSourceToken { get; set; }
#nullable restore
#else
        public string ProgramGatewayFundingSourceToken { get; set; }
#endif
        /// <summary>Specifies which event types automatically enable Commando Mode.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Real_time_standin_criteria? RealTimeStandinCriteria { get; set; }
#nullable restore
#else
        public Real_time_standin_criteria RealTimeStandinCriteria { get; set; }
#endif
        /// <summary>Unique identifier of the Commando Mode control set.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Token { get; set; }
#nullable restore
#else
        public string Token { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Commando_mode_response"/> and sets the default values.
        /// </summary>
        public Commando_mode_response()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Commando_mode_response"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Commando_mode_response CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Commando_mode_response();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"commando_mode_enables", n => { CommandoModeEnables = n.GetObjectValue<Commando_mode_enables>(Commando_mode_enables.CreateFromDiscriminatorValue); } },
                {"created_time", n => { CreatedTime = n.GetDateTimeOffsetValue(); } },
                {"current_state", n => { CurrentState = n.GetObjectValue<Commando_mode_nested_transition>(Commando_mode_nested_transition.CreateFromDiscriminatorValue); } },
                {"last_modified_time", n => { LastModifiedTime = n.GetDateTimeOffsetValue(); } },
                {"program_gateway_funding_source_token", n => { ProgramGatewayFundingSourceToken = n.GetStringValue(); } },
                {"real_time_standin_criteria", n => { RealTimeStandinCriteria = n.GetObjectValue<Real_time_standin_criteria>(Real_time_standin_criteria.CreateFromDiscriminatorValue); } },
                {"token", n => { Token = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Commando_mode_enables>("commando_mode_enables", CommandoModeEnables);
            writer.WriteDateTimeOffsetValue("created_time", CreatedTime);
            writer.WriteObjectValue<Commando_mode_nested_transition>("current_state", CurrentState);
            writer.WriteDateTimeOffsetValue("last_modified_time", LastModifiedTime);
            writer.WriteStringValue("program_gateway_funding_source_token", ProgramGatewayFundingSourceToken);
            writer.WriteObjectValue<Real_time_standin_criteria>("real_time_standin_criteria", RealTimeStandinCriteria);
            writer.WriteStringValue("token", Token);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
