/***********
 * Nombre del archivo:  PasswordHasherBCrypt.cs
 * Descripción:         Implementación del servicio de encriptación de contraseñas utilizando el algoritmo BCrypt.
 *                      Permite generar hashes seguros y verificar contraseñas planas contra sus versiones hasheadas.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Implementación del servicio IPasswordHasher con BCrypt.
 ***********/

using Usuario.Application.Auth.Services;

namespace Usuario.Infrastructure.Auth.Services
{
    public class PasswordHasherBCrypt : IPasswordHasher
    {
        public string Hash(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public bool Verify(string plainPassword, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(plainPassword, hashedPassword);
        }
    }
}
