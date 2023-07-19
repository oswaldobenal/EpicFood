using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using EpicFood_API.Models;
using EpicFood_API.Models.Custom;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace EpicFood_API.Services
{
    public class AuthorizationService : IAuthotizationService
    {
        private readonly EpicFoodDbContext _context;
        private readonly IConfiguration _configuration;

        public AuthorizationService(EpicFoodDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        private string GenerateToken(string userId)
        {
            var key = _configuration.GetValue<string>("JwtSettings:key");
            var keyBytes = Encoding.ASCII.GetBytes(key);

            var claims = new ClaimsIdentity();
            claims.AddClaim(new Claim(ClaimTypes.NameIdentifier, userId));

            var credencialsToken = new SigningCredentials(
                new SymmetricSecurityKey(keyBytes),
                SecurityAlgorithms.HmacSha256Signature
            );

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = claims,
                Expires = DateTime.UtcNow.AddMinutes(2),
                SigningCredentials = credencialsToken
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenConfig = tokenHandler.CreateToken(tokenDescriptor);

            string tokenCreated = tokenHandler.WriteToken(tokenConfig);

            return tokenCreated;
        }

        private string GenerateRefreshToken()
        {
            var byteArray = new byte[64];
            var refreshToken = "";

            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(byteArray);
                refreshToken = Convert.ToBase64String(byteArray);
            }

            return refreshToken;
        }

        private async Task<ResponseAuthorization> SaveHistoryRefreshToken(
            int userId,
            string token,
            string refreshToken)
        {
            var historyRefreshToken = new HistorialRefreshToken
            {
                IdUsuario = userId,
                Token = token,
                RefreshToken = refreshToken,
                FechaCreacion = DateTime.UtcNow,
                FechaExpiracion = DateTime.UtcNow.AddDays(5)
            };

            await _context.HistorialRefreshTokens.AddAsync(historyRefreshToken);
            await _context.SaveChangesAsync();

            return new ResponseAuthorization
            {
                Token = token,
                RefresToken = refreshToken,
                Result = true,
                Message = "Ok"
            };
        }

        public async Task<ResponseAuthorization> ReturnToken(RequestAuthorization authorization)
        {
            var user_found = _context.Personas.FirstOrDefault(x => x.PerCorreo == authorization.UserName && x.PerClave == authorization.Password);

            if (user_found == null)
            {
                return await Task.FromResult<ResponseAuthorization>(null);
            }

            string tokenCreated = GenerateToken(user_found.PerId.ToString());

            string refreshTokenCreated = GenerateRefreshToken();

            //return new ResponseAuthorization()
            //{
            //    Token = tokenCreated,
            //    Result = true,
            //    Message = "Ok"
            //};

            return await SaveHistoryRefreshToken(user_found.PerId, tokenCreated, refreshTokenCreated);
        }

        public async Task<ResponseAuthorization> ReturnRefreshToken(RefreshTokenRequest refreshTokenRequest, int userId)
        {
            var refreshTokenFound = _context.HistorialRefreshTokens.FirstOrDefault(x =>
                x.Token == refreshTokenRequest.TokenExpirado &&
                x.RefreshToken == refreshTokenRequest.RefreshToken &&
                x.IdUsuario == userId
            );

            if (refreshTokenFound == null)
                return new ResponseAuthorization
                {
                    Result = false,
                    Message = "No existe refresh token"
                };

            var refreshTokenCreated = GenerateRefreshToken();
            var tokenCreated = GenerateToken(userId.ToString());

            return await SaveHistoryRefreshToken(userId, tokenCreated, refreshTokenCreated);

        }
    }
}

