// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Marqeta.Core.Sdk.Models
{
    /// <summary>Type of redemption.* `EXTERNAL` - You issue the redemption on your external platform; Marqeta adjusts the reward program balance on the system of record.* `STATEMENT_CREDIT` - Marqeta issues the redemption as a statement credit on the associated account. +*NOTE*: This creates a new journal entry on the account and cannot be undone.* `ACH` - The reward redemption is issued as an ACH transfer to the receiving account.</summary>
    public enum RedemptionType
    {
        [EnumMember(Value = "EXTERNAL")]
        #pragma warning disable CS1591
        EXTERNAL,
        #pragma warning restore CS1591
        [EnumMember(Value = "STATEMENT_CREDIT")]
        #pragma warning disable CS1591
        STATEMENT_CREDIT,
        #pragma warning restore CS1591
        [EnumMember(Value = "ACH")]
        #pragma warning disable CS1591
        ACH,
        #pragma warning restore CS1591
    }
}
