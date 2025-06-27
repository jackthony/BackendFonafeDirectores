<<<<<<< HEAD
﻿using Empresa.Application.EMP_Director.Repositories;
using Empresa.Domain.EMP_Director.Repositories;
using Empresa.Infrastructure.EMP_Director.Persistence.Repositories.SqlServer;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Responses;

namespace Empresa.Infrastructure.EMP_Director
=======
﻿using Microsoft.Extensions.DependencyInjection;
using Empresa.Domain.Director.Repositories;
using Empresa.Infrastructure.Director.Persistence.Repositories.SqlServer;

namespace Empresa.Infrastructure.Director
>>>>>>> origin/masterboa
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddDirectorInfrastructure(this IServiceCollection services)
        {
<<<<<<< HEAD
            services.AddScoped<IWriteDirectorRepository<SpResultBase>, DirectorSqlRepository>();
            services.AddScoped<IReadDirectorRepository, DirectorSqlRepository>();
=======
            services.AddScoped<IDirectorRepository, DirectorSqlRepository>();
>>>>>>> origin/masterboa
            return services;
        }
    }
}
