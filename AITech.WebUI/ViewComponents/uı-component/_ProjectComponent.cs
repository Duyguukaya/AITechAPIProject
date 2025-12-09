using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents.uı_component
{
    public class _ProjectComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
