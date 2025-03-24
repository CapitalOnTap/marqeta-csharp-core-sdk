using System.Globalization;
using System.Xml;
using Marqeta.Core.Sdk.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Helpers;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Serialization.Text;

namespace Marqeta.Core.Sdk.Serialization.Text;

/// <summary>
///     The <see cref="IParseNode"/> implementation for the text/html content type. 
///     Copied from:  <see href="https://github.com/microsoft/kiota-serialization-text-dotnet/blob/main/src/TextParseNode.cs"/>
///     <see cref="TextParseNode"/>
///     Changes will be marked with a MODIFIED comment, otherwise we call the <see cref="TextParseNode"/> implementation
///     Current changes:
///         <see cref="GetObjectValue{T}"/> returns an <see cref="ApiError"/> instead of throwing an error if type matches
/// </summary>
public class TextHtmlParseNode : IParseNode
{
    internal const string NoStructuredDataMessage = "text does not support structured data";
    private readonly string? Text;
    
    /// <summary>
    ///     Initializes a new instance of the <see cref="TextHtmlParseNode"/> class
    /// </summary>
    /// <param name="text">The text value.</param>
    public TextHtmlParseNode(string? text)
    {
        Text = text?.Trim('"');
    }

    /// <inheritdoc />
    public Action<IParsable>? OnBeforeAssignFieldValues { get; set; }
    /// <inheritdoc />
    public Action<IParsable>? OnAfterAssignFieldValues { get; set; }
    /// <inheritdoc />
    public bool? GetBoolValue() => bool.TryParse(Text, out var result) ? result : null;
    /// <inheritdoc />
    public byte[]? GetByteArrayValue() => string.IsNullOrEmpty(Text) ? null : Convert.FromBase64String(Text);
    /// <inheritdoc />
    public byte? GetByteValue() => byte.TryParse(Text, out var result) ? result : null;
    /// <inheritdoc />
    public IParseNode GetChildNode(string identifier) => throw new InvalidOperationException(NoStructuredDataMessage);
    /// <inheritdoc />
    public IEnumerable<T> GetCollectionOfObjectValues<T>(ParsableFactory<T> factory) where T : IParsable => throw new InvalidOperationException(NoStructuredDataMessage);
    /// <inheritdoc />
#if NET5_0_OR_GREATER
    public IEnumerable<T> GetCollectionOfPrimitiveValues<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields)] T>()=> throw new InvalidOperationException(NoStructuredDataMessage);
#else
    public IEnumerable<T> GetCollectionOfPrimitiveValues<T>() => throw new InvalidOperationException(NoStructuredDataMessage);
#endif
    /// <inheritdoc />
    public DateTimeOffset? GetDateTimeOffsetValue() => DateTimeOffset.TryParse(Text, CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind, out var result) ? result : null;
    /// <inheritdoc />
    public Date? GetDateValue() => DateTime.TryParse(Text, CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind, out var result) ? new Date(result) : null;
    /// <inheritdoc />
    public decimal? GetDecimalValue() => decimal.TryParse(Text, NumberStyles.Number, CultureInfo.InvariantCulture, out var result) ? result : null;
    /// <inheritdoc />
    public double? GetDoubleValue() => double.TryParse(Text, NumberStyles.Number, CultureInfo.InvariantCulture, out var result) ? result : null;
    /// <inheritdoc />
    public float? GetFloatValue() => float.TryParse(Text, NumberStyles.Number, CultureInfo.InvariantCulture, out var result) ? result : null;
    /// <inheritdoc />
    public Guid? GetGuidValue() => Guid.TryParse(Text, out var result) ? result : null;
    /// <inheritdoc />
    public int? GetIntValue() => int.TryParse(Text, NumberStyles.Number, CultureInfo.InvariantCulture, out var result) ? result : null;
    /// <inheritdoc />
    public long? GetLongValue() => long.TryParse(Text, NumberStyles.Number, CultureInfo.InvariantCulture, out var result) ? result : null;
    /// <inheritdoc />
    public T GetObjectValue<T>(ParsableFactory<T> factory) where T : IParsable
    {
        // MODIFIED: If the item we want to create is an <see cref="ApiError"/>
        // then set the MessageEscaped as the current text
        var item = factory(this);
        if (item is ApiError { MessageEscaped.Length: 0 } apiError)
            apiError.MessageEscaped = Text;
        return item;
    }
    /// <inheritdoc />
    public sbyte? GetSbyteValue() => sbyte.TryParse(Text, NumberStyles.Number, CultureInfo.InvariantCulture, out var result) ? result : null;
    /// <inheritdoc />
    public string? GetStringValue() => Text;
    /// <inheritdoc />
    public TimeSpan? GetTimeSpanValue() => string.IsNullOrEmpty(Text) ? null : XmlConvert.ToTimeSpan(Text);
    /// <inheritdoc />
    public Time? GetTimeValue() => DateTime.TryParse(Text, CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind, out var result) ? new Time(result) : null;
    /// <inheritdoc />
#if NET5_0_OR_GREATER
    public IEnumerable<T?> GetCollectionOfEnumValues<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields)] T>() where T : struct, Enum
#else
    public IEnumerable<T?> GetCollectionOfEnumValues<T>() where T : struct, Enum
#endif
        => throw new InvalidOperationException(NoStructuredDataMessage);
    /// <inheritdoc />
#if NET5_0_OR_GREATER
    public T? GetEnumValue<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields)] T>() where T : struct, Enum
#else
    public T? GetEnumValue<T>() where T : struct, Enum
#endif
        => Text is null ? null : EnumHelpers.GetEnumValue<T>(Text);
}