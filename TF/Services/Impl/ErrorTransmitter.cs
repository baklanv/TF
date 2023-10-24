using System;
using System.Net;

namespace TF.Services.Impl
{
    public class ErrorTransmitter : IErrorTransmitter
    {
        public Action<string, string, string[]> RefreshUI { private get; set; }

        public void ShowExceptionData(
            HttpStatusCode httpCode,
            string errorMessage,
            string[] stackTrace)
        {
            switch (httpCode)
            {
                case HttpStatusCode.BadRequest:
                case HttpStatusCode.Unauthorized:
                case HttpStatusCode.Forbidden:
                case HttpStatusCode.NotFound:
                    RefreshUI?.Invoke(httpCode.ToString(), errorMessage, Array.Empty<string>());
                    return;
            }
            
            if ((int)httpCode >= 500)
            {
                RefreshUI?.Invoke("ServerError", "Details", stackTrace);
            }
            else
            {
                RefreshUI?.Invoke("UnknownError", string.Empty, Array.Empty<string>());
            }
        }
    }
}
