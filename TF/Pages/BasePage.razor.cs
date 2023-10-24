using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace TF.Pages
{
    public partial class BasePage
    {
        [Inject]
        public AuthenticationStateProvider AuthenticationStateProvider { get; set; }

        protected override Task OnInitializedAsync() => AuthenticationStateProvider.GetAuthenticationStateAsync();
    }
}
