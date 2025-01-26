using DahitanGhar.Application.Interfaces;
using DahitanGhar.Infrastructure.DbSet;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

//Config Title for swaggger UI
builder.Services.AddSwaggerDocument(config =>
{
    config.Title = "Dahitan Ghar";
});

//Register DbContext
builder.Services.AddDbContextPool<DgDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DgConnStr"));
});


//Register Services
builder.Services.AddScoped<IDgDbContext, DgDbContext>();


//Config Angular UI
builder.Services.AddSpaStaticFiles(configuration =>
{
    configuration.RootPath = "Client/dist/Client/browser";
});

var app = builder.Build();

var env = app.Environment;
// Configure the HTTP request pipeline.
if (env.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseOpenApi();
    app.UseSwaggerUi(settings =>
    {
        settings.Path = "/api";
    });
}
else
{
    // Use custom exception handler middleware early in the pipeline
    app.UseExceptionHandler("/Home/error"); // Custom path or middleware
    app.UseHsts();
}

//Use below code if static files are to be used in production environment (if angular is used as a client)
app.UseStaticFiles();

if (!app.Environment.IsDevelopment())
{
    app.UseSpaStaticFiles();
}
app.UseRouting();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller}/{action=Index}/{id?}");
});

app.UseSpa(spa =>
{
    spa.Options.SourcePath = "Client/dist/Client/browser"; // this will be used for production...

    if (env.IsDevelopment())
    {
        spa.UseProxyToSpaDevelopmentServer(builder.Configuration["SpaBaseUrl"] ?? "http://localhost:4200");
    }

});


app.Run();
