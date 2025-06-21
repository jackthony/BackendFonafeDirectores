using Ministerio.Application.Dtos;
using Ministerio.Application.Repositories;
using Ministerio.Domain.Models;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;

namespace Ministerio.Application.UseCases
{
    public class ListarMinisterioUseCase : IUseCase<ListarMinisterioRequest, List<MinisterioDto>>
    {
        private readonly IReadMinisterioRepository _repository;

        public ListarMinisterioUseCase(IReadMinisterioRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, List<MinisterioDto>>> ExecuteAsync(ListarMinisterioRequest request)
        {
            var result = await _repository.ListAsync(request);
            return result;
        }
    }
}
