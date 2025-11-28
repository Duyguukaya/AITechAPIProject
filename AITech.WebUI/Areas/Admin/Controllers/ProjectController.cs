using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProjectController() : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
