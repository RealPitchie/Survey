using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Survey.Persistence;
using Survey.UI.Areas.Identity;
using Survey.UI.Data;
using MudBlazor.Services;
using Survey.UI.Data.Survey;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;
var connectionString = "UserID=root;Password=passmein123;Server=localhost;Port=5432;Database=survey;";

services.AddDbContext<UIContext>(options =>
    options.UseNpgsql(connectionString));

services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<UIContext>();

// Add services to the container. 
services.AddDbContext<DataContext>(options =>
    options.UseNpgsql(connectionString));
services.AddDatabaseDeveloperPageExceptionFilter(); 
services.AddRazorPages();
services.AddServerSideBlazor();
services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();
services.AddMudServices();
services.AddScoped<SurveyRepository>();
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();