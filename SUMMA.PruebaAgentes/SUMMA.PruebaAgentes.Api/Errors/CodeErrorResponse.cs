namespace SUMMA.PruebaAgentes.Api.Errors
{
    public class CodeErrorResponse
    {
        public int StatusCode { get; set; }
        public string? Mensaje { get; set; }

        public CodeErrorResponse(int statusCode, string? mensaje = null)
        {
            StatusCode = statusCode;
            Mensaje = mensaje;
        }
        private string GetDefaultMessageStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "El request enviado tiene errores",
                _ => string.Empty
            };
        }
    }
}
