// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Marqeta.Core.Sdk.Models
{
    /// <summary>
    /// Contains information about the point of sale, including details on how the card was presented.Returned if provided by the card network, and the request uses Transaction Model v2 of the Marqeta Core API.Not returned for Transaction Model v1 requests.
    /// </summary>
    public class Pos : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>How the terminal accepts card data.</summary>
        public Marqeta.Core.Sdk.Models.Pos_card_data_input_capability? CardDataInputCapability { get; set; }
        /// <summary>Method used to authenticate the cardholder.</summary>
        public Marqeta.Core.Sdk.Models.Pos_cardholder_authentication_method? CardholderAuthenticationMethod { get; set; }
        /// <summary>Whether the cardholder was present during the transaction.</summary>
        public bool? CardHolderPresence { get; set; }
        /// <summary>Whether the card was present during the transaction.</summary>
        public bool? CardPresence { get; set; }
        /// <summary>Country code of the card acceptor or terminal.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CountryCode { get; set; }
#nullable restore
#else
        public string CountryCode { get; set; }
#endif
        /// <summary>Whether the transaction is an installment payment.</summary>
        public bool? IsInstallment { get; set; }
        /// <summary>Whether the transaction is recurring.</summary>
        public bool? IsRecurring { get; set; }
        /// <summary>Method used for capturing the card primary account number (PAN) during the transaction.</summary>
        public Marqeta.Core.Sdk.Models.Pos_pan_entry_mode? PanEntryMode { get; set; }
        /// <summary>Indicates whether the card acceptor or terminal supports partial-approval transactions.</summary>
        public bool? PartialApprovalCapable { get; set; }
        /// <summary>Indicates whether the card acceptor or terminal can capture card personal identification numbers (PINs).*NOTE:* This field does not indicate whether a PIN was entered.</summary>
        public Marqeta.Core.Sdk.Models.Pos_pin_entry_mode? PinEntryMode { get; set; }
        /// <summary>Indicates whether the cardholder entered a PIN during the transaction.</summary>
        public bool? PinPresent { get; set; }
        /// <summary>Indicates whether the card acceptor or terminal supports purchase-only approvals.</summary>
        public bool? PurchaseAmountOnly { get; set; }
        /// <summary>Indicates a higher-risk operation, such as a quasi-cash or cryptocurrency transaction.These transactions typically involve non-financial institutions.</summary>
        public Marqeta.Core.Sdk.Models.Pos_special_condition_indicator? SpecialConditionIndicator { get; set; }
        /// <summary>Whether the card acceptor/terminal was attended.</summary>
        public Marqeta.Core.Sdk.Models.Pos_terminal_attendance? TerminalAttendance { get; set; }
        /// <summary>Card acceptor or terminal identification number.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TerminalId { get; set; }
#nullable restore
#else
        public string TerminalId { get; set; }
#endif
        /// <summary>Location of the card acceptor/terminal.</summary>
        public Marqeta.Core.Sdk.Models.Pos_terminal_location? TerminalLocation { get; set; }
        /// <summary>Type of card acceptor/terminal.</summary>
        public Marqeta.Core.Sdk.Models.Pos_terminal_type? TerminalType { get; set; }
        /// <summary>Specifies whether the transaction was initiated by a cardholder or a merchant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TransactionInitiatedBy { get; set; }
#nullable restore
#else
        public string TransactionInitiatedBy { get; set; }
#endif
        /// <summary>United States ZIP code of the card acceptor or terminal.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Zip { get; set; }
#nullable restore
#else
        public string Zip { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Models.Pos"/> and sets the default values.
        /// </summary>
        public Pos()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Models.Pos"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Marqeta.Core.Sdk.Models.Pos CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Marqeta.Core.Sdk.Models.Pos();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "card_data_input_capability", n => { CardDataInputCapability = n.GetEnumValue<Marqeta.Core.Sdk.Models.Pos_card_data_input_capability>(); } },
                { "card_holder_presence", n => { CardHolderPresence = n.GetBoolValue(); } },
                { "card_presence", n => { CardPresence = n.GetBoolValue(); } },
                { "cardholder_authentication_method", n => { CardholderAuthenticationMethod = n.GetEnumValue<Marqeta.Core.Sdk.Models.Pos_cardholder_authentication_method>(); } },
                { "country_code", n => { CountryCode = n.GetStringValue(); } },
                { "is_installment", n => { IsInstallment = n.GetBoolValue(); } },
                { "is_recurring", n => { IsRecurring = n.GetBoolValue(); } },
                { "pan_entry_mode", n => { PanEntryMode = n.GetEnumValue<Marqeta.Core.Sdk.Models.Pos_pan_entry_mode>(); } },
                { "partial_approval_capable", n => { PartialApprovalCapable = n.GetBoolValue(); } },
                { "pin_entry_mode", n => { PinEntryMode = n.GetEnumValue<Marqeta.Core.Sdk.Models.Pos_pin_entry_mode>(); } },
                { "pin_present", n => { PinPresent = n.GetBoolValue(); } },
                { "purchase_amount_only", n => { PurchaseAmountOnly = n.GetBoolValue(); } },
                { "special_condition_indicator", n => { SpecialConditionIndicator = n.GetEnumValue<Marqeta.Core.Sdk.Models.Pos_special_condition_indicator>(); } },
                { "terminal_attendance", n => { TerminalAttendance = n.GetEnumValue<Marqeta.Core.Sdk.Models.Pos_terminal_attendance>(); } },
                { "terminal_id", n => { TerminalId = n.GetStringValue(); } },
                { "terminal_location", n => { TerminalLocation = n.GetEnumValue<Marqeta.Core.Sdk.Models.Pos_terminal_location>(); } },
                { "terminal_type", n => { TerminalType = n.GetEnumValue<Marqeta.Core.Sdk.Models.Pos_terminal_type>(); } },
                { "transaction_initiated_by", n => { TransactionInitiatedBy = n.GetStringValue(); } },
                { "zip", n => { Zip = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<Marqeta.Core.Sdk.Models.Pos_card_data_input_capability>("card_data_input_capability", CardDataInputCapability);
            writer.WriteEnumValue<Marqeta.Core.Sdk.Models.Pos_cardholder_authentication_method>("cardholder_authentication_method", CardholderAuthenticationMethod);
            writer.WriteBoolValue("card_holder_presence", CardHolderPresence);
            writer.WriteBoolValue("card_presence", CardPresence);
            writer.WriteStringValue("country_code", CountryCode);
            writer.WriteBoolValue("is_installment", IsInstallment);
            writer.WriteBoolValue("is_recurring", IsRecurring);
            writer.WriteEnumValue<Marqeta.Core.Sdk.Models.Pos_pan_entry_mode>("pan_entry_mode", PanEntryMode);
            writer.WriteBoolValue("partial_approval_capable", PartialApprovalCapable);
            writer.WriteEnumValue<Marqeta.Core.Sdk.Models.Pos_pin_entry_mode>("pin_entry_mode", PinEntryMode);
            writer.WriteBoolValue("pin_present", PinPresent);
            writer.WriteBoolValue("purchase_amount_only", PurchaseAmountOnly);
            writer.WriteEnumValue<Marqeta.Core.Sdk.Models.Pos_special_condition_indicator>("special_condition_indicator", SpecialConditionIndicator);
            writer.WriteEnumValue<Marqeta.Core.Sdk.Models.Pos_terminal_attendance>("terminal_attendance", TerminalAttendance);
            writer.WriteStringValue("terminal_id", TerminalId);
            writer.WriteEnumValue<Marqeta.Core.Sdk.Models.Pos_terminal_location>("terminal_location", TerminalLocation);
            writer.WriteEnumValue<Marqeta.Core.Sdk.Models.Pos_terminal_type>("terminal_type", TerminalType);
            writer.WriteStringValue("transaction_initiated_by", TransactionInitiatedBy);
            writer.WriteStringValue("zip", Zip);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
