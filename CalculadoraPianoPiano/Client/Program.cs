using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using CalculadoraPianoPiano.Client;
using CalculadoraPianoPiano.Shared;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient("CalculadoraPianoPiano.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));

// Supply HttpClient instances that include access tokens when making requests to the server project
builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("CalculadoraPianoPiano.ServerAPI"));

var cliente = new Cliente();
builder.Services.AddSingleton(cliente);
builder.Services.AddAntDesign();

builder.Services.AddBlazorBootstrap();

await builder.Build().RunAsync();

