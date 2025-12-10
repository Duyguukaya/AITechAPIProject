using AITech.WebUI.Services.FAQServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents.uı_component
{
    public class _FAQComponent(IFAQService _faqService) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
  
            var values = await _faqService.GetAllAsync();
            return View(values);
        }
    }
}