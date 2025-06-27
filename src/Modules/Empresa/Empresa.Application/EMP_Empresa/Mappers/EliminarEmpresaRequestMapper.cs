using Shared.Kernel.Interfaces;
using Empresa.Application.Empresa.Dtos;
using Empresa.Domain.Empresa.Parameters;
using Shared.Time;

namespace Empresa.Application.Empresa.Mappers
{
    public class EliminarEmpresaRequestMapper : IMapper<EliminarEmpresaRequest, EliminarEmpresaParameters>
    {
        private readonly ITimeProvider _timeProvider;

        public EliminarEmpresaRequestMapper(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }
        public EliminarEmpresaParameters Map(EliminarEmpresaRequest source)
        {
            return new EliminarEmpresaParameters
            {
                EmpresaId = source.nIdEmpresa,
                FechaModificacion = _timeProvider.NowPeru,
                UsuarioModificacionId = source.nUsuarioModificacion
            };
        }
    }
}
