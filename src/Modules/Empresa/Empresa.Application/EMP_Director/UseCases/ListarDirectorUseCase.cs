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

namespace Empresa.Application.EMP_Director.UseCases
{
    public class ListarDirectorUseCase : IUseCase<ListarDirectorRequest, List<DirectorDto>>
    {
        private readonly IReadDirectorRepository _repository;

        public ListarDirectorUseCase(IReadDirectorRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, List<DirectorDto>>> ExecuteAsync(ListarDirectorRequest request)
        {
            var result = await _repository.ListAsync(request);
            return result;
        }
    }
}
