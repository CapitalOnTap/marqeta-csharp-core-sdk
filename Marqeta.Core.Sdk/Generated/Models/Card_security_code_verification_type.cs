// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Marqeta.Core.Sdk.Models
{
    /// <summary>Indicates the type of security code.Can have these possible values:* *CVV1* – the security code stored in the magnetic stripe on the card.* *CVV2* – the security code printed on the card.* *ICVV* – the security code stored on the chip of the card.* *DCVV* – a dynamic security code used in some contactless payments when a card or device is tapped against the card reader.</summary>
    public enum Card_security_code_verification_type
    {
        [EnumMember(Value = "CVV1")]
        #pragma warning disable CS1591
        CVV1,
        #pragma warning restore CS1591
        [EnumMember(Value = "CVV2")]
        #pragma warning disable CS1591
        CVV2,
        #pragma warning restore CS1591
        [EnumMember(Value = "ICVV")]
        #pragma warning disable CS1591
        ICVV,
        #pragma warning restore CS1591
        [EnumMember(Value = "DCVV")]
        #pragma warning disable CS1591
        DCVV,
        #pragma warning restore CS1591
    }
}
