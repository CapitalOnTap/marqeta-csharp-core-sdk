// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Marqeta.Core.Sdk.Models
{
    /// <summary>The international service assessment indicator indicates if an ISA fee is applicable to the transaction.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum Transaction_model_isaIndicator
    {
        [EnumMember(Value = "MULTI_CURRENCY")]
        #pragma warning disable CS1591
        MULTI_CURRENCY,
        #pragma warning restore CS1591
        [EnumMember(Value = "SINGLE_CURRENCY")]
        #pragma warning disable CS1591
        SINGLE_CURRENCY,
        #pragma warning restore CS1591
        [EnumMember(Value = "REBATE_CANCELLED")]
        #pragma warning disable CS1591
        REBATE_CANCELLED,
        #pragma warning restore CS1591
        [EnumMember(Value = "MULTI_CURRENCY_NON_US_COUNTRIES")]
        #pragma warning disable CS1591
        MULTI_CURRENCY_NON_US_COUNTRIES,
        #pragma warning restore CS1591
        [EnumMember(Value = "SINGLE_CURRENCY_PAID_BY_ISSUER")]
        #pragma warning disable CS1591
        SINGLE_CURRENCY_PAID_BY_ISSUER,
        #pragma warning restore CS1591
        [EnumMember(Value = "NO_CHARGE_ASSESSED")]
        #pragma warning disable CS1591
        NO_CHARGE_ASSESSED,
        #pragma warning restore CS1591
    }
}
