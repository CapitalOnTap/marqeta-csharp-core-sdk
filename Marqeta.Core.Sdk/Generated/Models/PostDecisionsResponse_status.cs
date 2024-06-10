// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Marqeta.Core.Sdk.Models
{
    /// <summary>Status of the decision on the application.</summary>
    public enum PostDecisionsResponse_status
    {
        [EnumMember(Value = "SUBMITTED")]
        #pragma warning disable CS1591
        SUBMITTED,
        #pragma warning restore CS1591
        [EnumMember(Value = "DECISIONING")]
        #pragma warning disable CS1591
        DECISIONING,
        #pragma warning restore CS1591
        [EnumMember(Value = "MANUAL_REVIEW")]
        #pragma warning disable CS1591
        MANUAL_REVIEW,
        #pragma warning restore CS1591
        [EnumMember(Value = "APPROVED")]
        #pragma warning disable CS1591
        APPROVED,
        #pragma warning restore CS1591
        [EnumMember(Value = "DECLINED")]
        #pragma warning disable CS1591
        DECLINED,
        #pragma warning restore CS1591
        [EnumMember(Value = "EXPIRED")]
        #pragma warning disable CS1591
        EXPIRED,
        #pragma warning restore CS1591
        [EnumMember(Value = "REJECTED")]
        #pragma warning disable CS1591
        REJECTED,
        #pragma warning restore CS1591
        [EnumMember(Value = "ERROR")]
        #pragma warning disable CS1591
        ERROR,
        #pragma warning restore CS1591
    }
}
