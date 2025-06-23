using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Archivo.Application.Archivo.Dtos;
using Archivo.Application.Archivo.Mappers;
using Archivo.Application.Archivo.UseCases;
using Archivo.Application.Archivo.Validators;
using Archivo.Domain.Archivo.Parameters;
using Archivo.Domain.Archivo.Results;
using Microsoft.AspNetCore.Http;

namespace Archivo.Application.Archivo
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddArchivoApplication(this IServiceCollection services)
        {
            // UseCases
            services.AddScoped<IUseCase<ActualizarArchivoRequest, SpResultBase>, ActualizarArchivoUseCase>();
            services.AddScoped<IUseCase<CrearArchivoRequest, SpResultBase>, CrearArchivoUseCase>();
            services.AddScoped<IUseCase<EliminarArchivoRequest, SpResultBase>, EliminarArchivoUseCase>();
            services.AddScoped<IUseCase<ListarArchivoPaginadoRequest, PagedResult<ArchivoResult>>, ListarArchivoPaginadaUseCase>();
            services.AddScoped<IUseCase<ListarArchivoRequest, List<ArchivoResult>>, ListarArchivoUseCase>();
            services.AddScoped<IUseCase<int, ArchivoResult?>, ObtenerArchivoPorIdUseCase>();
            services.AddScoped<IUseCase<ExportFileRequest, IFormFile>, ExportFileUseCase>();

            // Mappers
            services.AddScoped<IMapper<ActualizarArchivoRequest, ActualizarArchivoParameters>, ActualizarArchivoRequestMapper>();
            services.AddScoped<IMapper<CrearArchivoRequest, CrearArchivoParameters>, CrearArchivoRequestMapper>();
            services.AddScoped<IMapper<EliminarArchivoRequest, EliminarArchivoParameters>, EliminarArchivoRequestMapper>();
            services.AddScoped<IMapper<ListarArchivoPaginadoRequest, ListarArchivoPaginadoParameters>, ListarArchivoPaginadoRequestMapper>();
            services.AddScoped<IMapper<ListarArchivoRequest, ListarArchivoParameters>, ListarArchivoRequestMapper>();
            services.AddScoped<IMapper<ExportFileRequest, ExportParameters>, ExportFileRequestMapper>();

            // Validators
            services.AddScoped<IValidator<ActualizarArchivoRequest>, ActualizarArchivoRequestValidator>();
            services.AddScoped<IValidator<CrearArchivoRequest>, CrearArchivoRequestValidator>();
            services.AddScoped<IValidator<EliminarArchivoRequest>, EliminarArchivoRequestValidator>();
            services.AddScoped<IValidator<ListarArchivoPaginadoRequest>, ListarArchivoPaginadoRequestValidator>();
            services.AddScoped<IValidator<ListarArchivoRequest>, ListarArchivoRequestValidator>();

            return services;
        }

    }
}
