/*****
 * Nombre del archivo:  ListarProvinciaUseCase.cs
 * Descripción:         Caso de uso para listar provincias. Recibe una solicitud, la mapea a parámetros
 *                      de dominio y consulta el repositorio para obtener la lista de resultados.
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

namespace Empresa.Application.Provincia.UseCases
{
    public class ListarProvinciaUseCase : IUseCase<ListarProvinciaRequest, List<ProvinciaResult>>
    {
        private readonly IUbigeoRepository _repository;
        private readonly IMapper<ListarProvinciaRequest, ListarProvinciaParameters> _mapper;

        public ListarProvinciaUseCase(
            IUbigeoRepository repository,
            IMapper<ListarProvinciaRequest, ListarProvinciaParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, List<ProvinciaResult>>> ExecuteAsync(ListarProvinciaRequest request)
        {
            var parameters = _mapper.Map(request);
            var result = await _repository.ListProvincias(parameters);
            return result;
        }
    }
}
