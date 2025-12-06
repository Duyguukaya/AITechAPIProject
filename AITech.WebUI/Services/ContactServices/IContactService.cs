using AITech.WebUI.DTOs.ChooseDtos;
using AITech.WebUI.DTOs.ContactDtos;

namespace AITech.WebUI.Services.ContactServices
{
    public interface IContactService
    {
        Task<List<ResultContactDto>> GetAllAsync();
        Task<UpdateContactDto> GetByAsync(int id);
        Task CreateAsync(CreateContactDto contactDto);
        Task UpdateAsync(UpdateContactDto contactDto);
        Task DeleteAsync(int id);
    }
}
