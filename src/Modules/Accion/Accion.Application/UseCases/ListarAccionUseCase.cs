using Accion.Application.Dtos;
using Accion.Application.Repositories;
using Accion.Domain.Models;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;

namespace Accion.Application.UseCases
{
    public class ListarAccionUseCase : IUseCase<ListarAccionRequest, List<AccionDto>>
    {
        private readonly IReadAccionRepository _repository;

        public ListarAccionUseCase(IReadAccionRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, List<AccionDto>>> ExecuteAsync(ListarAccionRequest request)
        {
            var result = await _repository.ListAsync(request);
            return result;
        }
    }
}
