namespace Empresa.Application.Sector.Dtos
{
    public class CrearSectorRequest
    {
        public string sNombreSector { get; set; } = default!;
        public int nUsuarioRegistroId { get; set; }
    }
}
