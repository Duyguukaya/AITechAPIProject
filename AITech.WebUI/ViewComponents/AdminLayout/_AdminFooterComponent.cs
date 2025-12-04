using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents.AdminLayout
{
    public class _AdminFooterComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
