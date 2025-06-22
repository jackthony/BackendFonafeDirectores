namespace Empresa.Application.EMP_Cargo.Dtos
{
    public class EliminarCargoRequest
    {
        public required int CargoId { get; set; }
        public required int UsuarioModificacionId { get; set; }
    }

}
