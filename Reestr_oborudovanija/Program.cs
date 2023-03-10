using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Reestr_oborudovanija;
using Reestr_oborudovanija.Controllers;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<ReestrContext>(options =>
  options.UseSqlite(@"Data Source=G:\programms\sqlite\reestr.sqlite"));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var logger = new LoggerConfiguration()
  .WriteTo.Console()
  .ReadFrom.Configuration(builder.Configuration)
  .CreateLogger();
builder.Logging.ClearProviders();
builder.Logging.AddSerilog(logger);

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.RequireHttpsMetadata = false;
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    // ????????, ????? ?? ?????????????? ???????? ??? ????????? ??????
                    ValidateIssuer = true,
                    // ??????, ?????????????? ????????
                    ValidIssuer = AuthOptions.ISSUER,

                    // ????? ?? ?????????????? ??????????? ??????
                    ValidateAudience = true,
                    // ????????? ??????????? ??????
                    ValidAudience = AuthOptions.AUDIENCE,
                    // ????? ?? ?????????????? ????? ?????????????
                    ValidateLifetime = true,

                    // ????????? ????? ????????????
                    IssuerSigningKey = AuthOptions.GetSymmetricSecurityKey(),
                    // ????????? ????? ????????????
                    ValidateIssuerSigningKey = true,
                };
            });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.UseDefaultFiles();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapDefaultControllerRoute().RequireAuthorization();
});

app.Run();
