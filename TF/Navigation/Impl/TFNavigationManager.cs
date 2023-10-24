using Microsoft.AspNetCore.Components;

namespace TF.Navigation.Impl
{
    public class TFNavigationManager : ITFNavigationManager
    {
        private readonly NavigationManager _navigationManager;

        private const string LOGIN_PAGE = "/login";

        public TFNavigationManager(NavigationManager navigationManager)
        {
            _navigationManager = navigationManager;
        }

        public void NavigateToHomePage()
        {
            _navigationManager.NavigateTo("/");
        }

        public void NavigateToLoginPage()
        {
            _navigationManager.NavigateTo(LOGIN_PAGE);
        }
    }
}
