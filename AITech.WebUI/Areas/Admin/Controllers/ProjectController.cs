using AITech.WebUI.DTOs.ProjectDtos;
using AITech.WebUI.Services.CategoryServices;
using AITech.WebUI.Services.ProjectServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AITech.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProjectController(IProjectService _projectService, ICategoryService _categoryService) : Controller
    {
        private async Task GetCategoriesAsync()
        {
            var categoriList = await _categoryService.GetAllAsync();
            ViewBag.categories = (from category in categoriList
                                  select new SelectListItem
                                  {
                                      Text = category.Name,
                                      Value = category.Id.ToString()
                                  }).ToList();
        }


        public async Task<IActionResult> Index()
        {
            var projects = await _projectService.GetAllAsync();
            return View(projects);
        }

        public async Task<IActionResult> CreateProject()
        {
           
            await GetCategoriesAsync();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProject(CreateProjectDto projectDto)
        {
            if (!ModelState.IsValid)
            {
                
                await GetCategoriesAsync();
                return View(projectDto);
            }

            await _projectService.CreateAsync(projectDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateProject(int id)
        {
        
            await GetCategoriesAsync();
            var values = await _projectService.GetByAsync(id);
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProject(UpdateProjectDto projectDto)
        {
            if (!ModelState.IsValid)
            {
               
                await GetCategoriesAsync();
                return View(projectDto);
            }

            await _projectService.UpdateAsync(projectDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteProject(int id)
        {
            await _projectService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}