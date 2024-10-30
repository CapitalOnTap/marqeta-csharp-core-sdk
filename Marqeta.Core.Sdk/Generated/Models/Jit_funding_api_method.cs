// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Marqeta.Core.Sdk.Models
{
    /// <summary>JIT Funding response type.See &lt;&lt;/core-api/gateway-jit-funding-messages#_the_jit_funding_object, The jit_funding object&gt;&gt; for the purpose, funding event type, and description of each method.</summary>
    public enum Jit_funding_api_method
    {
        [EnumMember(Value = "pgfs.authorization")]
        #pragma warning disable CS1591
        PgfsAuthorization,
        #pragma warning restore CS1591
        [EnumMember(Value = "pgfs.authorization.clearing")]
        #pragma warning disable CS1591
        PgfsAuthorizationClearing,
        #pragma warning restore CS1591
        [EnumMember(Value = "pgfs.authorization.advice")]
        #pragma warning disable CS1591
        PgfsAuthorizationAdvice,
        #pragma warning restore CS1591
        [EnumMember(Value = "pgfs.authorization.incremental")]
        #pragma warning disable CS1591
        PgfsAuthorizationIncremental,
        #pragma warning restore CS1591
        [EnumMember(Value = "pgfs.authorization.capture")]
        #pragma warning disable CS1591
        PgfsAuthorizationCapture,
        #pragma warning restore CS1591
        [EnumMember(Value = "pgfs.authorization.reversal")]
        #pragma warning disable CS1591
        PgfsAuthorizationReversal,
        #pragma warning restore CS1591
        [EnumMember(Value = "pgfs.authorization.cashback")]
        #pragma warning disable CS1591
        PgfsAuthorizationCashback,
        #pragma warning restore CS1591
        [EnumMember(Value = "pgfs.balanceinquiry")]
        #pragma warning disable CS1591
        PgfsBalanceinquiry,
        #pragma warning restore CS1591
        [EnumMember(Value = "pgfs.auth_plus_capture")]
        #pragma warning disable CS1591
        PgfsAuth_plus_capture,
        #pragma warning restore CS1591
        [EnumMember(Value = "pgfs.refund")]
        #pragma warning disable CS1591
        PgfsRefund,
        #pragma warning restore CS1591
        [EnumMember(Value = "pgfs.refund.authorization")]
        #pragma warning disable CS1591
        PgfsRefundAuthorization,
        #pragma warning restore CS1591
        [EnumMember(Value = "pgfs.refund.authorization.reversal")]
        #pragma warning disable CS1591
        PgfsRefundAuthorizationReversal,
        #pragma warning restore CS1591
        [EnumMember(Value = "pgfs.refund.authorization.clearing")]
        #pragma warning disable CS1591
        PgfsRefundAuthorizationClearing,
        #pragma warning restore CS1591
        [EnumMember(Value = "pgfs.force_capture")]
        #pragma warning disable CS1591
        PgfsForce_capture,
        #pragma warning restore CS1591
        [EnumMember(Value = "pgfs.authorization.capture.chargeback")]
        #pragma warning disable CS1591
        PgfsAuthorizationCaptureChargeback,
        #pragma warning restore CS1591
        [EnumMember(Value = "pgfs.authorization.capture.chargeback.reversal")]
        #pragma warning disable CS1591
        PgfsAuthorizationCaptureChargebackReversal,
        #pragma warning restore CS1591
        [EnumMember(Value = "pgfs.pindebit")]
        #pragma warning disable CS1591
        PgfsPindebit,
        #pragma warning restore CS1591
        [EnumMember(Value = "pgfs.pindebit.chargeback")]
        #pragma warning disable CS1591
        PgfsPindebitChargeback,
        #pragma warning restore CS1591
        [EnumMember(Value = "pgfs.pindebit.chargeback.reversal")]
        #pragma warning disable CS1591
        PgfsPindebitChargebackReversal,
        #pragma warning restore CS1591
        [EnumMember(Value = "pgfs.pindebit.cashback")]
        #pragma warning disable CS1591
        PgfsPindebitCashback,
        #pragma warning restore CS1591
        [EnumMember(Value = "pgfs.pindebit.refund")]
        #pragma warning disable CS1591
        PgfsPindebitRefund,
        #pragma warning restore CS1591
        [EnumMember(Value = "pgfs.pindebit.authorization")]
        #pragma warning disable CS1591
        PgfsPindebitAuthorization,
        #pragma warning restore CS1591
        [EnumMember(Value = "pgfs.pindebit.authorization.clearing")]
        #pragma warning disable CS1591
        PgfsPindebitAuthorizationClearing,
        #pragma warning restore CS1591
        [EnumMember(Value = "pgfs.pindebit.authorization.reversal")]
        #pragma warning disable CS1591
        PgfsPindebitAuthorizationReversal,
        #pragma warning restore CS1591
        [EnumMember(Value = "pgfs.pindebit.atm.withdrawal")]
        #pragma warning disable CS1591
        PgfsPindebitAtmWithdrawal,
        #pragma warning restore CS1591
        [EnumMember(Value = "pgfs.pindebit.balanceinquiry")]
        #pragma warning disable CS1591
        PgfsPindebitBalanceinquiry,
        #pragma warning restore CS1591
        [EnumMember(Value = "pgfs.pindebit.quasi.cash")]
        #pragma warning disable CS1591
        PgfsPindebitQuasiCash,
        #pragma warning restore CS1591
        [EnumMember(Value = "pgfs.dispute.credit")]
        #pragma warning disable CS1591
        PgfsDisputeCredit,
        #pragma warning restore CS1591
        [EnumMember(Value = "pgfs.dispute.debit")]
        #pragma warning disable CS1591
        PgfsDisputeDebit,
        #pragma warning restore CS1591
        [EnumMember(Value = "pgfs.directdeposit.credit")]
        #pragma warning disable CS1591
        PgfsDirectdepositCredit,
        #pragma warning restore CS1591
        [EnumMember(Value = "pgfs.directdeposit.debit")]
        #pragma warning disable CS1591
        PgfsDirectdepositDebit,
        #pragma warning restore CS1591
        [EnumMember(Value = "pgfs.directdeposit.credit.reversal")]
        #pragma warning disable CS1591
        PgfsDirectdepositCreditReversal,
        #pragma warning restore CS1591
        [EnumMember(Value = "pgfs.directdeposit.debit.reversal")]
        #pragma warning disable CS1591
        PgfsDirectdepositDebitReversal,
        #pragma warning restore CS1591
        [EnumMember(Value = "pgfs.adjustment.credit")]
        #pragma warning disable CS1591
        PgfsAdjustmentCredit,
        #pragma warning restore CS1591
        [EnumMember(Value = "pgfs.adjustment.debit")]
        #pragma warning disable CS1591
        PgfsAdjustmentDebit,
        #pragma warning restore CS1591
        [EnumMember(Value = "pgfs.auth_plus_capture.standin")]
        #pragma warning disable CS1591
        PgfsAuth_plus_captureStandin,
        #pragma warning restore CS1591
        [EnumMember(Value = "pgfs.authorization.standin")]
        #pragma warning disable CS1591
        PgfsAuthorizationStandin,
        #pragma warning restore CS1591
        [EnumMember(Value = "pgfs.network.load")]
        #pragma warning disable CS1591
        PgfsNetworkLoad,
        #pragma warning restore CS1591
        [EnumMember(Value = "pgfs.original.credit.authorization")]
        #pragma warning disable CS1591
        PgfsOriginalCreditAuthorization,
        #pragma warning restore CS1591
        [EnumMember(Value = "pgfs.original.credit.auth_plus_capture")]
        #pragma warning disable CS1591
        PgfsOriginalCreditAuth_plus_capture,
        #pragma warning restore CS1591
        [EnumMember(Value = "pgfs.original.credit.authorization.clearing")]
        #pragma warning disable CS1591
        PgfsOriginalCreditAuthorizationClearing,
        #pragma warning restore CS1591
        [EnumMember(Value = "pgfs.original.credit.authorization.reversal")]
        #pragma warning disable CS1591
        PgfsOriginalCreditAuthorizationReversal,
        #pragma warning restore CS1591
        [EnumMember(Value = "pgfs.billpayment")]
        #pragma warning disable CS1591
        PgfsBillpayment,
        #pragma warning restore CS1591
        [EnumMember(Value = "pgfs.billpayment.capture")]
        #pragma warning disable CS1591
        PgfsBillpaymentCapture,
        #pragma warning restore CS1591
        [EnumMember(Value = "pgfs.billpayment.reversal")]
        #pragma warning disable CS1591
        PgfsBillpaymentReversal,
        #pragma warning restore CS1591
        [EnumMember(Value = "pgfs.atm.withdrawal")]
        #pragma warning disable CS1591
        PgfsAtmWithdrawal,
        #pragma warning restore CS1591
        [EnumMember(Value = "pgfs.atm.clearing.withdrawal")]
        #pragma warning disable CS1591
        PgfsAtmClearingWithdrawal,
        #pragma warning restore CS1591
        [EnumMember(Value = "pgfs.authorization.quasi.cash")]
        #pragma warning disable CS1591
        PgfsAuthorizationQuasiCash,
        #pragma warning restore CS1591
        [EnumMember(Value = "pgfs.authorization.clearing.quasi.cash")]
        #pragma warning disable CS1591
        PgfsAuthorizationClearingQuasiCash,
        #pragma warning restore CS1591
        [EnumMember(Value = "pgfs.authorization.account_verification")]
        #pragma warning disable CS1591
        PgfsAuthorizationAccount_verification,
        #pragma warning restore CS1591
        [EnumMember(Value = "pgfs.product.inquiry")]
        #pragma warning disable CS1591
        PgfsProductInquiry,
        #pragma warning restore CS1591
    }
}
