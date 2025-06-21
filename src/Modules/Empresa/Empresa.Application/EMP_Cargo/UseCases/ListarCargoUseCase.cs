using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cargo.Application.EMP_Cargo.Repositories;
using Empresa.Application.EMP_Cargo.Dtos;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;

namespace Cargo.Application.EMP_Cargo.UseCases
{
    public class ListarCargoUseCase : IUseCase<ListarCargoRequest, List<CargoDto>>
    {
        private readonly IReadCargoRepository _repository;

        public ListarCargoUseCase(IReadCargoRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, List<CargoDto>>> ExecuteAsync(ListarCargoRequest request)
        {
            var result = await _repository.ListAsync(request);
            return result;
        }
    }
}
