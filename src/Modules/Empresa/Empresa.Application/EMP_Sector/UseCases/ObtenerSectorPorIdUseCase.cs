<<<<<<< HEAD
﻿using Empresa.Application.EMP_Sector.Dtos;
using Empresa.Application.EMP_Sector.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;

namespace Empresa.Application.EMP_Sector.UseCases
{
    public class ObtenerSectorPorIdUseCase : IUseCase<long, SectorDto?>
    {
        private readonly IReadSectorRepository _repository;

        public ObtenerSectorPorIdUseCase(IReadSectorRepository repository)
=======
﻿using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Empresa.Domain.Sector.Repositories;
using Empresa.Domain.Sector.Results;

namespace Empresa.Application.Sector.UseCases
{
    public class ObtenerSectorPorIdUseCase : IUseCase<int, SectorResult?>
    {
        private readonly ISectorRepository _repository;

        public ObtenerSectorPorIdUseCase(ISectorRepository repository)
>>>>>>> origin/masterboa
        {
            _repository = repository;
        }

<<<<<<< HEAD
        public async Task<OneOf<ErrorBase, SectorDto?>> ExecuteAsync(long request)
=======
        public async Task<OneOf<ErrorBase, SectorResult?>> ExecuteAsync(int request)
>>>>>>> origin/masterboa
        {
            var result = await _repository.GetByIdAsync(request);
            if (result == null) return ErrorBase.NotFound();
            return result;
        }
    }
}
