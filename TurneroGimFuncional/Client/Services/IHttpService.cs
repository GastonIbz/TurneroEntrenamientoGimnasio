namespace TurneroGimFuncional.Client.Services
{
    public interface IHttpService
    {
        Task<HttpRespuesta<Res>> Get<Res>(string url);
    }
}