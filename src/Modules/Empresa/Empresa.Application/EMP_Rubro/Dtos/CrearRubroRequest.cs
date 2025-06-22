namespace Empresa.Application.Rubro.Dtos
{
    public class CrearRubroRequest
    {
        public string NombreRubro { get; set; } = default!;
        public int UsuarioRegistroId { get; set; }
    }
}
