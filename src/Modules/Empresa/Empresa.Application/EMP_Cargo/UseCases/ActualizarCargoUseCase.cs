<<<<<<< HEAD
﻿using Empresa.Domain.EMP_Cargo.Models;
using Empresa.Domain.EMP_Cargo.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Application.EMP_Cargo.UseCases
{
    public class ActualizarCargoUseCase : IUseCase<ActualizarCargoData, SpResultBase>
    {
        private readonly IWriteCargoRepository<SpResultBase> _repository;

        public ActualizarCargoUseCase(IWriteCargoRepository<SpResultBase> repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(ActualizarCargoData request)
        {
            var result = await _repository.UpdateAsync(request);
=======
﻿using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Cargo.Dtos;
using Empresa.Domain.Cargo.Parameters;
using Empresa.Domain.Cargo.Repositories;

namespace Empresa.Application.Cargo.UseCases
{
    public class ActualizarCargoUseCase : IUseCase<ActualizarCargoRequest, SpResultBase>
    {
        private readonly ICargoRepository _repository;
        private readonly IMapper<ActualizarCargoRequest, ActualizarCargoParameters> _mapper;

        public ActualizarCargoUseCase(ICargoRepository repository, IMapper<ActualizarCargoRequest, ActualizarCargoParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(ActualizarCargoRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.UpdateAsync(parameters);
>>>>>>> origin/masterboa
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
