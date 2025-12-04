using AITech.WebUI.DTOs.AboutDtos;

namespace AITech.WebUI.Services.AboutServices
{
    public interface IAboutService
    {
        Task<List<ResultAboutDto>> GetAllAsync();
        Task<UpdateAboutDto> GetByAsync(int id);
        Task CreateAsync(CreateAboutDto projectDto);
        Task UpdateAsync(UpdateAboutDto projectDto);
        Task DeleteAsync(int id);
    }
}
