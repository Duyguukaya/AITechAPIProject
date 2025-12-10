using AITech.WebUI.DTOs.TeamDtos;

namespace AITech.WebUI.Services.TeamServices
{
    public interface ITeamService
    {
        Task<List<ResultTeamDto>> GetAllAsync();
        Task<UpdateTeamDto> GetByAsync(int id);
        Task CreateAsync(CreateTeamDto teamDto);
        Task UpdateAsync(UpdateTeamDto teamDto);
        Task DeleteAsync(int id);
    }
}
