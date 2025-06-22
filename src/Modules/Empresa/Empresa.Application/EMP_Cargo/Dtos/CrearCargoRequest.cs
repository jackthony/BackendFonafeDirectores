namespace Empresa.Application.Cargo.Dtos
{
    public class CrearCargoRequest
    {
        public string NombreCargo { get; set; } = default!;
        public int UsuarioRegistroId { get; set; }
    }
}
