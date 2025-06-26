namespace Empresa.Application.Dieta.Dtos
{
    public class ObtenerDietaRequest
    {
        public required string SRUC { get; set; }
        public required int NTipoCargo { get; set; }
    }
}
