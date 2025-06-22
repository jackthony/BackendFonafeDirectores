using Shared.Kernel.Interfaces;
using Usuario.Application.User.Dtos;
using Usuario.Domain.User.Parameters;

namespace Usuario.Application.User.Mappers
{
    public class CrearUserRequestMapper : IMapper<CrearUserRequest, CrearUserParameters>
    {
        public CrearUserParameters Map(CrearUserRequest source)
        {
            throw new NotImplementedException();
        }
    }
}
