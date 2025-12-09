using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents.uı_component
{
    public class _FeatureComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
