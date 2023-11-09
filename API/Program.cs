using Infra.API.Interfaces;
using Infra.API.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<Infra.Data.ExampleDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddHttpClient<ILocationService, LocationService>(client =>
{
    // TODO: extend base address if possible to include the "search" portion.
    client.BaseAddress = new Uri("https://nominatim.openstreetmap.org/");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
