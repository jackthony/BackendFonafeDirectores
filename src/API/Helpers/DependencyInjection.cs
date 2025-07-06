using Empresa.Application.Sector.Dtos;
using Shared.Kernel.Interfaces;

namespace Api.Helpers
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddTrackableApplication(this IServiceCollection services)
        {
            services.AddScoped<ITrackableRequest, ActualizarSectorRequest>();

            return services;
        }
    }
}
