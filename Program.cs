using BowlingApp.Components;
using Microsoft.EntityFrameworkCore;
using BowlingApp.Data;
using BowlingApp.Services;

var builder = WebApplication.CreateBuilder(args);

// Add MySQL EF Core
builder.Services.AddDbContext<DataContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        new MySqlServerVersion(new Version(8, 0, 36)) // match your MySQL version
    ));

builder.Services.AddScoped<IGameService, GameService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IScoreBoardService, ScoreBoardService>();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

// upgrading to version 8.0.2 or later will allow us to two blazor pages from rendering twice by allow to use this parameter
//.AddInteractiveServerRenderMode(options => options.Prerender = false);
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
