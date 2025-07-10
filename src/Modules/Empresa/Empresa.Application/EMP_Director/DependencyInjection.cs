/*****
 * Nombre del archivo:  DependencyInjection.cs
 * Descripción:         Configura la inyección de dependencias para los casos de uso, mappers y validadores de directores.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Se ha organizado la configuración de dependencias para los casos de uso de directores, mappers y validadores.
 *****/
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Director.Dtos;
using Empresa.Application.Director.Mappers;
using Empresa.Application.Director.UseCases;
using Empresa.Application.Director.Validators;
using Empresa.Domain.Director.Parameters;
using Empresa.Domain.Director.Results;

namespace Empresa.Application.Director
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDirectorApplication(this IServiceCollection services)
        {
            // UseCases
            services.AddScoped<IUseCase<ActualizarDirectorRequest, SpResultBase>, ActualizarDirectorUseCase>();
            services.AddScoped<IUseCase<CrearDirectorRequest, SpResultBase>, CrearDirectorUseCase>();
            services.AddScoped<IUseCase<EliminarDirectorRequest, SpResultBase>, EliminarDirectorUseCase>();
            services.AddScoped<IUseCase<ListarDirectorPaginadoRequest, PagedResult<DirectorResult>>, ListarDirectorPaginadaUseCase>();
            services.AddScoped<IUseCase<ListarDirectorRequest, List<DirectorResult>>, ListarDirectorUseCase>();
            services.AddScoped<IUseCase<int, DirectorResult?>, ObtenerDirectorPorIdUseCase>();

            // Mappers
            services.AddScoped<IMapper<ActualizarDirectorRequest, ActualizarDirectorParameters>, ActualizarDirectorRequestMapper>();
            services.AddScoped<IMapper<CrearDirectorRequest, CrearDirectorParameters>, CrearDirectorRequestMapper>();
            services.AddScoped<IMapper<EliminarDirectorRequest, EliminarDirectorParameters>, EliminarDirectorRequestMapper>();
            services.AddScoped<IMapper<ListarDirectorPaginadoRequest, ListarDirectorPaginadoParameters>, ListarDirectorPaginadoRequestMapper>();
            services.AddScoped<IMapper<ListarDirectorRequest, ListarDirectorParameters>, ListarDirectorRequestMapper>();

            // Validators
            services.AddScoped<IValidator<ActualizarDirectorRequest>, ActualizarDirectorRequestValidator>();
            services.AddScoped<IValidator<CrearDirectorRequest>, CrearDirectorRequestValidator>();
            services.AddScoped<IValidator<EliminarDirectorRequest>, EliminarDirectorRequestValidator>();
            services.AddScoped<IValidator<ListarDirectorPaginadoRequest>, ListarDirectorPaginadoRequestValidator>();
            services.AddScoped<IValidator<ListarDirectorRequest>, ListarDirectorRequestValidator>();

            return services;
        }

    }
}
