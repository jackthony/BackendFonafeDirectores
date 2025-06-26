namespace Empresa.Application.TipoDirector.Dtos
{
    public class CrearTipoDirectorRequest
    {
        public string sNombreTipoDirector { get; set; } = default!;
        public int nUsuarioRegistro { get; set; }
    }
}
