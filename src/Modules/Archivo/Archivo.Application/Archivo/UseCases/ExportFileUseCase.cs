using Archivo.Application.Archivo.Dtos;
using Archivo.Application.Archivo.Services;
using Archivo.Domain.Archivo.Parameters;
using Archivo.Domain.Archivo.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;

namespace Archivo.Application.Archivo.UseCases
{
    public class ExportFileUseCase : IUseCase<ExportFileRequest, Stream>
    {
        private readonly IExportImportService _service;
        private readonly IExportImportRepository _repository;
        private readonly IMapper<ExportFileRequest, ExportParameters> _mapper;

        public ExportFileUseCase(IExportImportService service, IExportImportRepository repository, IMapper<ExportFileRequest, ExportParameters> mapper)
        {
            _service = service;
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, Stream>> ExecuteAsync(ExportFileRequest request)
        {
            var parameters = _mapper.Map(request);

            var empresas = await _repository.GetEmpresas(parameters);
            if (empresas == null || empresas.Count == 0)
                return ErrorBase.NotFound();

            var directores = await _repository.GetDirectores(parameters);
            if (directores == null || directores.Count == 0)
                return ErrorBase.NotFound();

            var stream = _service.ObtenerDatosExportAsync(empresas, directores);

            return stream;
        }
    }
}
