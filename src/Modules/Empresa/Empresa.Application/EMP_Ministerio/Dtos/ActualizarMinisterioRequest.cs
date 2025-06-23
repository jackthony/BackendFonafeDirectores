namespace Empresa.Application.Ministerio.Dtos
{
    public class ActualizarMinisterioRequest
    {
        public int nMinisterioId { get; set; }
        public string sNombreMinisterio { get; set; } = default!;
        public int nUsuarioModificacionId { get; set; }
    }
}
