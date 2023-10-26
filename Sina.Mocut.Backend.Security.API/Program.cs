using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Sina.Mocut.Backend.Infrastructure.Database;
using Sina.Mocut.Backend.Security.API.Models;
using System.Linq;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MocutDB>(options =>
{
    options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=MocutDB;Trusted_Connection=True");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();




app.MapPost("/userlogin", (MocutDB DB,LoginRequstDTO loginRequst) =>
{
    Boolean isOk = true;
    var result = DB
    .customers
    .Where(m => m.Phonenumber == loginRequst.PhoneNumber)
    .FirstOrDefault();
    if (result != null )
    {
        return isOk;
    }
    return isOk=false;

});

app.Run();
