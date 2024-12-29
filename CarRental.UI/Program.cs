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

//builder.Services.AddSingleton<Helpers>();
//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
//builder.Services.AddSingleton<BookingProcessor>();

await builder.Build().RunAsync();
