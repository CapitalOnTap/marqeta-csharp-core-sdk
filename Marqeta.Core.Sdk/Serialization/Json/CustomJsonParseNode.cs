using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;
using System.Xml;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Helpers;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Serialization.Json;

#if NET5_0_OR_GREATER
using System.Diagnostics.CodeAnalysis;
#endif

namespace Marqeta.Core.Sdk.Serialization.Json;

/// <summary>
///     The <see cref="IParseNode"/> implementation for the json content type.
///     Copied from: <see href="https://github.com/microsoft/kiota-serialization-json-dotnet/blob/main/src/JsonParseNode.cs"/>
///     <see cref="JsonParseNode"/>
///     We don't call the base implementation in <see cref="JsonParseNode"/> as some methods new up a <see cref="JsonParseNode"/>
///     which causes inconsistencies
///     Changes will be marked with a MODIFIED comment 
///     Current changes:
///         <see cref="GetEnumValue{T}"/> throws an <see cref="ArgumentOutOfRangeException"/> instead of null
/// </summary>
public class CustomJsonParseNode : IParseNode
{
    private readonly JsonElement _jsonNode;
    private readonly KiotaJsonSerializationContext _jsonSerializerContext;

    /// <summary>
    /// The <see cref="CustomJsonParseNode"/> constructor.
    /// </summary>
    /// <param name="node">The JsonElement to initialize the node with</param>
    /// <param name="jsonSerializerContext">The JsonSerializerContext to utilize.</param>
    public CustomJsonParseNode(JsonElement node, KiotaJsonSerializationContext jsonSerializerContext)
    {
        _jsonNode = node;
        _jsonSerializerContext = jsonSerializerContext;
    }

    /// <summary>
    /// Get the string value from the json node
    /// </summary>
    /// <returns>A string value</returns>
    public string? GetStringValue() => _jsonNode.Deserialize(_jsonSerializerContext.String);

    /// <summary>
    /// Get the boolean value from the json node
    /// </summary>
    /// <returns>A boolean value</returns>
    public bool? GetBoolValue() => _jsonNode.Deserialize(_jsonSerializerContext.Boolean);

    /// <summary>
    /// Get the byte value from the json node
    /// </summary>
    /// <returns>A byte value</returns>
    public byte? GetByteValue() => _jsonNode.Deserialize(_jsonSerializerContext.Byte);

    /// <summary>
    /// Get the sbyte value from the json node
    /// </summary>
    /// <returns>A sbyte value</returns>
    public sbyte? GetSbyteValue() => _jsonNode.Deserialize(_jsonSerializerContext.SByte);

    /// <summary>
    /// Get the int value from the json node
    /// </summary>
    /// <returns>A int value</returns>
    public int? GetIntValue() => _jsonNode.Deserialize(_jsonSerializerContext.Int32);

    /// <summary>
    /// Get the float value from the json node
    /// </summary>
    /// <returns>A float value</returns>
    public float? GetFloatValue() => _jsonNode.Deserialize(_jsonSerializerContext.Single);

    /// <summary>
    /// Get the Long value from the json node
    /// </summary>
    /// <returns>A Long value</returns>
    public long? GetLongValue() => _jsonNode.Deserialize(_jsonSerializerContext.Int64);

    /// <summary>
    /// Get the double value from the json node
    /// </summary>
    /// <returns>A double value</returns>
    public double? GetDoubleValue() => _jsonNode.Deserialize(_jsonSerializerContext.Double);

    /// <summary>
    /// Get the decimal value from the json node
    /// </summary>
    /// <returns>A decimal value</returns>
    public decimal? GetDecimalValue() => _jsonNode.Deserialize(_jsonSerializerContext.Decimal);

    /// <summary>
    /// Get the guid value from the json node
    /// </summary>
    /// <returns>A guid value</returns>
    public Guid? GetGuidValue() => _jsonNode.TryGetGuid(out var guid) ? 
        guid : _jsonNode.Deserialize(_jsonSerializerContext.Guid);

