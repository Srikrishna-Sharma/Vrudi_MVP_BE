

using Vrudi_MVP_BE.Extensions;
using Vrudi_MVP_BE.VrDbContext;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddJwtAuthenticate();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwagger();
builder.Services.AddDependencies();
//builder.Services.AddDbContext<VrudiDbContext>(item => item.UseSqlServer(IConfiguration["ConnectionStrings:MyDB"]));
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