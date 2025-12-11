using AITech.DTO.Dtos;
using AITech.Entity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AITech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;

        public AuthController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        // GİRİŞ İŞLEMİ (Login)
        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            var result = await _signInManager.PasswordSignInAsync(loginDto.Username, loginDto.Password, false, false);

            if (result.Succeeded)
            {
                return Ok(new { message = "Giriş başarılı" });
            }
            return Unauthorized();
        }

        // KAYIT İŞLEMİ (Register)
        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterDto registerDto)
        {
            // Yeni kullanıcı nesnesi oluştur
            var user = new AppUser
            {
                NameSurname = registerDto.Name + " " + registerDto.Surname,
                Email = registerDto.Email,
                UserName = registerDto.Username
            };

            // Kullanıcıyı oluştur (Şifreyi otomatik hashler)
            var result = await _userManager.CreateAsync(user, registerDto.Password);

            if (result.Succeeded)
            {
                return Ok(new { message = "Kayıt başarılı" });
            }

            // Hata varsa listele (Örn: Şifre çok kısa vb.)
            return BadRequest(result.Errors);
        }
    }
}