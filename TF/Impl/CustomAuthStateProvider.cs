using System.Net.Http.Headers;
using System.Security.Claims;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using TF.Constants;
using TF.Navigation;

namespace TF.Impl
{
    public class CustomAuthStateProvider : AuthenticationStateProvider
    {
        private static TaskCompletionSource<AuthenticationState> _tcs;

        private readonly ITFNavigationManager _updocNavigationManager;
        //private readonly IAccountService _accountService;
        private readonly HttpClient _httpClient;
        private readonly ILocalStorageService _localStorage;

        public CustomAuthStateProvider(
            ITFNavigationManager updocNavigationManager,
            //IAccountService accountService,
            HttpClient httpClient,
            ILocalStorageService localStorage)
        {
            _updocNavigationManager = updocNavigationManager;
            //_accountService = accountService;
            _httpClient = httpClient;
            _localStorage = localStorage;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var tcs = _tcs;

            if (tcs != null)
            {
                return await tcs.Task;
            }

            _tcs = new();

            var state = new AuthenticationState(new ClaimsPrincipal());
            var accessToken = await _localStorage.GetItemAsStringAsync(StorageKeys.AUTH_TOKEN);
            //var refreshToken = await _localStorage.GetItemAsStringAsync(StorageKeys.REFRESH_TOKEN);

            if (string.IsNullOrEmpty(accessToken))
            {
                _updocNavigationManager.NavigateToLoginPage();
            }
            else
            {
                state = SetAuthenticationState(accessToken);
            }

            NotifyAuthenticationStateChanged(Task.FromResult(state));

            _tcs?.SetResult(state);
            _tcs = null;

            return state;
        }

        /*private async Task<AuthenticationState> RefreshTokensAsync(string refreshToken)
        {
            var state = new AuthenticationState(new ClaimsPrincipal());
            try
            {
                //var tokensPair = await _accountService.RefreshTokensAsync(refreshToken);

                if (tokensPair is not null)
                {
                    await _localStorage.SetItemAsStringAsync(StorageKeys.AUTH_TOKEN, tokensPair.AccessToken);
                    await _localStorage.SetItemAsStringAsync(StorageKeys.REFRESH_TOKEN, tokensPair.RefreshToken);

                    state = SetAuthenticationState(tokensPair.AccessToken);

                    var authorizedDto = await _accountService.GetAuthorizedAsync();

                    await _localStorage.SetItemAsync(StorageKeys.ACCOUNT_CONTEXT, authorizedDto);
                }
            }
            catch
            {
                _updocNavigationManager.NavigateToLoginPage();
            }

            return state;
        }*/

        private AuthenticationState SetAuthenticationState(string accessToken)
        {
            var identity = new ClaimsIdentity(new[] { new Claim(StorageKeys.AUTH_TOKEN, accessToken) }, "Jwt");
            var state = new AuthenticationState(new ClaimsPrincipal(identity));
            Console.WriteLine(accessToken);
            //_httpClient.DefaultRequestHeaders.Authorization = new("Bearer ", accessToken);
            _httpClient.DefaultRequestHeaders.Authorization = new ("Bearer", accessToken);

            return state;
        }

        /*
        private bool IsValidToken(string token)
        {
            var jwtSecurityToken = new JwtSecurityTokenHandler().ReadJwtToken(token);
            var expireClaim = jwtSecurityToken.Claims.FirstOrDefault(x => x.Type == "exp");

            if (long.TryParse(expireClaim?.Value, out var expireSeconds))
            {
                var expireDateTime = DateTimeOffset.FromUnixTimeSeconds(expireSeconds);
                return DateTimeOffset.UtcNow < expireDateTime;
            }

            return false;
        }*/
    }
}
