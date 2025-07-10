/*****
 * Nombre de clase:     DependencyInjection
 * Descripción:         Clase estática encargada de registrar las dependencias del módulo Especialidad
 *                      en el contenedor de inyección de dependencias de la capa de aplicación.
 *                      Incluye la configuración de UseCases, Mappers y Validators.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase creada para centralizar el registro de servicios del módulo Especialidad.
 *****/

using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Especialidad.Dtos;
using Empresa.Application.Especialidad.Mappers;
using Empresa.Application.Especialidad.UseCases;
using Empresa.Application.Especialidad.Validators;
using Empresa.Domain.Especialidad.Parameters;
using Empresa.Domain.Especialidad.Results;

namespace Empresa.Application.Especialidad
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddEspecialidadApplication(this IServiceCollection services)
        {
            // UseCases
            services.AddScoped<IUseCase<ActualizarEspecialidadRequest, SpResultBase>, ActualizarEspecialidadUseCase>();
            services.AddScoped<IUseCase<CrearEspecialidadRequest, SpResultBase>, CrearEspecialidadUseCase>();
            services.AddScoped<IUseCase<EliminarEspecialidadRequest, SpResultBase>, EliminarEspecialidadUseCase>();
            services.AddScoped<IUseCase<ListarEspecialidadPaginadoRequest, PagedResult<EspecialidadResult>>, ListarEspecialidadPaginadaUseCase>();
            services.AddScoped<IUseCase<ListarEspecialidadRequest, List<EspecialidadResult>>, ListarEspecialidadUseCase>();
            services.AddScoped<IUseCase<int, EspecialidadResult?>, ObtenerEspecialidadPorIdUseCase>();

            // Mappers
            services.AddScoped<IMapper<ActualizarEspecialidadRequest, ActualizarEspecialidadParameters>, ActualizarEspecialidadRequestMapper>();
            services.AddScoped<IMapper<CrearEspecialidadRequest, CrearEspecialidadParameters>, CrearEspecialidadRequestMapper>();
            services.AddScoped<IMapper<EliminarEspecialidadRequest, EliminarEspecialidadParameters>, EliminarEspecialidadRequestMapper>();
            services.AddScoped<IMapper<ListarEspecialidadPaginadoRequest, ListarEspecialidadPaginadoParameters>, ListarEspecialidadPaginadoRequestMapper>();
            services.AddScoped<IMapper<ListarEspecialidadRequest, ListarEspecialidadParameters>, ListarEspecialidadRequestMapper>();

            // Validators
            services.AddScoped<IValidator<ActualizarEspecialidadRequest>, ActualizarEspecialidadRequestValidator>();
            services.AddScoped<IValidator<CrearEspecialidadRequest>, CrearEspecialidadRequestValidator>();
            services.AddScoped<IValidator<EliminarEspecialidadRequest>, EliminarEspecialidadRequestValidator>();
            services.AddScoped<IValidator<ListarEspecialidadPaginadoRequest>, ListarEspecialidadPaginadoRequestValidator>();
            services.AddScoped<IValidator<ListarEspecialidadRequest>, ListarEspecialidadRequestValidator>();

            return services;
        }

    }
}
