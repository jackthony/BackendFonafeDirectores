/*****
 * Nombre del archivo: ListarEmpresaUseCase.cs
 * Descripción: Este archivo contiene la lógica del caso de uso para listar empresas sin paginación, recibiendo un request
 *              con parámetros de filtrado y mapeando esos parámetros a parámetros específicos que son enviados al repositorio.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación de la lógica para listar empresas según los parámetros de filtro proporcionados.
 *****/
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Empresa.Dtos;
using Empresa.Domain.Empresa.Parameters;
using Empresa.Domain.Empresa.Repositories;
using Empresa.Domain.Empresa.Results;

namespace Empresa.Application.Empresa.UseCases
{
    public class ListarEmpresaUseCase : IUseCase<ListarEmpresaRequest, List<EmpresaResult>>
    {
        private readonly IEmpresaRepository _repository;
        private readonly IMapper<ListarEmpresaRequest, ListarEmpresaParameters> _mapper;

        public ListarEmpresaUseCase(
            IEmpresaRepository repository,
            IMapper<ListarEmpresaRequest, ListarEmpresaParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, List<EmpresaResult>>> ExecuteAsync(ListarEmpresaRequest request)
        {
            var parameters = _mapper.Map(request);
            var result = await _repository.ListAsync(parameters);
            return result;
        }
    }
}
