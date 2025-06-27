<<<<<<< HEAD
﻿using Empresa.Domain.EMP_Sector.Models;
using Empresa.Domain.EMP_Sector.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Application.EMP_Sector.UseCases
{
    public class EliminarSectorUseCase : IUseCase<EliminarSectorData, SpResultBase>
    {
        private readonly IWriteSectorRepository<SpResultBase> _repository;

        public EliminarSectorUseCase(IWriteSectorRepository<SpResultBase> repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(EliminarSectorData request)
        {
            var result = await _repository.DeleteAsync(request);
            if (!result.Success) return ErrorBase.Database(result.Message);
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
    public class EliminarSectorUseCase : IUseCase<EliminarSectorRequest, SpResultBase>
    {
        private readonly ISectorRepository _repository;
        private readonly IMapper<EliminarSectorRequest, EliminarSectorParameters> _mapper;

        public EliminarSectorUseCase(
            ISectorRepository repository,
            IMapper<EliminarSectorRequest, EliminarSectorParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(EliminarSectorRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.DeleteAsync(parameters);

            if (!result.Success) return ErrorBase.Database(result.Message);

>>>>>>> origin/masterboa
            return result;
        }
    }
}