    /// <summary>
    /// Get the <see cref="DateTimeOffset"/> value from the json node
    /// </summary>
    /// <returns>A <see cref="DateTimeOffset"/> value</returns>
    public DateTimeOffset? GetDateTimeOffsetValue()
    {
        if(_jsonNode.ValueKind != JsonValueKind.String)
            return null;

        if(TryGetUsingTypeInfo(_jsonNode, _jsonSerializerContext.DateTimeOffset, out var dateTimeOffset))
            return dateTimeOffset;
        else if(DateTimeOffset.TryParse(_jsonNode.GetString(), CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind, out var dto))
            return dto;
        else return null;
    }

    /// <summary>
    /// Get the <see cref="TimeSpan"/> value from the json node
    /// </summary>
    /// <returns>A <see cref="TimeSpan"/> value</returns>
    public TimeSpan? GetTimeSpanValue()
    {
        var jsonString = _jsonNode.GetString();
        if(string.IsNullOrEmpty(jsonString))
            return null;

        // Parse an ISO8601 duration.http://en.wikipedia.org/wiki/ISO_8601#Durations to a TimeSpan
        return XmlConvert.ToTimeSpan(jsonString);
    }

    /// <summary>
    /// Get the <see cref="Date"/> value from the json node
    /// </summary>
    /// <returns>A <see cref="Date"/> value</returns>
    public Date? GetDateValue()
    {
        if(_jsonNode.ValueKind != JsonValueKind.String)
            return null;

        if(TryGetUsingTypeInfo(_jsonNode, _jsonSerializerContext.Date, out var date))
            return date;
        else if(DateTime.TryParse(_jsonNode.GetString(), CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind, out var dt))
            return new Date(dt);
        else return null;
    }

    /// <summary>
    /// Get the <see cref="Time"/> value from the json node
    /// </summary>
    /// <returns>A <see cref="Time"/> value</returns>
    public Time? GetTimeValue()
    {
        if(_jsonNode.ValueKind != JsonValueKind.String)
            return null;

        if(TryGetUsingTypeInfo(_jsonNode, _jsonSerializerContext.Time, out var time))
            return time;
        if(DateTime.TryParse(_jsonNode.GetString(), CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind, out var result))
            return new Time(result);
        else return null;
    }

    /// <summary>
    /// Get the enumeration value of type <typeparam name="T"/>from the json node
    /// </summary>
    /// <returns>An enumeration value or null</returns>
#if NET5_0_OR_GREATER
    public T? GetEnumValue<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields)] T>() where T : struct, Enum
#else
        public T? GetEnumValue<T>() where T : struct, Enum
#endif
    {
        var rawValue = _jsonNode.GetString();
        
        // MODIFIED: Don't try to parse if we don't have a value to parse as we don't want an exception here.
        if(string.IsNullOrEmpty(rawValue)) return null;
        
        var type = typeof(T);
        return EnumHelpers.GetEnumValue<T>(rawValue!)
               // MODIFICATION: We want to throw an exception rather than return null
            ?? throw new ArgumentOutOfRangeException(type.FullName, rawValue, "Unable to parse enum value");
    }

    /// <summary>
    /// Get the collection of type <typeparam name="T"/>from the json node
    /// </summary>
    /// <param name="factory">The factory to use to create the model object.</param>
    /// <returns>A collection of objects</returns>
    public IEnumerable<T> GetCollectionOfObjectValues<T>(ParsableFactory<T> factory) where T : IParsable
    {
        
        var enumerator = _jsonNode.EnumerateArray();
        while(enumerator.MoveNext())
        {
            var currentParseNode = new CustomJsonParseNode(enumerator.Current, _jsonSerializerContext)
            {
                OnAfterAssignFieldValues = OnAfterAssignFieldValues,
                OnBeforeAssignFieldValues = OnBeforeAssignFieldValues
            };
            yield return currentParseNode.GetObjectValue<T>(factory);
        }
    }
    /// <summary>
    /// Gets the collection of enum values of the node.
    /// </summary>
    /// <returns>The collection of enum values.</returns>
#if NET5_0_OR_GREATER
    public IEnumerable<T?> GetCollectionOfEnumValues<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields)] T>() where T : struct, Enum
#else
        public IEnumerable<T?> GetCollectionOfEnumValues<T>() where T : struct, Enum
