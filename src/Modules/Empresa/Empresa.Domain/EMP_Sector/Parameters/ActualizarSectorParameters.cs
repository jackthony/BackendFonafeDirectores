namespace Empresa.Domain.Sector.Parameters
{
    public class ActualizarSectorParameters
    {
        public int SectorId { get; set; }
        public string NombreSector { get; set; } = default!;
        public int UsuarioModificacionId { get; set; }
        public DateTime FechaModificacion { get; set; }

    }
}
