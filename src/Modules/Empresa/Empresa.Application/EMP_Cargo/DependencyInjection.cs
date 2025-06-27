<<<<<<< HEAD
﻿using Empresa.Application.EMP_Cargo.Dtos;
using Empresa.Application.EMP_Cargo.Mappers;
using Empresa.Application.EMP_Cargo.UseCases;
using Empresa.Application.EMP_Cargo.Validators;
using Empresa.Domain.EMP_Cargo.Models;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Application.EMP_Cargo
=======
﻿using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Cargo.Dtos;
using Empresa.Application.Cargo.Mappers;
using Empresa.Application.Cargo.UseCases;
using Empresa.Application.Cargo.Validators;
using Empresa.Domain.Cargo.Parameters;
using Empresa.Domain.Cargo.Results;

namespace Empresa.Application.Cargo
>>>>>>> origin/masterboa
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCargoApplication(this IServiceCollection services)
        {
<<<<<<< HEAD
            // Mappers
            services.AddScoped<IMapper<CrearCargoRequest, CrearCargoData>, CrearCargoMapper>();
            services.AddScoped<IMapper<ActualizarCargoRequest, ActualizarCargoData>, ActualizarCargoMapper>();
            services.AddScoped<IMapper<EliminarCargoRequest, EliminarCargoData>, EliminarCargoMapper>();

            // Validators
            services.AddValidatorsFromAssemblyContaining<ActualizarCargoRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<CrearCargoRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<EliminarCargoRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<ListarCargoPaginadoRequestValidator>();
            services.AddValidatorsFromAssemblyContaining<ListarCargoRequestValidator>();

            // UseCases
            services.AddScoped<IUseCase<CrearCargoData, SpResultBase>, CrearCargoUseCase>();
            services.AddScoped<IUseCase<ActualizarCargoData, SpResultBase>, ActualizarCargoUseCase>();
            services.AddScoped<IUseCase<EliminarCargoData, SpResultBase>, EliminarCargoUseCase>();
            services.AddScoped<IUseCase<ListarCargoPaginadoRequest, PagedResult<CargoDto>>, ListarCargoPaginadasUseCase>();
            services.AddScoped<IUseCase<ListarCargoRequest, List<CargoDto>>, ListarCargoUseCase>();
            services.AddScoped<IUseCase<long, CargoDto?>, ObtenerCargoPorIdUseCase>();

            return services;
        }
=======
            // UseCases
            services.AddScoped<IUseCase<ActualizarCargoRequest, SpResultBase>, ActualizarCargoUseCase>();
            services.AddScoped<IUseCase<CrearCargoRequest, SpResultBase>, CrearCargoUseCase>();
            services.AddScoped<IUseCase<EliminarCargoRequest, SpResultBase>, EliminarCargoUseCase>();
            services.AddScoped<IUseCase<ListarCargoPaginadoRequest, PagedResult<CargoResult>>, ListarCargoPaginadaUseCase>();
            services.AddScoped<IUseCase<ListarCargoRequest, List<CargoResult>>, ListarCargoUseCase>();
            services.AddScoped<IUseCase<int, CargoResult?>, ObtenerCargoPorIdUseCase>();

            // Mappers
            services.AddScoped<IMapper<ActualizarCargoRequest, ActualizarCargoParameters>, ActualizarCargoRequestMapper>();
            services.AddScoped<IMapper<CrearCargoRequest, CrearCargoParameters>, CrearCargoRequestMapper>();
            services.AddScoped<IMapper<EliminarCargoRequest, EliminarCargoParameters>, EliminarCargoRequestMapper>();
            services.AddScoped<IMapper<ListarCargoPaginadoRequest, ListarCargoPaginadoParameters>, ListarCargoPaginadoRequestMapper>();
            services.AddScoped<IMapper<ListarCargoRequest, ListarCargoParameters>, ListarCargoRequestMapper>();

            // Validators
            services.AddScoped<IValidator<ActualizarCargoRequest>, ActualizarCargoRequestValidator>();
            services.AddScoped<IValidator<CrearCargoRequest>, CrearCargoRequestValidator>();
            services.AddScoped<IValidator<EliminarCargoRequest>, EliminarCargoRequestValidator>();
            services.AddScoped<IValidator<ListarCargoPaginadoRequest>, ListarCargoPaginadoRequestValidator>();
            services.AddScoped<IValidator<ListarCargoRequest>, ListarCargoRequestValidator>();

            return services;
        }

>>>>>>> origin/masterboa
    }
}
