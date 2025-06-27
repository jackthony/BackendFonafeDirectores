<<<<<<< HEAD
﻿using Empresa.Application.EMP_Director.Dtos;
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
=======
﻿using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Director.Dtos;
using Empresa.Domain.Director.Parameters;
using Empresa.Domain.Director.Repositories;
using Empresa.Domain.Director.Results;

namespace Empresa.Application.Director.UseCases
{
    public class ListarDirectorUseCase : IUseCase<ListarDirectorRequest, List<DirectorResult>>
    {
        private readonly IDirectorRepository _repository;
        private readonly IMapper<ListarDirectorRequest, ListarDirectorParameters> _mapper;

        public ListarDirectorUseCase(
            IDirectorRepository repository,
            IMapper<ListarDirectorRequest, ListarDirectorParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, List<DirectorResult>>> ExecuteAsync(ListarDirectorRequest request)
        {
            var parameters = _mapper.Map(request);
            var result = await _repository.ListAsync(parameters);
>>>>>>> origin/masterboa
            return result;
        }
    }
}
