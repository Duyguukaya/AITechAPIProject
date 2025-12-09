using AITech.WebUI.DTOs.FeatureDtos;

namespace AITech.WebUI.Services.FeatureServices
{
    public class FeatureService : IFeatureService
    {
        private readonly HttpClient _client;

        public FeatureService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:7012/api/");
            _client = client;
        }

        public async Task CreateAsync(CreateFeatureDto featureDto)
        {
            await _client.PostAsJsonAsync("Features", featureDto);
        }

        public async Task DeleteAsync(int id)
        {
            await _client.DeleteAsync("Features/" + id);
        }

        public async Task<List<ResultFeatureDto>> GetAllAsync()
        {
            return await _client.GetFromJsonAsync<List<ResultFeatureDto>>("Features");
        }

        public async Task<UpdateFeatureDto> GetByAsync(int id)
        {
            return await _client.GetFromJsonAsync<UpdateFeatureDto>("Features/"+id);
        }

        public async Task UpdateAsync(UpdateFeatureDto featureDto)
        {
            await _client.PutAsJsonAsync("Features", featureDto);
        }
    }
}
