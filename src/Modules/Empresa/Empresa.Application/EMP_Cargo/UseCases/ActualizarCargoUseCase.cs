using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresa.Domain.EMP_Cargo.Models;
using Empresa.Domain.EMP_Cargo.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Cargo.Application.EMP_Cargo.UseCases
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
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
