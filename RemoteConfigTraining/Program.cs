using MediatR;
using Microsoft.EntityFrameworkCore;
using RemoteConfigTraining;
using RemoteConfigTraining.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//builder.Services.AddMediatR(typeof(Program));
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
//builder.Services.AddDbContext<ApiContext>(opt => opt.UseInMemoryDatabase("test"));

//builder.Services.AddScoped<IFeatureRepository, FeatureRepository>();

builder.Services.ConfigureCustomServices();


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
