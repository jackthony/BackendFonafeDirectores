using Empresa.Domain.Dieta.Results;

namespace Empresa.Presentation.Dieta.Responses
{
    public static class DietaResponseMapper
    {
        public static DietaResponse ToResponse(DietaResult result)
        {
            return new DietaResponse
            {
                SRUC = result.Ruc,
                NTipoCargo = result.TipoCargo,
                MDieta = result.MontoDieta
            };
        }
    }
}
