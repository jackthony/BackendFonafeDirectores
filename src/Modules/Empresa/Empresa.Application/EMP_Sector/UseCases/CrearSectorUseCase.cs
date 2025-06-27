<<<<<<< HEAD
﻿using Empresa.Domain.EMP_Sector.Models;
using Empresa.Domain.EMP_Sector.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Application.EMP_Sector.UseCases
{
    public class CrearSectorUseCase : IUseCase<CrearSectorData, SpResultBase>
    {
        private readonly IWriteSectorRepository<SpResultBase> _repository;

        public CrearSectorUseCase(IWriteSectorRepository<SpResultBase> repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(CrearSectorData request)
        {
            var result = await _repository.AddAsync(request);
=======
﻿using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Sector.Dtos;
using Empresa.Domain.Sector.Parameters;
using Empresa.Domain.Sector.Repositories;

namespace Empresa.Application.Sector.UseCases
{
    public class CrearSectorUseCase : IUseCase<CrearSectorRequest, SpResultBase>
    {
        private readonly ISectorRepository _repository;
        private readonly IMapper<CrearSectorRequest, CrearSectorParameters> _mapper;

        public CrearSectorUseCase(ISectorRepository repository, IMapper<CrearSectorRequest, CrearSectorParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(CrearSectorRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.AddAsync(parameters);
>>>>>>> origin/masterboa
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
