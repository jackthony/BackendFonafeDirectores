namespace Empresa.Presentation.Especialidad.Responses
{
    public class EspecialidadResponse
    {
        public int nIdEspecialidad { get; set; }
        public string sNombreEspecialidad { get; set; } = string.Empty;
        public bool bActivo { get; set; }
        public DateTime dtFechaRegistro { get; set; }
        public int nUsuarioRegistro { get; set; }
        public DateTime? dtFechaModificacion { get; set; }
        public int? nUsuarioModificacion { get; set; }
        public int indice { get; set; }
    }
}
