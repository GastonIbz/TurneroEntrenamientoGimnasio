using System.Text.Json;
namespace TurneroGimFuncional.Client.Services
{
    public class HttpService : IHttpService
    {
        private readonly HttpClient http;

        public HttpService(HttpClient http)
        {
            this.http = http;
        }
        public async Task<HttpRespuesta<Res>> Get<Res>(string url)
        {
            var response = await http.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var respuesta = await DeserializarRespuesta<Res>(response);
                return new HttpRespuesta<Res>(respuesta, false, response);
            }
            else
            {
                return new HttpRespuesta<Res>(default, true, response);
            }
        }

        private async Task<Res> DeserializarRespuesta<Res>(HttpResponseMessage response)
        {
            var respuestaStr = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<Res>(respuestaStr, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
    }
}
