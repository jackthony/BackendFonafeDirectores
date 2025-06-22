using Empresa.Application.EMP_Cargo.Dtos;
using Empresa.Application.EMP_Cargo.Mappers;
using Empresa.Application.EMP_Cargo.UseCases;
using Empresa.Application.EMP_Cargo.Validators;
using Empresa.Domain.EMP_Cargo.Models;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Application.EMP_Cargo
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCargoApplication(this IServiceCollection services)
        {
            // Mappers
            services.AddScoped<IMapper<CrearCargoRequest, CrearCargoData>, CrearCargoMapper>();
            services.AddScoped<IMapper<ActualizarCargoRequest, ActualizarCargoData>, ActualizarCargoMapper>();
            services.AddScoped<IMapper<EliminarCargoRequest, EliminarCargoData>, EliminarCargoMapper>();

            // Validators
            services.AddValidatorsFromAssemblyContaining<ActualizarCargoRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<CrearCargoRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<EliminarCargoRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<ListarCargoPaginadoRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<ListarCargoRequestValidator>();

            // UseCases
            services.AddScoped<IUseCase<CrearCargoData, SpResultBase>, CrearCargoUseCase>();
            services.AddScoped<IUseCase<ActualizarCargoData, SpResultBase>, ActualizarCargoUseCase>();
            services.AddScoped<IUseCase<EliminarCargoData, SpResultBase>, EliminarCargoUseCase>();
            services.AddScoped<IUseCase<ListarCargoPaginadoRequest, PagedResult<CargoDto>>, ListarCargoPaginadasUseCase>();
            services.AddScoped<IUseCase<ListarCargoRequest, List<CargoDto>>, ListarCargoUseCase>();
            services.AddScoped<IUseCase<long, CargoDto?>, ObtenerCargoPorIdUseCase>();

            return services;
        }
    }
}
