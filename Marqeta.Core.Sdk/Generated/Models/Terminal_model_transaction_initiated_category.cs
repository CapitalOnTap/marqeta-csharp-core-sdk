// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Marqeta.Core.Sdk.Models
{
    /// <summary>Specifies the category of a point-of-sale transaction.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum Terminal_model_transaction_initiated_category
    {
        [EnumMember(Value = "CARD_ON_FILE")]
        #pragma warning disable CS1591
        CARD_ON_FILE,
        #pragma warning restore CS1591
        [EnumMember(Value = "RECURRING_VAR_AMT_FIXED_FREQ")]
        #pragma warning disable CS1591
        RECURRING_VAR_AMT_FIXED_FREQ,
        #pragma warning restore CS1591
        [EnumMember(Value = "RECURRING_PAYMENT")]
        #pragma warning disable CS1591
        RECURRING_PAYMENT,
        #pragma warning restore CS1591
        [EnumMember(Value = "INSTALLMENT_PAYMENT")]
        #pragma warning disable CS1591
        INSTALLMENT_PAYMENT,
        #pragma warning restore CS1591
        [EnumMember(Value = "UNSCHEDULED_PAYMENT")]
        #pragma warning disable CS1591
        UNSCHEDULED_PAYMENT,
        #pragma warning restore CS1591
        [EnumMember(Value = "PARTIAL_SHIPMENT")]
        #pragma warning disable CS1591
        PARTIAL_SHIPMENT,
        #pragma warning restore CS1591
        [EnumMember(Value = "DELAYED_PAYMENT")]
        #pragma warning disable CS1591
        DELAYED_PAYMENT,
        #pragma warning restore CS1591
        [EnumMember(Value = "NO_SHOW")]
        #pragma warning disable CS1591
        NO_SHOW,
        #pragma warning restore CS1591
        [EnumMember(Value = "RESUBMISSION")]
        #pragma warning disable CS1591
        RESUBMISSION,
        #pragma warning restore CS1591
        [EnumMember(Value = "DEFERRED_BILLING")]
        #pragma warning disable CS1591
        DEFERRED_BILLING,
        #pragma warning restore CS1591
        [EnumMember(Value = "ACCOUNT_INQUIRY")]
        #pragma warning disable CS1591
        ACCOUNT_INQUIRY,
        #pragma warning restore CS1591
        [EnumMember(Value = "INCREMENTAL_AUTHORIZATION")]
        #pragma warning disable CS1591
        INCREMENTAL_AUTHORIZATION,
        #pragma warning restore CS1591
        [EnumMember(Value = "REAUTHORIZATION")]
        #pragma warning disable CS1591
        REAUTHORIZATION,
        #pragma warning restore CS1591
    }
}