#endif
    {
        var enumerator = _jsonNode.EnumerateArray();
        while(enumerator.MoveNext())
        {
            var currentParseNode = new CustomJsonParseNode(enumerator.Current, _jsonSerializerContext)
            {
                OnAfterAssignFieldValues = OnAfterAssignFieldValues,
                OnBeforeAssignFieldValues = OnBeforeAssignFieldValues
            };
            yield return currentParseNode.GetEnumValue<T>();
        }
    }
    /// <summary>
    /// Gets the byte array value of the node.
    /// </summary>
    /// <returns>The byte array value of the node.</returns>
    public byte[]? GetByteArrayValue()
    {
        if(_jsonNode.ValueKind is JsonValueKind.String && _jsonNode.TryGetBytesFromBase64(out var result))
            return result;
        return null;
    }
    /// <summary>
    /// Gets the untyped value of the node
    /// </summary>
    /// <returns>The untyped value of the node.</returns>
    private UntypedNode GetUntypedValue() => GetUntypedValue(_jsonNode);


    /// <summary>
    /// Get the collection of primitives of type <typeparam name="T"/>from the json node
    /// </summary>
    /// <returns>A collection of objects</returns>
#if NET5_0_OR_GREATER
        public IEnumerable<T> GetCollectionOfPrimitiveValues<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields)] T>()
#else
    public IEnumerable<T> GetCollectionOfPrimitiveValues<T>()
