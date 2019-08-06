using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Beers.Core.Models;
using Newtonsoft.Json;

namespace Beers.Core.Services
{
    public class RestService : IRestService
    {
        private const string Url = "https://api.punkapi.com/v2/beers?page=1&per_page=80";
        private readonly HttpClient _client;

        public RestService()
        {
            _client = new HttpClient();
        }

        public async Task<IList<Beer>> GetBeers()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, Url);
            try
            {
                var result = await _client.SendAsync(request);
                return await Deserialize<IList<Beer>>(result);
            }
            catch (Exception)
            {
            }

            return new List<Beer>();
        }

        private async Task<T> Deserialize<T>(HttpResponseMessage response)
        {
            using (var stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
            using (var reader = new StreamReader(stream))
            using (var json = new JsonTextReader(reader))
            {
                var serializer = JsonSerializer.CreateDefault();
                return serializer.Deserialize<T>(json);
            }
        }
    }
}