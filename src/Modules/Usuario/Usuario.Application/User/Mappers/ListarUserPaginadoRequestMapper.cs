using Shared.Kernel.Interfaces;
using Usuario.Application.User.Dtos;
using Usuario.Domain.User.Parameters;

namespace Usuario.Application.User.Mappers
{
    public class ListarUserPaginadoRequestMapper : IMapper<ListarUserPaginadoRequest, ListarUserPaginadoParameters>
    {
        public ListarUserPaginadoParameters Map(ListarUserPaginadoRequest source)
        {
<<<<<<< HEAD
            throw new NotImplementedException();
=======
            return new ListarUserPaginadoParameters
            {
                Page = source.Page,
                PageSize = source.PageSize,
                Nombre = source.sNombreCompleto,
                Estado = source.bIsEstado
            };
>>>>>>> origin/masterboa
        }
    }
}
