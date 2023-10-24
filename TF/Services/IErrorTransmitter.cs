using System;
using System.Net;

namespace TF.Services
{
    public interface IErrorTransmitter
    {
        Action<string, string, string[]> RefreshUI { set; }

        void ShowExceptionData(HttpStatusCode httpCode, string errorMessage, string[] stackTrace);
    }
}
