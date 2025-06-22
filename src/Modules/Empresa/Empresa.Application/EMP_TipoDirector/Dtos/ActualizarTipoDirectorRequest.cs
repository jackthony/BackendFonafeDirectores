namespace Empresa.Application.TipoDirector.Dtos
{
    public class ActualizarTipoDirectorRequest
    {
        public int TipoDirectorId { get; set; }
        public string NombreTipoDirector { get; set; } = default!;
        public int UsuarioModificacionId { get; set; }
    }
}
