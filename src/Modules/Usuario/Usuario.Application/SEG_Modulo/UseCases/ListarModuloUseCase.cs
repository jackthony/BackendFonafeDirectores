/***********
* Nombre del archivo: ObtenerModuloPorIdUseCase.cs
* Descripción:        **Caso de uso** para obtener un módulo por su identificador.
*                     Orquesta la lógica para recuperar los datos de un módulo específico
*                     desde el **repositorio** y manejar posibles escenarios donde el módulo no es encontrado.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase de caso de uso.
***********/

using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Usuario.Application.Modulo.Dtos;
using Usuario.Domain.Modulo.Parameters;
using Usuario.Domain.Modulo.Repositories;
using Usuario.Domain.Modulo.Results;

namespace Usuario.Application.Modulo.UseCases
{
    public class ListarModuloUseCase : IUseCase<ListarModuloRequest, List<ModuloResult>>
    {
        private readonly IModuloRepository _repository;
        private readonly IMapper<ListarModuloRequest, ListarModuloParameters> _mapper;

        public ListarModuloUseCase(
            IModuloRepository repository,
            IMapper<ListarModuloRequest, ListarModuloParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, List<ModuloResult>>> ExecuteAsync(ListarModuloRequest request)
        {
            var parameters = _mapper.Map(request);
            var result = await _repository.ListAsync(parameters);
            return result;
        }
    }
}
