/***********
* Nombre del archivo: IPasswordHasher.cs
* Descripción:        **Define la interfaz para el servicio de hashing y verificación de contraseñas**.
*                     Proporciona métodos para **hashear una contraseña** (transformarla en una cadena segura y unidireccional)
*                     y para **verificar si una contraseña en texto plano coincide con una contraseña hasheada** almacenada.
*                     Esto es fundamental para la seguridad en la gestión de credenciales de usuario.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la interfaz IPasswordHasher.
***********/

namespace Usuario.Application.Auth.Services
{
    public interface IPasswordHasher
    {
        public string Hash(string password);
        public bool Verify(string hashedPassword, string plainPassword);
    }
}
