using Usuario.Application.SEG_Log.Dtos;
namespace Usuario.Application.SEG_Log.Services
{
    public interface ILogService
    {
        public Task RegistrarAuditoriaAsync(LogAuditoriaRequest dto);
        public Task RegistrarTrazabilidadAsync(LogTrazabilidadRequest dto);
        public Task RegistrarSistemaAsync(LogSistemaRequest dto);
    }
}
