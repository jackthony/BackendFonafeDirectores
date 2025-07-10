/*****
 * Nombre del archivo:  ListarDistritoUseCase.cs
 * Descripción:         Caso de uso para listar distritos. Convierte la solicitud en parámetros de dominio
 *                      mediante un mapeador y consulta el repositorio para obtener los resultados.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/

using Empresa.Application.Ubigeo.Dtos;
using Empresa.Domain.Ubigeo.Parameters;
using Empresa.Domain.Ubigeo.Repositories;
using Empresa.Domain.Ubigeo.Results;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;

namespace Empresa.Application.Distrito.UseCases
{
    public class ListarDistritoUseCase : IUseCase<ListarDistritoRequest, List<DistritoResult>>
    {
        private readonly IUbigeoRepository _repository;
        private readonly IMapper<ListarDistritoRequest, ListarDistritoParameters> _mapper;

        public ListarDistritoUseCase(
            IUbigeoRepository repository,
            IMapper<ListarDistritoRequest, ListarDistritoParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, List<DistritoResult>>> ExecuteAsync(ListarDistritoRequest request)
        {
            var parameters = _mapper.Map(request);
            var result = await _repository.ListDistritos(parameters);
            return result;
        }
    }
}
