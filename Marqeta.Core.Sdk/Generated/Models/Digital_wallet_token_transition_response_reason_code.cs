// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Marqeta.Core.Sdk.Models
{
    /// <summary>Standard code describing the reason for the transition:* *00:* Object activated for the first time* *01:* Requested by you* *02:* Inactivity over time* *03:* This address cannot accept mail or the addressee is unknown* *04:* Negative account balance* *05:* Account under review* *06:* Suspicious activity was identified* *07:* Activity outside the program parameters was identified* *08:* Confirmed fraud was identified* *09:* Matched with an Office of Foreign Assets Control list* *10:* Card was reported lost* *11:* Card information was cloned* *12:* Account or card information was compromised* *13:* Temporary status change while on hold/leave* *14:* Initiated by Marqeta* *15:* Initiated by issuer* *16:* Card expired* *17:* Failed KYC* *18:* Changed to `ACTIVE` because information was properly validated* *19:* Changed to `ACTIVE` because account activity was properly validated* *20:* Change occurred prior to the normalization of reason codes* *21:* Initiated by a third party, often a digital wallet provider* *22:* PIN retry limit reached* *23:* Card was reported stolen* *24:* Address issue* *25:* Name issue* *26:* SSN issue* *27:* DOB issue* *28:* Email issue* *29:* Phone issue* *30:* Account/fulfillment mismatch* *31:* Other reason</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum Digital_wallet_token_transition_response_reason_code
    {
        [EnumMember(Value = "00")]
        #pragma warning disable CS1591
        ZeroZero,
        #pragma warning restore CS1591
        [EnumMember(Value = "01")]
        #pragma warning disable CS1591
        ZeroOne,
        #pragma warning restore CS1591
        [EnumMember(Value = "02")]
        #pragma warning disable CS1591
        ZeroTwo,
        #pragma warning restore CS1591
        [EnumMember(Value = "03")]
        #pragma warning disable CS1591
        ZeroThree,
        #pragma warning restore CS1591
        [EnumMember(Value = "04")]
        #pragma warning disable CS1591
        ZeroFour,
        #pragma warning restore CS1591
        [EnumMember(Value = "05")]
        #pragma warning disable CS1591
        ZeroFive,
        #pragma warning restore CS1591
        [EnumMember(Value = "06")]
        #pragma warning disable CS1591
        ZeroSix,
        #pragma warning restore CS1591
        [EnumMember(Value = "07")]
        #pragma warning disable CS1591
        ZeroSeven,
        #pragma warning restore CS1591
        [EnumMember(Value = "08")]
        #pragma warning disable CS1591
        ZeroEight,
        #pragma warning restore CS1591
        [EnumMember(Value = "09")]
        #pragma warning disable CS1591
        ZeroNine,
        #pragma warning restore CS1591
        [EnumMember(Value = "10")]
        #pragma warning disable CS1591
        OneZero,
        #pragma warning restore CS1591
        [EnumMember(Value = "11")]
        #pragma warning disable CS1591
        OneOne,
        #pragma warning restore CS1591
        [EnumMember(Value = "12")]
        #pragma warning disable CS1591
        OneTwo,
        #pragma warning restore CS1591
        [EnumMember(Value = "13")]
        #pragma warning disable CS1591
        OneThree,
        #pragma warning restore CS1591
        [EnumMember(Value = "14")]
        #pragma warning disable CS1591
        OneFour,
        #pragma warning restore CS1591
        [EnumMember(Value = "15")]
        #pragma warning disable CS1591
        OneFive,
        #pragma warning restore CS1591
        [EnumMember(Value = "16")]
        #pragma warning disable CS1591
        OneSix,
        #pragma warning restore CS1591
        [EnumMember(Value = "17")]
        #pragma warning disable CS1591
        OneSeven,
        #pragma warning restore CS1591
        [EnumMember(Value = "18")]
        #pragma warning disable CS1591
        OneEight,
        #pragma warning restore CS1591
        [EnumMember(Value = "19")]
        #pragma warning disable CS1591
        OneNine,
        #pragma warning restore CS1591
        [EnumMember(Value = "20")]
        #pragma warning disable CS1591
        TwoZero,
        #pragma warning restore CS1591
        [EnumMember(Value = "21")]
        #pragma warning disable CS1591
        TwoOne,
        #pragma warning restore CS1591
        [EnumMember(Value = "22")]
        #pragma warning disable CS1591
        TwoTwo,
        #pragma warning restore CS1591
        [EnumMember(Value = "23")]
        #pragma warning disable CS1591
        TwoThree,
        #pragma warning restore CS1591
        [EnumMember(Value = "24")]
        #pragma warning disable CS1591
        TwoFour,
        #pragma warning restore CS1591
        [EnumMember(Value = "25")]
        #pragma warning disable CS1591
        TwoFive,
        #pragma warning restore CS1591
        [EnumMember(Value = "26")]
        #pragma warning disable CS1591
        TwoSix,
        #pragma warning restore CS1591
        [EnumMember(Value = "27")]
        #pragma warning disable CS1591
        TwoSeven,
        #pragma warning restore CS1591
        [EnumMember(Value = "28")]
        #pragma warning disable CS1591
        TwoEight,
        #pragma warning restore CS1591
        [EnumMember(Value = "29")]
        #pragma warning disable CS1591
        TwoNine,
        #pragma warning restore CS1591
        [EnumMember(Value = "30")]
        #pragma warning disable CS1591
        ThreeZero,
        #pragma warning restore CS1591
        [EnumMember(Value = "31")]
        #pragma warning disable CS1591
        ThreeOne,
        #pragma warning restore CS1591
        [EnumMember(Value = "32")]
        #pragma warning disable CS1591
        ThreeTwo,
        #pragma warning restore CS1591
    }
}
