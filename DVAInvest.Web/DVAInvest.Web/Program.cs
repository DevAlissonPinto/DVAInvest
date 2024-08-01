using DVAInvest.Application;
using DVAInvest.Domain.Interfaces.Application;
using DVAInvest.Domain.Interfaces.Services;
using DVAInvest.Domain.Services;
using DVAInvest.Web.Components;
using DVAInvest.Web.Security;
using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddScoped<CookieHandler>();

builder.Services.AddAuthorizationCore();

builder.Services.AddScoped<AuthenticationStateProvider, CookieAuthenticationStateProvider>();
builder.Services.AddScoped(x =>
    (ICookieAuthenticationStateProvider)x.GetRequiredService<AuthenticationStateProvider>());

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Host.ConfigureServices((context, services) => 
{
    DVAInvest.Infra.Ioc.AlmoxarifadoIoc.Initialize(services, context.Configuration);
});

builder.Services.AddHttpClient<IBrapiService, BrapiService>();
builder.Services.AddHttpClient("DVAInvest", opt => { opt.BaseAddress = new Uri("https://localhost:7005"); }).AddHttpMessageHandler<CookieHandler>(); ;

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode();

app.Run();
