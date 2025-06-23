namespace Empresa.Application.Sector.Dtos
{
    public class ActualizarSectorRequest
    {
        public int nSectorId { get; set; }
        public string sNombreSector { get; set; } = default!;
        public int nUsuarioModificacionId { get; set; }
    }
}
