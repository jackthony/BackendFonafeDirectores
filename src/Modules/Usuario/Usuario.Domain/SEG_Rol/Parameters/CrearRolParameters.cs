/***********
 * Nombre del archivo:  CrearRolParameters.cs
 * Descripción:         Clase que contiene los parámetros necesarios para crear un nuevo rol.
 *                      Incluye el nombre del rol, el Id del usuario que realiza el registro
 *                      y la fecha de registro.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Implementación inicial para crear roles.
 ***********/

namespace Usuario.Domain.Rol.Parameters
{
    public class CrearRolParameters
    {
      public string NombreRol { get; set; } = default!;
      public int UsuarioRegistroId { get; set; }
      public DateTime FechaRegistro { get; set; }
    }
}
