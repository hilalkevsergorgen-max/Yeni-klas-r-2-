using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using SEYRİ_ALA.Data.Interfaces;
using SEYRİ_ALA.Models;
using System.Security.Claims;

namespace SEYRİ_ALA.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserRepository _userRepository;

        public AccountController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public IActionResult Register() => View(new RegisterViewModel());

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid) return View(model); //hatalı işlem kontrolü - tekrar kontrol gönderimi

            // Veritabanı kontrolü repository üzerinden yapılıyor
            var existingUser = await _userRepository.GetByEmailAsync(model.Email);
            if (existingUser != null)
            {
                ViewBag.Message = "❌ Bu e-posta zaten kayıtlı.";
                return View(model);
            }

            var user = new User
            {
                FullName = model.FullName,
                Email = model.Email,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(model.Password), //geri dönüşümü olmayan şifreleme
                Role = "User"
            };

            await _userRepository.AddAsync(user);
            await _userRepository.SaveChangesAsync();

            return RedirectToAction("Login");
        }

        [HttpGet]
        public IActionResult Login() => View(new LoginViewModel());

        [HttpPost]
        [ValidateAntiForgeryToken] //sahte form gönderimine karşı koruma 
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var user = await _userRepository.GetByEmailAsync(model.Email);

            if (user != null && BCrypt.Net.BCrypt.Verify(model.Password, user.PasswordHash))
            {
                var claims = new List<Claim> // sistem kontrolü için - kullanıcı dijital kimlik kartı
                {
                    new Claim(ClaimTypes.Name, user.Email),
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(ClaimTypes.Role, user.Role),
                    new Claim("FullName", user.FullName ?? "")
                };

                var claimsIdentity = new ClaimsIdentity(claims, "CookieAuth");
                var authProperties = new AuthenticationProperties { IsPersistent = model.RememberMe };

                await HttpContext.SignInAsync("CookieAuth", new ClaimsPrincipal(claimsIdentity), authProperties); 
                // beni hatırla özelliği için (tarayıcı kapalı-oturum açık)

                return RedirectToAction("Index", "Home");
            }

            ViewBag.Message = "❌ Hatalı giriş bilgileri.";
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync("CookieAuth"); 
            return RedirectToAction("Index", "Home");
        }
    }
}