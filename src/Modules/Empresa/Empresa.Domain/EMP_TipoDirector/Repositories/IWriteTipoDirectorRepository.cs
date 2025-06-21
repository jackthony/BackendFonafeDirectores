using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresa.Domain.EMP_TipoDirector.Models;

namespace Empresa.Domain.EMP_TipoDirector.Repositories
{
    public interface IWriteTipoDirectorRepository<T>
    {
        public Task<T> AddAsync(CrearTipoDirectorData request);
        public Task<T> UpdateAsync(ActualizarTipoDirectorData request);
        public Task<T> DeleteAsync(EliminarTipoDirectorData request);
    }
}
