/*****
 * Nombre del archivo:  ActualizarEmpresaUseCase.cs
 * Descripción:         Lógica de negocio para actualizar una empresa. Recibe un request de actualización y lo convierte en un parámetro,
 *                      luego lo pasa al repositorio para realizar la actualización.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Implementación de la lógica para actualizar los detalles de la empresa, con manejo de errores.
 *****/
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Empresa.Dtos;
using Empresa.Domain.Empresa.Parameters;
using Empresa.Domain.Empresa.Repositories;

namespace Empresa.Application.Empresa.UseCases
{
    public class ActualizarEmpresaUseCase : IUseCase<ActualizarEmpresaRequest, SpResultBase>
    {
        private readonly IEmpresaRepository _repository;
        private readonly IMapper<ActualizarEmpresaRequest, ActualizarEmpresaParameters> _mapper;

        public ActualizarEmpresaUseCase(IEmpresaRepository repository, IMapper<ActualizarEmpresaRequest, ActualizarEmpresaParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(ActualizarEmpresaRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.UpdateAsync(parameters);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
