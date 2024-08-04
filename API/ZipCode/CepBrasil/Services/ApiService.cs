namespace CepBrasil.Services
{
    using System.Net.Http;
    using System.Threading.Tasks;
    public class ApiService
    {
        public HttpClient _httpClient;

        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetApiResponseAsync(string requestUri)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(requestUri);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}
