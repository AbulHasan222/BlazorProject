
using FintechHub.UI.Components;
using FintechHub.UI.Configuration;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.IdentityModel.Tokens;
using MudBlazor.Services;
using SecurityAuthManager.Contracts;
using SecurityAuthManager.Repositories;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddServerSideBlazor();
builder.Services.AddHttpContextAccessor();


builder.Services.ConfigureJsonNamingConvention();
builder.Services.ConfigureJWTAuthentication(builder.Configuration);
builder.Services.ConfigureRepositoryWrapper();

builder.Services.AddMemoryCache();
builder.Services.AddStackExchangeRedisCache(op =>
{
    op.Configuration = builder.Configuration.GetConnectionString("redisCach");
});

builder.Services.Configure<object>(builder.Configuration.GetSection("AppSettings"));

builder.Services.AddMudServices();
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddHttpClient("", client => client.BaseAddress = new Uri("https://localhost:7178/"));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseDeveloperExceptionPage();
app.UseStaticFiles();
app.UseAntiforgery();
app.UseEnyimMemcached();
app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.UseSwagger();
app.UseSession();

//app.UseSwaggerUI(c=>c.SwaggerEndpoint("swagger/v1/swagger.json", "v1"));

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
