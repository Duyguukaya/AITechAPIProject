using AITech.WebUI.DTOs.AboutItemsDtos;
using AITech.WebUI.Services.AboutItemServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutItemController(IAboutItemService _aboutItemService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var abouts = await _aboutItemService.GetAllAsync();
            return View(abouts);
        }

        [HttpGet]
        public async Task<IActionResult> CreateAboutItem()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAboutItem(CreateAboutItemsDto categoryDto)
        {
            await _aboutItemService.CreateAsync(categoryDto);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateAboutItem(int id)
        {
            var about = await _aboutItemService.GetByAsync(id);
            return View(about);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAboutItem(UpdateAboutItemsDto categoryDto)
        {
            await _aboutItemService.UpdateAsync(categoryDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteAboutItem(int id)
        {
            await _aboutItemService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
