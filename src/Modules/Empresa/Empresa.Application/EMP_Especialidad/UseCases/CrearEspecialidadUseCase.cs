/*****
 * Nombre de clase:     CrearEspecialidadUseCase
 * Descripción:         Caso de uso para crear una nueva especialidad. Recibe un DTO
 *                      de creación, lo mapea a los parámetros del dominio y llama al
 *                      repositorio para agregar la especialidad en la base de datos.
 *                      Devuelve el resultado de la operación o un error si falla.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase creada para gestionar la creación de especialidades.
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
    public class CrearEspecialidadUseCase : IUseCase<CrearEspecialidadRequest, SpResultBase>
    {
        private readonly IEspecialidadRepository _repository;
        private readonly IMapper<CrearEspecialidadRequest, CrearEspecialidadParameters> _mapper;

        public CrearEspecialidadUseCase(IEspecialidadRepository repository, IMapper<CrearEspecialidadRequest, CrearEspecialidadParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(CrearEspecialidadRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.AddAsync(parameters);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
