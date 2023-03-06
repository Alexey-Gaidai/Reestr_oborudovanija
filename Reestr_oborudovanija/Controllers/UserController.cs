using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Reestr_oborudovanija.Models;
using Reestr_oborudovanija.Models.Client;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Security.Cryptography;

namespace Reestr_oborudovanija.Controllers
{
    public class UserController: Controller
    {
        private readonly ReestrContext _context;
        private readonly ILogger _logger;


        public UserController(ReestrContext context, ILogger<UserController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpPost("/signup")]
        public async Task<ActionResult<User>> PostUser(UserClient newUser)
        {
            cryptPassword(newUser.Password, out string hashedPassword, out string salt);
            if (_context.Users.Any(u => u.Login == newUser.Login))
            {
                return StatusCode((int)HttpStatusCode.Conflict); ;
            }
            var user = new User
            {
                Name = newUser.Name,
                LastName = newUser.LastName,
                Login = newUser.Login,
                Password = hashedPassword,
                Salt = salt,
                Role = "user",
            };
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
           
            return CreatedAtAction("GetUsers", new { id = user.UserId }, user);
            
        }

        [HttpPost("/token")]
        public IActionResult Token(string username, string password)
        {
            var identity = GetIdentity(username, password);
            if (identity == null)
            {
                return BadRequest(new { errorText = "Invalid username or password." });
            }
            var now = DateTime.UtcNow;
            // создаем JWT-токен
            var jwt = new JwtSecurityToken(
                    issuer: AuthOptions.ISSUER,
                    audience: AuthOptions.AUDIENCE,
                    notBefore: now,
                    claims: identity.Claims,
                    expires: now.Add(TimeSpan.FromSeconds(AuthOptions.LIFETIME)),
                    signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));
            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);
            var response = new
            {
                access_token = encodedJwt,
                username = identity.Name,
                role = identity.Claims.Where(c => c.Type == "Role").Select(c => c.Value).SingleOrDefault(),
                userId = identity.Claims.Where(c => c.Type == "Id").Select(c => c.Value).SingleOrDefault()
            };
            _logger.LogInformation($"Пользователь {username} совершил вход", DateTime.UtcNow.ToLongTimeString());
            return Json(response);
        }

        private ClaimsIdentity GetIdentity(string username, string password)
        {
            var person = _context.Users.Where(u => u.Login == username).FirstOrDefault();
            if (person != null && equalsPassword(password, person.Password, person.Salt) == true)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimsIdentity.DefaultNameClaimType, person.Login),
                    new Claim(ClaimsIdentity.DefaultRoleClaimType, person.Role),
                    new Claim("Role", person.Role),
                    new Claim("Id", person.UserId.ToString())
                };
                ClaimsIdentity claimsIdentity =
                new ClaimsIdentity(claims, "Token", ClaimsIdentity.DefaultNameClaimType,
                    ClaimsIdentity.DefaultRoleClaimType);
                return claimsIdentity;
            }
            return null;
        }

        private void cryptPassword(string password, out string passwordHash, out string salt)
        {
            using (var hmac = new HMACSHA512())
            {
                salt = Convert.ToBase64String(hmac.Key);
                passwordHash = Convert.ToBase64String(
                    hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password))
                );
            }
        }

        private bool equalsPassword(string password, string passwordHash, string passwordSalt)
        {
            using (var hmac = new HMACSHA512(Convert.FromBase64String(passwordSalt)))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(Convert.FromBase64String(passwordHash));
            }
        }
    }
}
