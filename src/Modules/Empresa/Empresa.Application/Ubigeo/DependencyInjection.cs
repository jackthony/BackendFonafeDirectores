using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Ubigeo.Dtos;
using Empresa.Application.Ubigeo.Mappers;
using Empresa.Application.Ubigeo.UseCases;
using Empresa.Application.Ubigeo.Validators;
using Empresa.Domain.Ubigeo.Parameters;
using Empresa.Domain.Ubigeo.Results;

namespace Empresa.Application.Ubigeo
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddUbigeoApplication(this IServiceCollection services)
        {
            // UseCases
            services.AddScoped<IUseCase<ActualizarUbigeoRequest, SpResultBase>, ActualizarUbigeoUseCase>();
            services.AddScoped<IUseCase<CrearUbigeoRequest, SpResultBase>, CrearUbigeoUseCase>();
            services.AddScoped<IUseCase<EliminarUbigeoRequest, SpResultBase>, EliminarUbigeoUseCase>();
            services.AddScoped<IUseCase<ListarUbigeoPaginadoRequest, PagedResult<UbigeoResult>>, ListarUbigeoPaginadaUseCase>();
            services.AddScoped<IUseCase<ListarUbigeoRequest, List<UbigeoResult>>, ListarUbigeoUseCase>();
            services.AddScoped<IUseCase<int, UbigeoResult?>, ObtenerUbigeoPorIdUseCase>();

            // Mappers
            services.AddScoped<IMapper<ActualizarUbigeoRequest, ActualizarUbigeoParameters>, ActualizarUbigeoRequestMapper>();
            services.AddScoped<IMapper<CrearUbigeoRequest, CrearUbigeoParameters>, CrearUbigeoRequestMapper>();
            services.AddScoped<IMapper<EliminarUbigeoRequest, EliminarUbigeoParameters>, EliminarUbigeoRequestMapper>();
            services.AddScoped<IMapper<ListarUbigeoPaginadoRequest, ListarUbigeoPaginadoParameters>, ListarUbigeoPaginadoRequestMapper>();
            services.AddScoped<IMapper<ListarUbigeoRequest, ListarUbigeoParameters>, ListarUbigeoRequestMapper>();

            // Validators
            services.AddScoped<IValidator<ActualizarUbigeoRequest>, ActualizarUbigeoRequestValidator>();
            services.AddScoped<IValidator<CrearUbigeoRequest>, CrearUbigeoRequestValidator>();
            services.AddScoped<IValidator<EliminarUbigeoRequest>, EliminarUbigeoRequestValidator>();
            services.AddScoped<IValidator<ListarUbigeoPaginadoRequest>, ListarUbigeoPaginadoRequestValidator>();
            services.AddScoped<IValidator<ListarUbigeoRequest>, ListarUbigeoRequestValidator>();

            return services;
        }

    }
}
