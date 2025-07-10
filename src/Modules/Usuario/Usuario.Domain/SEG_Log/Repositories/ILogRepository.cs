/***********
 * Nombre del archivo:  ILogRepository.cs
 * Descripción:         Interfaz que define los métodos para el registro de logs en el sistema,
 *                      incluyendo trazabilidad de acciones y logs del sistema.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial con métodos para registrar trazabilidad y logs de sistema.
 ***********/

using Usuario.Domain.SEG_Log.Parameters;

namespace Usuario.Domain.SEG_Log.Repositories
{
    public interface ILogRepository
    {
        public Task RegistrarTrazabilidadAsync(LogTrazabilidadParameters parameters);
        public Task RegistrarSistemaAsync(LogSistemaParameters parameters);
    }
}
