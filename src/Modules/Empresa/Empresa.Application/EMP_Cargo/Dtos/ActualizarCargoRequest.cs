namespace Empresa.Application.EMP_Cargo.Dtos
{
    public class ActualizarCargoRequest
    {
        public required int CargoId { get; set; }
        public required int UsuarioModificacionId { get; set; }
        public string? NombreCargo { get; set; }
        public bool? IsActivo { get; set; }
    }
}
