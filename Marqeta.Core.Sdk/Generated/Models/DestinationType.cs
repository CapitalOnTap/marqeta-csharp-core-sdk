// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Marqeta.Core.Sdk.Models {
    /// <summary>Destination of the reward redemption.* `INVESTMENT` - The redemption is paid into an investment account.* `WALLET` - The redemption is paid into a digital wallet.* `ACH` - The redemption is paid into an ACH account.Required for external redemptions.</summary>
    public enum DestinationType {
        [EnumMember(Value = "INVESTMENT")]
        INVESTMENT,
        [EnumMember(Value = "WALLET")]
        WALLET,
        [EnumMember(Value = "ACH")]
        ACH,
    }
}
