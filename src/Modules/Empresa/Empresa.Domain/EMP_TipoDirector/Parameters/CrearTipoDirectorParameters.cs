namespace Empresa.Domain.TipoDirector.Parameters
{
    public class CrearTipoDirectorParameters
    {
        public string NombreTipoDirector { get; set; } = default!;
        public int UsuarioRegistroId { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
