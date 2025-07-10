/*****
 * Nombre del archivo:  ListarEmpresaPaginadaUseCase.cs
 * Descripción:         Lógica de negocio para listar empresas con paginación. Recibe un request con los parámetros de paginación y los mapea
 *                      a parámetros específicos que son enviados al repositorio para obtener los resultados de la base de datos.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Implementación de la lógica de paginación para la obtención de empresas, con manejo de errores.
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
    public class ListarEmpresaPaginadaUseCase : IUseCase<ListarEmpresaPaginadoRequest, PagedResult<EmpresaResult>>
    {
        private readonly IEmpresaRepository _repository;
        private readonly IMapper<ListarEmpresaPaginadoRequest, ListarEmpresaPaginadoParameters> _mapper;

        public ListarEmpresaPaginadaUseCase(
            IEmpresaRepository repository,
            IMapper<ListarEmpresaPaginadoRequest, ListarEmpresaPaginadoParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, PagedResult<EmpresaResult>>> ExecuteAsync(ListarEmpresaPaginadoRequest request)
        {
            var parameters = _mapper.Map(request);
            var result = await _repository.ListByPaginationAsync(parameters);
            return result;
        }
    }
}
