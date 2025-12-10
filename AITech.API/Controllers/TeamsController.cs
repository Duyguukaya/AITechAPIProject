using AITech.Business.Services.TeamServices;
using AITech.DTO.TeamDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AITech.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController(ITeamService _teamService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var team = await _teamService.TGetAllAsync();
            return Ok(team);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var team = await _teamService.TGetByIdAsync(id);
            return Ok(team);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateTeamDto teamDto)
        {
            await _teamService.TCreateAsync(teamDto);
            return Created();
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateTeamDto teamDto)
        {
            await _teamService.TUpdateAsync(teamDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _teamService.TDeleteAsync(id);
            return NoContent();
        }
    }
}
