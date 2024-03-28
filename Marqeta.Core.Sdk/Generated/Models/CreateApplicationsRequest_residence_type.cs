// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Marqeta.Core.Sdk.Models {
    /// <summary>Whether the user owns or rents their residence, or has another situation.Required when retrieving an application.</summary>
    public enum CreateApplicationsRequest_residence_type {
        [EnumMember(Value = "OWN")]
        OWN,
        [EnumMember(Value = "RENT")]
        RENT,
        [EnumMember(Value = "OTHER")]
        OTHER,
    }
}
