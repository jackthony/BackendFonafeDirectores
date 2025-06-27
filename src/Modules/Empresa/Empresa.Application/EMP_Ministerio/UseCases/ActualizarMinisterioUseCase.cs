<<<<<<< HEAD
﻿using Empresa.Domain.EMP_Ministerio.Models;
using Empresa.Domain.EMP_Ministerio.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Application.EMP_Ministerio.UseCases
{
    public class ActualizarMinisterioUseCase : IUseCase<ActualizarMinisterioData, SpResultBase>
    {
        private readonly IWriteMinisterioRepository<SpResultBase> _repository;

        public ActualizarMinisterioUseCase(IWriteMinisterioRepository<SpResultBase> repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(ActualizarMinisterioData request)
        {
            var result = await _repository.UpdateAsync(request);
=======
﻿using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Ministerio.Dtos;
using Empresa.Domain.Ministerio.Parameters;
using Empresa.Domain.Ministerio.Repositories;

namespace Empresa.Application.Ministerio.UseCases
{
    public class ActualizarMinisterioUseCase : IUseCase<ActualizarMinisterioRequest, SpResultBase>
    {
        private readonly IMinisterioRepository _repository;
        private readonly IMapper<ActualizarMinisterioRequest, ActualizarMinisterioParameters> _mapper;

        public ActualizarMinisterioUseCase(IMinisterioRepository repository, IMapper<ActualizarMinisterioRequest, ActualizarMinisterioParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(ActualizarMinisterioRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.UpdateAsync(parameters);
>>>>>>> origin/masterboa
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
