using CarRental.Application.DependencyInjection;
using CarRental.Infrastructure.DepedencyInjection;
using CarRental.UI;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.RegisterMediatrHandlers();
builder.Services.RegisterInfrastructureServices();

await builder.Build().RunAsync();
