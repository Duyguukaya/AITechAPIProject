using AITech.WebUI.Services.TeamServices; 
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents.uı_component
{

    public class _TeamComponent(ITeamService _teamService) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _teamService.GetAllAsync();
            return View(values);
        }
    }
}