// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Marqeta.Core.Sdk.Models
{
    /// <summary>Card fulfillment status:* *ISSUED:* Initial state of all newly created/issued cards.* *ORDERED:* Card ordered through the card fulfillment provider.* *REORDERED:* Card reordered through the card fulfillment provider.* *REJECTED:* Card rejected by the card fulfillment provider.* *SHIPPED:* Card shipped by the card fulfillment provider.* *DELIVERED:* Card delivered by the card fulfillment provider.* *DIGITALLY_PRESENTED:* Card digitally presented using the `/cards/{token}/showpan` endpoint; does not affect the delivery of physical cards.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum Card_response_fulfillment_status
    {
        [EnumMember(Value = "ISSUED")]
        #pragma warning disable CS1591
        ISSUED,
        #pragma warning restore CS1591
        [EnumMember(Value = "ORDERED")]
        #pragma warning disable CS1591
        ORDERED,
        #pragma warning restore CS1591
        [EnumMember(Value = "REORDERED")]
        #pragma warning disable CS1591
        REORDERED,
        #pragma warning restore CS1591
        [EnumMember(Value = "REJECTED")]
        #pragma warning disable CS1591
        REJECTED,
        #pragma warning restore CS1591
        [EnumMember(Value = "SHIPPED")]
        #pragma warning disable CS1591
        SHIPPED,
        #pragma warning restore CS1591
        [EnumMember(Value = "DELIVERED")]
        #pragma warning disable CS1591
        DELIVERED,
        #pragma warning restore CS1591
        [EnumMember(Value = "DIGITALLY_PRESENTED")]
        #pragma warning disable CS1591
        DIGITALLY_PRESENTED,
        #pragma warning restore CS1591
    }
}
