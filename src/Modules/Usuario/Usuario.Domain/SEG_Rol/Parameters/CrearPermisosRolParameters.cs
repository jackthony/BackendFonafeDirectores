namespace Usuario.Domain.SEG_Rol.Parameters
{
    public class CrearPermisosRolParameters
    {
        public int RolId { get; set; }
        public List<PermisoRolParameter> Permisos { get; set; } = [];
        public int UsuarioModificacionId { get; set; }
        public DateTime FechaOperacion { get; set; }
    }
}
