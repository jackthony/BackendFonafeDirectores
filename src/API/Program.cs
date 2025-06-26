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
using Empresa.Application.Dieta;
using Empresa.Infrastructure.Especialidad;
using Empresa.Infrastructure.Ministerio;
using Empresa.Infrastructure.Rubro;
using Empresa.Infrastructure.Sector;
using Empresa.Infrastructure.TipoDirector;
using Empresa.Infrastructure.Dieta;
using Archivo.Application.Archivo;
using Archivo.Infrastructure.Archivo;
using Empresa.Presentation.EMP_Cargo;
using Empresa.Presentation.EMP_Director;
using Empresa.Presentation.EMP_Empresa;
using Empresa.Presentation.EMP_Especialidad;
using Empresa.Presentation.EMP_Ministerio;
using Empresa.Presentation.EMP_Rubro;
using Empresa.Presentation.EMP_Sector;
using Empresa.Presentation.EMP_TipoDirector;
using Empresa.Presentation.EMP_Dieta;
using Shared.ClientV1;
using Shared.Kernel.Responses;
using Shared.Presenters;
using Usuario.Presentation.User;
using Usuario.Application.Rol;
using Usuario.Infrastructure.Rol;
using Usuario.Presentation.SEG_Rol;
using Usuario.Application.PermisoRol;
using Usuario.Infrastructure.PermisoRol;
using Usuario.Presentation.PermisoRol;
using Empresa.Application.Ubigeo;
using Empresa.Infrastructure.Ubigeo;
using Empresa.Presentation.Ubigeo;
using Usuario.Application.Modulo;
using Usuario.Infrastructure.Modulo;
using Usuario.Presentation.Modulo;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .WriteTo.File("logs/app-.log", rollingInterval: RollingInterval.Day)
    .Enrich.FromLogContext()
    .MinimumLevel.Debug()
    .CreateLogger();

builder.Host.UseSerilog();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "Boa API", Version = "v1" });
});
builder.Services.AddHttpClient();

builder.Services.AddTransient<IPresenterDelivery<SpResultBase, ItemResponse<bool>>, ItemResponseMapperBool>();
builder.Services.AddTransient<IPresenterDelivery<SpResultBase, ItemResponse<int>>, ItemResponseMapperInt>();

builder.Services.AddSingleton<ITimeProvider, PeruTimeProvider>();

builder.Services.AddDatabase(builder.Configuration);
builder.Services.AddStorage();

builder.Services.AddAuthApplication();
builder.Services.AddAuthInfrastructure();

builder.Services.AddUserApplication();
builder.Services.AddUserInfrastructure();
builder.Services.AddUserPresenters();

builder.Services.AddRolApplication();
builder.Services.AddRolInfrastructure();
builder.Services.AddRolPresenters();

builder.Services.AddPermisoRolApplication();
builder.Services.AddPermisoRolInfrastructure();
builder.Services.AddPermisoRolPresenters();

builder.Services.AddCargoApplication();
builder.Services.AddCargoInfrastructure();
builder.Services.AddCargoPresenters();

builder.Services.AddDirectorApplication();
builder.Services.AddDirectorInfrastructure();
builder.Services.AddDirectorPresenters();

builder.Services.AddEmpresaApplication();
builder.Services.AddEmpresaInfrastructure();
builder.Services.AddEmpresaPresenters();

builder.Services.AddEspecialidadApplication();
builder.Services.AddEspecialidadInfrastructure();
builder.Services.AddEspecialidadPresenters();

builder.Services.AddMinisterioApplication();
builder.Services.AddMinisterioInfrastructure();
builder.Services.AddMinisterioPresenters();

builder.Services.AddRubroApplication();
builder.Services.AddRubroInfrastructure();
builder.Services.AddRubroPresenters();

builder.Services.AddSectorApplication();
builder.Services.AddSectorInfrastructure();
builder.Services.AddSectorPresenters();

builder.Services.AddTipoDirectorApplication();
builder.Services.AddTipoDirectorInfrastructure();
builder.Services.AddTipoDirectorPresenters();

builder.Services.AddArchivoApplication();
builder.Services.AddArchivoInfrastructure();

builder.Services.AddUbigeoApplication();
builder.Services.AddUbigeoInfrastructure();
builder.Services.AddUbigeoPresenters();

builder.Services.AddDietaApplication();
builder.Services.AddDietaInfrastructure();
builder.Services.AddDietaPresenters();

builder.Services.AddModuloApplication();
builder.Services.AddModuloInfrastructure();
builder.Services.AddModuloPresenters();

builder.Services.Decorate(typeof(IUseCase<,>), typeof(LoggingUseCaseDecorator<,>));
builder.Services.Decorate(typeof(IUseCase<,>), typeof(ExceptionHandlingUseCaseDecorator<,>));   
builder.Services.Decorate(typeof(IUseCase<,>), typeof(ValidationUseCaseDecorator<,>));

builder.Services.AddCors(options =>
{
    options.AddPolicy("PermitirTodos", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();

app.UseCors("PermitirTodos");

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
