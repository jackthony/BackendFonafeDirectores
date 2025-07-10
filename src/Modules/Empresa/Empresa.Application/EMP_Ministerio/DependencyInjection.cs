/*****
 * Nombre de clase:     DependencyInjection
 * Descripción:         Clase estática encargada de registrar las dependencias del módulo Ministerio
 *                      en el contenedor de inyección de dependencias de la capa de aplicación.
 *                      Incluye la configuración de UseCases, Mappers y Validators.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase creada para centralizar el registro de servicios del módulo Ministerio.
 *****/

using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Ministerio.Dtos;
using Empresa.Application.Ministerio.Mappers;
using Empresa.Application.Ministerio.UseCases;
using Empresa.Application.Ministerio.Validators;
using Empresa.Domain.Ministerio.Parameters;
using Empresa.Domain.Ministerio.Results;

namespace Empresa.Application.Ministerio
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddMinisterioApplication(this IServiceCollection services)
        {
            // UseCases
            services.AddScoped<IUseCase<ActualizarMinisterioRequest, SpResultBase>, ActualizarMinisterioUseCase>();
            services.AddScoped<IUseCase<CrearMinisterioRequest, SpResultBase>, CrearMinisterioUseCase>();
            services.AddScoped<IUseCase<EliminarMinisterioRequest, SpResultBase>, EliminarMinisterioUseCase>();
            services.AddScoped<IUseCase<ListarMinisterioPaginadoRequest, PagedResult<MinisterioResult>>, ListarMinisterioPaginadaUseCase>();
            services.AddScoped<IUseCase<ListarMinisterioRequest, List<MinisterioResult>>, ListarMinisterioUseCase>();
            services.AddScoped<IUseCase<int, MinisterioResult?>, ObtenerMinisterioPorIdUseCase>();

            // Mappers
            services.AddScoped<IMapper<ActualizarMinisterioRequest, ActualizarMinisterioParameters>, ActualizarMinisterioRequestMapper>();
            services.AddScoped<IMapper<CrearMinisterioRequest, CrearMinisterioParameters>, CrearMinisterioRequestMapper>();
            services.AddScoped<IMapper<EliminarMinisterioRequest, EliminarMinisterioParameters>, EliminarMinisterioRequestMapper>();
            services.AddScoped<IMapper<ListarMinisterioPaginadoRequest, ListarMinisterioPaginadoParameters>, ListarMinisterioPaginadoRequestMapper>();
            services.AddScoped<IMapper<ListarMinisterioRequest, ListarMinisterioParameters>, ListarMinisterioRequestMapper>();

            // Validators
            services.AddScoped<IValidator<ActualizarMinisterioRequest>, ActualizarMinisterioRequestValidator>();
            services.AddScoped<IValidator<CrearMinisterioRequest>, CrearMinisterioRequestValidator>();
            services.AddScoped<IValidator<EliminarMinisterioRequest>, EliminarMinisterioRequestValidator>();
            services.AddScoped<IValidator<ListarMinisterioPaginadoRequest>, ListarMinisterioPaginadoRequestValidator>();
            services.AddScoped<IValidator<ListarMinisterioRequest>, ListarMinisterioRequestValidator>();

            return services;
        }

    }
}
