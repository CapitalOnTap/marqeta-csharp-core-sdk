// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Marqeta.Core.Sdk.Models
{
    /// <summary>Specifies whether the transaction was initiated by a cardholder or a merchant.</summary>
    public enum Pos_transaction_initiated_by
    {
        [EnumMember(Value = "CONSUMER")]
        #pragma warning disable CS1591
        CONSUMER,
        #pragma warning restore CS1591
        [EnumMember(Value = "MERCHANT")]
        #pragma warning disable CS1591
        MERCHANT,
        #pragma warning restore CS1591
        [EnumMember(Value = "UNKNOWN")]
        #pragma warning disable CS1591
        UNKNOWN,
        #pragma warning restore CS1591
        [EnumMember(Value = "MARQETA")]
        #pragma warning disable CS1591
        MARQETA,
        #pragma warning restore CS1591
        [EnumMember(Value = "NETWORK")]
        #pragma warning disable CS1591
        NETWORK,
        #pragma warning restore CS1591
    }
}