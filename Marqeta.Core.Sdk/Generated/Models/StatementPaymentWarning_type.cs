// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Marqeta.Core.Sdk.Models {
    /// <summary>Type of statement warning.* `MIN_PAYMENT` - Displays the total estimated payment amount and how long it would take to pay off the statement balance if only making minimum payments.* `3_YEAR` - Displays the monthly payment amount and total estimated payment amount if paying off the statement balance in three years.</summary>
    public enum StatementPaymentWarning_type {
        [EnumMember(Value = "MIN_PAYMENT")]
        MIN_PAYMENT,
        [EnumMember(Value = "3_YEAR")]
        Three_YEAR,
    }
}
