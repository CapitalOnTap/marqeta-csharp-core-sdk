// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Marqeta.Core.Sdk.Models
{
    /// <summary>Reason why the transaction was declined.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum Jit_funding_api_decline_reason
    {
        [EnumMember(Value = "INVALID_AMOUNT")]
        #pragma warning disable CS1591
        INVALID_AMOUNT,
        #pragma warning restore CS1591
        [EnumMember(Value = "INSUFFICIENT_FUNDS")]
        #pragma warning disable CS1591
        INSUFFICIENT_FUNDS,
        #pragma warning restore CS1591
        [EnumMember(Value = "TRANSACTION_NOT_PERMITTED")]
        #pragma warning disable CS1591
        TRANSACTION_NOT_PERMITTED,
        #pragma warning restore CS1591
        [EnumMember(Value = "SUSPECTED_FRAUD")]
        #pragma warning disable CS1591
        SUSPECTED_FRAUD,
        #pragma warning restore CS1591
        [EnumMember(Value = "AMOUNT_LIMIT_EXCEEDED")]
        #pragma warning disable CS1591
        AMOUNT_LIMIT_EXCEEDED,
        #pragma warning restore CS1591
        [EnumMember(Value = "TRANSACTION_COUNT_LIMIT_EXCEEDED")]
        #pragma warning disable CS1591
        TRANSACTION_COUNT_LIMIT_EXCEEDED,
        #pragma warning restore CS1591
        [EnumMember(Value = "DUPLICATE_TRANSACTION")]
        #pragma warning disable CS1591
        DUPLICATE_TRANSACTION,
        #pragma warning restore CS1591
        [EnumMember(Value = "INVALID_MERCHANT")]
        #pragma warning disable CS1591
        INVALID_MERCHANT,
        #pragma warning restore CS1591
        [EnumMember(Value = "INVALID_CARD")]
        #pragma warning disable CS1591
        INVALID_CARD,
        #pragma warning restore CS1591
        [EnumMember(Value = "NO_CREDIT_ACCOUNT")]
        #pragma warning disable CS1591
        NO_CREDIT_ACCOUNT,
        #pragma warning restore CS1591
        [EnumMember(Value = "EXPIRED_CARD")]
        #pragma warning disable CS1591
        EXPIRED_CARD,
        #pragma warning restore CS1591
        [EnumMember(Value = "NO_CHECKING_ACCOUNT")]
        #pragma warning disable CS1591
        NO_CHECKING_ACCOUNT,
        #pragma warning restore CS1591
        [EnumMember(Value = "NO_SAVINGS_ACCOUNT")]
        #pragma warning disable CS1591
        NO_SAVINGS_ACCOUNT,
        #pragma warning restore CS1591
        [EnumMember(Value = "STOP_PAYMENT")]
        #pragma warning disable CS1591
        STOP_PAYMENT,
        #pragma warning restore CS1591
        [EnumMember(Value = "REVOCATION_AUTHORIZATION_ORDER")]
        #pragma warning disable CS1591
        REVOCATION_AUTHORIZATION_ORDER,
        #pragma warning restore CS1591
        [EnumMember(Value = "REVOCATION_ALL_AUTHORIZATION_ORDER")]
        #pragma warning disable CS1591
        REVOCATION_ALL_AUTHORIZATION_ORDER,
        #pragma warning restore CS1591
        [EnumMember(Value = "SOFT_DECLINE_AUTHENTICATION_REQUIRED")]
        #pragma warning disable CS1591
        SOFT_DECLINE_AUTHENTICATION_REQUIRED,
        #pragma warning restore CS1591
        [EnumMember(Value = "CLOSED_ACCOUNT")]
        #pragma warning disable CS1591
        CLOSED_ACCOUNT,
        #pragma warning restore CS1591
        [EnumMember(Value = "SOFT_DECLINE_PIN_REQUIRED")]
        #pragma warning disable CS1591
        SOFT_DECLINE_PIN_REQUIRED,
        #pragma warning restore CS1591
        [EnumMember(Value = "CARD_NOT_ACTIVE")]
        #pragma warning disable CS1591
        CARD_NOT_ACTIVE,
        #pragma warning restore CS1591
        [EnumMember(Value = "CARDHOLDER_NOT_ACTIVE")]
        #pragma warning disable CS1591
        CARDHOLDER_NOT_ACTIVE,
        #pragma warning restore CS1591
    }
}
