// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Marqeta.Core.Sdk.Accounts.Item.Journalentries
{
    #pragma warning disable CS1591
    public enum GetTypesQueryParameterType
    #pragma warning restore CS1591
    {
        [EnumMember(Value = "authorization")]
        #pragma warning disable CS1591
        Authorization,
        #pragma warning restore CS1591
        [EnumMember(Value = "authorization.advice")]
        #pragma warning disable CS1591
        AuthorizationAdvice,
        #pragma warning restore CS1591
        [EnumMember(Value = "authorization.incremental")]
        #pragma warning disable CS1591
        AuthorizationIncremental,
        #pragma warning restore CS1591
        [EnumMember(Value = "authorization.reversal")]
        #pragma warning disable CS1591
        AuthorizationReversal,
        #pragma warning restore CS1591
        [EnumMember(Value = "authorization.reversal.issuerexpiration")]
        #pragma warning disable CS1591
        AuthorizationReversalIssuerexpiration,
        #pragma warning restore CS1591
        [EnumMember(Value = "authorization.clearing")]
        #pragma warning disable CS1591
        AuthorizationClearing,
        #pragma warning restore CS1591
        [EnumMember(Value = "refund")]
        #pragma warning disable CS1591
        Refund,
        #pragma warning restore CS1591
        [EnumMember(Value = "refund.authorization")]
        #pragma warning disable CS1591
        RefundAuthorization,
        #pragma warning restore CS1591
        [EnumMember(Value = "refund.authorization.advice")]
        #pragma warning disable CS1591
        RefundAuthorizationAdvice,
        #pragma warning restore CS1591
        [EnumMember(Value = "refund.authorization.reversal")]
        #pragma warning disable CS1591
        RefundAuthorizationReversal,
        #pragma warning restore CS1591
        [EnumMember(Value = "refund.authorization.clearing")]
        #pragma warning disable CS1591
        RefundAuthorizationClearing,
        #pragma warning restore CS1591
        [EnumMember(Value = "refund.authorization.reversal.issuerexpiration")]
        #pragma warning disable CS1591
        RefundAuthorizationReversalIssuerexpiration,
        #pragma warning restore CS1591
        [EnumMember(Value = "originalcredit.authorization")]
        #pragma warning disable CS1591
        OriginalcreditAuthorization,
        #pragma warning restore CS1591
        [EnumMember(Value = "originalcredit.authorization.clearing")]
        #pragma warning disable CS1591
        OriginalcreditAuthorizationClearing,
        #pragma warning restore CS1591
        [EnumMember(Value = "originalcredit.authorization.reversal")]
        #pragma warning disable CS1591
        OriginalcreditAuthorizationReversal,
        #pragma warning restore CS1591
        [EnumMember(Value = "originalcredit.authpluscapture")]
        #pragma warning disable CS1591
        OriginalcreditAuthpluscapture,
        #pragma warning restore CS1591
        [EnumMember(Value = "originalcredit.authpluscapture.reversal")]
        #pragma warning disable CS1591
        OriginalcreditAuthpluscaptureReversal,
        #pragma warning restore CS1591
        [EnumMember(Value = "originalcredit.authorization.reversal.issuerexpiration")]
        #pragma warning disable CS1591
        OriginalcreditAuthorizationReversalIssuerexpiration,
        #pragma warning restore CS1591
        [EnumMember(Value = "account.balancerefund")]
        #pragma warning disable CS1591
        AccountBalancerefund,
        #pragma warning restore CS1591
        [EnumMember(Value = "account.reward.cashback")]
        #pragma warning disable CS1591
        AccountRewardCashback,
        #pragma warning restore CS1591
        [EnumMember(Value = "account.reward.auto.cashback")]
        #pragma warning disable CS1591
        AccountRewardAutoCashback,
        #pragma warning restore CS1591
        [EnumMember(Value = "account.reward.auto.cashback.reversal")]
        #pragma warning disable CS1591
        AccountRewardAutoCashbackReversal,
        #pragma warning restore CS1591
        [EnumMember(Value = "account.payment")]
        #pragma warning disable CS1591
        AccountPayment,
        #pragma warning restore CS1591
        [EnumMember(Value = "account.payment.completed")]
        #pragma warning disable CS1591
        AccountPaymentCompleted,
        #pragma warning restore CS1591
        [EnumMember(Value = "account.payment.returned")]
        #pragma warning disable CS1591
        AccountPaymentReturned,
        #pragma warning restore CS1591
        [EnumMember(Value = "account.payment.canceled")]
        #pragma warning disable CS1591
        AccountPaymentCanceled,
        #pragma warning restore CS1591
        [EnumMember(Value = "account.payment.refunded")]
        #pragma warning disable CS1591
        AccountPaymentRefunded,
        #pragma warning restore CS1591
        [EnumMember(Value = "account.payment.completed.hold.released")]
        #pragma warning disable CS1591
        AccountPaymentCompletedHoldReleased,
        #pragma warning restore CS1591
        [EnumMember(Value = "account.payment.completed.hold")]
        #pragma warning disable CS1591
        AccountPaymentCompletedHold,
        #pragma warning restore CS1591
        [EnumMember(Value = "account.interest")]
        #pragma warning disable CS1591
        AccountInterest,
        #pragma warning restore CS1591
        [EnumMember(Value = "account.fee.payment.late")]
        #pragma warning disable CS1591
        AccountFeePaymentLate,
        #pragma warning restore CS1591
        [EnumMember(Value = "account.fee.payment.returned")]
        #pragma warning disable CS1591
        AccountFeePaymentReturned,
        #pragma warning restore CS1591
        [EnumMember(Value = "account.fee.interest.minimum")]
        #pragma warning disable CS1591
        AccountFeeInterestMinimum,
        #pragma warning restore CS1591
        [EnumMember(Value = "account.dispute")]
        #pragma warning disable CS1591
        AccountDispute,
        #pragma warning restore CS1591
        [EnumMember(Value = "account.dispute.reversal")]
        #pragma warning disable CS1591
        AccountDisputeReversal,
        #pragma warning restore CS1591
        [EnumMember(Value = "account.dispute.won")]
        #pragma warning disable CS1591
        AccountDisputeWon,
        #pragma warning restore CS1591
        [EnumMember(Value = "account.dispute.lost")]
        #pragma warning disable CS1591
        AccountDisputeLost,
        #pragma warning restore CS1591
        [EnumMember(Value = "account.dispute.lost.graceperiod")]
        #pragma warning disable CS1591
        AccountDisputeLostGraceperiod,
        #pragma warning restore CS1591
        [EnumMember(Value = "account.adjustment")]
        #pragma warning disable CS1591
        AccountAdjustment,
        #pragma warning restore CS1591
        [EnumMember(Value = "account.adjustment.purchase")]
        #pragma warning disable CS1591
        AccountAdjustmentPurchase,
        #pragma warning restore CS1591
        [EnumMember(Value = "account.adjustment.fee")]
        #pragma warning disable CS1591
        AccountAdjustmentFee,
        #pragma warning restore CS1591
        [EnumMember(Value = "account.adjustment.interest")]
        #pragma warning disable CS1591
        AccountAdjustmentInterest,
        #pragma warning restore CS1591
        [EnumMember(Value = "account.adjustment.reward")]
        #pragma warning disable CS1591
        AccountAdjustmentReward,
        #pragma warning restore CS1591
        [EnumMember(Value = "pindebit")]
        #pragma warning disable CS1591
        Pindebit,
        #pragma warning restore CS1591
        [EnumMember(Value = "pindebit.authorization.clearing")]
        #pragma warning disable CS1591
        PindebitAuthorizationClearing,
        #pragma warning restore CS1591
        [EnumMember(Value = "pindebit.refund")]
        #pragma warning disable CS1591
        PindebitRefund,
        #pragma warning restore CS1591
    }
}