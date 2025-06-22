using Shared.Kernel.Interfaces;
using Usuario.Application.User.Dtos;
using Usuario.Domain.User.Parameters;

namespace Usuario.Application.User.Mappers
{
    public class ListarUserRequestMapper : IMapper<ListarUserRequest, ListarUserParameters>
    {
        public ListarUserParameters Map(ListarUserRequest source)
        {
            throw new NotImplementedException();
        }
    }
}
