using AITech.WebUI.DTOs.AboutDtos;

namespace AITech.WebUI.Services.AboutServices
{
    public class AboutService : IAboutService
    {
        private readonly HttpClient _client;

        public AboutService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:7012/api/");
            _client = client;
        }

        public async Task CreateAsync(CreateAboutDto projectDto)
        {
            await _client.PostAsJsonAsync("Abouts", projectDto);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync("Abouts/"+id);
        }

        public async Task<List<ResultAboutDto>> GetAllAsync()
        {
           return await _client.GetFromJsonAsync<List<ResultAboutDto>>("Abouts");
        }

        public async Task<UpdateAboutDto> GetByAsync(int id)
        {
            return await _client.GetFromJsonAsync<UpdateAboutDto>("Abouts/"+id);
        }

        public async Task UpdateAsync(UpdateAboutDto projectDto)
        {
            await _client.PutAsJsonAsync("Abouts", projectDto);
        }
    }
}
