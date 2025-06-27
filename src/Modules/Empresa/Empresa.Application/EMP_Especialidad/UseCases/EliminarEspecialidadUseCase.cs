<<<<<<< HEAD
﻿using Empresa.Domain.EMP_Especialidad.Models;
using Empresa.Domain.EMP_Especialidad.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Application.EMP_Especialidad.UseCases
{
    public class EliminarEspecialidadUseCase : IUseCase<EliminarEspecialidadData, SpResultBase>
    {
        private readonly IWriteEspecialidadRepository<SpResultBase> _repository;

        public EliminarEspecialidadUseCase(IWriteEspecialidadRepository<SpResultBase> repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(EliminarEspecialidadData request)
        {
            var result = await _repository.DeleteAsync(request);
            if (!result.Success) return ErrorBase.Database(result.Message);
=======
﻿using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Especialidad.Dtos;
using Empresa.Domain.Especialidad.Parameters;
using Empresa.Domain.Especialidad.Repositories;

namespace Empresa.Application.Especialidad.UseCases
{
    public class EliminarEspecialidadUseCase : IUseCase<EliminarEspecialidadRequest, SpResultBase>
    {
        private readonly IEspecialidadRepository _repository;
        private readonly IMapper<EliminarEspecialidadRequest, EliminarEspecialidadParameters> _mapper;

        public EliminarEspecialidadUseCase(
            IEspecialidadRepository repository,
            IMapper<EliminarEspecialidadRequest, EliminarEspecialidadParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(EliminarEspecialidadRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.DeleteAsync(parameters);

            if (!result.Success) return ErrorBase.Database(result.Message);

>>>>>>> origin/masterboa
            return result;
        }
    }
}
