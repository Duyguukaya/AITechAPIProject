using AITech.WebUI.Services.FeatureServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AITech.WebUI.ViewComponents.uı_component
{
    public class _FeatureComponent(IFeatureService _featureService) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var feature = await _featureService.GetAllAsync();
            return View(feature);
        }
    }
}
