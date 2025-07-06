using Usuario.Application.SEG_Log.Dtos;
namespace Usuario.Application.SEG_Log.Services
{
    public interface ILogService
    {
        public Task RegistrarSistemaAsync(LogSistemaRequest dto);
        public Task RegistrarTrazabilidadAsync(LogTrazabilidadRequest dto);
    }
}
