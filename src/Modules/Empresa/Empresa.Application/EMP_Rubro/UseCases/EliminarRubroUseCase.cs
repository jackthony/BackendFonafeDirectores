<<<<<<< HEAD
﻿using Empresa.Domain.EMP_Rubro.Models;
using Empresa.Domain.EMP_Rubro.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Application.EMP_Rubro.UseCases
{
    public class EliminarRubroUseCase : IUseCase<EliminarRubroData, SpResultBase>
    {
        private readonly IWriteRubroRepository<SpResultBase> _repository;

        public EliminarRubroUseCase(IWriteRubroRepository<SpResultBase> repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(EliminarRubroData request)
        {
            var result = await _repository.DeleteAsync(request);
            if (!result.Success) return ErrorBase.Database(result.Message);
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
    public class EliminarRubroUseCase : IUseCase<EliminarRubroRequest, SpResultBase>
    {
        private readonly IRubroRepository _repository;
        private readonly IMapper<EliminarRubroRequest, EliminarRubroParameters> _mapper;

        public EliminarRubroUseCase(
            IRubroRepository repository,
            IMapper<EliminarRubroRequest, EliminarRubroParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(EliminarRubroRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.DeleteAsync(parameters);

            if (!result.Success) return ErrorBase.Database(result.Message);

>>>>>>> origin/masterboa
            return result;
        }
    }
}
