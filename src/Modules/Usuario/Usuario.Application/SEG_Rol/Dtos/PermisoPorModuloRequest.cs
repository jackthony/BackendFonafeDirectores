namespace Usuario.Application.SEG_Rol.Dtos
{
    public class PermisoPorModuloRequest
    {
        public int nModuloId { get; set; }
        public List<AccionPermisoRequest> lstAcciones { get; set; } = [];
    }
}
