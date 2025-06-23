namespace Empresa.Application.Rubro.Dtos
{
    public class ActualizarRubroRequest
    {
        public int nIdRubro { get; set; }
        public string sNombreRubro { get; set; } = default!;
        public int nUsuarioModificacion { get; set; }
    }
}
