using AITech.WebUI.Services.BannerServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents.uı_component
{
    public class _BannerComponent(IBannerService _bannerService):ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var banner = await _bannerService.GetAllAsync();
            var activeBanners = banner.Where(x => x.IsActive == true).ToList();
            return View(activeBanners);
        }
    }
}
