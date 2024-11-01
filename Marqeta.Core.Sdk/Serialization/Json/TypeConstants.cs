using Microsoft.Kiota.Abstractions;

namespace Marqeta.Core.Sdk.Serialization.Json;

/// <summary>
///     Copied from  <see href="https://github.com/microsoft/kiota-serialization-json-dotnet/blob/main/src/TypeConstants.cs"/>
///     <see cref="Microsoft.Kiota.Serialization.Json.TypeConstants"/>
/// </summary>
static internal class TypeConstants
{
    static readonly internal Type BooleanType = typeof(bool?);
    static readonly internal Type ByteType = typeof(byte?);
    static readonly internal Type SbyteType = typeof(sbyte?);
    static readonly internal Type StringType = typeof(string);
    static readonly internal Type IntType = typeof(int?);
    static readonly internal Type FloatType = typeof(float?);
    static readonly internal Type LongType = typeof(long?);
    static readonly internal Type DoubleType = typeof(double?);
    static readonly internal Type DecimalType = typeof(decimal?);
    static readonly internal Type GuidType = typeof(Guid?);
    static readonly internal Type DateTimeOffsetType = typeof(DateTimeOffset?);
    static readonly internal Type TimeSpanType = typeof(TimeSpan?);
    static readonly internal Type DateType = typeof(Date?);
    static readonly internal Type TimeType = typeof(Time?);
}