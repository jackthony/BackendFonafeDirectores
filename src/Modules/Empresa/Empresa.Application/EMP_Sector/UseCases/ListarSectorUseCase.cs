<<<<<<< HEAD
﻿using Empresa.Application.EMP_Sector.Dtos;
using Empresa.Application.EMP_Sector.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;

namespace Empresa.Application.EMP_Sector.UseCases
{
    public class ListarSectorUseCase : IUseCase<ListarSectorRequest, List<SectorDto>>
    {
        private readonly IReadSectorRepository _repository;

        public ListarSectorUseCase(IReadSectorRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, List<SectorDto>>> ExecuteAsync(ListarSectorRequest request)
        {
            var result = await _repository.ListAsync(request);
=======
﻿using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Sector.Dtos;
using Empresa.Domain.Sector.Parameters;
using Empresa.Domain.Sector.Repositories;
using Empresa.Domain.Sector.Results;

namespace Empresa.Application.Sector.UseCases
{
    public class ListarSectorUseCase : IUseCase<ListarSectorRequest, List<SectorResult>>
    {
        private readonly ISectorRepository _repository;
        private readonly IMapper<ListarSectorRequest, ListarSectorParameters> _mapper;

        public ListarSectorUseCase(
            ISectorRepository repository,
            IMapper<ListarSectorRequest, ListarSectorParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, List<SectorResult>>> ExecuteAsync(ListarSectorRequest request)
        {
            var parameters = _mapper.Map(request);
            var result = await _repository.ListAsync(parameters);
>>>>>>> origin/masterboa
            return result;
        }
    }
}
