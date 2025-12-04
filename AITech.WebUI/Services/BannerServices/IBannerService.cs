using AITech.WebUI.DTOs.BannerDtos;

namespace AITech.WebUI.Services.BannerServices
{
    public interface IBannerService
    {
        Task<List<ResultBannerDto>> GetAllAsync();
        Task<UpdateBannerDto> GetByAsync(int id);
        Task CreateAsync(CreateBannerDto projectDto);
        Task UpdateAsync(UpdateBannerDto projectDto);
        Task DeleteAsync(int id);
        Task MakeActiveAsync(int id);
        Task MakePassiveAsync(int id);
    }
}
