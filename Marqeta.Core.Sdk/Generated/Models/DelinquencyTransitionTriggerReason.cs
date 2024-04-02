// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Marqeta.Core.Sdk.Models {
    /// <summary>Event that triggered an update to the account&apos;s delinquency state.</summary>
    public enum DelinquencyTransitionTriggerReason {
        [EnumMember(Value = "PAYMENT")]
        PAYMENT,
        [EnumMember(Value = "PAYMENT_VOID")]
        PAYMENT_VOID,
        [EnumMember(Value = "CREDIT")]
        CREDIT,
        [EnumMember(Value = "MINIMUM_PAYMENT_OVERRIDE")]
        MINIMUM_PAYMENT_OVERRIDE,
        [EnumMember(Value = "STATEMENT_GENERATION")]
        STATEMENT_GENERATION,
        [EnumMember(Value = "REAGE")]
        REAGE,
    }
}