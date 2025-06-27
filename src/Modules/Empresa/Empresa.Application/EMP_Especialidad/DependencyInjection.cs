<<<<<<< HEAD
﻿using Empresa.Application.EMP_Especialidad.Dtos;
using Empresa.Application.EMP_Especialidad.UseCases;
using Empresa.Application.EMP_Especialidad.Validators;
using Empresa.Domain.EMP_Especialidad.Models;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Application.EMP_Especialidad
=======
﻿using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Especialidad.Dtos;
using Empresa.Application.Especialidad.Mappers;
using Empresa.Application.Especialidad.UseCases;
using Empresa.Application.Especialidad.Validators;
using Empresa.Domain.Especialidad.Parameters;
using Empresa.Domain.Especialidad.Results;

namespace Empresa.Application.Especialidad
>>>>>>> origin/masterboa
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddEspecialidadApplication(this IServiceCollection services)
        {
<<<<<<< HEAD
            // Validators
            services.AddValidatorsFromAssemblyContaining<ActualizarEspecialidadRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<CrearEspecialidadRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<EliminarEspecialidadRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<ListarEspecialidadPaginadoRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<ListarEspecialidadRequestValidator>();

            // UseCases
            services.AddScoped<IUseCase<CrearEspecialidadData, SpResultBase>, CrearEspecialidadUseCase>();
            services.AddScoped<IUseCase<ActualizarEspecialidadData, SpResultBase>, ActualizarEspecialidadUseCase>();
            services.AddScoped<IUseCase<EliminarEspecialidadData, SpResultBase>, EliminarEspecialidadUseCase>();
            services.AddScoped<IUseCase<ListarEspecialidadPaginadoRequest, PagedResult<EspecialidadDto>>, ListarEspecialidadPaginadasUseCase>();
            services.AddScoped<IUseCase<ListarEspecialidadRequest, List<EspecialidadDto>>, ListarEspecialidadUseCase>();
            services.AddScoped<IUseCase<long, EspecialidadDto?>, ObtenerEspecialidadPorIdUseCase>();

            return services;
        }
=======
            // UseCases
            services.AddScoped<IUseCase<ActualizarEspecialidadRequest, SpResultBase>, ActualizarEspecialidadUseCase>();
            services.AddScoped<IUseCase<CrearEspecialidadRequest, SpResultBase>, CrearEspecialidadUseCase>();
            services.AddScoped<IUseCase<EliminarEspecialidadRequest, SpResultBase>, EliminarEspecialidadUseCase>();
            services.AddScoped<IUseCase<ListarEspecialidadPaginadoRequest, PagedResult<EspecialidadResult>>, ListarEspecialidadPaginadaUseCase>();
            services.AddScoped<IUseCase<ListarEspecialidadRequest, List<EspecialidadResult>>, ListarEspecialidadUseCase>();
            services.AddScoped<IUseCase<int, EspecialidadResult?>, ObtenerEspecialidadPorIdUseCase>();

            // Mappers
            services.AddScoped<IMapper<ActualizarEspecialidadRequest, ActualizarEspecialidadParameters>, ActualizarEspecialidadRequestMapper>();
            services.AddScoped<IMapper<CrearEspecialidadRequest, CrearEspecialidadParameters>, CrearEspecialidadRequestMapper>();
            services.AddScoped<IMapper<EliminarEspecialidadRequest, EliminarEspecialidadParameters>, EliminarEspecialidadRequestMapper>();
            services.AddScoped<IMapper<ListarEspecialidadPaginadoRequest, ListarEspecialidadPaginadoParameters>, ListarEspecialidadPaginadoRequestMapper>();
            services.AddScoped<IMapper<ListarEspecialidadRequest, ListarEspecialidadParameters>, ListarEspecialidadRequestMapper>();

            // Validators
            services.AddScoped<IValidator<ActualizarEspecialidadRequest>, ActualizarEspecialidadRequestValidator>();
            services.AddScoped<IValidator<CrearEspecialidadRequest>, CrearEspecialidadRequestValidator>();
            services.AddScoped<IValidator<EliminarEspecialidadRequest>, EliminarEspecialidadRequestValidator>();
            services.AddScoped<IValidator<ListarEspecialidadPaginadoRequest>, ListarEspecialidadPaginadoRequestValidator>();
            services.AddScoped<IValidator<ListarEspecialidadRequest>, ListarEspecialidadRequestValidator>();

            return services;
        }

>>>>>>> origin/masterboa
    }
}
