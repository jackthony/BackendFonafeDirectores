using Api.Common;
using Api.Decorators;
using Api.Middlewares;
using Empresa.Application;
using Empresa.Infrastructure;
using Empresa.Presentation;
using Usuario.Application;
using Usuario.Infrastructure;
using Usuario.Presentation;
using Serilog;
using Shared.Kernel.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Shared.Time;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Configurar autenticación JWT
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.RequireHttpsMetadata = false;
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(builder.Configuration["Jwt:Key"]!)),
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],
        ValidateLifetime = true,
        ClockSkew = TimeSpan.Zero
    };
});


Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .WriteTo.File("logs/app-.log", rollingInterval: RollingInterval.Day)
    .Enrich.FromLogContext()
    .MinimumLevel.Debug()
    .CreateLogger();

builder.Host.UseSerilog();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "Boa API", Version = "v1" });
});

builder.Services.AddSingleton<ITimeProvider, Shared.Time.TimeProvider>();

builder.Services.AddDatabase(builder.Configuration);
builder.Services.AddEmpresaApplication();
builder.Services.AddEmpresaInfrastructure();
builder.Services.AddEmpresaPresentation();

builder.Services.AddUsuarioApplication();
builder.Services.AddUsuarioInfrastructure();
builder.Services.AddUsuarioPresentation();

builder.Services.Decorate(typeof(IUseCase<,>), typeof(LoggingUseCaseDecorator<,>));
builder.Services.Decorate(typeof(IUseCase<,>), typeof(ExceptionHandlingUseCaseDecorator<,>));   
builder.Services.Decorate(typeof(IUseCase<,>), typeof(ValidationUseCaseDecorator<,>));

//builder.Services.Decorate(typeof(IUseCase<,>), typeof(AuditableUseCaseDecorator<,>));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<ExceptionHandlingMiddleware>();

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();
