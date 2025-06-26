using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Usuario.Domain.Modulo.Repositories;
using Usuario.Domain.Modulo.Results;

namespace Usuario.Application.Modulo.UseCases
{
    public class ListarModulosConAccionesUseCase : IUseCase<int, List<ModuloConAccionesResult>>
    {
        private readonly IModuloRepository _repository;

        public ListarModulosConAccionesUseCase(IModuloRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, List<ModuloConAccionesResult>>> ExecuteAsync(int rolId)
        {
            var result = await _repository.ListModulosWithAccionsAsync(rolId);
            return result;
        }
    }
}
