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
