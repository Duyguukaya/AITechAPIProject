using AITech.WebUI.DTOs.TeamDtos;
using AITech.WebUI.Services.TeamServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class TeamController(ITeamService _teamService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var teams = await _teamService.GetAllAsync();
            return View(teams);
        }

        [HttpGet]
        public async Task<IActionResult> CreateTeam()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateTeam(CreateTeamDto teamDto)
        {
            await _teamService.CreateAsync(teamDto);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateTeam(int id)
        {
            var team = await _teamService.GetByAsync(id);
            return View(team);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateTeam(UpdateTeamDto teamDto)
        {
            await _teamService.UpdateAsync(teamDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteTeam(int id)
        {
            await _teamService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
