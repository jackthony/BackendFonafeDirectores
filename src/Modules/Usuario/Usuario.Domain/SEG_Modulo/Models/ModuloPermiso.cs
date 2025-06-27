namespace Usuario.Domain.SEG_Modulo.Models
{
    public class ModuloPermiso
    {
        public string NombreModulo { get; set; } = string.Empty;
        public List<Permiso> Permisos { get; set; } = [];
    }
}
