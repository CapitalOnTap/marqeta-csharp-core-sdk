// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Marqeta.Core.Sdk.Models
{
    /// <summary>Specifies the return destination for refunds in the case of a transaction reversal.In most cases, you should set the value to `GATEWAY`, which returns funds to the program gateway funding source.Setting to `GPA` returns the funds to the user&apos;s GPA, which creates a positive account balance and introduces the potential of a transaction being authorized without a JIT Funding request being sent to the gateway.</summary>
    public enum Jit_funding_programgateway_funding_source_refunds_destination
    {
        [EnumMember(Value = "GATEWAY")]
        #pragma warning disable CS1591
        GATEWAY,
        #pragma warning restore CS1591
        [EnumMember(Value = "GPA")]
        #pragma warning disable CS1591
        GPA,
        #pragma warning restore CS1591
        [EnumMember(Value = "WATERFALL")]
        #pragma warning disable CS1591
        WATERFALL,
        #pragma warning restore CS1591
    }
}
