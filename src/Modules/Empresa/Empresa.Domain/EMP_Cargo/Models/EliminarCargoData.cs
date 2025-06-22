namespace Empresa.Domain.EMP_Cargo.Models
{
    public class EliminarCargoData
    {
        public required int CargoId { get; set; }
        public required int UsuarioModificacionId { get; set; }
        public required DateTime FechaModificacion { get; set; }
    }
}
