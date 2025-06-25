namespace Usuario.Application.SEG_Rol.Dtos
{
    public class CrearPermisosRolRequest
    {
        public int nRolId { get; set; }
        public List<PermisolRolRequest> lstPermisos { get; set; } = [];
        public int nUsuarioModificacionId { get; set; }
    }
}
