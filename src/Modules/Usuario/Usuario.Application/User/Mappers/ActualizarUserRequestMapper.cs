using Shared.Kernel.Interfaces;
using Usuario.Application.User.Dtos;
using Usuario.Domain.User.Parameters;

namespace Usuario.Application.User.Mappers
{
    public class ActualizarUserRequestMapper : IMapper<ActualizarUserRequest, ActualizarUserParameters>
    {
        public ActualizarUserParameters Map(ActualizarUserRequest source)
        {
            throw new NotImplementedException();
        }
    }
}
