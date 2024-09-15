using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Blazored.LocalStorage;
using PokeApiNet;
using Pokepedia;
using Pokepedia.Shared;
using Pokepedia.Repos;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddBlazoredLocalStorage();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<PokeApiClient>();

builder.Services.AddScoped<IPokemonSummaryClient, PokemonSummaryBrowserClient>();
builder.Services.AddScoped<ISelectedPokemonRepository, SelectedPokemonRepository>();

await builder.Build().RunAsync();
