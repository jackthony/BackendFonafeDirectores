namespace Empresa.Application.Director.Dtos
{
    public class CrearDirectorRequest
    {
        public string NombreTipoDirector { get; set; } = default!;
        public int UsuarioRegistroId { get; set; }
    }
}
