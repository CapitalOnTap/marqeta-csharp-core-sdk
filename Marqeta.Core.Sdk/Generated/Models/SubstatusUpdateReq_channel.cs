// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Marqeta.Core.Sdk.Models
{
    /// <summary>The mechanism by which a state designation was applied to a substatus.If no value is set, then it defaults to `API`.* `ADMIN` - Indicates that the state of the substatus was added through the Marqeta Dashboard.* `API` - Indicates that you initiated the update of the substatus through the Core API.Use this value when creating a card transition with an API `POST` request.* `FRAUD` - Indicates that either Marqeta or the card network has determined that the account is fraudulent.* `SYSTEM` - Indicates that the substatus update was initiated by Marqeta.For example, Marqeta determined during application decisioning that the applicant is `MLA`.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum SubstatusUpdateReq_channel
    {
        [EnumMember(Value = "ADMIN")]
        #pragma warning disable CS1591
        ADMIN,
        #pragma warning restore CS1591
        [EnumMember(Value = "API")]
        #pragma warning disable CS1591
        API,
        #pragma warning restore CS1591
        [EnumMember(Value = "FRAUD")]
        #pragma warning disable CS1591
        FRAUD,
        #pragma warning restore CS1591
        [EnumMember(Value = "SYSTEM")]
        #pragma warning disable CS1591
        SYSTEM,
        #pragma warning restore CS1591
    }
}
