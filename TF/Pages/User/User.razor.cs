using Microsoft.AspNetCore.Components;
using TF.Services;

namespace TF.Pages.User
{
    public partial class User
    {
         [Inject]
         public IUsersService UsersService{ get; set; }

         private bool _isLoadingFinish;

         private async Task GetInfoAsync()
         {
            var hj = await UsersService.GetInfoAsync();
            StateHasChanged();
         }

         protected async override Task OnInitializedAsync()
         {
            await base.OnInitializedAsync();
            await GetInfoAsync();
            await GetAccountAsync();
            _isLoadingFinish = true;
         }

        protected async Task GetAccountAsync()
        {
            var hj = await UsersService.GetAccountsAsync();
            StateHasChanged();
        }
    }
}
