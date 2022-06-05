

using Vrudi_MVP_BE.Extensions;
using Vrudi_MVP_BE.VrDbContext;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);
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
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.Run();