/*****
 * Nombre del archivo:  EliminarSectorUseCase.cs
 * Descripción:         Caso de uso para eliminar un sector. Realiza el mapeo de la solicitud
 *                      a parámetros para la operación de eliminación en el repositorio.
 *                      Retorna un resultado de procedimiento almacenado o un error en caso de fallo.
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

            return result;
        }
    }
}
