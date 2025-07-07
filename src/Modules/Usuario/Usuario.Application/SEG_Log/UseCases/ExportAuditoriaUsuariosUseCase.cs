using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Usuario.Application.SEG_Log.Services;
using Usuario.Domain.SEG_Log.Parameters;
using Usuario.Domain.SEG_Log.Repositories;

namespace Usuario.Application.SEG_Log.UseCases
{
    public class ExportAuditoriaUsuariosUseCase : IUseCase<ObtenerAuditoriaUsuariosRequest, Stream>
    {
        private readonly IExportLogsRepository _repository;
        private readonly IExportLogsService _exportService;

        public ExportAuditoriaUsuariosUseCase(
            IExportLogsRepository repository,
            IExportLogsService exportService)
        {
            _repository = repository;
            _exportService = exportService;
        }

        public async Task<OneOf<ErrorBase, Stream>> ExecuteAsync(ObtenerAuditoriaUsuariosRequest request)
        {
            var usuarios = await _repository.ObtenerAuditoriaUsuariosAsync(request);

            if (usuarios == null || usuarios.Count == 0)
                return ErrorBase.Validation("No se encontraron usuarios para los filtros especificados.");

            var stream = _exportService.ExportarAuditoriaUsuariosExcel(usuarios);

            return stream;
        }
    }
}
