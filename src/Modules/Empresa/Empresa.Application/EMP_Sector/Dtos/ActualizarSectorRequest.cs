namespace Empresa.Application.Sector.Dtos
{
    public class ActualizarSectorRequest
    {
        public int SectorId { get; set; }
        public string NombreSector { get; set; } = default!;
        public int UsuarioModificacionId { get; set; }
    }
}
