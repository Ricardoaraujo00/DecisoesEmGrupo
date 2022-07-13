using DecisoesEmGrupo.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using DecisoesEmGrupo.Client.IService;
using DecisoesEmGrupo.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IPropostaService, PropostaService>();
builder.Services.AddScoped<IComentarioService, ComentarioService>();

builder.Services.AddMudServices();

await builder.Build().RunAsync();