/***********
 * Nombre del archivo:  PeruTimeProvider.cs
 * Descripción:         Implementación del proveedor de tiempo específico para Perú, adaptado según
 *                      el sistema operativo. Permite obtener la hora actual en UTC y en zona horaria de Perú.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 ***********/

using System.Runtime.InteropServices;

namespace Shared.Time
{
    public class PeruTimeProvider : ITimeProvider
    {
        private readonly TimeZoneInfo _peruTimeZone;

        public PeruTimeProvider()
        {
            var isWindows = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
            var timeZoneId = isWindows ? "SA Pacific Standard Time" : "America/Lima";
            _peruTimeZone = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
        }

        public DateTime NowPeru => TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, _peruTimeZone);
        public DateTime UtcNow => DateTime.UtcNow;
    }
}
