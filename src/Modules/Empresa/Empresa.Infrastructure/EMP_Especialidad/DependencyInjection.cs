<<<<<<< HEAD
﻿using Empresa.Application.EMP_Especialidad.Repositories;
using Empresa.Domain.EMP_Especialidad.Repositories;
using Empresa.Infrastructure.EMP_Especialidad.Persistence.Repositories.SqlServer;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Responses;

namespace Empresa.Infrastructure.EMP_Especialidad
=======
﻿using Microsoft.Extensions.DependencyInjection;
using Empresa.Domain.Especialidad.Repositories;
using Empresa.Infrastructure.Especialidad.Persistence.Repositories.SqlServer;

namespace Empresa.Infrastructure.Especialidad
>>>>>>> origin/masterboa
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddEspecialidadInfrastructure(this IServiceCollection services)
        {
<<<<<<< HEAD
            services.AddScoped<IWriteEspecialidadRepository<SpResultBase>, EspecialidadSqlRepository>();
            services.AddScoped<IReadEspecialidadRepository, EspecialidadSqlRepository>();
=======
            services.AddScoped<IEspecialidadRepository, EspecialidadSqlRepository>();
>>>>>>> origin/masterboa
            return services;
        }
    }
}
