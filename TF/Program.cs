using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TF.Impl;
using TF.Services;
using TF.Services.Impl;
using TF.Navigation;
using TF.Navigation.Impl;

namespace TF
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

           
            builder.Services.AddScoped(_ => new HttpClient { BaseAddress = new Uri("https://invest-public-api.tinkoff.ru/rest/") }); //https://invest-public-api.tinkoff.ru/rest/ //builder.HostEnvironment.BaseAddress
            builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();
            builder.Services.AddAuthorizationCore();
            builder.Services.AddBlazoredLocalStorage();
            //builder.Services.AddLocalization();



            builder.Services.AddScoped<IHttpRepository, HttpRepository>();
            builder.Services.AddScoped<IErrorTransmitter, ErrorTransmitter>();
            builder.Services.AddScoped<IOperationsService, OperationsService>();
            builder.Services.AddScoped<IUsersService, UserService>();

            builder.Services.AddSingleton<ITFNavigationManager, TFNavigationManager>();

            await builder.Build().RunAsync();
        }
    }
}
