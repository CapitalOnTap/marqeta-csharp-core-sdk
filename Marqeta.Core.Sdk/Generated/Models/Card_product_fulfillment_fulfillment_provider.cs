// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Marqeta.Core.Sdk.Models {
    /// <summary>Specifies the fulfillment provider.You can work with providers located in North America, Europe, South America, and the Asia-Pacific region.For more information, see &lt;&lt;/developer-guides/managing-physical-cards#_fulfillment_providers_by_location, Fulfillment providers by location&gt;&gt;.*NOTE:* Expedited processing is available for cards that are fulfilled by link:https://www.arroweye.com/[Arroweye Solutions, window=&quot;_blank&quot;], link:https://www.gi-de.com/[G+D, window=&quot;_blank&quot;], link:http://www.idemia.com[IDEMIA, window=&quot;_blank&quot;], and link:http://perfectplastic.com/[Perfect Plastic Printing, window=&quot;_blank&quot;].You can expedite an order&apos;s processing by using the `expedite` field of the &lt;&lt;/core-api/cards, card&gt;&gt; or &lt;&lt;/core-api/bulk-card-orders, bulkissuance&gt;&gt; object.Contact your Marqeta representative for information regarding the cost of expedited service.</summary>
    public enum Card_product_fulfillment_fulfillment_provider {
        [EnumMember(Value = "PERFECTPLASTIC")]
        PERFECTPLASTIC,
        [EnumMember(Value = "ARROWEYE")]
        ARROWEYE,
        [EnumMember(Value = "IDEMIA")]
        IDEMIA,
        [EnumMember(Value = "IDEMIA_UK")]
        IDEMIA_UK,
        [EnumMember(Value = "IDEMIA_FR")]
        IDEMIA_FR,
        [EnumMember(Value = "IDEMIA_CZ")]
        IDEMIA_CZ,
        [EnumMember(Value = "IDEMIA_APAC")]
        IDEMIA_APAC,
        [EnumMember(Value = "IDEMIA_PL")]
        IDEMIA_PL,
        [EnumMember(Value = "IDEMIA_AU")]
        IDEMIA_AU,
        [EnumMember(Value = "IDEMIA_LA")]
        IDEMIA_LA,
        [EnumMember(Value = "GEMALTO")]
        GEMALTO,
        [EnumMember(Value = "NITECREST")]
        NITECREST,
        [EnumMember(Value = "OBERTHUR")]
        OBERTHUR,
        [EnumMember(Value = "ALLPAY")]
        ALLPAY,
    }
}
