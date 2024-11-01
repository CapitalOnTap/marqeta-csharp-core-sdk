// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Marqeta.Core.Sdk.Models
{
    /// <summary>Specifies the fulfillment provider.You can work with providers located in North America, Europe, South America, and the Asia-Pacific region.For more information, see &lt;&lt;/developer-guides/managing-physical-cards#_fulfillment_providers_by_location, Fulfillment providers by location&gt;&gt;.*NOTE:* Expedited processing is available for cards that are fulfilled by link:https://www.arroweye.com/[Arroweye Solutions, window=&quot;_blank&quot;], link:https://www.gi-de.com/[G+D, window=&quot;_blank&quot;], link:http://www.idemia.com[IDEMIA, window=&quot;_blank&quot;], and link:http://perfectplastic.com/[Perfect Plastic Printing, window=&quot;_blank&quot;].You can expedite an order&apos;s processing by using the `expedite` field of the &lt;&lt;/core-api/cards, card&gt;&gt; or &lt;&lt;/core-api/bulk-card-orders, bulkissuance&gt;&gt; object.Contact your Marqeta representative for information regarding the cost of expedited service.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum Card_product_fulfillment_fulfillment_provider
    {
        [EnumMember(Value = "PERFECTPLASTIC")]
        #pragma warning disable CS1591
        PERFECTPLASTIC,
        #pragma warning restore CS1591
        [EnumMember(Value = "ARROWEYE")]
        #pragma warning disable CS1591
        ARROWEYE,
        #pragma warning restore CS1591
        [EnumMember(Value = "IDEMIA")]
        #pragma warning disable CS1591
        IDEMIA,
        #pragma warning restore CS1591
        [EnumMember(Value = "IDEMIA_UK")]
        #pragma warning disable CS1591
        IDEMIA_UK,
        #pragma warning restore CS1591
        [EnumMember(Value = "IDEMIA_FR")]
        #pragma warning disable CS1591
        IDEMIA_FR,
        #pragma warning restore CS1591
        [EnumMember(Value = "IDEMIA_CZ")]
        #pragma warning disable CS1591
        IDEMIA_CZ,
        #pragma warning restore CS1591
        [EnumMember(Value = "IDEMIA_APAC")]
        #pragma warning disable CS1591
        IDEMIA_APAC,
        #pragma warning restore CS1591
        [EnumMember(Value = "IDEMIA_PL")]
        #pragma warning disable CS1591
        IDEMIA_PL,
        #pragma warning restore CS1591
        [EnumMember(Value = "IDEMIA_AU")]
        #pragma warning disable CS1591
        IDEMIA_AU,
        #pragma warning restore CS1591
        [EnumMember(Value = "IDEMIA_LA")]
        #pragma warning disable CS1591
        IDEMIA_LA,
        #pragma warning restore CS1591
        [EnumMember(Value = "GEMALTO")]
        #pragma warning disable CS1591
        GEMALTO,
        #pragma warning restore CS1591
        [EnumMember(Value = "NITECREST")]
        #pragma warning disable CS1591
        NITECREST,
        #pragma warning restore CS1591
        [EnumMember(Value = "OBERTHUR")]
        #pragma warning disable CS1591
        OBERTHUR,
        #pragma warning restore CS1591
        [EnumMember(Value = "ALLPAY")]
        #pragma warning disable CS1591
        ALLPAY,
        #pragma warning restore CS1591
    }
}
