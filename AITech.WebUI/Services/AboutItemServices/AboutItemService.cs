using AITech.WebUI.DTOs.AboutItemsDtos;

namespace AITech.WebUI.Services.AboutItemServices
{
    public class AboutItemService : IAboutItemService
    {
        private readonly HttpClient _client;

        public AboutItemService(HttpClient client)
        {

            client.BaseAddress = new Uri("https://localhost:7012/api/");
            _client = client;
        }

        public async Task CreateAsync(CreateAboutItemsDto projectDto)
        {
            await _client.PostAsJsonAsync("AboutItems", projectDto);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync("AboutItems/" + id);
        }

        public async Task<List<ResultAboutItemsDto>> GetAllAsync()
        {
            return await _client.GetFromJsonAsync<List<ResultAboutItemsDto>>("AboutItems");
        }

        public async Task<UpdateAboutItemsDto> GetByAsync(int id)
        {
            return await _client.GetFromJsonAsync<UpdateAboutItemsDto>("AboutItems/" + id);
        }

        public async Task UpdateAsync(UpdateAboutItemsDto projectDto)
        {
            await _client.PutAsJsonAsync("AboutItems", projectDto);
        }
    }
}
