using FunApp.Client;
using FunApp.Client.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;
using System.Net.Http;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Register Syncfusion license
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NzE1MTcwQDMyMzAyZTMyMmUzMFVBMUVvVWJKdnR0eHd1VzZFRmIyZ0dNMGpOYVM3T1pnOFBlLzNCa0Fjelk9");

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddSyncfusionBlazor();


// Register all services to use
//builder.Services.AddHttpClient<IPokemonTypeService, PokemonTypeService>(client =>
//{
//    client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
//}).AddHttpMessageHandler<AuthorizationHandler>();

builder.Services.AddHttpClient<IPokemonTypeService, PokemonTypeService>(client =>
{
    client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
});

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });



await builder.Build().RunAsync();
