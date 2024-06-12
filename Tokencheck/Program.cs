using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Configuration;
using DiamondShop.Data;
using Microsoft.Extensions.Configuration;

namespace Tokencheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Đọc cấu hình từ appsettings.json
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            var jwtSettings = configuration.GetSection("Jwt").Get<Jwt>();

            // Generate a random key
            var key = GenerateRandomKey(64);
            Console.WriteLine("Random Key: " + key);

            // Create a token
            var token = CreateToken(jwtSettings.SecretKey);
            Console.WriteLine("Generated Token: " + token);

            // Validate the token
            ValidateToken(token, jwtSettings.SecretKey);
        }

        static string GenerateRandomKey(int length)
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                var bytes = new byte[length];
                rng.GetBytes(bytes);
                return Convert.ToBase64String(bytes);
            }
        }

        static string CreateToken(string secretKey)
        {
            var key = Encoding.UTF8.GetBytes(secretKey);
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, "John Doe"),
                    new Claim(ClaimTypes.NameIdentifier, "1234567890")
                }),
                Expires = DateTime.UtcNow.AddMinutes(30),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        static void ValidateToken(string token, string secretKey)
        {
            var key = Encoding.UTF8.GetBytes(secretKey);
            var tokenHandler = new JwtSecurityTokenHandler();
            var validationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = false,
                ValidateAudience = false
            };

            try
            {
                var principal = tokenHandler.ValidateToken(token, validationParameters, out SecurityToken validatedToken);
                Console.WriteLine("Token is valid");
                Console.WriteLine("Decoded JWT:");
                foreach (var claim in principal.Claims)
                {
                    Console.WriteLine($"{claim.Type}: {claim.Value}");
                }
            }
            catch (SecurityTokenException ex)
            {
                Console.WriteLine($"Invalid token: {ex.Message}");
            }
        }
    }
}
