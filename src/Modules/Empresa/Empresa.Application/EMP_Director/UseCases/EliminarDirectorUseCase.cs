using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresa.Domain.EMP_Director.Models;
using Empresa.Domain.EMP_Director.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Application.EMP_Director.UseCases
{
    public class EliminarDirectorUseCase : IUseCase<EliminarDirectorData, SpResultBase>
    {
        private readonly IWriteDirectorRepository<SpResultBase> _repository;

        public EliminarDirectorUseCase(IWriteDirectorRepository<SpResultBase> repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(EliminarDirectorData request)
        {
            var result = await _repository.DeleteAsync(request);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
