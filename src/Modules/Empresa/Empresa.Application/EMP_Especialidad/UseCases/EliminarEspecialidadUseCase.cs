/*****
 * Nombre de clase:     EliminarEspecialidadUseCase
 * Descripción:         Caso de uso para eliminar una especialidad. Recibe una solicitud,
 *                      mapea a los parámetros del dominio y llama al repositorio para
 *                      realizar la eliminación en la base de datos. Devuelve el resultado
 *                      de la operación o un error en caso de fallo.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase creada para gestionar la eliminación de especialidades.
 *****/

using OneOf;
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

            return result;
        }
    }
}
