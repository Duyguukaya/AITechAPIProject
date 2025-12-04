using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents.AdminLayout
{
    public class _AdminScriptComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
