using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Usuario.Application.SEG_Log.Services;
using Usuario.Domain.SEG_Log.Parameters;
using Usuario.Domain.SEG_Log.Repositories;

namespace Usuario.Application.SEG_Log.UseCases
{
    public class ExportUsuariosPorTipoUsuarioUseCase : IUseCase<ObtenerUsuariosPorTipoUsuarioRequest, Stream>
    {
        private readonly IExportLogsRepository _repository;
        private readonly IExportLogsService _exportService;

        public ExportUsuariosPorTipoUsuarioUseCase(
            IExportLogsRepository repository,
            IExportLogsService exportService)
        {
            _repository = repository;
            _exportService = exportService;
        }

        public async Task<OneOf<ErrorBase, Stream>> ExecuteAsync(ObtenerUsuariosPorTipoUsuarioRequest request)
        {
            var usuarios = await _repository.ObtenerUsuariosPorTipoUsuarioAsync(request);

            if (usuarios == null || usuarios.Count == 0)
                return ErrorBase.Validation("No se encontraron usuarios con el tipo especificado.");

            var stream = _exportService.ExportarUsuariosPorTipoUsuarioExcel(usuarios);

            return stream;
        }
    }
}
