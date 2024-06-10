// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Marqeta.Core.Sdk.Models
{
    /// <summary>Status of the credit product.* `DRAFT` - The credit product is in the process of being created.* `PENDING_APPROVAL` - The credit product has been created and is awaiting approval.* `SENT_FOR_REVISION` - The credit product has been returned for revision.* `ACTIVE` - The credit product is active.* `REJECTED` - The credit product has been rejected; this status cannot be changed.* `ARCHIVED` - The previously active credit product has been archived.</summary>
    public enum ResourceStatus
    {
        [EnumMember(Value = "DRAFT")]
        #pragma warning disable CS1591
        DRAFT,
        #pragma warning restore CS1591
        [EnumMember(Value = "PENDING_APPROVAL")]
        #pragma warning disable CS1591
        PENDING_APPROVAL,
        #pragma warning restore CS1591
        [EnumMember(Value = "SENT_FOR_REVISION")]
        #pragma warning disable CS1591
        SENT_FOR_REVISION,
        #pragma warning restore CS1591
        [EnumMember(Value = "ACTIVE")]
        #pragma warning disable CS1591
        ACTIVE,
        #pragma warning restore CS1591
        [EnumMember(Value = "REJECTED")]
        #pragma warning disable CS1591
        REJECTED,
        #pragma warning restore CS1591
        [EnumMember(Value = "ARCHIVED")]
        #pragma warning disable CS1591
        ARCHIVED,
        #pragma warning restore CS1591
    }
}
