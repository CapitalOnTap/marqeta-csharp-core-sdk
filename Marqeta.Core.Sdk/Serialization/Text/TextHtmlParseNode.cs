using Marqeta.Core.Sdk.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Serialization.Text;

namespace Marqeta.Core.Sdk.Serialization.Text;

/// <summary>
/// The <see cref="IParseNode"/> implementation for the text/html content type. 
/// Copied from: https://github.com/microsoft/kiota-serialization-text-dotnet/blob/main/src/TextParseNode.cs
/// <see cref="TextParseNode"/>
/// Changes will be marked with a MODIFIED comment, otherwise we call the <see cref="TextParseNode"/> implementation
/// Current changes:
///     <see cref="GetObjectValue{T}"/> returns an <see cref="ApiError"/> instead of throwing an error if type matches
/// </summary>
public class TextHtmlParseNode : IParseNode
{
    private readonly TextParseNode _textParseNode;
    private readonly string? _text;
    /// <summary>
    /// Initializes a new instance of the <see cref="TextHtmlParseNode"/> class
    /// </summary>
    /// <param name="text">The text value.</param>
    public TextHtmlParseNode(string? text)
    {
        _text = text?.Trim('"');
        _textParseNode = new TextParseNode(text);
    }
    /// <inheritdoc />
    public Action<IParsable>? OnBeforeAssignFieldValues { get; set; }
    /// <inheritdoc />
    public Action<IParsable>? OnAfterAssignFieldValues { get; set; }
    /// <inheritdoc />
    public bool? GetBoolValue() => _textParseNode.GetBoolValue();
    /// <inheritdoc />
    public byte[]? GetByteArrayValue() => _textParseNode.GetByteArrayValue();
    /// <inheritdoc />
    public byte? GetByteValue() => _textParseNode.GetByteValue();
    /// <inheritdoc />
    public IParseNode GetChildNode(string identifier) => _textParseNode.GetChildNode(identifier);
    /// <inheritdoc />
    public IEnumerable<T> GetCollectionOfObjectValues<T>(ParsableFactory<T> factory) where T : IParsable => 
        _textParseNode.GetCollectionOfObjectValues(factory);
    /// <inheritdoc />
    public IEnumerable<T> GetCollectionOfPrimitiveValues<T>() => _textParseNode.GetCollectionOfPrimitiveValues<T>();
    /// <inheritdoc />
    public DateTimeOffset? GetDateTimeOffsetValue() => _textParseNode.GetDateTimeOffsetValue();
    /// <inheritdoc />
    public Date? GetDateValue() => _textParseNode.GetDateValue();
    /// <inheritdoc />
    public decimal? GetDecimalValue() => _textParseNode.GetDecimalValue();
    /// <inheritdoc />
    public double? GetDoubleValue() => _textParseNode.GetDoubleValue();
    /// <inheritdoc />
    public float? GetFloatValue() => _textParseNode.GetFloatValue();
    /// <inheritdoc />
    public Guid? GetGuidValue() => _textParseNode.GetGuidValue();
    /// <inheritdoc />
    public int? GetIntValue() => _textParseNode.GetIntValue();
    /// <inheritdoc />
    public long? GetLongValue() => _textParseNode.GetLongValue();
    /// <inheritdoc />
    public T GetObjectValue<T>(ParsableFactory<T> factory) where T : IParsable
    {
        // MODIFIED: If the item we want to create is an <see cref="ApiError"/>
        // then set the MessageEscaped as the current text
        var item = factory(this);
        if (item is ApiError { MessageEscaped.Length: 0 } apiError)
            apiError.MessageEscaped = _text;
        return item;
    }
    /// <inheritdoc />
    public sbyte? GetSbyteValue() => _textParseNode.GetSbyteValue();
    /// <inheritdoc />
    public string? GetStringValue() => _textParseNode.GetStringValue();
    /// <inheritdoc />
    public TimeSpan? GetTimeSpanValue() => _textParseNode.GetTimeSpanValue();
    /// <inheritdoc />
    public Time? GetTimeValue() => _textParseNode.GetTimeValue();
    /// <inheritdoc />
#if NET5_0_OR_GREATER
    public IEnumerable<T?> GetCollectionOfEnumValues<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields)] T>() where T : struct, Enum
#else
    public IEnumerable<T?> GetCollectionOfEnumValues<T>() where T : struct, Enum
#endif
    => _textParseNode.GetCollectionOfEnumValues<T>();
    /// <inheritdoc />
#if NET5_0_OR_GREATER
    public T? GetEnumValue<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields)] T>() where T : struct, Enum
#else
    public T? GetEnumValue<T>() where T : struct, Enum
#endif
    => _textParseNode.GetEnumValue<T>();
}