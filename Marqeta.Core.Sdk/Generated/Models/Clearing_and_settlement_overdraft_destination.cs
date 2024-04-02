// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Marqeta.Core.Sdk.Models {
    /// <summary>Specifies the destination for overdraft funds.This field does not apply if JIT Funding is enabled.</summary>
    public enum Clearing_and_settlement_overdraft_destination {
        [EnumMember(Value = "GPA")]
        GPA,
        [EnumMember(Value = "MSA")]
        MSA,
        [EnumMember(Value = "MERCHANT_CAMPAIGN_ACCOUNT")]
        MERCHANT_CAMPAIGN_ACCOUNT,
        [EnumMember(Value = "GLOBAL_OVERDRAFT_ACCOUNT")]
        GLOBAL_OVERDRAFT_ACCOUNT,
    }
}
