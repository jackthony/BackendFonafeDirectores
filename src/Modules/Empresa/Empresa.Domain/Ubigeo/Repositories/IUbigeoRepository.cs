using Empresa.Domain.Ubigeo.Parameters;
using Empresa.Domain.Ubigeo.Results;

namespace Empresa.Domain.Ubigeo.Repositories
{
    public interface IUbigeoRepository
    {
        public Task<List<DepartamentoResult>> ListDepartamentos(ListarDepartamentoParameters request);
        public Task<List<ProvinciaResult>> ListProvincias(ListarProvinciaParameters request);
        public Task<List<DistritoResult>> ListDistritos(ListarDistritoParameters request);

    }
}
