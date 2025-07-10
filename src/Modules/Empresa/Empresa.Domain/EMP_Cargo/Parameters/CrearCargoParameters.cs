/***********
 * Nombre del archivo:  CrearCargoParameters.cs
 * Descripción:         Clase que contiene los parámetros necesarios para crear un nuevo cargo, con nombre, usuario y fecha de registro.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación de la clase para parámetros de creación de cargo.
 ***********/

namespace Empresa.Domain.Cargo.Parameters
{
    public class CrearCargoParameters
    {
        public string NombreCargo { get; set; } = default!;
        public int UsuarioRegistroId { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
