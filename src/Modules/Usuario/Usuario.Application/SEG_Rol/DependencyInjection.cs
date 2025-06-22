using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Usuario.Application.Rol.Dtos;
using Usuario.Application.Rol.Mappers;
using Usuario.Application.Rol.UseCases;
using Usuario.Application.Rol.Validators;
using Usuario.Domain.Rol.Parameters;
using Usuario.Domain.Rol.Results;

namespace Usuario.Application.Rol
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRolApplication(this IServiceCollection services)
        {
            // UseCases
            services.AddScoped<IUseCase<ActualizarRolRequest, SpResultBase>, ActualizarRolUseCase>();
            services.AddScoped<IUseCase<CrearRolRequest, SpResultBase>, CrearRolUseCase>();
            services.AddScoped<IUseCase<EliminarRolRequest, SpResultBase>, EliminarRolUseCase>();
            services.AddScoped<IUseCase<ListarRolPaginadoRequest, PagedResult<RolResult>>, ListarRolPaginadaUseCase>();
            services.AddScoped<IUseCase<ListarRolRequest, List<RolResult>>, ListarRolUseCase>();
            services.AddScoped<IUseCase<int, RolResult?>, ObtenerRolPorIdUseCase>();

            // Mappers
            services.AddScoped<IMapper<ActualizarRolRequest, ActualizarRolParameters>, ActualizarRolRequestMapper>();
            services.AddScoped<IMapper<CrearRolRequest, CrearRolParameters>, CrearRolRequestMapper>();
            services.AddScoped<IMapper<EliminarRolRequest, EliminarRolParameters>, EliminarRolRequestMapper>();
            services.AddScoped<IMapper<ListarRolPaginadoRequest, ListarRolPaginadoParameters>, ListarRolPaginadoRequestMapper>();
            services.AddScoped<IMapper<ListarRolRequest, ListarRolParameters>, ListarRolRequestMapper>();

            // Validators
            services.AddScoped<IValidator<ActualizarRolRequest>, ActualizarRolRequestValidator>();
            services.AddScoped<IValidator<CrearRolRequest>, CrearRolRequestValidator>();
            services.AddScoped<IValidator<EliminarRolRequest>, EliminarRolRequestValidator>();
            services.AddScoped<IValidator<ListarRolPaginadoRequest>, ListarRolPaginadoRequestValidator>();
            services.AddScoped<IValidator<ListarRolRequest>, ListarRolRequestValidator>();

            return services;
        }

    }
}
