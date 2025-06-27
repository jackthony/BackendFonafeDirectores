namespace Empresa.Domain.Sector.Parameters
{
    public class CrearSectorParameters
    {
        public string NombreSector { get; set; } = default!;
        public int UsuarioRegistroId { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
