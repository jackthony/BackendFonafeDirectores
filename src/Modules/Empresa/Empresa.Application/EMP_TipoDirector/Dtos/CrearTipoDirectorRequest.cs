namespace Empresa.Application.TipoDirector.Dtos
{
    public class CrearTipoDirectorRequest
    {
        public string NombreTipoDirector { get; set; } = default!;
        public int UsuarioRegistroId { get; set; }
    }
}
