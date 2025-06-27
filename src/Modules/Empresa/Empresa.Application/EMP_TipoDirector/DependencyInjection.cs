<<<<<<< HEAD
﻿using Empresa.Application.EMP_TipoDirector.Dtos;
using Empresa.Application.EMP_TipoDirector.UseCases;
using Empresa.Application.EMP_TipoDirector.Validators;
using Empresa.Domain.EMP_TipoDirector.Models;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Application.EMP_TipoDirector
=======
﻿using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.TipoDirector.Dtos;
using Empresa.Application.TipoDirector.Mappers;
using Empresa.Application.TipoDirector.UseCases;
using Empresa.Application.TipoDirector.Validators;
using Empresa.Domain.TipoDirector.Parameters;
using Empresa.Domain.TipoDirector.Results;

namespace Empresa.Application.TipoDirector
>>>>>>> origin/masterboa
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddTipoDirectorApplication(this IServiceCollection services)
        {
<<<<<<< HEAD
            // Validators
            services.AddValidatorsFromAssemblyContaining<ActualizarTipoDirectorRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<CrearTipoDirectorRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<EliminarTipoDirectorRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<ListarTipoDirectorPaginadoRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<ListarTipoDirectorRequestValidator>();

            // UseCases
            services.AddScoped<IUseCase<CrearTipoDirectorData, SpResultBase>, CrearTipoDirectorUseCase>();
            services.AddScoped<IUseCase<ActualizarTipoDirectorData, SpResultBase>, ActualizarTipoDirectorUseCase>();
            services.AddScoped<IUseCase<EliminarTipoDirectorData, SpResultBase>, EliminarTipoDirectorUseCase>();
            services.AddScoped<IUseCase<ListarTipoDirectorPaginadoRequest, PagedResult<TipoDirectorDto>>, ListarTipoDirectorPaginadasUseCase>();
            services.AddScoped<IUseCase<ListarTipoDirectorRequest, List<TipoDirectorDto>>, ListarTipoDirectorUseCase>();
            services.AddScoped<IUseCase<long, TipoDirectorDto?>, ObtenerTipoDirectorPorIdUseCase>();

            return services;
        }
=======
            // UseCases
            services.AddScoped<IUseCase<ActualizarTipoDirectorRequest, SpResultBase>, ActualizarTipoDirectorUseCase>();
            services.AddScoped<IUseCase<CrearTipoDirectorRequest, SpResultBase>, CrearTipoDirectorUseCase>();
            services.AddScoped<IUseCase<EliminarTipoDirectorRequest, SpResultBase>, EliminarTipoDirectorUseCase>();
            services.AddScoped<IUseCase<ListarTipoDirectorPaginadoRequest, PagedResult<TipoDirectorResult>>, ListarTipoDirectorPaginadaUseCase>();
            services.AddScoped<IUseCase<ListarTipoDirectorRequest, List<TipoDirectorResult>>, ListarTipoDirectorUseCase>();
            services.AddScoped<IUseCase<int, TipoDirectorResult?>, ObtenerTipoDirectorPorIdUseCase>();

            // Mappers
            services.AddScoped<IMapper<ActualizarTipoDirectorRequest, ActualizarTipoDirectorParameters>, ActualizarTipoDirectorRequestMapper>();
            services.AddScoped<IMapper<CrearTipoDirectorRequest, CrearTipoDirectorParameters>, CrearTipoDirectorRequestMapper>();
            services.AddScoped<IMapper<EliminarTipoDirectorRequest, EliminarTipoDirectorParameters>, EliminarTipoDirectorRequestMapper>();
            services.AddScoped<IMapper<ListarTipoDirectorPaginadoRequest, ListarTipoDirectorPaginadoParameters>, ListarTipoDirectorPaginadoRequestMapper>();
            services.AddScoped<IMapper<ListarTipoDirectorRequest, ListarTipoDirectorParameters>, ListarTipoDirectorRequestMapper>();

            // Validators
            services.AddScoped<IValidator<ActualizarTipoDirectorRequest>, ActualizarTipoDirectorRequestValidator>();
            services.AddScoped<IValidator<CrearTipoDirectorRequest>, CrearTipoDirectorRequestValidator>();
            services.AddScoped<IValidator<EliminarTipoDirectorRequest>, EliminarTipoDirectorRequestValidator>();
            services.AddScoped<IValidator<ListarTipoDirectorPaginadoRequest>, ListarTipoDirectorPaginadoRequestValidator>();
            services.AddScoped<IValidator<ListarTipoDirectorRequest>, ListarTipoDirectorRequestValidator>();

            return services;
        }

>>>>>>> origin/masterboa
    }
}
