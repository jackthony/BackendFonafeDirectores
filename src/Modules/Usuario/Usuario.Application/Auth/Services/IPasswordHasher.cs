namespace Usuario.Application.Auth.Services
{
    public interface IPasswordHasher
    {
        public string Hash(string password);
        public bool Verify(string hashedPassword, string plainPassword);
    }
}
