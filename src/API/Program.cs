using Api.Common;
using Api.Decorators;
using Api.Middlewares;
using Usuario.Application;
using Usuario.Infrastructure;
using Usuario.Presentation;
using Serilog;
using Shared.Kernel.Interfaces;
using Shared.Time;
using Empresa.Application.EMP_Empresa;
using Empresa.Presentation.EMP_Empresa;
using Empresa.Infrastructure.EMP_Empresa;
using Empresa.Application.EMP_Cargo;
using Empresa.Infrastructure.EMP_Cargo;
using Empresa.Presentation.EMP_Cargo;
using Usuario.Application.Auth;
using Usuario.Infrastructure.Auth;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Configurar autenticación JWT
// aqui agregar las inyecciones de auth



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

builder.Services.AddSingleton<ITimeProvider, PeruTimeProvider>();

builder.Services.AddDatabase(builder.Configuration);
builder.Services.AddEmpresaApplication();
builder.Services.AddEmpresaInfrastructure();
builder.Services.AddEmpresaPresentation();
builder.Services.AddCargoApplication();
builder.Services.AddCargoInfrastructure();
builder.Services.AddCargoPresentation();

builder.Services.AddUsuarioApplication();
builder.Services.AddUsuarioInfrastructure();
builder.Services.AddUsuarioPresentation();

builder.Services.AddAuthApplication();
builder.Services.AddAuthInfrastructure();

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
