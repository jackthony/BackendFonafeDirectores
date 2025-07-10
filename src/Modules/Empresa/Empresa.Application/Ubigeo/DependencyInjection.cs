/*****
 * Nombre del archivo:  DependencyInjection.cs
 * Descripción:         Implementa la inyección de dependencias para el módulo Ubigeo. Registra los
 *                      casos de uso, mapeadores y validadores en el contenedor de servicios de .NET.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/

using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Interfaces;
using Empresa.Application.Ubigeo.Dtos;
using Empresa.Application.Ubigeo.Validators;
using Empresa.Domain.Ubigeo.Parameters;
using Empresa.Domain.Ubigeo.Results;
using Empresa.Application.Departamento.UseCases;
using Empresa.Application.Departamento.Mappers;
using Empresa.Application.Provincia.Mappers;
using Empresa.Application.Distrito.Mappers;
using Empresa.Application.Distrito.UseCases;
using Empresa.Application.Provincia.UseCases;

namespace Empresa.Application.Ubigeo
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddUbigeoApplication(this IServiceCollection services)
        {
            // UseCases
            services.AddScoped<IUseCase<ListarDepartamentoRequest, List<DepartamentoResult>>, ListarDepartamentoUseCase>();
            services.AddScoped<IUseCase<ListarProvinciaRequest, List<ProvinciaResult>>, ListarProvinciaUseCase>();
            services.AddScoped<IUseCase<ListarDistritoRequest, List<DistritoResult>>, ListarDistritoUseCase>();

            // Mappers
            services.AddScoped<IMapper<ListarDepartamentoRequest, ListarDepartamentoParameters>, ListarDepartamentoRequestMapper>();
            services.AddScoped<IMapper<ListarProvinciaRequest, ListarProvinciaParameters>, ListarProvinciaRequestMapper>();
            services.AddScoped<IMapper<ListarDistritoRequest, ListarDistritoParameters>, ListarDistritoRequestMapper>();

            // Validators
            services.AddScoped<IValidator<ListarDepartamentoRequest>, ListarDepartamentoRequestValidator>();
            services.AddScoped<IValidator<ListarProvinciaRequest>, ListarProvinciaRequestValidator>();
            services.AddScoped<IValidator<ListarDistritoRequest>, ListarDistritoRequestValidator>();

            return services;
        }

    }
}
