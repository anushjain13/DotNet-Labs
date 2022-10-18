using FirstApi.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<FirstApiContext>(options =>
                   options.UseSqlServer(builder.Configuration.GetConnectionString("FirstApiContext")));


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(
        builder =>
        {
            builder.AddPolicy(name: "AllowOrigin", corsPolicy =>
            {
                corsPolicy.AllowAnyOrigin()
                        .AllowAnyHeader()
                        .AllowAnyMethod();
            });
        }
    );


var app = builder.Build();
app.UseCors("AllowOrigin");

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