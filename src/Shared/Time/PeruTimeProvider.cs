
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
