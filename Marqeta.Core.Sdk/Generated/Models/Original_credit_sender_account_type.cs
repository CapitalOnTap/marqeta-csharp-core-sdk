// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Marqeta.Core.Sdk.Models {
    /// <summary>The type of account from which the OCT draws funds.</summary>
    public enum Original_credit_sender_account_type {
        [EnumMember(Value = "OTHER")]
        OTHER,
        [EnumMember(Value = "RTN_BANK_ACCOUNT")]
        RTN_BANK_ACCOUNT,
        [EnumMember(Value = "IBAN")]
        IBAN,
        [EnumMember(Value = "CARD_ACCOUNT")]
        CARD_ACCOUNT,
        [EnumMember(Value = "EMAIL")]
        EMAIL,
        [EnumMember(Value = "PHONE_NUMBER")]
        PHONE_NUMBER,
        [EnumMember(Value = "BANK_ACCOUNT_NUMBER_AND_BANK_IDENTIFICATION_CODE")]
        BANK_ACCOUNT_NUMBER_AND_BANK_IDENTIFICATION_CODE,
        [EnumMember(Value = "WALLET_ID")]
        WALLET_ID,
        [EnumMember(Value = "SOCIAL_NETWORK_ID")]
        SOCIAL_NETWORK_ID,
    }
}
