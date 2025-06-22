namespace Empresa.Application.Director.Dtos
{
    public class ActualizarDirectorRequest
    {
        public int TipoDirectorId { get; set; }
        public string NombreTipoDirector { get; set; } = default!;
        public int UsuarioModificacionId { get; set; }
    }
}
