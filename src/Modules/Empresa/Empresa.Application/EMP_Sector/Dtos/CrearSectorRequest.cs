namespace Empresa.Application.Sector.Dtos
{
    public class CrearSectorRequest
    {
        public string NombreSector { get; set; } = default!;
        public int UsuarioRegistroId { get; set; }
    }
}
