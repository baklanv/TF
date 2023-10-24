using System.Threading.Tasks;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using TF.Constants;
using TF.Model;
using TF.Navigation;
using TF.Services;

namespace TF.Pages
{
    public partial class Login
    {
        //[Inject]
        //public IAccountService AccountService { get; set; }

        [Inject]
        public ILocalStorageService LocalStorageService { get; set; }

        [Inject]
        public AuthenticationStateProvider AuthStateProvider { get; set; }

        [Inject]
        public ITFNavigationManager navigationManager { get; set; }

        // private readonly LoginDto _loginDto = new();
        private string _token = "";
        private async Task LogIn()
        {
            //var token = await AccountService.LoginAsync(_loginDto);
            var token = "";
            Console.WriteLine(_token);
            await LocalStorageService.SetItemAsStringAsync(StorageKeys.AUTH_TOKEN, _token);
            await AuthStateProvider.GetAuthenticationStateAsync();
            //var authorizedDto = await AccountService.GetAuthorizedAsync();
            //await LocalStorageService.SetItemAsync(StorageKeys.ACCOUNT_CONTEXT, authorizedDto);
            navigationManager.NavigateToHomePage();
        }
    }
}
