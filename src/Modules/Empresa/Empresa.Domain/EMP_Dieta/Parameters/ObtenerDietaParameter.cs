namespace Empresa.Domain.Dieta.Parameters
{
    public class ObtenerDietaParameter
    {
        public required string Ruc { get; set; } = string.Empty;
        public required int TipoCargo { get; set; }
    }
}
