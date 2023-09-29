using CreditoDigital.Client;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<ICoreVedic, CoreVedic>();

var CoreClientVedic = new ConfigEndpoint(builder.Configuration["endpointCoreVedic"]);

builder.Services.AddSingleton(CoreClientVedic);

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
