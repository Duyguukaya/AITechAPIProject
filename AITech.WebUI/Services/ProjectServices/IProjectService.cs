using AITech.WebUI.DTOs.ProjectDtos;

namespace AITech.WebUI.Services.ProjectServices
{
    public interface IProjectService
    {
        Task<List<ResultProjectDto>> GetAllAsync();
        Task<UpdateProjectDto> GetByAsync(int id);
        Task CreateAsync(CreateProjectDto projectDto);
        Task UpdateAsync(UpdateProjectDto projectDto);
        Task DeleteAsync(int id);
    }
}
