using AITech.WebUI.Models;
using AITech.WebUI.Services.AboutItemServices;
using AITech.WebUI.Services.AboutServices;
using AITech.WebUI.Services.SocialServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents.uı_component
{

    public class _AboutComponent(IAboutService _aboutService, IAboutItemService _aboutItemService,ISocialService _socialService) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
           
            var aboutList = await _aboutService.GetAllAsync();
            var mainAbout = aboutList.FirstOrDefault();

            
            var items = await _aboutItemService.GetAllAsync();

            var social = await _socialService.GetAllAsync();

            var model = new AboutViewModel
            {
                About = mainAbout,
                AboutItems = items,
                Social = social
            };

            
            return View(model);
        }
    }
}
