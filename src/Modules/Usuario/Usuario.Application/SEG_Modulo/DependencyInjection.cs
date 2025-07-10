/***********
* Nombre del archivo: DependencyInjection.cs
* Descripción:        Clase de extensión para configurar la inyección de dependencias de la capa de aplicación
*                     del módulo. Registra los casos de uso (UseCases), mappers y validadores
*                     relacionados con las operaciones de gestión de módulos.
* Autor:              Daniel Alva
* Fecha de creación:  10/07/2025
* Última modificación:10/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase para la configuración de inyección de dependencias
*                     de la capa de aplicación del módulo.
***********/

using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Usuario.Application.Modulo.Dtos;
using Usuario.Application.Modulo.Mappers;
using Usuario.Application.Modulo.UseCases;
using Usuario.Application.Modulo.Validators;
using Usuario.Domain.Modulo.Parameters;
using Usuario.Domain.Modulo.Results;

namespace Usuario.Application.Modulo
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddModuloApplication(this IServiceCollection services)
        {
            // UseCases
            services.AddScoped<IUseCase<ActualizarModuloRequest, SpResultBase>, ActualizarModuloUseCase>();
            services.AddScoped<IUseCase<CrearModuloRequest, SpResultBase>, CrearModuloUseCase>();
            services.AddScoped<IUseCase<EliminarModuloRequest, SpResultBase>, EliminarModuloUseCase>();
            services.AddScoped<IUseCase<ListarModuloPaginadoRequest, PagedResult<ModuloResult>>, ListarModuloPaginadaUseCase>();
            services.AddScoped<IUseCase<ListarModuloRequest, List<ModuloResult>>, ListarModuloUseCase>();
            services.AddScoped<IUseCase<int, ModuloResult?>, ObtenerModuloPorIdUseCase>();
            services.AddScoped<IUseCase<int, List<ModuloConAccionesResult>>, ListarModulosConAccionesUseCase>();

            // Mappers
            services.AddScoped<IMapper<ActualizarModuloRequest, ActualizarModuloParameters>, ActualizarModuloRequestMapper>();
            services.AddScoped<IMapper<CrearModuloRequest, CrearModuloParameters>, CrearModuloRequestMapper>();
            services.AddScoped<IMapper<EliminarModuloRequest, EliminarModuloParameters>, EliminarModuloRequestMapper>();
            services.AddScoped<IMapper<ListarModuloPaginadoRequest, ListarModuloPaginadoParameters>, ListarModuloPaginadoRequestMapper>();
            services.AddScoped<IMapper<ListarModuloRequest, ListarModuloParameters>, ListarModuloRequestMapper>();

            // Validators
            services.AddScoped<IValidator<ActualizarModuloRequest>, ActualizarModuloRequestValidator>();
            services.AddScoped<IValidator<CrearModuloRequest>, CrearModuloRequestValidator>();
            services.AddScoped<IValidator<EliminarModuloRequest>, EliminarModuloRequestValidator>();
            services.AddScoped<IValidator<ListarModuloPaginadoRequest>, ListarModuloPaginadoRequestValidator>();
            services.AddScoped<IValidator<ListarModuloRequest>, ListarModuloRequestValidator>();

            return services;
        }

    }
}
