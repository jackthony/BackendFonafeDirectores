namespace Empresa.Application.Ministerio.Dtos
{
    public class ActualizarMinisterioRequest
    {
        public int MinisterioId { get; set; }
        public string NombreMinisterio { get; set; } = default!;
        public int UsuarioModificacionId { get; set; }
    }
}
