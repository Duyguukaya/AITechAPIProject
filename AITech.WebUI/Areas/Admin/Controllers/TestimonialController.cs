using AITech.WebUI.DTOs.TestimonialDtos;
using AITech.WebUI.Services.TestimonialServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class TestimonialController(ITestimonialService _testimonialService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var tetimonials = await _testimonialService.GetAllAsync();
            return View(tetimonials);
        }

        [HttpGet]
        public async Task<IActionResult> CreateTestimonial()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateTestimonial(CreateTestimonialDto testimonialDto)
        {
            await _testimonialService.CreateAsync(testimonialDto);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateTestimonial(int id)
        {
            var testimonial = await _testimonialService.GetByAsync(id);
            return View(testimonial);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateTestimonial(UpdateTestimonialDto testimonialDto)
        {
            await _testimonialService.UpdateAsync(testimonialDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteTestimonial(int id)
        {
            await _testimonialService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
