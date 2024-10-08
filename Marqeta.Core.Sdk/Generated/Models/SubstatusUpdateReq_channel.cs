// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Marqeta.Core.Sdk.Models
{
    /// <summary>The channel through which deactivation is occurring:- **ADMIN**: Added through the Marqeta Dashboard.- **API**: Initiated through the Core API.- **FRAUD**: Determined by Marqeta or the card network.- **SYSTEM**: Initiated by Marqeta</summary>
    public enum SubstatusUpdateReq_channel
    {
        [EnumMember(Value = "ADMIN")]
        #pragma warning disable CS1591
        ADMIN,
        #pragma warning restore CS1591
        [EnumMember(Value = "API")]
        #pragma warning disable CS1591
        API,
        #pragma warning restore CS1591
        [EnumMember(Value = "FRAUD")]
        #pragma warning disable CS1591
        FRAUD,
        #pragma warning restore CS1591
        [EnumMember(Value = "SYSTEM")]
        #pragma warning disable CS1591
        SYSTEM,
        #pragma warning restore CS1591
    }
}
