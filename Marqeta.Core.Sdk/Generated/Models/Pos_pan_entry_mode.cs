// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Marqeta.Core.Sdk.Models {
    /// <summary>Method used for capturing the card primary account number (PAN) during the transaction.</summary>
    public enum Pos_pan_entry_mode
    {
        [EnumMember(Value = "UNKNOWN")]
        #pragma warning disable CS1591
        UNKNOWN,
        #pragma warning restore CS1591
        [EnumMember(Value = "MANUAL")]
        #pragma warning disable CS1591
        MANUAL,
        #pragma warning restore CS1591
        [EnumMember(Value = "MAG_STRIPE")]
        #pragma warning disable CS1591
        MAG_STRIPE,
        #pragma warning restore CS1591
        [EnumMember(Value = "MAG_STRIPE_CONTACTLESS")]
        #pragma warning disable CS1591
        MAG_STRIPE_CONTACTLESS,
        #pragma warning restore CS1591
        [EnumMember(Value = "BAR_CODE")]
        #pragma warning disable CS1591
        BAR_CODE,
        #pragma warning restore CS1591
        [EnumMember(Value = "OCR")]
        #pragma warning disable CS1591
        OCR,
        #pragma warning restore CS1591
        [EnumMember(Value = "MICR")]
        #pragma warning disable CS1591
        MICR,
        #pragma warning restore CS1591
        [EnumMember(Value = "CHIP")]
        #pragma warning disable CS1591
        CHIP,
        #pragma warning restore CS1591
        [EnumMember(Value = "CHIP_CONTACTLESS")]
        #pragma warning disable CS1591
        CHIP_CONTACTLESS,
        #pragma warning restore CS1591
        [EnumMember(Value = "CARD_ON_FILE")]
        #pragma warning disable CS1591
        CARD_ON_FILE,
        #pragma warning restore CS1591
        [EnumMember(Value = "CHIP_FALLBACK")]
        #pragma warning disable CS1591
        CHIP_FALLBACK,
        #pragma warning restore CS1591
        [EnumMember(Value = "OTHER")]
        #pragma warning disable CS1591
        OTHER,
        #pragma warning restore CS1591
    }
}
