namespace Empresa.Application.TipoDirector.Dtos
{
    public class ActualizarTipoDirectorRequest
    {
        public int nIdTipoDirector { get; set; }
        public string sNombreTipoDirector { get; set; } = default!;
        public int nUsuarioModificacion { get; set; }
    }
}
