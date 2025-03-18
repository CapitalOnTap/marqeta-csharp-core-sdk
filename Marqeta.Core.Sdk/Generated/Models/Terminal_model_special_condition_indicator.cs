// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Marqeta.Core.Sdk.Models
{
    /// <summary>Indicates a higher-risk operation, such as a quasi-cash or cryptocurrency transaction.These transactions typically involve non-financial institutions.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum Terminal_model_special_condition_indicator
    {
        [EnumMember(Value = "UNSPECIFIED")]
        #pragma warning disable CS1591
        UNSPECIFIED,
        #pragma warning restore CS1591
        [EnumMember(Value = "CRYPTOCURRENCY_PURCHASE")]
        #pragma warning disable CS1591
        CRYPTOCURRENCY_PURCHASE,
        #pragma warning restore CS1591
        [EnumMember(Value = "QUASI_CASH")]
        #pragma warning disable CS1591
        QUASI_CASH,
        #pragma warning restore CS1591
        [EnumMember(Value = "DEBT_PAYMENT")]
        #pragma warning disable CS1591
        DEBT_PAYMENT,
        #pragma warning restore CS1591
        [EnumMember(Value = "CENTRAL_BANK_DIGITAL_CURRENCY_PURCHASE")]
        #pragma warning disable CS1591
        CENTRAL_BANK_DIGITAL_CURRENCY_PURCHASE,
        #pragma warning restore CS1591
        [EnumMember(Value = "STABLECOIN_PURCHASE")]
        #pragma warning disable CS1591
        STABLECOIN_PURCHASE,
        #pragma warning restore CS1591
        [EnumMember(Value = "BLOCKCHAIN_NATIVE_TOKEN_PURCHASE")]
        #pragma warning disable CS1591
        BLOCKCHAIN_NATIVE_TOKEN_PURCHASE,
        #pragma warning restore CS1591
        [EnumMember(Value = "NON_FUNGIBLE_TOKEN_PURCHASE")]
        #pragma warning disable CS1591
        NON_FUNGIBLE_TOKEN_PURCHASE,
        #pragma warning restore CS1591
    }
}
