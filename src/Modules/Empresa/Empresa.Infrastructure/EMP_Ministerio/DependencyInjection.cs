<<<<<<< HEAD
﻿using Empresa.Application.EMP_Ministerio.Repositories;
using Empresa.Domain.EMP_Ministerio.Repositories;
using Empresa.Infrastructure.EMP_Ministerio.Persistence.Repositories.SqlServer;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Responses;

namespace Empresa.Infrastructure.EMP_Ministerio
=======
﻿using Microsoft.Extensions.DependencyInjection;
using Empresa.Domain.Ministerio.Repositories;
using Empresa.Infrastructure.Ministerio.Persistence.Repositories.SqlServer;

namespace Empresa.Infrastructure.Ministerio
>>>>>>> origin/masterboa
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddMinisterioInfrastructure(this IServiceCollection services)
        {
<<<<<<< HEAD
            services.AddScoped<IWriteMinisterioRepository<SpResultBase>, MinisterioSqlRepository>();
            services.AddScoped<IReadMinisterioRepository, MinisterioSqlRepository>();
=======
            services.AddScoped<IMinisterioRepository, MinisterioSqlRepository>();
>>>>>>> origin/masterboa
            return services;
        }
    }
}
