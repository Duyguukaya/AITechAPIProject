using AITech.WebUI.DTOs.FAQDtos;

namespace AITech.WebUI.Services.FAQServices
{
    public interface IFAQService
    {
        Task<List<ResultFAQDto>> GetAllAsync();
        Task<UpdateFAQDto> GetByAsync(int id);
        Task CreateAsync(CreateFAQDto fAQDto);
        Task UpdateAsync(UpdateFAQDto fAQDto);
        Task DeleteAsync(int id);
    }
}
