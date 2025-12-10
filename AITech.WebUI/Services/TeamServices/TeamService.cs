using AITech.WebUI.DTOs.TeamDtos;

namespace AITech.WebUI.Services.TeamServices
{
    public class TeamService : ITeamService
    {
        private readonly HttpClient _httpClient;

        public TeamService(HttpClient httpClient)
        {
            httpClient.BaseAddress = new Uri("https://localhost:7012/api/");
            _httpClient = httpClient;
        }

        public async Task CreateAsync(CreateTeamDto teamDto)
        {
            await _httpClient.PostAsJsonAsync("Teams", teamDto);
        }

        public async Task DeleteAsync(int id)
        {
            await _httpClient.DeleteAsync("Teams/" + id);
        }

        public async Task<List<ResultTeamDto>> GetAllAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<ResultTeamDto>>("Teams");
        }

        public async Task<UpdateTeamDto> GetByAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<UpdateTeamDto>("Teams/" + id);
        }

        public async Task UpdateAsync(UpdateTeamDto teamDto)
        {
           await _httpClient.PutAsJsonAsync("Teams", teamDto);
        }
    }
}
