<<<<<<< HEAD
﻿using Empresa.Application.EMP_Especialidad.Dtos;
using Empresa.Application.EMP_Especialidad.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;

namespace Empresa.Application.EMP_Especialidad.UseCases
{
    public class ListarEspecialidadUseCase : IUseCase<ListarEspecialidadRequest, List<EspecialidadDto>>
    {
        private readonly IReadEspecialidadRepository _repository;

        public ListarEspecialidadUseCase(IReadEspecialidadRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, List<EspecialidadDto>>> ExecuteAsync(ListarEspecialidadRequest request)
        {
            var result = await _repository.ListAsync(request);
=======
﻿using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Especialidad.Dtos;
using Empresa.Domain.Especialidad.Parameters;
using Empresa.Domain.Especialidad.Repositories;
using Empresa.Domain.Especialidad.Results;

namespace Empresa.Application.Especialidad.UseCases
{
    public class ListarEspecialidadUseCase : IUseCase<ListarEspecialidadRequest, List<EspecialidadResult>>
    {
        private readonly IEspecialidadRepository _repository;
        private readonly IMapper<ListarEspecialidadRequest, ListarEspecialidadParameters> _mapper;

        public ListarEspecialidadUseCase(
            IEspecialidadRepository repository,
            IMapper<ListarEspecialidadRequest, ListarEspecialidadParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, List<EspecialidadResult>>> ExecuteAsync(ListarEspecialidadRequest request)
        {
            var parameters = _mapper.Map(request);
            var result = await _repository.ListAsync(parameters);
>>>>>>> origin/masterboa
            return result;
        }
    }
}
