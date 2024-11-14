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
    //Add swagger UI
    app.UseOpenApi();
    app.UseSwaggerUi();
}
else
{
    // Use custom exception handler middleware early in the pipeline
    app.UseExceptionHandler("/Home/error"); // Custom path or middleware
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseSpa(spa =>
{
    spa.Options.SourcePath = "Client/dist/Client/browser"; //this will be used for production...

    if (env.IsDevelopment())
    {
        spa.UseProxyToSpaDevelopmentServer(builder.Configuration["SpaBaseUrl"] ?? "http://localhost:4200");
    }
});

app.Run();
