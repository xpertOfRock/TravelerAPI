using Microsoft.EntityFrameworkCore;
using Prometheus;
using TravelerAPI.Extensions;

var builder = WebApplication.CreateBuilder(args);

var configuration = builder.Configuration;

builder.Services.AddControllers();
builder.Services.AddOpenApi();

builder.Services.AddCustomServices(configuration);

builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    db.Database.Migrate();
}

app.UseHttpsRedirection();

app.UseMetricServer();
app.UseHttpMetrics();

app.MapControllers();
app.UseExceptionHandler(options => { });
app.Run();
