<<<<<<< HEAD
﻿using Empresa.Application.EMP_Sector.Repositories;
using Empresa.Domain.EMP_Sector.Repositories;
using Empresa.Infrastructure.EMP_Sector.Persistence.Repositories.SqlServer;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Responses;

namespace Empresa.Infrastructure.EMP_Sector
=======
﻿using Microsoft.Extensions.DependencyInjection;
using Empresa.Domain.Sector.Repositories;
using Empresa.Infrastructure.Sector.Persistence.Repositories.SqlServer;

namespace Empresa.Infrastructure.Sector
>>>>>>> origin/masterboa
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddSectorInfrastructure(this IServiceCollection services)
        {
<<<<<<< HEAD
            services.AddScoped<IWriteSectorRepository<SpResultBase>, SectorSqlRepository>();
            services.AddScoped<IReadSectorRepository, SectorSqlRepository>();
=======
            services.AddScoped<ISectorRepository, SectorSqlRepository>();
>>>>>>> origin/masterboa
            return services;
        }
    }
}
