namespace Empresa.Domain.Cargo.Results
{
    public class CargoResult
    {
        public int CargoId { get; set; }
        public string NombreCargo { get; set; } = default!;
        public bool IsActivo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? UsuarioModificacionId { get; set; }
    }
}
