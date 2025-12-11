using AITech.WebUI.DTOs.FeatureDtos;
using AITech.WebUI.Services.FeatureServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class FeatureController(IFeatureService _featureService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var features = await _featureService.GetAllAsync();
            return View(features);
        }

        [HttpGet]
        public async Task<IActionResult> CreateFeature()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateFeature(CreateFeatureDto featureDto)
        {
            await _featureService.CreateAsync(featureDto);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateFeature(int id)
        {
            var feature = await _featureService.GetByAsync(id);
            return View(feature);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateFeature(UpdateFeatureDto featureDto)
        {
            await _featureService.UpdateAsync(featureDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteFeature(int id)
        {
            await _featureService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
