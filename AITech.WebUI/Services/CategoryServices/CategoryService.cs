using AITech.WebUI.DTOs.CategoryDtos;
using Newtonsoft.Json;


namespace AITech.WebUI.Services.CategoryServices
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _client;

        public CategoryService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:7012/api/");
            _client = client;
        }

        public Task CreateAsync(CreateCategoryDto categoryDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultCategoryDto>> GetAllAsync()
        {
            var response = await _client.GetAsync("Categories");

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Kategori listesi alınamadı");
            }

            var jsonContent = await response.Content.ReadAsStringAsync();

            var values = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonContent);

            return values;

        }

        public Task<UpdateCategoryDto> GetByAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(UpdateCategoryDto categoryDto)
        {
            throw new NotImplementedException();
        }
    }
}
