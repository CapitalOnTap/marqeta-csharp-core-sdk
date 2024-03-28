using System.Runtime.Serialization;

namespace Marqeta.Core.Sdk.Extensions;

/// <summary>
/// Enum for webhook event type
/// </summary>
public enum EventType
{
    [EnumMember(Value = "chargebacktransition")]
    ChargebackTransaction,
    [EnumMember(Value = "digitalwallettokentransition")]
    DigitalWalletTokenTransition,
    [EnumMember(Value = "cardtransition")]
    CardTransition,
    [EnumMember(Value = "usertransition")]
    UserTransition,
    [EnumMember(Value = "businesstransition")]
    BusinessTransition,
    [EnumMember(Value = "transaction")]
    Transaction,
    [EnumMember(Value = "threedstransition")]
    ThreeDSTransition,
}