using Shared.Kernel.Interfaces;
using Empresa.Domain.Dieta.Parameters;
using Empresa.Application.Dieta.Dtos;

namespace Empresa.Application.Dieta.Mappers
{
    public class ObtenerDietaRequestMapper : IMapper<ObtenerDietaRequest, ObtenerDietaParameter>
    {
        public ObtenerDietaParameter Map(ObtenerDietaRequest source)
        {
            return new ObtenerDietaParameter
            {
                Ruc = source.SRUC,
                TipoCargo = source.NTipoCargo
            };
        }
    }
}
