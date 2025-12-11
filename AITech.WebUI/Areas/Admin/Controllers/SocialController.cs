using AITech.WebUI.DTOs.SocialDtos;
using AITech.WebUI.Services.SocialServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class SocialController(ISocialService _socialService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var socials = await _socialService.GetAllAsync();
            return View(socials);
        }

        [HttpGet]
        public async Task<IActionResult> CreateSocial()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateSocial(CreateSocialDto socialDto)
        {
            await _socialService.CreateAsync(socialDto);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateSocial(int id)
        {
            var social = await _socialService.GetByAsync(id);
            return View(social);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateSocial(UpdateSocialDto socialDto)
        {
            await _socialService.UpdateAsync(socialDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteSocial(int id)
        {
            await _socialService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
