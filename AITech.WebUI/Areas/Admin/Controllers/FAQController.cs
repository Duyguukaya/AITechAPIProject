using AITech.WebUI.DTOs.FAQDtos;
using AITech.WebUI.Services.FAQServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FAQController(IFAQService _fAQService): Controller
    {
        public async Task<IActionResult> Index()
        {
            var faqs = await _fAQService.GetAllAsync();
            return View(faqs);
        }

        [HttpGet]
        public async Task<IActionResult> CreateFAQ()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateFAQ(CreateFAQDto fAQDto)
        {
            await _fAQService.CreateAsync(fAQDto);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateFAQ(int id)
        {
            var faq = await _fAQService.GetByAsync(id);
            return View(faq);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateFAQ(UpdateFAQDto fAQDto)
        {
            await _fAQService.UpdateAsync(fAQDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteFAQ(int id)
        {
            await _fAQService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
