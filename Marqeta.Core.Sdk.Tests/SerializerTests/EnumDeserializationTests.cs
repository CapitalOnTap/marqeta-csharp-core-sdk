using System.Threading.Tasks;
using Marqeta.Core.Sdk.Models;
using Marqeta.Core.Sdk.Serialization.Json;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using Xunit;

namespace Marqeta.Core.Sdk.Tests.SerializerTests
{
    public class EnumDeserializationTests
    {
        public EnumDeserializationTests()
        {
            ApiClientBuilder.RegisterDefaultDeserializer<CustomJsonParseNodeFactory>();
        }
        
        [Theory]
        [InlineData("{\"transaction_type\": \"asfasf\"}")]
        [InlineData("{\"transportation_mode\": \"asfasf\"}")]
        [InlineData("{\"transaction_type\": \"asfasf\", \"transportation_mode\": \"BUS\"}")]
        [InlineData("{\"transaction_type\": \"PRE_FUNDED\", \"transportation_mode\": \"abssdfs\"}")]
        public async Task TestDeserialization_ShouldThrow(string json)
        {
            await Assert.ThrowsAsync<System.Text.Json.JsonException>(() => KiotaSerializer.DeserializeAsync<Transit>("application/json", json));
        }
        
        [Theory]
        [InlineData("{\"transaction_type\": \"PRE_FUNDED\"}", Transit_transaction_type.PRE_FUNDED, null)]
        [InlineData("{\"transportation_mode\": \"WATER_BORNE_VEHICLE\"}", null, Transit_transportation_mode.WATER_BORNE_VEHICLE)]
        [InlineData("{\"transaction_type\": \"AUTHORIZED_AGGREGATED_SPLIT_CLEARING\", \"transportation_mode\": \"SELF_DRIVE_VEHICLE\"}", Transit_transaction_type.AUTHORIZED_AGGREGATED_SPLIT_CLEARING, Transit_transportation_mode.SELF_DRIVE_VEHICLE)]
        [InlineData("{\"transaction_type\": \"pre_fUnDeD\"}", Transit_transaction_type.PRE_FUNDED, null)]
        [InlineData("{}", null, null)]
        public async Task TestDeserialization_ShouldDeserialize(string json, Transit_transaction_type? transitTransactionType, Transit_transportation_mode? transitTransportationMode)
        {
            var result = await KiotaSerializer.DeserializeAsync<Transit>("application/json", json);
            Assert.Equal(result.TransactionType, transitTransactionType);
            Assert.Equal(result.TransportationMode, transitTransportationMode);
            
        }
    }
}