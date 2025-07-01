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
                var count = await _repository.GetNumeroMiembros(request.nIdEmpresa ?? 0);

                int cantidadReal = result.Items.Count;
                int cantidadMaxima = count;
                int pageSize = result.PageSize;

                int vacantesDisponibles = cantidadMaxima - cantidadReal;

                int vacantesARellenar = Math.Min(pageSize - cantidadReal, vacantesDisponibles);

                for (int i = cantidadReal; i < vacantesARellenar; i++)
                {
                    var director = new DirectorResult
                    {
                        sNombres = "Vacante disponible"
                    };
                    result.Items.Add(director);
                }

            }
            return result;
        }
    }
}
