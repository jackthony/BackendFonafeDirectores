using Usuario.Domain.SEG_Log.Parameters;

namespace Usuario.Domain.SEG_Log.Repositories
{
    public interface ILogRepository
    {
        public Task RegistrarAuditoriaAsync(LogAuditoriaParameters parameters);
        public Task RegistrarTrazabilidadAsync(LogTrazabilidadParameters parameters);
        public Task RegistrarSistemaAsync(LogSistemaParameters parameters);
    }
}
