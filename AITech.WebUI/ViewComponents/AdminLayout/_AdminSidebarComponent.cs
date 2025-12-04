using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents.AdminLayout
{
    public class _AdminSidebarComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(); 
        }
    }
}
