namespace Empresa.Domain.Ministerio.Parameters
{
    public class ActualizarMinisterioParameters
    {
        public int MinisterioId { get; set; }
        public string NombreMinisterio { get; set; } = default!;
        public int UsuarioModificacionId { get; set; }
        public DateTime FechaModificacion { get; set; }

    }
}
