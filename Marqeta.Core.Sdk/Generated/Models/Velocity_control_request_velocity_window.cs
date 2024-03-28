// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Marqeta.Core.Sdk.Models {
    /// <summary>Defines the time period to which the `amount_limit` and `usage_limit` fields apply:* *DAY* – one day; days begin at 00:00:00 UTC.* *WEEK* – one week; weeks begin Sundays at 00:00:00 UTC.* *MONTH* – one month; months begin on the first day of month at 00:00:00 UTC.* *LIFETIME* – forever; time period never expires.* *TRANSACTION* – a single transaction.// (2023-05-03): This statement was validated by Processing, as part of a customer inquiry.*NOTE:* If set to `DAY`, `WEEK`, or `MONTH`, the velocity control takes effect retroactively from the beginning of the specified period.The amount and usage data already collected within the first period is counted toward the limits.// (2023-05-03): Commenting this note out, as it is untrue in testing as reported by customers and confirmed by transaction engine team//*NOTE:* Editing any of the following fields on a velocity control resets its usage and amount count to 0://* `merchant_scope.mcc`//* `merchant_scope.mid`//* `merchant_scope.mcc_group`//* `association.user_token`//* `association.card_product_token`</summary>
    public enum Velocity_control_request_velocity_window {
        [EnumMember(Value = "DAY")]
        DAY,
        [EnumMember(Value = "WEEK")]
        WEEK,
        [EnumMember(Value = "MONTH")]
        MONTH,
        [EnumMember(Value = "LIFETIME")]
        LIFETIME,
        [EnumMember(Value = "TRANSACTION")]
        TRANSACTION,
    }
}
