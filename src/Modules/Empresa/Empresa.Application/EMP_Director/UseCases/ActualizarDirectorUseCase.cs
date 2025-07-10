/*****
 * Nombre del archivo:  ActualizarDirectorUseCase.cs
 * Descripción:         Caso de uso para actualizar un director. Mapea los datos del request (`ActualizarDirectorRequest`) a los parámetros correspondientes (`ActualizarDirectorParameters`) 
 *                      y luego llama al repositorio (`IDirectorRepository`) para realizar la actualización en la base de datos.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Director.Dtos;
using Empresa.Domain.Director.Parameters;
using Empresa.Domain.Director.Repositories;

namespace Empresa.Application.Director.UseCases
{
    public class ActualizarDirectorUseCase : IUseCase<ActualizarDirectorRequest, SpResultBase>
    {
        private readonly IDirectorRepository _repository;
        private readonly IMapper<ActualizarDirectorRequest, ActualizarDirectorParameters> _mapper;

        public ActualizarDirectorUseCase(IDirectorRepository repository, IMapper<ActualizarDirectorRequest, ActualizarDirectorParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(ActualizarDirectorRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.UpdateAsync(parameters);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
