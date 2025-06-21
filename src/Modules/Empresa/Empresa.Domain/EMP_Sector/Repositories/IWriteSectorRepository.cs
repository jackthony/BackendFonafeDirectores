using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresa.Domain.EMP_Sector.Models;

namespace Empresa.Domain.EMP_Sector.Repositories
{
    public interface IWriteSectorRepository<T>
    {
        public Task<T> AddAsync(CrearSectorData request);
        public Task<T> UpdateAsync(ActualizarSectorData request);
        public Task<T> DeleteAsync(EliminarSectorData request);
    }
}
