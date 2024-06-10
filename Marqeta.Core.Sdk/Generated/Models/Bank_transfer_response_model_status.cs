// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Marqeta.Core.Sdk.Models
{
    /// <summary>New state of the ACH transfer.</summary>
    public enum Bank_transfer_response_model_status
    {
        [EnumMember(Value = "INITIATED")]
        #pragma warning disable CS1591
        INITIATED,
        #pragma warning restore CS1591
        [EnumMember(Value = "PENDING")]
        #pragma warning disable CS1591
        PENDING,
        #pragma warning restore CS1591
        [EnumMember(Value = "PROCESSING")]
        #pragma warning disable CS1591
        PROCESSING,
        #pragma warning restore CS1591
        [EnumMember(Value = "SUBMITTED")]
        #pragma warning disable CS1591
        SUBMITTED,
        #pragma warning restore CS1591
        [EnumMember(Value = "RETURNED")]
        #pragma warning disable CS1591
        RETURNED,
        #pragma warning restore CS1591
        [EnumMember(Value = "COMPLETED")]
        #pragma warning disable CS1591
        COMPLETED,
        #pragma warning restore CS1591
        [EnumMember(Value = "ERROR")]
        #pragma warning disable CS1591
        ERROR,
        #pragma warning restore CS1591
        [EnumMember(Value = "CANCELLED")]
        #pragma warning disable CS1591
        CANCELLED,
        #pragma warning restore CS1591
        [EnumMember(Value = "REVERSAL_PEND")]
        #pragma warning disable CS1591
        REVERSAL_PEND,
        #pragma warning restore CS1591
        [EnumMember(Value = "REVERSAL_COMP")]
        #pragma warning disable CS1591
        REVERSAL_COMP,
        #pragma warning restore CS1591
        [EnumMember(Value = "REVERSAL_DECL")]
        #pragma warning disable CS1591
        REVERSAL_DECL,
        #pragma warning restore CS1591
    }
}