#endif
    {
        var genericType = typeof(T);
        foreach(var collectionValue in _jsonNode.EnumerateArray())
        {
            var currentParseNode = new CustomJsonParseNode(collectionValue, _jsonSerializerContext)
            {
                OnBeforeAssignFieldValues = OnBeforeAssignFieldValues,
                OnAfterAssignFieldValues = OnAfterAssignFieldValues
            };
            if(genericType == TypeConstants.BooleanType)
                yield return (T)(object)currentParseNode.GetBoolValue()!;
            else if(genericType == TypeConstants.ByteType)
                yield return (T)(object)currentParseNode.GetByteValue()!;
            else if(genericType == TypeConstants.SbyteType)
                yield return (T)(object)currentParseNode.GetSbyteValue()!;
            else if(genericType == TypeConstants.StringType)
                yield return (T)(object)currentParseNode.GetStringValue()!;
            else if(genericType == TypeConstants.IntType)
                yield return (T)(object)currentParseNode.GetIntValue()!;
            else if(genericType == TypeConstants.FloatType)
                yield return (T)(object)currentParseNode.GetFloatValue()!;
            else if(genericType == TypeConstants.LongType)
                yield return (T)(object)currentParseNode.GetLongValue()!;
            else if(genericType == TypeConstants.DoubleType)
                yield return (T)(object)currentParseNode.GetDoubleValue()!;
            else if(genericType == TypeConstants.GuidType)
                yield return (T)(object)currentParseNode.GetGuidValue()!;
            else if(genericType == TypeConstants.DateTimeOffsetType)
                yield return (T)(object)currentParseNode.GetDateTimeOffsetValue()!;
            else if(genericType == TypeConstants.TimeSpanType)
                yield return (T)(object)currentParseNode.GetTimeSpanValue()!;
            else if(genericType == TypeConstants.DateType)
                yield return (T)(object)currentParseNode.GetDateValue()!;
            else if(genericType == TypeConstants.TimeType)
                yield return (T)(object)currentParseNode.GetTimeValue()!;
            else if(currentParseNode.GetStringValue() is { Length: > 0 } rawValue)
            {
                yield return (T)EnumHelpers.GetEnumValue(genericType, rawValue)!;
            }
            else
                throw new InvalidOperationException($"unknown type for deserialization {genericType.FullName}");
        }
    }

    /// <summary>
    /// Gets the collection of untyped values of the node.
    /// </summary>
    /// <returns>The collection of untyped values.</returns>
    private IEnumerable<UntypedNode> GetCollectionOfUntypedValues(JsonElement jsonNode)
    {
        foreach(var collectionValue in jsonNode.EnumerateArray())
        {
            var currentParseNode = new CustomJsonParseNode(collectionValue, _jsonSerializerContext)
            {
                OnBeforeAssignFieldValues = OnBeforeAssignFieldValues,
                OnAfterAssignFieldValues = OnAfterAssignFieldValues
            };
            yield return currentParseNode.GetUntypedValue();
        }
    }

    /// <summary>
    /// Gets the collection of properties in the untyped object.
    /// </summary>
    /// <returns>The collection of properties in the untyped object.</returns>
    private IDictionary<string, UntypedNode> GetPropertiesOfUntypedObject(JsonElement jsonNode)
    {
        var properties = new Dictionary<string, UntypedNode>();
        if(jsonNode.ValueKind == JsonValueKind.Object)
        {
            foreach(var objectValue in jsonNode.EnumerateObject())
            {
                JsonElement property = objectValue.Value;
                if(objectValue.Value.ValueKind == JsonValueKind.Object)
                {
                    var childNode = new CustomJsonParseNode(objectValue.Value, _jsonSerializerContext)
                    {
                        OnBeforeAssignFieldValues = OnBeforeAssignFieldValues,
                        OnAfterAssignFieldValues = OnAfterAssignFieldValues
                    };
                    var objectVal = childNode.GetPropertiesOfUntypedObject(childNode._jsonNode);
                    properties[objectValue.Name] = new UntypedObject(objectVal);
                }
                else
                {
                    properties[objectValue.Name] = GetUntypedValue(property);
                }
            }
        }
        return properties;
    }

    private UntypedNode GetUntypedValue(JsonElement jsonNode) => jsonNode.ValueKind switch
    {
        JsonValueKind.Number when jsonNode.TryGetInt32(out var intValue) => new UntypedInteger(intValue),
        JsonValueKind.Number when jsonNode.TryGetInt64(out var longValue) => new UntypedLong(longValue),
        JsonValueKind.Number when jsonNode.TryGetDecimal(out var decimalValue) => new UntypedDecimal(decimalValue),
        JsonValueKind.Number when jsonNode.TryGetSingle(out var floatValue) => new UntypedFloat(floatValue),
        JsonValueKind.Number when jsonNode.TryGetDouble(out var doubleValue) => new UntypedDouble(doubleValue),
        JsonValueKind.String => new UntypedString(jsonNode.GetString()),
        JsonValueKind.True or JsonValueKind.False => new UntypedBoolean(jsonNode.GetBoolean()),
        JsonValueKind.Array => new UntypedArray(GetCollectionOfUntypedValues(jsonNode)),
        JsonValueKind.Object => new UntypedObject(GetPropertiesOfUntypedObject(jsonNode)),
        JsonValueKind.Null or JsonValueKind.Undefined => new UntypedNull(),
        _ => throw new InvalidOperationException($"unexpected additional value type during deserialization json kind : {jsonNode.ValueKind}")
    };

    /// <summary>
    /// The action to perform before assigning field values.
    /// </summary>
    public Action<IParsable>? OnBeforeAssignFieldValues { get; set; }

    /// <summary>
    /// The action to perform after assigning field values.
    /// </summary>
    public Action<IParsable>? OnAfterAssignFieldValues { get; set; }

    /// <summary>
    /// Get the object of type <typeparam name="T"/>from the json node
    /// </summary>
    /// <param name="factory">The factory to use to create the model object.</param>
    /// <returns>An object of the specified type</returns>
    public T GetObjectValue<T>(ParsableFactory<T> factory) where T : IParsable
    {
        // until interface exposes GetUntypedValue()
        var genericType = typeof(T);
        if(genericType == typeof(UntypedNode))
        {
            return (T)(object)GetUntypedValue();
        }
        
        var item = factory(this);
        OnBeforeAssignFieldValues?.Invoke(item);
        AssignFieldValues(item);
        OnAfterAssignFieldValues?.Invoke(item);
        return item;
    }
    private void AssignFieldValues<T>(T item) where T : IParsable
    {
        if(_jsonNode.ValueKind != JsonValueKind.Object) return;
        IDictionary<string, object>? itemAdditionalData = null;
        if(item is IAdditionalDataHolder holder)
        {
            holder.AdditionalData ??= new Dictionary<string, object>();
            itemAdditionalData = holder.AdditionalData;
        }
        var fieldDeserializers = item.GetFieldDeserializers();  

        foreach(var fieldValue in _jsonNode.EnumerateObject())
        {
            if(fieldDeserializers.ContainsKey(fieldValue.Name))
            {
                if(fieldValue.Value.ValueKind == JsonValueKind.Null)
                    continue;// If the property is already null just continue. As calling functions like GetDouble,GetBoolValue do not process JsonValueKind.Null.

                var fieldDeserializer = fieldDeserializers[fieldValue.Name];
                Debug.WriteLine($"found property {fieldValue.Name} to deserialize");
                
                // MODIFIED: Wrap fieldDeserializer.Invoke() in a try catch to catch json parsing exceptions and rethrow with a more useful error.
                try
                {
                    fieldDeserializer.Invoke(new CustomJsonParseNode(fieldValue.Value, _jsonSerializerContext)
                    {
                        OnBeforeAssignFieldValues = OnBeforeAssignFieldValues,
                        OnAfterAssignFieldValues = OnAfterAssignFieldValues
                    });
                }
                catch (Exception ex)
                {
                    throw new JsonException($"Failed to deserialize property: {fieldValue.Name} on type {typeof(T).FullName}", ex);
                }
            }
            else if (itemAdditionalData != null)
            {
                Debug.WriteLine($"found additional property {fieldValue.Name} to deserialize");
                IDictionaryExtensions.TryAdd(itemAdditionalData, fieldValue.Name, TryGetAnything(fieldValue.Value)!);
            }
            else
            {
                Debug.WriteLine($"found additional property {fieldValue.Name} to deserialize but the model doesn't support additional data");
            }
        }
    }
    private object? TryGetAnything(JsonElement element)
    {
        switch(element.ValueKind)
        {
            case JsonValueKind.Number:
                if(element.TryGetDecimal(out var dec)) return dec;
                else if(element.TryGetDouble(out var db)) return db;
                else if(element.TryGetInt16(out var s)) return s;
                else if(element.TryGetInt32(out var i)) return i;
                else if(element.TryGetInt64(out var l)) return l;
                else if(element.TryGetSingle(out var f)) return f;
                else if(element.TryGetUInt16(out var us)) return us;
                else if(element.TryGetUInt32(out var ui)) return ui;
                else if(element.TryGetUInt64(out var ul)) return ul;
                else throw new InvalidOperationException("unexpected additional value type during number deserialization");
            case JsonValueKind.String:
                if(element.TryGetDateTime(out var dt)) return dt;
                else if(element.TryGetDateTimeOffset(out var dto)) return dto;
                else if(element.TryGetGuid(out var g)) return g;
                else return element.GetString();
            case JsonValueKind.Array:
            case JsonValueKind.Object:
                return GetUntypedValue(element);
            case JsonValueKind.True:
                return true;
            case JsonValueKind.False:
                return false;
            case JsonValueKind.Null:
            case JsonValueKind.Undefined:
                return null;
            default:
                throw new InvalidOperationException($"unexpected additional value type during deserialization json kind : {element.ValueKind}");
        }
    }

    /// <summary>
    /// Get the child node of the specified identifier
    /// </summary>
    /// <param name="identifier">The identifier of the child node</param>
    /// <returns>An instance of <see cref="IParseNode"/></returns>
    public IParseNode? GetChildNode(string identifier)
    {
        if(_jsonNode.ValueKind == JsonValueKind.Object && _jsonNode.TryGetProperty(identifier ?? throw new ArgumentNullException(nameof(identifier)), out var jsonElement)) 
        {
            return new CustomJsonParseNode(jsonElement, _jsonSerializerContext)
            {
                OnBeforeAssignFieldValues = OnBeforeAssignFieldValues,
                OnAfterAssignFieldValues = OnAfterAssignFieldValues
            };
        }

        return default;
    }
        
#if NET5_0_OR_GREATER
    private static string ToEnumRawName<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields)] T>(string value) where T : struct, Enum
#else
        private static string ToEnumRawName<T>(string value) where T : struct, Enum
#endif
    {
        foreach (var field in typeof(T).GetFields())
        {
            if (field.GetCustomAttribute<EnumMemberAttribute>() is { } attr &&
                value.Equals(attr.Value, StringComparison.Ordinal))
            {
                return field.Name;
            }
        }

        return value;
    }
        
    private static bool TryGetUsingTypeInfo<T>(JsonElement currentElement, JsonTypeInfo<T>? typeInfo, out T? deserializedValue)
    {
        try
        {
            deserializedValue = currentElement.Deserialize(typeInfo!);
            return true;
        }
        catch(Exception)
        {
            deserializedValue = default;
            return false;
        }
    }
}