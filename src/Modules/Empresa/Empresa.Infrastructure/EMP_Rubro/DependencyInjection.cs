<<<<<<< HEAD
﻿using Empresa.Application.EMP_Rubro.Repositories;
using Empresa.Domain.EMP_Rubro.Repositories;
using Empresa.Infrastructure.EMP_Rubro.Persistence.Repositories.SqlServer;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Responses;

namespace Empresa.Infrastructure.EMP_Rubro
=======
﻿using Microsoft.Extensions.DependencyInjection;
using Empresa.Domain.Rubro.Repositories;
using Empresa.Infrastructure.Rubro.Persistence.Repositories.SqlServer;

namespace Empresa.Infrastructure.Rubro
>>>>>>> origin/masterboa
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddRubroInfrastructure(this IServiceCollection services)
        {
<<<<<<< HEAD
            services.AddScoped<IWriteRubroRepository<SpResultBase>, RubroSqlRepository>();
            services.AddScoped<IReadRubroRepository, RubroSqlRepository>();
=======
            services.AddScoped<IRubroRepository, RubroSqlRepository>();
>>>>>>> origin/masterboa
            return services;
        }
    }
}
