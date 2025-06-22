namespace Empresa.Domain.EMP_Cargo.Models
{
    public class ActualizarCargoData
    {
        public required int CargoId { get; set; }
        public required int UsuarioModificacionId { get; set; }
        public required DateTime FechaModificacion { get; set; }
        public string? NombreCargo { get; set; }
        public bool? IsActivo { get; set; }
       
    }
}
