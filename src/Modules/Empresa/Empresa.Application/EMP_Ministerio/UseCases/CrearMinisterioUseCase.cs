<<<<<<< HEAD
﻿using Empresa.Domain.EMP_Ministerio.Models;
using Empresa.Domain.EMP_Ministerio.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Application.EMP_Ministerio.UseCases
{
    public class CrearMinisterioUseCase : IUseCase<CrearMinisterioData, SpResultBase>
    {
        private readonly IWriteMinisterioRepository<SpResultBase> _repository;

        public CrearMinisterioUseCase(IWriteMinisterioRepository<SpResultBase> repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(CrearMinisterioData request)
        {
            var result = await _repository.AddAsync(request);
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
    public class CrearMinisterioUseCase : IUseCase<CrearMinisterioRequest, SpResultBase>
    {
        private readonly IMinisterioRepository _repository;
        private readonly IMapper<CrearMinisterioRequest, CrearMinisterioParameters> _mapper;

        public CrearMinisterioUseCase(IMinisterioRepository repository, IMapper<CrearMinisterioRequest, CrearMinisterioParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(CrearMinisterioRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.AddAsync(parameters);
>>>>>>> origin/masterboa
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
