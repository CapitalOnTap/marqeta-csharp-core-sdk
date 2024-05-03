// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Marqeta.Core.Sdk.Models {
    /// <summary>Type of adjustment.The adjustment is made on its correlating amount (for example, purchase adjustments are made on purchase amounts).You can use general adjustments for standalone adjustments made on the credit account balance itself, which includes account write-offs, credits, and more.</summary>
    public enum AccountAdjustmentResponse_type
    {
        [EnumMember(Value = "PURCHASE")]
        #pragma warning disable CS1591
        PURCHASE,
        #pragma warning restore CS1591
        [EnumMember(Value = "FEE")]
        #pragma warning disable CS1591
        FEE,
        #pragma warning restore CS1591
        [EnumMember(Value = "REWARD")]
        #pragma warning disable CS1591
        REWARD,
        #pragma warning restore CS1591
        [EnumMember(Value = "INTEREST")]
        #pragma warning disable CS1591
        INTEREST,
        #pragma warning restore CS1591
        [EnumMember(Value = "GENERAL")]
        #pragma warning disable CS1591
        GENERAL,
        #pragma warning restore CS1591
    }
}
