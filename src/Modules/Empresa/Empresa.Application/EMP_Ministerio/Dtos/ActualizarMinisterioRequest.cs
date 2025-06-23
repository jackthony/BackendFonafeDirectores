namespace Empresa.Application.Ministerio.Dtos
{
    public class ActualizarMinisterioRequest
    {
        public int nIdMinisterio { get; set; }
        public string sNombreMinisterio { get; set; } = default!;
        public int nUsuarioModificacion { get; set; }
    }
}
