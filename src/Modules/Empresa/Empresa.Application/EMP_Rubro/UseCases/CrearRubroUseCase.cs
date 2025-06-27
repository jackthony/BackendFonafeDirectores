<<<<<<< HEAD
﻿using Empresa.Domain.EMP_Rubro.Models;
using Empresa.Domain.EMP_Rubro.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Application.EMP_Rubro.UseCases
{
    public class CrearRubroUseCase : IUseCase<CrearRubroData, SpResultBase>
    {
        private readonly IWriteRubroRepository<SpResultBase> _repository;

        public CrearRubroUseCase(IWriteRubroRepository<SpResultBase> repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(CrearRubroData request)
        {
            var result = await _repository.AddAsync(request);
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
    public class CrearRubroUseCase : IUseCase<CrearRubroRequest, SpResultBase>
    {
        private readonly IRubroRepository _repository;
        private readonly IMapper<CrearRubroRequest, CrearRubroParameters> _mapper;

        public CrearRubroUseCase(IRubroRepository repository, IMapper<CrearRubroRequest, CrearRubroParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(CrearRubroRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.AddAsync(parameters);
>>>>>>> origin/masterboa
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
