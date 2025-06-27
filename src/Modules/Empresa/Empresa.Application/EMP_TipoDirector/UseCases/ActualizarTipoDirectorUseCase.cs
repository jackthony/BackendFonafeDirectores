<<<<<<< HEAD
﻿using Empresa.Domain.EMP_TipoDirector.Models;
using Empresa.Domain.EMP_TipoDirector.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Application.EMP_TipoDirector.UseCases
{
    public class ActualizarTipoDirectorUseCase : IUseCase<ActualizarTipoDirectorData, SpResultBase>
    {
        private readonly IWriteTipoDirectorRepository<SpResultBase> _repository;

        public ActualizarTipoDirectorUseCase(IWriteTipoDirectorRepository<SpResultBase> repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(ActualizarTipoDirectorData request)
        {
            var result = await _repository.UpdateAsync(request);
=======
﻿using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.TipoDirector.Dtos;
using Empresa.Domain.TipoDirector.Parameters;
using Empresa.Domain.TipoDirector.Repositories;

namespace Empresa.Application.TipoDirector.UseCases
{
    public class ActualizarTipoDirectorUseCase : IUseCase<ActualizarTipoDirectorRequest, SpResultBase>
    {
        private readonly ITipoDirectorRepository _repository;
        private readonly IMapper<ActualizarTipoDirectorRequest, ActualizarTipoDirectorParameters> _mapper;

        public ActualizarTipoDirectorUseCase(ITipoDirectorRepository repository, IMapper<ActualizarTipoDirectorRequest, ActualizarTipoDirectorParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(ActualizarTipoDirectorRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.UpdateAsync(parameters);
>>>>>>> origin/masterboa
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
