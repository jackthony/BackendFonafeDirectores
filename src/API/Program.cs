using Api.Common;
using Api.Decorators;
using Api.Middlewares;
using Serilog;
using Shared.Kernel.Interfaces;
using Shared.Time;
using Usuario.Application.Auth;
using Usuario.Infrastructure.Auth;
using Usuario.Application.User;
using Usuario.Infrastructure.User;
using Empresa.Application.Cargo;
using Empresa.Infrastructure.Cargo;
using Empresa.Application.Director;
using Empresa.Infrastructure.Director;
using Empresa.Application.Empresa;
using Empresa.Infrastructure.Empresa;
using Empresa.Application.Especialidad;
using Empresa.Application.Ministerio;
using Empresa.Application.Rubro;
using Empresa.Application.Sector;
using Empresa.Application.TipoDirector;
using Empresa.Infrastructure.Especialidad;
using Empresa.Infrastructure.Ministerio;
using Empresa.Infrastructure.Rubro;
using Empresa.Infrastructure.Sector;
using Empresa.Infrastructure.TipoDirector;

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

builder.Services.AddAuthApplication();
builder.Services.AddAuthInfrastructure();

builder.Services.AddUserApplication();
builder.Services.AddUserInfrastructure();

builder.Services.AddCargoApplication();
builder.Services.AddCargoInfrastructure();

builder.Services.AddDirectorApplication();
builder.Services.AddDirectorInfrastructure();

builder.Services.AddEmpresaApplication();
builder.Services.AddEmpresaInfrastructure();

builder.Services.AddEspecialidadApplication();
builder.Services.AddEspecialidadInfrastructure();

builder.Services.AddMinisterioApplication();
builder.Services.AddMinisterioInfrastructure();

builder.Services.AddRubroApplication();
builder.Services.AddRubroInfrastructure();

builder.Services.AddSectorApplication();
builder.Services.AddSectorInfrastructure();

builder.Services.AddTipoDirectorApplication();
builder.Services.AddTipoDirectorInfrastructure();


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
