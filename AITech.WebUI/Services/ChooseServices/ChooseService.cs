using AITech.WebUI.DTOs.ChooseDtos;

namespace AITech.WebUI.Services.ChooseServices
{
    public class ChooseService : IChooseService
    {
        private readonly HttpClient _httpClient;

        public ChooseService(HttpClient httpClient)
        {
            httpClient.BaseAddress = new Uri("https://localhost:7012/api/");
            _httpClient = httpClient;
        }

        public async Task CreateAsync(CreateChooseDto chooseDto)
        {
            await _httpClient.PostAsJsonAsync("Chooses", chooseDto); 
        }

        public async Task DeleteAsync(int id)
        {
            await _httpClient.DeleteAsync("Chooses/"+id);
        }

        public async Task<List<ResultChooseDto>> GetAllAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<ResultChooseDto>>("Chooses");
        }

        public async Task<UpdateChooseDto> GetByAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<UpdateChooseDto>("Chooses/" + id);
        }

        public async Task UpdateAsync(UpdateChooseDto chooseDto)
        {
            await _httpClient.PutAsJsonAsync("Chooses", chooseDto);
        }
    }
}
