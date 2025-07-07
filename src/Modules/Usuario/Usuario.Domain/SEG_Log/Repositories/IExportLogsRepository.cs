using Usuario.Domain.SEG_Log.Parameters;
using Usuario.Domain.SEG_Log.Results;

namespace Usuario.Domain.SEG_Log.Repositories
{
    public interface IExportLogsRepository
    {
        Task<List<AuditLogEstadoUsuarioResult>> ObtenerAuditoriaUsuariosAsync(ObtenerAuditoriaUsuariosRequest request);
        Task<List<UsuarioPorTipoUsuarioResult>> ObtenerUsuariosPorTipoUsuarioAsync(ObtenerUsuariosPorTipoUsuarioRequest request);
    }
}
