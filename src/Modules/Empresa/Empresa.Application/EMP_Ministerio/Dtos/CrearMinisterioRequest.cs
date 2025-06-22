namespace Empresa.Application.Ministerio.Dtos
{
    public class CrearMinisterioRequest
    {
        public string NombreMinisterio { get; set; } = default!;
        public int UsuarioRegistroId { get; set; }
    }
}
