using AITech.WebUI.DTOs.AboutItemsDtos;

namespace AITech.WebUI.Services.AboutItemServices
{
    public interface IAboutItemService
    {
        Task<List<ResultAboutItemsDto>> GetAllAsync();
        Task<UpdateAboutItemsDto> GetByAsync(int id);
        Task CreateAsync(CreateAboutItemsDto projectDto);
        Task UpdateAsync(UpdateAboutItemsDto projectDto);
        Task DeleteAsync(int id);
    }
}
