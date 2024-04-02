// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Marqeta.Core.Sdk.Models {
    /// <summary>Instrument type of the card:* *PHYSICAL_MSR:* A physical card with a magnetic stripe. This is the default physical card type.* *PHYSICAL_ICC:* A physical card with an integrated circuit, or &quot;chip.&quot;* *PHYSICAL_CONTACTLESS:* A physical card that uses radio frequency identification (RFID) or near-field communication (NFC) to enable payment over a secure radio interface.* *PHYSICAL_COMBO:* A physical card with a chip that also supports contactless payments.* *VIRTUAL_PAN:* A virtual card with a primary account number (PAN).</summary>
    public enum Card_response_instrument_type {
        [EnumMember(Value = "PHYSICAL_MSR")]
        PHYSICAL_MSR,
        [EnumMember(Value = "PHYSICAL_ICC")]
        PHYSICAL_ICC,
        [EnumMember(Value = "PHYSICAL_CONTACTLESS")]
        PHYSICAL_CONTACTLESS,
        [EnumMember(Value = "PHYSICAL_COMBO")]
        PHYSICAL_COMBO,
        [EnumMember(Value = "VIRTUAL_PAN")]
        VIRTUAL_PAN,
    }
}