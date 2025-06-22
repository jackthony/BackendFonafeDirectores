namespace Empresa.Domain.Cargo.Parameters
{
    public class ActualizarCargoParameters
    {
        public int CargoId { get; set; }
        public string NombreCargo { get; set; } = default!;
        public int UsuarioModificacionId { get; set; }
        public DateTime FechaModificacion { get; set; }

    }
}
