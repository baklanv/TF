using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace TF
{
    public interface IHttpRepository
    {
        Task<Stream> GetFileRequestAsync<T>(string route, Dictionary<string, string> queryParams = null);

        Task<T> GetRequestAsync<T>(string route, Dictionary<string, string> queryParams = null);

        Task PostRequestAsync(string route, object body);

        Task<TResponse> PostRequestAsync<TResponse>(string route, object body);

        Task<TResponse> PostRequestAsync<TResponse>(string route, HttpContent body);

        Task<string> PostRequestRawResultAsync(string route, object body);

        Task PutRequestAsync(string route, object body);

        Task<TResponse> PutRequestAsync<TResponse>(string route, object body);

        Task PatchRequestAsync(string route, object body);

        Task<TResponse> PatchRequestAsync<TResponse>(string route, object body);

        Task DeleteRequestAsync(string route);
    }
}
