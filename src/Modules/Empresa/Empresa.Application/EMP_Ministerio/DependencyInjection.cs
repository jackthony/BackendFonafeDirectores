<<<<<<< HEAD
﻿using Empresa.Application.EMP_Ministerio.Dtos;
using Empresa.Application.EMP_Ministerio.UseCases;
using Empresa.Application.EMP_Ministerio.Validators;
using Empresa.Domain.EMP_Ministerio.Models;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Application.EMP_Ministerio
=======
﻿using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Ministerio.Dtos;
using Empresa.Application.Ministerio.Mappers;
using Empresa.Application.Ministerio.UseCases;
using Empresa.Application.Ministerio.Validators;
using Empresa.Domain.Ministerio.Parameters;
using Empresa.Domain.Ministerio.Results;

namespace Empresa.Application.Ministerio
>>>>>>> origin/masterboa
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddMinisterioApplication(this IServiceCollection services)
        {
<<<<<<< HEAD
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
=======
            // UseCases
            services.AddScoped<IUseCase<ActualizarMinisterioRequest, SpResultBase>, ActualizarMinisterioUseCase>();
            services.AddScoped<IUseCase<CrearMinisterioRequest, SpResultBase>, CrearMinisterioUseCase>();
            services.AddScoped<IUseCase<EliminarMinisterioRequest, SpResultBase>, EliminarMinisterioUseCase>();
            services.AddScoped<IUseCase<ListarMinisterioPaginadoRequest, PagedResult<MinisterioResult>>, ListarMinisterioPaginadaUseCase>();
            services.AddScoped<IUseCase<ListarMinisterioRequest, List<MinisterioResult>>, ListarMinisterioUseCase>();
            services.AddScoped<IUseCase<int, MinisterioResult?>, ObtenerMinisterioPorIdUseCase>();

            // Mappers
            services.AddScoped<IMapper<ActualizarMinisterioRequest, ActualizarMinisterioParameters>, ActualizarMinisterioRequestMapper>();
            services.AddScoped<IMapper<CrearMinisterioRequest, CrearMinisterioParameters>, CrearMinisterioRequestMapper>();
            services.AddScoped<IMapper<EliminarMinisterioRequest, EliminarMinisterioParameters>, EliminarMinisterioRequestMapper>();
            services.AddScoped<IMapper<ListarMinisterioPaginadoRequest, ListarMinisterioPaginadoParameters>, ListarMinisterioPaginadoRequestMapper>();
            services.AddScoped<IMapper<ListarMinisterioRequest, ListarMinisterioParameters>, ListarMinisterioRequestMapper>();

            // Validators
            services.AddScoped<IValidator<ActualizarMinisterioRequest>, ActualizarMinisterioRequestValidator>();
            services.AddScoped<IValidator<CrearMinisterioRequest>, CrearMinisterioRequestValidator>();
            services.AddScoped<IValidator<EliminarMinisterioRequest>, EliminarMinisterioRequestValidator>();
            services.AddScoped<IValidator<ListarMinisterioPaginadoRequest>, ListarMinisterioPaginadoRequestValidator>();
            services.AddScoped<IValidator<ListarMinisterioRequest>, ListarMinisterioRequestValidator>();

            return services;
        }

>>>>>>> origin/masterboa
    }
}
