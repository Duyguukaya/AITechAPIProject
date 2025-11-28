using AITech.WebUI.DTOs.CategoryDtos;
using AITech.WebUI.Services.CategoryServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AITech.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController(ICategoryService _categoryService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var categories = await _categoryService.GetAllAsync();
            return View(categories);
        }

        [HttpGet] //yazmasakta olurdu. api de mutlaka yazılmalı
        public async Task<IActionResult> CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryDto categoryDto)
        {
            await _categoryService.CreateAsync(categoryDto);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateCategory(int id)
        {
            var categori =await _categoryService.GetByAsync(id);
            return View(categori);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryDto categoryDto)
        {
            await _categoryService.UpdateAsync(categoryDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteCategory(int id)
        {
            await _categoryService.DeleteAsync(id);
            return RedirectToAction("Index");
        }



    }
}
