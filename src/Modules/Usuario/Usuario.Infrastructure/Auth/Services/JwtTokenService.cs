using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Usuario.Application.Auth.Services;

namespace Usuario.Infrastructure.Auth.Services
{
    public class JwtTokenService : ITokenService
    {
        private readonly IConfiguration _configuration;
        private readonly string _jwtSecret;
        private readonly string _issuer;
        private readonly string _audience;
        private readonly int _tokenExpiryMinutes;

        public JwtTokenService(IConfiguration configuration)
        {
            _configuration = configuration;
            _jwtSecret = _configuration["Jwt:Key"]!;
            _issuer = _configuration["Jwt:Issuer"]!;
            _audience = _configuration["Jwt:Audience"]!;
            _tokenExpiryMinutes = int.Parse(_configuration["Jwt:AccessTokenMinutes"]!);
        }

        public string GenerateAccessToken(int userId, string email, IList<string> roles)
        {
            var claims = new List<Claim>
        {
            new(JwtRegisteredClaimNames.Sub, userId.ToString()),
            new(JwtRegisteredClaimNames.Email, email),
            new(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        };

            claims.AddRange(roles.Select(role => new Claim(ClaimTypes.Role, role)));

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSecret));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _issuer,
                audience: _audience,
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(_tokenExpiryMinutes),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public string GenerateRefreshToken()
        {
            var randomBytes = new byte[64];
            using var rng = RandomNumberGenerator.Create();
            rng.GetBytes(randomBytes);
            return Convert.ToBase64String(randomBytes);
        }

        public ClaimsPrincipal? ValidateAccessToken(string token)
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.UTF8.GetBytes(_jwtSecret);

                var validationParams = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidIssuer = _issuer,
                    ValidAudience = _audience,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero
                };

                var principal = tokenHandler.ValidateToken(token, validationParams, out _);
                return principal;
            }
            catch
            {
                return null;
            }
        }
    }
}
