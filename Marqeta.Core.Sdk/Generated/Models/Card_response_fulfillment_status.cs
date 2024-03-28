// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Marqeta.Core.Sdk.Models {
    /// <summary>Card fulfillment status:* *ISSUED:* Initial state of all newly created/issued cards.* *ORDERED:* Card ordered through the card fulfillment provider.* *REORDERED:* Card reordered through the card fulfillment provider.* *REJECTED:* Card rejected by the card fulfillment provider.* *SHIPPED:* Card shipped by the card fulfillment provider.* *DELIVERED:* Card delivered by the card fulfillment provider.* *DIGITALLY_PRESENTED:* Card digitally presented using the `/cards/{token}/showpan` endpoint; does not affect the delivery of physical cards.</summary>
    public enum Card_response_fulfillment_status {
        [EnumMember(Value = "ISSUED")]
        ISSUED,
        [EnumMember(Value = "ORDERED")]
        ORDERED,
        [EnumMember(Value = "REORDERED")]
        REORDERED,
        [EnumMember(Value = "REJECTED")]
        REJECTED,
        [EnumMember(Value = "SHIPPED")]
        SHIPPED,
        [EnumMember(Value = "DELIVERED")]
        DELIVERED,
        [EnumMember(Value = "DIGITALLY_PRESENTED")]
        DIGITALLY_PRESENTED,
    }
}
