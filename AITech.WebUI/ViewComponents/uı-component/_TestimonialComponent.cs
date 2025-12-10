using AITech.WebUI.Services.TestimonialServices; 
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents.uı_component
{
    public class _TestimonialComponent(ITestimonialService _testimonialService) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _testimonialService.GetAllAsync();
            return View(values);
        }
    }
}