<<<<<<< HEAD
﻿using Empresa.Domain.EMP_Rubro.Models;
using Empresa.Domain.EMP_Rubro.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Application.EMP_Rubro.UseCases
{
    public class ActualizarRubroUseCase : IUseCase<ActualizarRubroData, SpResultBase>
    {
        private readonly IWriteRubroRepository<SpResultBase> _repository;

        public ActualizarRubroUseCase(IWriteRubroRepository<SpResultBase> repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(ActualizarRubroData request)
        {
            var result = await _repository.UpdateAsync(request);
=======
﻿using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Rubro.Dtos;
using Empresa.Domain.Rubro.Parameters;
using Empresa.Domain.Rubro.Repositories;

namespace Empresa.Application.Rubro.UseCases
{
    public class ActualizarRubroUseCase : IUseCase<ActualizarRubroRequest, SpResultBase>
    {
        private readonly IRubroRepository _repository;
        private readonly IMapper<ActualizarRubroRequest, ActualizarRubroParameters> _mapper;

        public ActualizarRubroUseCase(IRubroRepository repository, IMapper<ActualizarRubroRequest, ActualizarRubroParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(ActualizarRubroRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.UpdateAsync(parameters);
>>>>>>> origin/masterboa
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
