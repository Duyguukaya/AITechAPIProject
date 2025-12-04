using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents.AdminLayout
{
    public class _AdminHeaderComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
