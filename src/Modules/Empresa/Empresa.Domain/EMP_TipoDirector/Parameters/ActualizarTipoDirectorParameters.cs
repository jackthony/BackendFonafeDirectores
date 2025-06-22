namespace Empresa.Domain.TipoDirector.Parameters
{
    public class ActualizarTipoDirectorParameters
    {
        public int TipoDirectorId { get; set; }
        public string NombreTipoDirector { get; set; } = default!;
        public int UsuarioModificacionId { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}
