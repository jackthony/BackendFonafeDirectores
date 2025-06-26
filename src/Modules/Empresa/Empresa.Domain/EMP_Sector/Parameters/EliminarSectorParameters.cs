namespace Empresa.Domain.Sector.Parameters
{
    public class EliminarSectorParameters
    {
        public int SectorId { get; set; }
        public int UsuarioModificacionId { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}
