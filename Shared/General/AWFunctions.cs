global using System.Security.Claims;
global using Microsoft.IdentityModel.Tokens;
global using System.Diagnostics.CodeAnalysis;
global using System.IdentityModel.Tokens.Jwt;
global using System.Security.Claims;
global using System.Security.Cryptography;

global using MimeKit;
global using MailKit.Net.Smtp;
global using MimeKit.Text;
using System.Text;
using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text.Json;
using Accreditation_Watch.Shared.Entities;

namespace Accreditation_Watch.Shared.General
{
    public static class AWFunctions
    {
        public static User CurrentUser { get; set; }
        //public static int SchoolId { get => CurrentUser.SchoolId; }
        public static string GeneratePassword(int length)
        {
            const string allowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()-_=+;:'?";
            byte[] randomNumber = new byte[length];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
            }
            var sb = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                sb.Append(allowedChars[randomNumber[i] % allowedChars.Length]);
            }
            return sb.ToString();
        }
        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
        public static string CreateToken(User user)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Name),
                new Claim(ClaimTypes.Role, "Admin"),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Sid, user.Id.ToString())

            };
            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("DefaultTokenis the best defualt tocken there is")); //MUST BE CHANGED 
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);
            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: creds
                );
            var jwt = new JwtSecurityTokenHandler().WriteToken(token);
            Console.WriteLine("completed");
            GetDeatailsFromToken(jwt);
            return jwt;
        }
        public static async Task<string> SendMail(User user)
        {
            string failed = null;
            var mailMessage = new MimeMessage();
            mailMessage.To.Add(MailboxAddress.Parse("ittai1tumelo@gmail.com"));
            mailMessage.From.Add(MailboxAddress.Parse("ittai1tumelo@gmail.com"));
            mailMessage.Subject = "Pedagogy Testing";
            mailMessage.Body = new TextPart(TextFormat.Html)
            {
                Text = $"Password : {user.Name} and Email : {user.Email}"
            };
            using var smtp = new SmtpClient();
            smtp.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
            smtp.Authenticate("ittai1tumelo@gmail.com", "oboesevbwetsuien");
            try
            {
                var response = await smtp.SendAsync(mailMessage);
                //if(response is not null)
                //if (!response) throw new Exception("Wow");
            }
            catch (Exception ex)
            {
                failed = ex.Message;

            }
            finally
            {
                smtp.Disconnect(true);
            }
            if (failed is null)
                return "Sent";
            else return "failed";

        }
        public static bool VerifyPassword(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var computeHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return computeHash.SequenceEqual(passwordHash);
            }
        }
        public static string CreateToken(UserLoginDto userdto, User _user)
        {
            var mySecret = "asdv234234^&%&^%&^hjsdfb2%%%";
            var foundUser = _user;
            if (foundUser is null) throw new Exception("The User Does not exist ");
            Claim claim;
            claim = new Claim(ClaimTypes.Role, "Admin");
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, _user.Name),
                new Claim(ClaimTypes.Expiration, DateTime.Now.AddMinutes(30).ToString()),
                new Claim(ClaimTypes.Email, foundUser.Email.ToString()),
                new Claim(ClaimTypes.Sid, foundUser.Id.ToString()),
                new Claim(ClaimTypes.Role, "Admin"),
            };
            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(mySecret));
            //var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(_configuration.GetSection("AppSettings:Token").Value));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);
            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: creds
                );
            var jwt = new JwtSecurityTokenHandler().WriteToken(token);
            GetDeatailsFromToken(jwt);
            return jwt;
        }
        public static User GetDeatailsFromToken(string token)
        {
            var identity = new ClaimsIdentity();

            identity = new ClaimsIdentity(ParseClaimsFromJwt(token), "jwt");
            var user = new ClaimsPrincipal(identity);
            var state = new AuthenticationState(user);
            var claims = user.Claims.ToList();
            if (claims is null) throw new Exception("User Claims can not be parsed");

            CurrentUser = new User()
            {
                Name = claims[0].Value,
                //Role = (Enum.TryParse<Role>(claims[1].Value, true, out var role)) ? role : Role.Basic,
                //Role = "Admin",
                Email = claims[2].Value,
                Id = int.Parse(claims[3].Value),
                Token = token,
            };
            return CurrentUser;
        }
        public static IEnumerable<Claim> ParseClaimsFromJwt(string jwt)
        {
            var payload = jwt.Split('.')[1];
            var jsonBytes = ParseBase64WithoutPadding(payload);
            var keyValuePairs = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonBytes);
            return keyValuePairs.Select(kvp => new Claim(kvp.Key, kvp.Value.ToString()));
        }
        private static byte[] ParseBase64WithoutPadding(string base64)
        {
            switch (base64.Length % 4)
            {
                case 2: base64 += "=="; break;
                case 3: base64 += "="; break;
            }
            return Convert.FromBase64String(base64);
        }
        public static bool IsBetween(int value, int min, int max, bool inclusive = false)
        {
            return inclusive
                ? value >= min && value <= max
                : value > min && value < max;
        }





    }
}
