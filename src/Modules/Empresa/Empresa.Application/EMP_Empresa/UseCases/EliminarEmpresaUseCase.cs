/*****
 * Nombre del archivo:  EliminarEmpresaUseCase.cs
 * Descripción:         Lógica de negocio para eliminar una empresa. Recibe un request con el ID de la empresa a eliminar, lo mapea a parámetros 
 *                      y luego lo pasa al repositorio para realizar la eliminación en la base de datos.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación de la lógica para eliminar una empresa, con manejo de errores.
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
    public class EliminarEmpresaUseCase : IUseCase<EliminarEmpresaRequest, SpResultBase>
    {
        private readonly IEmpresaRepository _repository;
        private readonly IMapper<EliminarEmpresaRequest, EliminarEmpresaParameters> _mapper;

        public EliminarEmpresaUseCase(
            IEmpresaRepository repository,
            IMapper<EliminarEmpresaRequest, EliminarEmpresaParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(EliminarEmpresaRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.DeleteAsync(parameters);

            if (!result.Success) return ErrorBase.Database(result.Message);

            return result;
        }
    }
}
