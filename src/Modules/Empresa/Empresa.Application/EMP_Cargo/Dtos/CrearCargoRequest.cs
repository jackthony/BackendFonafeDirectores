namespace Empresa.Application.EMP_Cargo.Dtos
{
    public class CrearCargoRequest
    {
        public required string NombreCargo { get; set; }
        public required int UsuarioRegistroId { get; set; }
    }
}
