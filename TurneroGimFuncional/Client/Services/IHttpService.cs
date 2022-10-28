namespace TurneroGimFuncional.Client.Services
{
    public interface IHttpService
    {
        Task<HttpRespuesta<Res>> Get<Res>(string url);
        Task<HttpRespuesta<object>> Post<Res>(string url, Res enviar);
        Task<HttpRespuesta<object>> Put<Res>(string url, Res enviar);
    }
}