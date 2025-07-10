/*****
 * Nombre del archivo:  DependencyInjection.cs
 * Descripción:         Configuración de la inyección de dependencias para la aplicación de Empresa.
 *                      Registra los casos de uso, mapeadores y validadores necesarios para el funcionamiento 
 *                      de los servicios relacionados con las empresas.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase para configurar la inyección de dependencias.
 *****/
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Empresa.Dtos;
using Empresa.Application.Empresa.Mappers;
using Empresa.Application.Empresa.UseCases;
using Empresa.Application.Empresa.Validators;
using Empresa.Domain.Empresa.Parameters;
using Empresa.Domain.Empresa.Results;

namespace Empresa.Application.Empresa
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddEmpresaApplication(this IServiceCollection services)
        {
            // UseCases
            services.AddScoped<IUseCase<ActualizarEmpresaRequest, SpResultBase>, ActualizarEmpresaUseCase>();
            services.AddScoped<IUseCase<CrearEmpresaRequest, SpResultBase>, CrearEmpresaUseCase>();
            services.AddScoped<IUseCase<EliminarEmpresaRequest, SpResultBase>, EliminarEmpresaUseCase>();
            services.AddScoped<IUseCase<ListarEmpresaPaginadoRequest, PagedResult<EmpresaResult>>, ListarEmpresaPaginadaUseCase>();
            services.AddScoped<IUseCase<ListarEmpresaRequest, List<EmpresaResult>>, ListarEmpresaUseCase>();
            services.AddScoped<IUseCase<int, EmpresaResult?>, ObtenerEmpresaPorIdUseCase>();

            // Mappers
            services.AddScoped<IMapper<ActualizarEmpresaRequest, ActualizarEmpresaParameters>, ActualizarEmpresaRequestMapper>();
            services.AddScoped<IMapper<CrearEmpresaRequest, CrearEmpresaParameters>, CrearEmpresaRequestMapper>();
            services.AddScoped<IMapper<EliminarEmpresaRequest, EliminarEmpresaParameters>, EliminarEmpresaRequestMapper>();
            services.AddScoped<IMapper<ListarEmpresaPaginadoRequest, ListarEmpresaPaginadoParameters>, ListarEmpresaPaginadoRequestMapper>();
            services.AddScoped<IMapper<ListarEmpresaRequest, ListarEmpresaParameters>, ListarEmpresaRequestMapper>();

            // Validators
            services.AddScoped<IValidator<ActualizarEmpresaRequest>, ActualizarEmpresaRequestValidator>();
            services.AddScoped<IValidator<CrearEmpresaRequest>, CrearEmpresaRequestValidator>();
            services.AddScoped<IValidator<EliminarEmpresaRequest>, EliminarEmpresaRequestValidator>();
            services.AddScoped<IValidator<ListarEmpresaPaginadoRequest>, ListarEmpresaPaginadoRequestValidator>();
            services.AddScoped<IValidator<ListarEmpresaRequest>, ListarEmpresaRequestValidator>();

            return services;
        }

    }
}
