using Empresa.Application.EMP_Ministerio.Dtos;
using Empresa.Application.EMP_Ministerio.UseCases;
using Empresa.Application.EMP_Ministerio.Validators;
using Empresa.Domain.EMP_Ministerio.Models;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Application.EMP_Ministerio
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
