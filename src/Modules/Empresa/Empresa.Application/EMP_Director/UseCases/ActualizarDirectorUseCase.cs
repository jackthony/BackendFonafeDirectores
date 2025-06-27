<<<<<<< HEAD
﻿using Empresa.Domain.EMP_Director.Models;
using Empresa.Domain.EMP_Director.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Application.EMP_Director.UseCases
{
    public class ActualizarDirectorUseCase : IUseCase<ActualizarDirectorData, SpResultBase>
    {
        private readonly IWriteDirectorRepository<SpResultBase> _repository;

        public ActualizarDirectorUseCase(IWriteDirectorRepository<SpResultBase> repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(ActualizarDirectorData request)
        {
            var result = await _repository.UpdateAsync(request);
=======
﻿using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Director.Dtos;
using Empresa.Domain.Director.Parameters;
using Empresa.Domain.Director.Repositories;

namespace Empresa.Application.Director.UseCases
{
    public class ActualizarDirectorUseCase : IUseCase<ActualizarDirectorRequest, SpResultBase>
    {
        private readonly IDirectorRepository _repository;
        private readonly IMapper<ActualizarDirectorRequest, ActualizarDirectorParameters> _mapper;

        public ActualizarDirectorUseCase(IDirectorRepository repository, IMapper<ActualizarDirectorRequest, ActualizarDirectorParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(ActualizarDirectorRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.UpdateAsync(parameters);
>>>>>>> origin/masterboa
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
