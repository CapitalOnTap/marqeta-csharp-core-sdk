// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Marqeta.Core.Sdk.Models {
    /// <summary>Identifies the standardized reason for the transition:*00:* Object activated for the first time.*01:* Requested by you.*02:* Inactivity over time.*03:* This address cannot accept mail or the addressee is unknown.*04:* Negative account balance.*05:* Account under review.*06:* Suspicious activity was identified.*07:* Activity outside the program parameters was identified.*08:* Confirmed fraud was identified.*09:* Matched with an Office of Foreign Assets Control list.*10:* Card was reported lost.*11:* Card information was cloned.*12:* Account or card information was compromised.*13:* Temporary status change while on hold/leave.*14:* Initiated by Marqeta.*15:* Initiated by issuer.*16:* Card expired.*17:* Failed KYC.*18:* Changed to `ACTIVE` because information was properly validated.*19:* Changed to `ACTIVE` because account activity was properly validated.*20:* Change occurred prior to the normalization of reason codes.*21:* Initiated by a third party, often a digital wallet provider.*22:* PIN retry limit reached.*23:* Card was reported stolen.*24:* Address issue.*25:* Name issue.*26:* SSN issue.*27:* DOB issue.*28:* Email issue.*29:* Phone issue.*30:* Account/fulfillment mismatch.*31:* Other reason.</summary>
    public enum BusinessTransitionResponse_reason_code {
        [EnumMember(Value = "00")]
        ZeroZero,
        [EnumMember(Value = "01")]
        ZeroOne,
        [EnumMember(Value = "02")]
        ZeroTwo,
        [EnumMember(Value = "03")]
        ZeroThree,
        [EnumMember(Value = "04")]
        ZeroFour,
        [EnumMember(Value = "05")]
        ZeroFive,
        [EnumMember(Value = "06")]
        ZeroSix,
        [EnumMember(Value = "07")]
        ZeroSeven,
        [EnumMember(Value = "08")]
        ZeroEight,
        [EnumMember(Value = "09")]
        ZeroNine,
        [EnumMember(Value = "10")]
        OneZero,
        [EnumMember(Value = "11")]
        OneOne,
        [EnumMember(Value = "12")]
        OneTwo,
        [EnumMember(Value = "13")]
        OneThree,
        [EnumMember(Value = "14")]
        OneFour,
        [EnumMember(Value = "15")]
        OneFive,
        [EnumMember(Value = "16")]
        OneSix,
        [EnumMember(Value = "17")]
        OneSeven,
        [EnumMember(Value = "18")]
        OneEight,
        [EnumMember(Value = "19")]
        OneNine,
        [EnumMember(Value = "20")]
        TwoZero,
        [EnumMember(Value = "21")]
        TwoOne,
        [EnumMember(Value = "22")]
        TwoTwo,
        [EnumMember(Value = "23")]
        TwoThree,
        [EnumMember(Value = "24")]
        TwoFour,
        [EnumMember(Value = "25")]
        TwoFive,
        [EnumMember(Value = "26")]
        TwoSix,
        [EnumMember(Value = "27")]
        TwoSeven,
        [EnumMember(Value = "28")]
        TwoEight,
        [EnumMember(Value = "29")]
        TwoNine,
        [EnumMember(Value = "30")]
        ThreeZero,
        [EnumMember(Value = "31")]
        ThreeOne,
        [EnumMember(Value = "32")]
        ThreeTwo,
    }
}