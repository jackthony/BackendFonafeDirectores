/*****
 * Nombre del archivo:  CrearSectorUseCase.cs
 * Descripción:         Caso de uso para crear un nuevo sector. Mapea la solicitud a parámetros
 *                      del dominio y llama al repositorio para insertar el nuevo registro.
 *                      Retorna el resultado del procedimiento almacenado o un error en caso de fallo.
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
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
