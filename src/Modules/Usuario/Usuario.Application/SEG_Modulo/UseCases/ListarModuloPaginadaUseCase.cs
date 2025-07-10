/***********
* Nombre del archivo: ListarModuloPaginadaUseCase.cs
* Descripción:        **Caso de uso** para listar módulos con paginación.
*                     Orquesta la lógica para obtener una colección paginada de módulos,
*                     transformando la solicitud a parámetros de dominio y utilizando el **repositorio**
*                     para acceder a los datos.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase de caso de uso para listar módulos paginados.
***********/

using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Usuario.Application.Modulo.Dtos;
using Usuario.Domain.Modulo.Parameters;
using Usuario.Domain.Modulo.Repositories;
using Usuario.Domain.Modulo.Results;

namespace Usuario.Application.Modulo.UseCases
{
    public class ListarModuloPaginadaUseCase : IUseCase<ListarModuloPaginadoRequest, PagedResult<ModuloResult>>
    {
        private readonly IModuloRepository _repository;
        private readonly IMapper<ListarModuloPaginadoRequest, ListarModuloPaginadoParameters> _mapper;

        public ListarModuloPaginadaUseCase(
            IModuloRepository repository,
            IMapper<ListarModuloPaginadoRequest, ListarModuloPaginadoParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, PagedResult<ModuloResult>>> ExecuteAsync(ListarModuloPaginadoRequest request)
        {
            var parameters = _mapper.Map(request);
            var result = await _repository.ListByPaginationAsync(parameters);
            return result;
        }
    }
}
