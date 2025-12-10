using AITech.WebUI.Services.ProjectServices; 
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents.uı_component
{

    public class _ProjectComponent(IProjectService _projectService) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _projectService.GetAllAsync();
  
            return View(values);
        }
    }
}