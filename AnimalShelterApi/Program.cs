using AnimalShelterApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authenticaion.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
// Add Services to the container

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticaionScheme)
  .AddJwtBearer(options =>
                  {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                      ValidateIssuer = true,
                      ValidateAudience = true,
                      ValidateLiftime = true,
                      ValidIssuer = builder.Configuration["Jwt:Issuer"],
                      ValidAudience = builder.Configuration["Jwt.Audience"],
                      IssuerSigningKey = new SymmetricSecutriyKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
                    };
                  });

builder.Services.AddControllers();

builder.Services.AddDbContext<AnimalShelterApiContext>(
                  dbContextOptions => dbContextOptions
                    .UseMySql(
                      builder.Configuration["ConnectionStrings:DefaultConnection"],
                      ServerVersion.AutoDetect(builder.Configuration["ConnectionStrings:DefaultConnection"]
                    )
                  )
                );

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}
else
{
  app.UseHttpsRedirection();
}

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();