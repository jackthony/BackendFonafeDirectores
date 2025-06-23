namespace Empresa.Application.Rubro.Dtos
{
    public class ActualizarRubroRequest
    {
        public int nRubroId { get; set; }
        public string sNombreRubro { get; set; } = default!;
        public int nUsuarioModificacionId { get; set; }
    }
}
