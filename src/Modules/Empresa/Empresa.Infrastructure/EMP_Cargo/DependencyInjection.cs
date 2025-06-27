<<<<<<< HEAD
﻿using Empresa.Application.EMP_Cargo.Repositories;
using Empresa.Domain.EMP_Cargo.Repositories;
using Empresa.Infrastructure.EMP_Cargo.Persistence.Repositories.SqlServer;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Responses;

namespace Empresa.Infrastructure.EMP_Cargo
=======
﻿using Microsoft.Extensions.DependencyInjection;
using Empresa.Domain.Cargo.Repositories;
using Empresa.Infrastructure.Cargo.Persistence.Repositories.SqlServer;

namespace Empresa.Infrastructure.Cargo
>>>>>>> origin/masterboa
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddCargoInfrastructure(this IServiceCollection services)
        {
<<<<<<< HEAD
            services.AddScoped<IWriteCargoRepository<SpResultBase>, CargoSqlRepository>();
            services.AddScoped<IReadCargoRepository, CargoSqlRepository>();
=======
            services.AddScoped<ICargoRepository, CargoSqlRepository>();
>>>>>>> origin/masterboa
            return services;
        }
    }
}
