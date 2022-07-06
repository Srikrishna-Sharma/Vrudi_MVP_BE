

using Vrudi_MVP_BE.Extensions;
using Vrudi_MVP_BE.VrDbContext;
using Microsoft.EntityFrameworkCore;
using NLog;

var builder = WebApplication.CreateBuilder(args);
LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));

ConfigurationManager configuration = builder.Configuration;
builder.Services.AddJwtAuthenticate();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwagger();
builder.Services.AddDependencies();
builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddDbContext<VrudiDbContext>(item => item.UseSqlServer(configuration["ConnectionStrings:VrudiDb"]));
var app = builder.Build();
app.UseAuthentication();
app.UseRouting();
app.UseAuthorization();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});
app.UseSwagger();
app.UseSwaggerUI();
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}
app.Run();