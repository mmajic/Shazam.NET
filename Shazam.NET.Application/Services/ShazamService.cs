using Newtonsoft.Json;
using Shazam.NET.Exceptions;

namespace Shazam.NET
{
    public class ShazamService(string key) : ServiceBase, IShazamService
    {
        private readonly string _key = key;

        public Task<object> AutoCompleteAsync(string term)
        {
            throw new NotImplementedException();
        }

        public Task<object> ListShazamEventsAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<SearchResponse> SearchAsync(string term)
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://shazam.p.rapidapi.com/search?term={term}&locale=en-US&offset=0&limit=5"),
                Headers =
                {
                    { "x-rapidapi-key", _key },
                    { "x-rapidapi-host", "shazam.p.rapidapi.com" },
                },
            };

            var response = await _client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();

                var deserialized = JsonConvert.DeserializeObject<SearchResponse>(content);

                if (deserialized != null)
                {
                    return deserialized;
                }
                else
                {
                    throw new SearchException("Error while deserializing object from the Shazam API");
                }
            }

            throw new SearchException($"Error: {response.StatusCode}");
        }
    }
}