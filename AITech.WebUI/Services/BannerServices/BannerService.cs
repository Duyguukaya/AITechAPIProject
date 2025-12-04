using AITech.WebUI.DTOs.BannerDtos;
namespace AITech.WebUI.Services.BannerServices
{
    public class BannerService : IBannerService
    {
        private readonly HttpClient _client;

        public BannerService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:7012/api/");
            _client = client;
        }

     
        public async Task CreateAsync(CreateBannerDto projectDto)
        {
            await _client.PostAsJsonAsync("Banners", projectDto);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync("Banners/" + id);
        }

        public async Task<List<ResultBannerDto>> GetAllAsync()
        {
            return await _client.GetFromJsonAsync<List<ResultBannerDto>>("Banners");

        }

        public async Task<UpdateBannerDto> GetByAsync(int id)
        {
            return await _client.GetFromJsonAsync<UpdateBannerDto>("Banners/" + id);
        }

        public async Task MakeActiveAsync(int id)
        {
            await _client.PatchAsync("banners/makeActive/" + id,null);
        }

        public async Task MakePassiveAsync(int id)
        {
            await _client.PatchAsync("banners/makePassive/" + id, null);
        }


        public async Task UpdateAsync(UpdateBannerDto projectDto)
        {
            await _client.PutAsJsonAsync("Banners", projectDto);
        }

    }
}
