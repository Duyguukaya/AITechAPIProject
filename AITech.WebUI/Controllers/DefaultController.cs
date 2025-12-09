using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
