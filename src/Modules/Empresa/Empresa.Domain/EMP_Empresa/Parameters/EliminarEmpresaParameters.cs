namespace Empresa.Domain.Empresa.Parameters
{
    public class EliminarEmpresaParameters
    {
        public int EmpresaId { get; set; }
        public DateTime FechaModificacion { get; set; }
        public int UsuarioModificacionId { get; set; }
    }
}
