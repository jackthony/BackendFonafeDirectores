/*****
 * Nombre del archivo:  ObtenerDirectorPorIdUseCase.cs
 * Descripción:         Caso de uso para obtener un director por su ID. Si no se encuentra, devuelve un error de "no encontrado".
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Empresa.Domain.Director.Repositories;
using Empresa.Domain.Director.Results;

namespace Empresa.Application.Director.UseCases
{
    public class ObtenerDirectorPorIdUseCase : IUseCase<int, DirectorResult?>
    {
        private readonly IDirectorRepository _repository;

        public ObtenerDirectorPorIdUseCase(IDirectorRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, DirectorResult?>> ExecuteAsync(int request)
        {
            var result = await _repository.GetByIdAsync(request);
            if (result == null) return ErrorBase.NotFound();
            return result;
        }
    }
}
