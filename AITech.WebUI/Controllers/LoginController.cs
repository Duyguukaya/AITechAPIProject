using AITech.WebUI.DTOs.AppUserDtos;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Text;
using System.Text.Json;

namespace AITech.WebUI.Controllers
{
    public class LoginController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public LoginController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        // === GİRİŞ (LOGIN) EKRANI ===
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginDto p)
        {
            var jsonContent = new StringContent(JsonSerializer.Serialize(p), Encoding.UTF8, "application/json");
            var client = _httpClientFactory.CreateClient();

            // API Portu: 7012
            var response = await client.PostAsync("https://localhost:7012/api/Auth/login", jsonContent);

            if (response.IsSuccessStatusCode)
            {
                var claims = new List<Claim> { new Claim(ClaimTypes.Name, p.Username) };
                var userIdentity = new ClaimsIdentity(claims, "AdminAuth");
                var principal = new ClaimsPrincipal(userIdentity);

                await HttpContext.SignInAsync("AdminAuth", principal);

                return RedirectToAction("Index", "Banner", new { area = "Admin" });
            }

            ModelState.AddModelError("", "Kullanıcı adı veya şifre hatalı.");
            return View();
        }

        // === KAYIT (REGISTER) EKRANI ===
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterDto p)
        {
            // 1. Şifre eşleşme kontrolü
            if (p.Password != p.ConfirmPassword)
            {
                ModelState.AddModelError("", "Şifreler uyuşmuyor!");
                return View(p);
            }

            var jsonContent = new StringContent(JsonSerializer.Serialize(p), Encoding.UTF8, "application/json");
            var client = _httpClientFactory.CreateClient();

            try
            {
                // API'ye İstek At
                var response = await client.PostAsync("https://localhost:7012/api/Auth/register", jsonContent);

                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }

                // --- HATAYI OLDUĞU GİBİ OKU VE EKRANA BAS ---
                var errorContent = await response.Content.ReadAsStringAsync();

                // Gelen hatayı olduğu gibi ekrana yazdırıyoruz ki ne olduğunu görelim:
                ModelState.AddModelError("", "API Hatası: " + errorContent);

                // Eğer JSON formatındaysa ve okumak istersen bu blok çalışır, çalışmazsa yukarıdaki satır hatayı gösterir.
                try
                {
                    var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                    var errors = JsonSerializer.Deserialize<List<IdentityErrorItem>>(errorContent, options);
                    if (errors != null)
                    {
                        foreach (var item in errors)
                        {
                            ModelState.AddModelError("", item.Description);
                        }
                    }
                }
                catch { /* JSON çevrilemezse boşver, zaten ham halini yukarıda yazdırdık */ }
            }
            catch (Exception ex)
            {
                // Eğer API kapalıysa veya bağlantı hatası varsa burası çalışır
                ModelState.AddModelError("", "Bağlantı Hatası: API'ye ulaşılamadı. " + ex.Message);
            }

            return View(p);
        }

        // === ÇIKIŞ YAP (LOGOUT) ===
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync("AdminAuth");
            return RedirectToAction("Default", "Login");
        }
    }

    // SINIF İSMİNİ DEĞİŞTİRDİK (Çakışmayı önlemek için)
    public class IdentityErrorItem
    {
        public string Code { get; set; }
        public string Description { get; set; }
    }
}