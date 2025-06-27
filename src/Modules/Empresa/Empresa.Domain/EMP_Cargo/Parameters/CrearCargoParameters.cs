namespace Empresa.Domain.Cargo.Parameters
{
    public class CrearCargoParameters
    {
        public string NombreCargo { get; set; } = default!;
        public int UsuarioRegistroId { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
