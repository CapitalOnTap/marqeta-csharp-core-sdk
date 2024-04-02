// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Marqeta.Core.Sdk.Models {
    /// <summary>The type of fee assessed by the card network.</summary>
    public enum Network_fee_model_type {
        [EnumMember(Value = "ISSUER_FEE")]
        ISSUER_FEE,
        [EnumMember(Value = "SWITCH_FEE")]
        SWITCH_FEE,
        [EnumMember(Value = "PINDEBIT_ASSOC_FEE")]
        PINDEBIT_ASSOC_FEE,
        [EnumMember(Value = "ACQUIRER_FEE")]
        ACQUIRER_FEE,
        [EnumMember(Value = "INTERCHANGE_FEE")]
        INTERCHANGE_FEE,
        [EnumMember(Value = "CUR_CONV_CARDHOLDER_FEE")]
        CUR_CONV_CARDHOLDER_FEE,
        [EnumMember(Value = "CUR_CONV_ISSUER_FEE")]
        CUR_CONV_ISSUER_FEE,
        [EnumMember(Value = "CROSS_BORDER_ISSUER_FEE")]
        CROSS_BORDER_ISSUER_FEE,
    }
}