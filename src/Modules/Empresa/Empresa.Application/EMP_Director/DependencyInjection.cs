<<<<<<< HEAD
﻿using Empresa.Application.EMP_Director.Dtos;
using Empresa.Application.EMP_Director.UseCases;
using Empresa.Application.EMP_Director.Validators;
using Empresa.Domain.EMP_Director.Models;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Application.EMP_Director
=======
﻿using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Director.Dtos;
using Empresa.Application.Director.Mappers;
using Empresa.Application.Director.UseCases;
using Empresa.Application.Director.Validators;
using Empresa.Domain.Director.Parameters;
using Empresa.Domain.Director.Results;

namespace Empresa.Application.Director
>>>>>>> origin/masterboa
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDirectorApplication(this IServiceCollection services)
        {
<<<<<<< HEAD
            // Validators
            services.AddValidatorsFromAssemblyContaining<ActualizarDirectorRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<CrearDirectorRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<EliminarDirectorRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<ListarDirectorPaginadoRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<ListarDirectorRequestValidator>();

            // UseCases
            services.AddScoped<IUseCase<CrearDirectorData, SpResultBase>, CrearDirectorUseCase>();
            services.AddScoped<IUseCase<ActualizarDirectorData, SpResultBase>, ActualizarDirectorUseCase>();
            services.AddScoped<IUseCase<EliminarDirectorData, SpResultBase>, EliminarDirectorUseCase>();
            services.AddScoped<IUseCase<ListarDirectorPaginadoRequest, PagedResult<DirectorDto>>, ListarDirectorPaginadasUseCase>();
            services.AddScoped<IUseCase<ListarDirectorRequest, List<DirectorDto>>, ListarDirectorUseCase>();
            services.AddScoped<IUseCase<long, DirectorDto?>, ObtenerDirectorPorIdUseCase>();

            return services;
        }
=======
            // UseCases
            services.AddScoped<IUseCase<ActualizarDirectorRequest, SpResultBase>, ActualizarDirectorUseCase>();
            services.AddScoped<IUseCase<CrearDirectorRequest, SpResultBase>, CrearDirectorUseCase>();
            services.AddScoped<IUseCase<EliminarDirectorRequest, SpResultBase>, EliminarDirectorUseCase>();
            services.AddScoped<IUseCase<ListarDirectorPaginadoRequest, PagedResult<DirectorResult>>, ListarDirectorPaginadaUseCase>();
            services.AddScoped<IUseCase<ListarDirectorRequest, List<DirectorResult>>, ListarDirectorUseCase>();
            services.AddScoped<IUseCase<int, DirectorResult?>, ObtenerDirectorPorIdUseCase>();

            // Mappers
            services.AddScoped<IMapper<ActualizarDirectorRequest, ActualizarDirectorParameters>, ActualizarDirectorRequestMapper>();
            services.AddScoped<IMapper<CrearDirectorRequest, CrearDirectorParameters>, CrearDirectorRequestMapper>();
            services.AddScoped<IMapper<EliminarDirectorRequest, EliminarDirectorParameters>, EliminarDirectorRequestMapper>();
            services.AddScoped<IMapper<ListarDirectorPaginadoRequest, ListarDirectorPaginadoParameters>, ListarDirectorPaginadoRequestMapper>();
            services.AddScoped<IMapper<ListarDirectorRequest, ListarDirectorParameters>, ListarDirectorRequestMapper>();

            // Validators
            services.AddScoped<IValidator<ActualizarDirectorRequest>, ActualizarDirectorRequestValidator>();
            services.AddScoped<IValidator<CrearDirectorRequest>, CrearDirectorRequestValidator>();
            services.AddScoped<IValidator<EliminarDirectorRequest>, EliminarDirectorRequestValidator>();
            services.AddScoped<IValidator<ListarDirectorPaginadoRequest>, ListarDirectorPaginadoRequestValidator>();
            services.AddScoped<IValidator<ListarDirectorRequest>, ListarDirectorRequestValidator>();

            return services;
        }

>>>>>>> origin/masterboa
    }
}
