using AITech.WebUI.Services.ChooseServices;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace AITech.WebUI.ViewComponents.uı_component
{
    public class _ChooseCompnent(IChooseService _chooseService):ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var choose = await _chooseService.GetAllAsync();
            var value = choose.FirstOrDefault();
            return View(value);
        }
    }
}
