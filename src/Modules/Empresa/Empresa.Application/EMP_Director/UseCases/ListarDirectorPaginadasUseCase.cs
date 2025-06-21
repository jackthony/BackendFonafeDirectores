using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresa.Application.EMP_Director.Repositories;
using Empresa.Application.EMP_Director.Dtos;
using Empresa.Application.EMP_Director.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Application.EMP_Director.UseCases
{
    public class ListarDirectorPaginadasUseCase : IUseCase<ListarDirectorPaginadoRequest, PagedResult<DirectorDto>>
    {
        private readonly IReadDirectorRepository _repository;

        public ListarDirectorPaginadasUseCase(IReadDirectorRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, PagedResult<DirectorDto>>> ExecuteAsync(ListarDirectorPaginadoRequest request)
        {
            var result = await _repository.ListByPaginationAsync(request);
            return result;
        }
    }
}
