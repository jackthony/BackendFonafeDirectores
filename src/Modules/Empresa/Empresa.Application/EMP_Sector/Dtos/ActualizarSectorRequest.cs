namespace Empresa.Application.Sector.Dtos
{
    public class ActualizarSectorRequest
    {
        public int nIdSector { get; set; }
        public string sNombreSector { get; set; } = default!;
        public int nUsuarioModificacion { get; set; }
    }
}
