// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Marqeta.Core.Sdk.Models
{
    /// <summary>Type of cycle.* `BEGINNING_REVOLVING` - Account is beginning to revolve and just started carrying a balancefrom the previous month.* `REVOLVING` - Account is revolving and has been carrying a balance from month to month for more than one month.* `END_REVOLVING` - Account is no longer revolving and the previous month&apos;s balance is paid off.* `TRANSACTING` - Account is not revolving and the balance is paid off each month.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum CycleType
    {
        [EnumMember(Value = "BEGINNING_REVOLVING")]
        #pragma warning disable CS1591
        BEGINNING_REVOLVING,
        #pragma warning restore CS1591
        [EnumMember(Value = "REVOLVING")]
        #pragma warning disable CS1591
        REVOLVING,
        #pragma warning restore CS1591
        [EnumMember(Value = "END_REVOLVING")]
        #pragma warning disable CS1591
        END_REVOLVING,
        #pragma warning restore CS1591
        [EnumMember(Value = "TRANSACTING")]
        #pragma warning disable CS1591
        TRANSACTING,
        #pragma warning restore CS1591
    }
}
