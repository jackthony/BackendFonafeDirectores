<<<<<<< HEAD
﻿using Empresa.Application.EMP_TipoDirector.Repositories;
using Empresa.Domain.EMP_TipoDirector.Repositories;
using Empresa.Infrastructure.EMP_TipoDirector.Persistence.Repositories.SqlServer;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Responses;

namespace Empresa.Infrastructure.EMP_TipoDirector
=======
﻿using Microsoft.Extensions.DependencyInjection;
using Empresa.Domain.TipoDirector.Repositories;
using Empresa.Infrastructure.TipoDirector.Persistence.Repositories.SqlServer;

namespace Empresa.Infrastructure.TipoDirector
>>>>>>> origin/masterboa
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddTipoDirectorInfrastructure(this IServiceCollection services)
        {
<<<<<<< HEAD
            services.AddScoped<IWriteTipoDirectorRepository<SpResultBase>, TipoDirectorSqlRepository>();
            services.AddScoped<IReadTipoDirectorRepository, TipoDirectorSqlRepository>();
=======
            services.AddScoped<ITipoDirectorRepository, TipoDirectorSqlRepository>();
>>>>>>> origin/masterboa
            return services;
        }
    }
}
