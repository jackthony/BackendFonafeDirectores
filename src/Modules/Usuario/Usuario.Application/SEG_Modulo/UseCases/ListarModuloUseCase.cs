using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Usuario.Application.Modulo.Dtos;
using Usuario.Domain.Modulo.Parameters;
using Usuario.Domain.Modulo.Repositories;
using Usuario.Domain.Modulo.Results;

namespace Usuario.Application.Modulo.UseCases
{
    public class ListarModuloUseCase : IUseCase<ListarModuloRequest, List<ModuloResult>>
    {
        private readonly IModuloRepository _repository;
        private readonly IMapper<ListarModuloRequest, ListarModuloParameters> _mapper;

        public ListarModuloUseCase(
            IModuloRepository repository,
            IMapper<ListarModuloRequest, ListarModuloParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, List<ModuloResult>>> ExecuteAsync(ListarModuloRequest request)
        {
            var parameters = _mapper.Map(request);
            var result = await _repository.ListAsync(parameters);
            return result;
        }
    }
}
