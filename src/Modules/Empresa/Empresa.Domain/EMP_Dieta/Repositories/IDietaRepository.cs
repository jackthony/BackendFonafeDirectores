using Empresa.Domain.Dieta.Parameters;
using Empresa.Domain.Dieta.Results;

namespace Empresa.Domain.Dieta.Repositories
{
    public interface IDietaRepository
    {
        public Task<DietaResult?> ObtenerDietaAsync(ObtenerDietaParameter request);
    }
}
