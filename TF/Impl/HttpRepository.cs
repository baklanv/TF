using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.WebUtilities;
using TF.Model;
using TF.Services;

namespace TF.Impl
{
    public class HttpRepository : IHttpRepository
    {
        private readonly HttpClient _client;
        private readonly JsonSerializerOptions _jsonOptions;
        private readonly IErrorTransmitter _errorTransmitter;

        public HttpRepository(HttpClient client, IErrorTransmitter errorTransmitter)
        {
            _client = client;
            _errorTransmitter = errorTransmitter;

            _jsonOptions = new JsonSerializerOptions
            {
                //PropertyNameCaseInsensitive = true
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };

            _jsonOptions.Converters.Add(new JsonStringEnumConverter());
        }

        public async Task<Stream> GetFileRequestAsync<T>(string route, Dictionary<string, string> queryParams = null)
        {
            var queryString = queryParams is null ? route : QueryHelpers.AddQueryString(route, queryParams);
            var response = await _client.GetAsync(queryString);

            await EnsureSuccessStatusCodeAsync(response);

            return await _client.GetStreamAsync(queryString);
        }

        public async Task<T> GetRequestAsync<T>(string route, Dictionary<string, string> queryParams = null)
        {
            var queryString = queryParams is null ? route : QueryHelpers.AddQueryString(route, queryParams);
            var response = await _client.GetAsync(queryString);

            await EnsureSuccessStatusCodeAsync(response);

            return await response.Content.ReadFromJsonAsync<T>(_jsonOptions);
        }

        public async Task PatchRequestAsync(string route, object body)
        {
            var response = await _client.PatchAsync(route, JsonContent.Create(inputValue: body, options: _jsonOptions));
            await EnsureSuccessStatusCodeAsync(response);
        }

        public async Task<TResponse> PatchRequestAsync<TResponse>(string route, object body)
        {
            var response = await _client.PatchAsync(route, JsonContent.Create(inputValue: body, options: _jsonOptions));
            await EnsureSuccessStatusCodeAsync(response);

            return await response.Content.ReadFromJsonAsync<TResponse>(_jsonOptions);
        }

        public async Task PostRequestAsync(string route, object body)
        {
            var response = await _client.PostAsJsonAsync(route, body, _jsonOptions);
            await EnsureSuccessStatusCodeAsync(response);
        }

        public async Task<TResponse> PostRequestAsync<TResponse>(string route, object body)
        {
            var response = await _client.PostAsJsonAsync(route, body, _jsonOptions);
            await EnsureSuccessStatusCodeAsync(response);

            return await response.Content.ReadFromJsonAsync<TResponse>(_jsonOptions);
        }

        public async Task<TResponse> PostRequestAsync<TResponse>(string route, HttpContent body)
        {
            var response = await _client.PostAsync(route, body);
            await EnsureSuccessStatusCodeAsync(response);

            return await response.Content.ReadFromJsonAsync<TResponse>(_jsonOptions);
        }

        public async Task<string> PostRequestRawResultAsync(string route, object body)
        {
            var response = await _client.PostAsJsonAsync(route, body, _jsonOptions);
            await EnsureSuccessStatusCodeAsync(response);

            return await response.Content.ReadAsStringAsync();
        }

        public async Task PutRequestAsync(string route, object body)
        {
            var response = await _client.PutAsJsonAsync(route, body, _jsonOptions);
            await EnsureSuccessStatusCodeAsync(response);
        }

        public async Task<TResponse> PutRequestAsync<TResponse>(string route, object body)
        {
            var response = await _client.PutAsJsonAsync(route, body, _jsonOptions);
            await EnsureSuccessStatusCodeAsync(response);

            return await response.Content.ReadFromJsonAsync<TResponse>(_jsonOptions);
        }

        public async Task DeleteRequestAsync(string route)
        {
            var response = await _client.DeleteAsync(route);
            await EnsureSuccessStatusCodeAsync(response);
        }

        private async Task EnsureSuccessStatusCodeAsync(HttpResponseMessage response)
        {
            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException)
            {
                var detail = await response.Content.ReadFromJsonAsync<ServerException>();
                _errorTransmitter.ShowExceptionData(
                    response.StatusCode,
                    detail.Title,
                    detail.Detail?.Split('\n'));
                throw;
            }
        }
    }
}
