using Empresa.Application.Dtos;
using Empresa.Application.UseCases;
using Empresa.Application.Validators;
using Empresa.Domain.EMP_Empresa.Models;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddEmpresaApplication(this IServiceCollection services)
        {
            // Validators
            services.AddValidatorsFromAssemblyContaining<ActualizarEmpresaRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<CrearEmpresaRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<EliminarEmpresaRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<ListarEmpresaPaginadoRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<ListarEmpresaRequestValidator>();

            // UseCases
            services.AddScoped<IUseCase<CrearEmpresaData, SpResultBase>, CrearEmpresaUseCase>();
            services.AddScoped<IUseCase<ActualizarEmpresaData, SpResultBase>, ActualizarEmpresaUseCase>();
            services.AddScoped<IUseCase<EliminarEmpresaData, SpResultBase>, EliminarEmpresaUseCase>();
            services.AddScoped<IUseCase<ListarEmpresaPaginadoRequest, PagedResult<EmpresaDto>>, ListarEmpresaPaginadasUseCase>();
            services.AddScoped<IUseCase<ListarEmpresaRequest, List<EmpresaDto>>, ListarEmpresaUseCase>();
            services.AddScoped<IUseCase<long, EmpresaDto?>, ObtenerEmpresaPorIdUseCase>();

            return services;
        }
    }
}
