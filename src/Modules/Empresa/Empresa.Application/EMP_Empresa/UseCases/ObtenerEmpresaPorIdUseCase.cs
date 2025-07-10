/*****
 * Nombre del archivo: ObtenerEmpresaPorIdUseCase.cs
 * Descripción: Este archivo contiene la lógica del caso de uso para obtener una empresa por su ID. Si la empresa no se encuentra,
 *              devuelve un error "Not Found". El repositorio correspondiente es utilizado para consultar la base de datos.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación de la lógica para obtener una empresa por su ID, manejo del error en caso de no encontrarse.
 *****/
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Empresa.Domain.Empresa.Repositories;
using Empresa.Domain.Empresa.Results;

namespace Empresa.Application.Empresa.UseCases
{
    public class ObtenerEmpresaPorIdUseCase : IUseCase<int, EmpresaResult?>
    {
        private readonly IEmpresaRepository _repository;

        public ObtenerEmpresaPorIdUseCase(IEmpresaRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, EmpresaResult?>> ExecuteAsync(int request)
        {
            var result = await _repository.GetByIdAsync(request);
            if (result == null) return ErrorBase.NotFound();
            return result;
        }
    }
}
