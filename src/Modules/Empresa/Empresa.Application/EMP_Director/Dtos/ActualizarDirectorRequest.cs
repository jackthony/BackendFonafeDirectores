namespace Empresa.Application.Director.Dtos
{
    public class ActualizarDirectorRequest
    {
        public int nIdRegistro { get; set; }
        public int nIdEmpresa { get; set; }
        public string sDepartamento { get; set; }
        public string sProvincia { get; set; }
        public string sDistrito { get; set; }
        public string sDireccion { get; set; }
        public string sTelefono { get; set; }
        public string sTelefonoSecundario { get; set; }
        public string sTelefonoTerciario { get; set; }
        public string sCorreo { get; set; }
        public string sCorreoSecundario { get; set; }
        public string sCorreoTerciario { get; set; }
        public int nCargo { get; set; }
        public int nTipoDirector { get; set; }
        public string sProfesion { get; set; }
        public int nIdSector { get; set; }
        public decimal mDieta { get; set; }
        public int nEspecialidad { get; set; }
        public DateTime dFechaNombramiento { get; set; }
        public DateTime dFechaDesignacion { get; set; }
        public string sComentario { get; set; }
        public int nUsuarioModificacion { get; set; }
    }
}
