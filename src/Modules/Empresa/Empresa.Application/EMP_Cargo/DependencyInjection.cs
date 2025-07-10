/*****
 * Nombre del archivo:  DependencyInjection.cs
 * Descripción:         Clase que configura la inyección de dependencias para los componentes relacionados con los cargos en la aplicación.
 *                      Registra los casos de uso (`UseCases`), mapeadores (`Mappers`) y validadores (`Validators`) necesarios para la gestión de cargos.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Cargo.Dtos;
using Empresa.Application.Cargo.Mappers;
using Empresa.Application.Cargo.UseCases;
using Empresa.Application.Cargo.Validators;
using Empresa.Domain.Cargo.Parameters;
using Empresa.Domain.Cargo.Results;

namespace Empresa.Application.Cargo
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCargoApplication(this IServiceCollection services)
        {
            // UseCases
            services.AddScoped<IUseCase<ActualizarCargoRequest, SpResultBase>, ActualizarCargoUseCase>();
            services.AddScoped<IUseCase<CrearCargoRequest, SpResultBase>, CrearCargoUseCase>();
            services.AddScoped<IUseCase<EliminarCargoRequest, SpResultBase>, EliminarCargoUseCase>();
            services.AddScoped<IUseCase<ListarCargoPaginadoRequest, PagedResult<CargoResult>>, ListarCargoPaginadaUseCase>();
            services.AddScoped<IUseCase<ListarCargoRequest, List<CargoResult>>, ListarCargoUseCase>();
            services.AddScoped<IUseCase<int, CargoResult?>, ObtenerCargoPorIdUseCase>();

            // Mappers
            services.AddScoped<IMapper<ActualizarCargoRequest, ActualizarCargoParameters>, ActualizarCargoRequestMapper>();
            services.AddScoped<IMapper<CrearCargoRequest, CrearCargoParameters>, CrearCargoRequestMapper>();
            services.AddScoped<IMapper<EliminarCargoRequest, EliminarCargoParameters>, EliminarCargoRequestMapper>();
            services.AddScoped<IMapper<ListarCargoPaginadoRequest, ListarCargoPaginadoParameters>, ListarCargoPaginadoRequestMapper>();
            services.AddScoped<IMapper<ListarCargoRequest, ListarCargoParameters>, ListarCargoRequestMapper>();

            // Validators
            services.AddScoped<IValidator<ActualizarCargoRequest>, ActualizarCargoRequestValidator>();
            services.AddScoped<IValidator<CrearCargoRequest>, CrearCargoRequestValidator>();
            services.AddScoped<IValidator<EliminarCargoRequest>, EliminarCargoRequestValidator>();
            services.AddScoped<IValidator<ListarCargoPaginadoRequest>, ListarCargoPaginadoRequestValidator>();
            services.AddScoped<IValidator<ListarCargoRequest>, ListarCargoRequestValidator>();

            return services;
        }

    }
}
