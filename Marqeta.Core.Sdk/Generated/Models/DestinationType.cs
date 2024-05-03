// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Marqeta.Core.Sdk.Models {
    /// <summary>Destination of the reward redemption.* `INVESTMENT` - The redemption is paid into an investment account.* `WALLET` - The redemption is paid into a digital wallet.* `ACH` - The redemption is paid into an ACH account.Required for external redemptions.</summary>
    public enum DestinationType
    {
        [EnumMember(Value = "INVESTMENT")]
        #pragma warning disable CS1591
        INVESTMENT,
        #pragma warning restore CS1591
        [EnumMember(Value = "WALLET")]
        #pragma warning disable CS1591
        WALLET,
        #pragma warning restore CS1591
        [EnumMember(Value = "ACH")]
        #pragma warning disable CS1591
        ACH,
        #pragma warning restore CS1591
    }
}
