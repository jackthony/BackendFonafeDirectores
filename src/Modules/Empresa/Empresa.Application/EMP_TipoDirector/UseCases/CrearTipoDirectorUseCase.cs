/*****
 * Nombre del archivo:  CrearTipoDirectorUseCase.cs
 * Descripción:         Caso de uso para crear un nuevo tipo de director. Convierte la solicitud en parámetros
 *                      de dominio y utiliza el repositorio para ejecutar la operación de inserción.
 *                      Devuelve el resultado o un error si ocurre algún problema en la base de datos.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/

using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.TipoDirector.Dtos;
using Empresa.Domain.TipoDirector.Parameters;
using Empresa.Domain.TipoDirector.Repositories;

namespace Empresa.Application.TipoDirector.UseCases
{
    public class CrearTipoDirectorUseCase : IUseCase<CrearTipoDirectorRequest, SpResultBase>
    {
        private readonly ITipoDirectorRepository _repository;
        private readonly IMapper<CrearTipoDirectorRequest, CrearTipoDirectorParameters> _mapper;

        public CrearTipoDirectorUseCase(ITipoDirectorRepository repository, IMapper<CrearTipoDirectorRequest, CrearTipoDirectorParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(CrearTipoDirectorRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.AddAsync(parameters);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
