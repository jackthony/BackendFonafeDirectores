namespace Empresa.Application.Cargo.Dtos
{
    public class ActualizarCargoRequest
    {
        public int CargoId { get; set; }
        public string NombreCargo { get; set; } = default!;
        public int UsuarioModificacionId { get; set; }
    }
}
