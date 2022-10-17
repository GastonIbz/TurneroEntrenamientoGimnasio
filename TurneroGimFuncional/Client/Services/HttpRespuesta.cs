namespace TurneroGimFuncional.Client.Services
{
    public class HttpRespuesta<Res>
    {
        public Res Respuesta { get; }
        public bool Error { get; }
        public HttpResponseMessage HttpResponseMessage { get; }

        public HttpRespuesta(Res respuesta, bool error, HttpResponseMessage httpResponseMessage)
        {
            Respuesta = respuesta;
            Error = error;
            HttpResponseMessage = httpResponseMessage;
        }


    }
}
