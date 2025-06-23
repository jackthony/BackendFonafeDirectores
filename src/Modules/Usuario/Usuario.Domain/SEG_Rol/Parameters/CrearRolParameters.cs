namespace Usuario.Domain.Rol.Parameters
{
    public class CrearRolParameters
    {
      public string NombreRol { get; set; } = default!;
      public int UsuarioRegistroId { get; set; }
      public DateTime FechaRegistro { get; set; }
    }
}
