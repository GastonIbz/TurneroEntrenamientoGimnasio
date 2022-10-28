using System.Globalization;
using System.Text;
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

        public async Task<HttpRespuesta<object>> Post<Res>(string url, Res enviar)
        {
            try
            {
                var enviarJson = JsonSerializer.Serialize(enviar);
                var enviarContent = new StringContent(enviarJson, Encoding.UTF8, "application/json");
                var respuesta = await http.PostAsync(url, enviarContent);
                return new HttpRespuesta<object>(null, !respuesta.IsSuccessStatusCode, respuesta);
            }
            catch (Exception) { throw; }
        }
        public async Task<HttpRespuesta<object>> Put<Res>(string url, Res enviar)
        {
            try
            {
                var enviarJson = JsonSerializer.Serialize(enviar);
                var enviarContent = new StringContent(enviarJson, Encoding.UTF8, "application/json");
                var respuesta = await http.PutAsync(url, enviarContent);
                return new HttpRespuesta<object>(null, !respuesta.IsSuccessStatusCode,
                    respuesta);
            }
            catch (Exception e)           { throw;}
        }

        public async Task<HttpRespuesta<object>> Delete(string url)
        {
            var respuesta = await http.DeleteAsync(url);

            return new HttpRespuesta<object>(null, !respuesta.IsSuccessStatusCode, respuesta);
        }
        


        private async Task<Res> DeserializarRespuesta<Res>(HttpResponseMessage response)
        {
            var respuestaStr = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<Res>(respuestaStr, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
    }
}
