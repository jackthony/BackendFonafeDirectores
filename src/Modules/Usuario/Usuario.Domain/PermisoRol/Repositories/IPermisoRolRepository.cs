using Shared.Kernel.Responses;
using Usuario.Domain.User.Parameters;
using Usuario.Domain.User.Results;

namespace Usuario.Domain.User.Repositories
{
    public interface IUserRepository
    {
        public Task<SpResultBase> AddAsync(CrearUserParameters request);
        public Task<SpResultBase> UpdateAsync(ActualizarUserParameters request);
        public Task<SpResultBase> DeleteAsync(EliminarUserParameters request);
        public Task<List<UserResult>> ListAsync(ListarUserParameters request);
        public Task<UserResult?> GetByIdAsync(int id);
        public Task<PagedResult<UserResult>> ListByPaginationAsync(ListarUserPaginadoParameters request);
    }
}
