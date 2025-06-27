<<<<<<< HEAD
﻿using Empresa.Domain.EMP_TipoDirector.Models;
using Empresa.Domain.EMP_TipoDirector.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Application.EMP_TipoDirector.UseCases
{
    public class EliminarTipoDirectorUseCase : IUseCase<EliminarTipoDirectorData, SpResultBase>
    {
        private readonly IWriteTipoDirectorRepository<SpResultBase> _repository;

        public EliminarTipoDirectorUseCase(IWriteTipoDirectorRepository<SpResultBase> repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(EliminarTipoDirectorData request)
        {
            var result = await _repository.DeleteAsync(request);
            if (!result.Success) return ErrorBase.Database(result.Message);
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
    public class EliminarTipoDirectorUseCase : IUseCase<EliminarTipoDirectorRequest, SpResultBase>
    {
        private readonly ITipoDirectorRepository _repository;
        private readonly IMapper<EliminarTipoDirectorRequest, EliminarTipoDirectorParameters> _mapper;

        public EliminarTipoDirectorUseCase(
            ITipoDirectorRepository repository,
            IMapper<EliminarTipoDirectorRequest, EliminarTipoDirectorParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(EliminarTipoDirectorRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.DeleteAsync(parameters);

            if (!result.Success) return ErrorBase.Database(result.Message);

>>>>>>> origin/masterboa
            return result;
        }
    }
}
