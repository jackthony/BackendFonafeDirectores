/*****
 * Nombre del archivo:  DependencyInjection.cs
 * Descripción:         Configura la inyección de dependencias para el módulo TipoDirector. Registra
 *                      los casos de uso, mapeadores y validadores relacionados en el contenedor de servicios.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/

using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.TipoDirector.Dtos;
using Empresa.Application.TipoDirector.Mappers;
using Empresa.Application.TipoDirector.UseCases;
using Empresa.Application.TipoDirector.Validators;
using Empresa.Domain.TipoDirector.Parameters;
using Empresa.Domain.TipoDirector.Results;

namespace Empresa.Application.TipoDirector
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddTipoDirectorApplication(this IServiceCollection services)
        {
            // UseCases
            services.AddScoped<IUseCase<ActualizarTipoDirectorRequest, SpResultBase>, ActualizarTipoDirectorUseCase>();
            services.AddScoped<IUseCase<CrearTipoDirectorRequest, SpResultBase>, CrearTipoDirectorUseCase>();
            services.AddScoped<IUseCase<EliminarTipoDirectorRequest, SpResultBase>, EliminarTipoDirectorUseCase>();
            services.AddScoped<IUseCase<ListarTipoDirectorPaginadoRequest, PagedResult<TipoDirectorResult>>, ListarTipoDirectorPaginadaUseCase>();
            services.AddScoped<IUseCase<ListarTipoDirectorRequest, List<TipoDirectorResult>>, ListarTipoDirectorUseCase>();
            services.AddScoped<IUseCase<int, TipoDirectorResult?>, ObtenerTipoDirectorPorIdUseCase>();

            // Mappers
            services.AddScoped<IMapper<ActualizarTipoDirectorRequest, ActualizarTipoDirectorParameters>, ActualizarTipoDirectorRequestMapper>();
            services.AddScoped<IMapper<CrearTipoDirectorRequest, CrearTipoDirectorParameters>, CrearTipoDirectorRequestMapper>();
            services.AddScoped<IMapper<EliminarTipoDirectorRequest, EliminarTipoDirectorParameters>, EliminarTipoDirectorRequestMapper>();
            services.AddScoped<IMapper<ListarTipoDirectorPaginadoRequest, ListarTipoDirectorPaginadoParameters>, ListarTipoDirectorPaginadoRequestMapper>();
            services.AddScoped<IMapper<ListarTipoDirectorRequest, ListarTipoDirectorParameters>, ListarTipoDirectorRequestMapper>();

            // Validators
            services.AddScoped<IValidator<ActualizarTipoDirectorRequest>, ActualizarTipoDirectorRequestValidator>();
            services.AddScoped<IValidator<CrearTipoDirectorRequest>, CrearTipoDirectorRequestValidator>();
            services.AddScoped<IValidator<EliminarTipoDirectorRequest>, EliminarTipoDirectorRequestValidator>();
            services.AddScoped<IValidator<ListarTipoDirectorPaginadoRequest>, ListarTipoDirectorPaginadoRequestValidator>();
            services.AddScoped<IValidator<ListarTipoDirectorRequest>, ListarTipoDirectorRequestValidator>();

            return services;
        }

    }
}
