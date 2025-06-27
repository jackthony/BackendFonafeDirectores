<<<<<<< HEAD
﻿using Empresa.Application.EMP_Empresa.Repositories;
using Empresa.Domain.EMP_Empresa.Repositories;
using Empresa.Infrastructure.EMP_Empresa.Persistence.Repositories.SqlServer;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Responses;

namespace Empresa.Infrastructure.EMP_Empresa
=======
﻿using Microsoft.Extensions.DependencyInjection;
using Empresa.Domain.Empresa.Repositories;
using Empresa.Infrastructure.Empresa.Persistence.Repositories.SqlServer;

namespace Empresa.Infrastructure.Empresa
>>>>>>> origin/masterboa
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddEmpresaInfrastructure(this IServiceCollection services)
        {
<<<<<<< HEAD
            services.AddScoped<IWriteEmpresaRepository<SpResultBase>, EmpresaSqlRepository>();
            services.AddScoped<IReadEmpresaRepository, EmpresaSqlRepository>();
=======
            services.AddScoped<IEmpresaRepository, EmpresaSqlRepository>();
>>>>>>> origin/masterboa
            return services;
        }
    }
}
