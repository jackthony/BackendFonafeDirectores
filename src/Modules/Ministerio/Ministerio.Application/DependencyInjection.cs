using Ministerio.Application.Dtos;
using Ministerio.Application.UseCases;
using Ministerio.Application.Validators;
using Ministerio.Domain.Models;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Ministerio.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddMinisterioApplication(this IServiceCollection services)
        {
            // Validators
            services.AddValidatorsFromAssemblyContaining<ActualizarMinisterioRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<CrearMinisterioRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<EliminarMinisterioRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<ListarMinisterioPaginadoRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<ListarMinisterioRequestValidator>();

            // UseCases
            services.AddScoped<IUseCase<CrearMinisterioData, SpResultBase>, CrearMinisterioUseCase>();
            services.AddScoped<IUseCase<ActualizarMinisterioData, SpResultBase>, ActualizarMinisterioUseCase>();
            services.AddScoped<IUseCase<EliminarMinisterioData, SpResultBase>, EliminarMinisterioUseCase>();
            services.AddScoped<IUseCase<ListarMinisterioPaginadoRequest, PagedResult<MinisterioDto>>, ListarMinisterioPaginadasUseCase>();
            services.AddScoped<IUseCase<ListarMinisterioRequest, List<MinisterioDto>>, ListarMinisterioUseCase>();
            services.AddScoped<IUseCase<long, MinisterioDto?>, ObtenerMinisterioPorIdUseCase>();

            return services;
        }
    }
}
