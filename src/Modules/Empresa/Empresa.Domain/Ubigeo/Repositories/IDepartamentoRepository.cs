using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresa.Domain.Ubigeo.Parameters;
using Empresa.Domain.Ubigeo.Results;

namespace Empresa.Domain.Ubigeo.Repositories
{
    public interface IDepartamentoRepository
    {
        public Task<List<DepartamentoResult>> ListAsync(ListarDepartamentoParameters request);
    }
}
