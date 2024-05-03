// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Marqeta.Core.Sdk.Models {
    /// <summary>Defines the time period to which the `amount_limit` and `usage_limit` fields apply:* *DAY* – one day; days begin at 00:00:00 UTC.* *WEEK* – one week; weeks begin Sundays at 00:00:00 UTC.* *MONTH* – one month; months begin on the first day of month at 00:00:00 UTC.* *LIFETIME* – forever; time period never expires.* *TRANSACTION* – a single transaction.</summary>
    public enum Velocity_control_balance_response_velocity_window
    {
        [EnumMember(Value = "DAY")]
        #pragma warning disable CS1591
        DAY,
        #pragma warning restore CS1591
        [EnumMember(Value = "WEEK")]
        #pragma warning disable CS1591
        WEEK,
        #pragma warning restore CS1591
        [EnumMember(Value = "MONTH")]
        #pragma warning disable CS1591
        MONTH,
        #pragma warning restore CS1591
        [EnumMember(Value = "LIFETIME")]
        #pragma warning disable CS1591
        LIFETIME,
        #pragma warning restore CS1591
        [EnumMember(Value = "TRANSACTION")]
        #pragma warning disable CS1591
        TRANSACTION,
        #pragma warning restore CS1591
    }
}
