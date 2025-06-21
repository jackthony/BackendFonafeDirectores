using Rubro.Application.Dtos;
using Rubro.Application.UseCases;
using Rubro.Application.Validators;
using Rubro.Domain.Models;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Rubro.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRubroApplication(this IServiceCollection services)
        {
            // Validators
            services.AddValidatorsFromAssemblyContaining<ActualizarRubroRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<CrearRubroRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<EliminarRubroRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<ListarRubroPaginadoRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<ListarRubroRequestValidator>();

            // UseCases
            services.AddScoped<IUseCase<CrearRubroData, SpResultBase>, CrearRubroUseCase>();
            services.AddScoped<IUseCase<ActualizarRubroData, SpResultBase>, ActualizarRubroUseCase>();
            services.AddScoped<IUseCase<EliminarRubroData, SpResultBase>, EliminarRubroUseCase>();
            services.AddScoped<IUseCase<ListarRubroPaginadoRequest, PagedResult<RubroDto>>, ListarRubroPaginadasUseCase>();
            services.AddScoped<IUseCase<ListarRubroRequest, List<RubroDto>>, ListarRubroUseCase>();
            services.AddScoped<IUseCase<long, RubroDto?>, ObtenerRubroPorIdUseCase>();

            return services;
        }
    }
}
