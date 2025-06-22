namespace Empresa.Domain.EMP_Cargo.Models
{
    public class CrearCargoData
    {
        public required string NombreCargo { get; set; }
        public required bool IsActivo { get; set; }
        public required int UsuarioRegistroId { get; set; }
        public required DateTime FechaRegistro { get; set; }
    }
}
