var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Configure SPA service.
builder.Services.AddSpaStaticFiles(configuration =>
{
    configuration.RootPath = "Client/dist/Client/browser";
});

var app = builder.Build();

// Configure the HTTP request pipeline.
var env = app.Environment;
if (env.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(settings =>
    {
        settings.RoutePrefix = "swagger";
    });
    app.UseDeveloperExceptionPage();
}
else
{
    // Use custom exception handler middleware early in the pipeline
    app.UseExceptionHandler("/Home/error"); // Custom path or middleware
    app.UseHsts();
}

app.UseStaticFiles();
if (!env.IsDevelopment())
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
