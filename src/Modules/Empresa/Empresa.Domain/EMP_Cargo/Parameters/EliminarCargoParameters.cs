namespace Empresa.Domain.Cargo.Parameters
{
    public class EliminarCargoParameters
    {
        public int CargoId { get; set; }
        public int UsuarioModificacionId { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}
