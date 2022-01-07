using MRQ.CryptoBot.Domain.Adapter.Token;
using MRQ.CryptoBot.Domain.Adapter.Moralis;
using System.Text.Json;
using MRQ.ReturnContent;

namespace MRQ.CryptoBot.Integration.Moralis
{
    public class MoralisTokenPriceAdapter : ITokenPriceAdapter
    {
        private readonly HttpClient? _httpClient;
        private readonly JsonSerializerOptions? _jsonSerializerOptions;
        private Returned _returned;

        public MoralisTokenPriceAdapter(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _jsonSerializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };


            _returned = ReturnedExtension.CreateReturned();
        }

        public async Task<PriceOfToken> GetTokenFromMoralis(string token)
        {
            _returned.ReturnedState.Message = "MoralisTokenPriceAdapter - Inicio Busca Token Price";
            _httpClient.DefaultRequestHeaders.Clear(); //TODO acertar os headers
            _httpClient.DefaultRequestHeaders.Add("X-API-Key", "jQWrwqiGwAWFhgQEDMiONpkTDU360LPjJfjvNiTvjDkHaFoF4KXKzgsMc5DSF7hd");
            var response = await _httpClient?.GetAsync(string.Format(IntegrationResource.URL, token));
            if (response == null)
                return new PriceOfToken();

            PriceOfToken balanceDto = JsonSerializer.Deserialize<PriceOfToken>(await response.Content.ReadAsStringAsync(), _jsonSerializerOptions);

            _returned.ReturnedState.Message = "MoralisTokenPriceAdapter - Fim Busca Token Price";

            return balanceDto;
        }


    }
}
