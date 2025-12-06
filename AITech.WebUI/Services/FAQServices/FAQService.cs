using AITech.WebUI.DTOs.FAQDtos;
using System.Net.Http;

namespace AITech.WebUI.Services.FAQServices
{
    public class FAQService : IFAQService
    {
        private readonly HttpClient _client;

        public FAQService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:7012/api/");
            _client = client;
        }

        public async Task CreateAsync(CreateFAQDto fAQDto)
        {
           await _client.PostAsJsonAsync("FAQs", fAQDto);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync("FAQs/"+id);
        }

        public async Task<List<ResultFAQDto>> GetAllAsync()
        {
           return await _client.GetFromJsonAsync<List<ResultFAQDto>>("FAQs");
        }

        public async Task<UpdateFAQDto> GetByAsync(int id)
        {
            return await _client.GetFromJsonAsync<UpdateFAQDto>("FAQs/"+id);
        }

        public async Task UpdateAsync(UpdateFAQDto fAQDto)
        {
            await _client.PutAsJsonAsync("FAQs", fAQDto);

        }
    }
}
