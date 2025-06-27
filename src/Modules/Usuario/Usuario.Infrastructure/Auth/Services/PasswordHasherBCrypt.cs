using Usuario.Application.Auth.Services;

namespace Usuario.Infrastructure.Auth.Services
{
    public class PasswordHasherBCrypt : IPasswordHasher
    {
        public string Hash(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

<<<<<<< HEAD
        public bool Verify(string hashedPassword, string plainPassword)
=======
        public bool Verify(string plainPassword, string hashedPassword)
>>>>>>> origin/masterboa
        {
            return BCrypt.Net.BCrypt.Verify(plainPassword, hashedPassword);
        }
    }
}
