/*****
 * Nombre del archivo:  ListarDirectorPaginadaUseCase.cs
 * Descripción:         Caso de uso para listar directores paginados. Mapea el request (`ListarDirectorPaginadoRequest`) a los parámetros correspondientes 
 *                      y obtiene los resultados paginados del repositorio. Si se especifica un `nIdEmpresa`, añade directores vacantes si el número de miembros es menor que el máximo permitido.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Director.Dtos;
using Empresa.Domain.Director.Parameters;
using Empresa.Domain.Director.Repositories;
using Empresa.Domain.Director.Results;

namespace Empresa.Application.Director.UseCases
{
    public class ListarDirectorPaginadaUseCase : IUseCase<ListarDirectorPaginadoRequest, PagedResult<DirectorResult>>
    {
        private readonly IDirectorRepository _repository;
        private readonly IMapper<ListarDirectorPaginadoRequest, ListarDirectorPaginadoParameters> _mapper;

        public ListarDirectorPaginadaUseCase(
            IDirectorRepository repository,
            IMapper<ListarDirectorPaginadoRequest, ListarDirectorPaginadoParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, PagedResult<DirectorResult>>> ExecuteAsync(ListarDirectorPaginadoRequest request)
        {
            var parameters = _mapper.Map(request);
            var result = await _repository.ListByPaginationAsync(parameters);

            if (request.nIdEmpresa != null)
            {
                var cantidadMaxima = await _repository.GetNumeroMiembros(request.nIdEmpresa ?? 0);

                int itemsMostradosHastaAhora = (request.Page - 1) * request.PageSize;
                int cantidadReal = result.TotalItems;
                int vacantesDisponibles = cantidadMaxima - cantidadReal;

                for (int i = 0; i < request.PageSize; i++)
                {
                    int indiceGlobal = itemsMostradosHastaAhora + i;
                    if (indiceGlobal >= cantidadReal && vacantesDisponibles > 0)
                    {
                        var director = new DirectorResult
                        {
                            sNombres = "DISPONIBLE",
                            sApellidos = "VACANTE"
                        };
                        result.Items.Add(director);
                        vacantesDisponibles--;
                    }
                }
            }

            return result;
        }
    }
}
