using MRQ.CryptoBot.Domain.Adapter.Data;
using MRQ.CryptoBot.Domain.Adapter.Moralis;
using System.Text.Json;

namespace MRQ.CryptoBot.Integration.Moralis
{
    public class MoralisBalanceAdapter : IMoralisBalanceAdapter
    {
        private readonly HttpClient? _httpClient;
        private readonly JsonSerializerOptions? _jsonSerializerOptions;

        public MoralisBalanceAdapter(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _jsonSerializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };
        }

        public async Task<BalanceDto> GetTokenFromMoralis(string token)
        {
            _httpClient.DefaultRequestHeaders.Clear(); //TODO acertar os headers
            _httpClient.DefaultRequestHeaders.Add("X-API-Key", "jQWrwqiGwAWFhgQEDMiONpkTDU360LPjJfjvNiTvjDkHaFoF4KXKzgsMc5DSF7hd");
            var response = await _httpClient?.GetAsync(string.Format(IntegrationResource.URL, token));
            if (response == null)
                return new BalanceDto();

            BalanceDto balanceDto = JsonSerializer.Deserialize<BalanceDto>(await response.Content.ReadAsStringAsync(), _jsonSerializerOptions);

            return balanceDto;
        }


    }
}
