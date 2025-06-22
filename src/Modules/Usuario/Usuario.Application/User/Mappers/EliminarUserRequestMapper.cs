using Shared.Kernel.Interfaces;
using Usuario.Application.User.Dtos;
using Usuario.Domain.User.Parameters;

namespace Usuario.Application.User.Mappers
{
    public class EliminarUserRequestMapper : IMapper<EliminarUserRequest, EliminarUserParameters>
    {
        public EliminarUserParameters Map(EliminarUserRequest source)
        {
            throw new NotImplementedException();
        }
    }
}
