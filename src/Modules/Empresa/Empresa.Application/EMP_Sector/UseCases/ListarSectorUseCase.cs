/*****
 * Nombre del archivo:  ListarSectorUseCase.cs
 * Descripción:         Caso de uso para listar sectores según criterios especificados en la solicitud.
 *                      Realiza el mapeo de la solicitud a parámetros del dominio y consulta el repositorio
 *                      para obtener la lista de sectores.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/

using OneOf;
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
            return result;
        }
    }
}
