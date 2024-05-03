using Marqeta.Core.Sdk.Models;
using Marqeta.Core.Sdk.Serialization.Json;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using Xunit;

namespace Marqeta.Core.Sdk.Tests.SerializerTests
{
    public class ApiErrorDeserializationTests
    {
        public ApiErrorDeserializationTests()
        {
            ApiClientBuilder.RegisterDefaultDeserializer<CustomJsonParseNodeFactory>();
        }
        
        [Theory]
        [InlineData("{\"error_code\": \"123456\"}", "123456", null, null)]
        [InlineData("{\"error_code\": \"123456\", \"error_message\": \"Hello\"}", "123456", "Hello", null)]
        [InlineData("{\"error_code\": \"123456\", \"error_message\": \"Hello\", \"message\": \"world\"}", "123456", "Hello", "world")]
        [InlineData("{\"error_message\": \"Hello\"}", null, "Hello", null)]
        [InlineData("{\"error_message\": \"Hello\", \"message\": \"world\"}", null, "Hello", "world")]
        [InlineData("{\"message\": \"world\"}", null, null, "world")]
        [InlineData("{\"error_code\": \"123456\", \"message\": \"world\"}", "123456", null, "world")]
        public void TestDeserialization(string json, string expectedErrorCode,string expectedErrorMessage, string expectedMessage)
        {
            var apiError = KiotaSerializer.Deserialize<ApiError>("application/json", json);
            Assert.Equal(expectedErrorCode, apiError.ErrorCode);
            Assert.Equal(expectedErrorMessage, apiError.ErrorMessage);
            Assert.Equal(expectedMessage, apiError.MessageEscaped);
        }
    }
}