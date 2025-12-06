using AITech.WebUI.DTOs.ContactDtos;
using System.Net.Http;

namespace AITech.WebUI.Services.ContactServices
{
    public class ContactService : IContactService
    {
        private readonly HttpClient _client;
        public ContactService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:7012/api/");
            _client = client;
        }

        public async Task CreateAsync(CreateContactDto contactDto)
        {
            await _client.PostAsJsonAsync("Contacts",contactDto);
        }

        public async Task DeleteAsync(int id)
        {
            // 1. İsteği bir değişkene atıyoruz
            var response = await _client.DeleteAsync($"Contacts/{id}");

            // 2. Eğer API'den "Başarılı (200 OK)" kodu DÖNMEZSE:
            if (!response.IsSuccessStatusCode)
            {
                // Hata mesajını API'den oku
                var errorMsg = await response.Content.ReadAsStringAsync();

                // Hatayı patlat ki neden silmediğini görelim
                throw new Exception($"SİLME İŞLEMİ BAŞARISIZ! \nAPI Kodu: {response.StatusCode} \nDetay: {errorMsg}");
            }
        }

        public async Task<List<ResultContactDto>> GetAllAsync()
        {
            return await _client.GetFromJsonAsync<List<ResultContactDto>>("Contacts");
        }

        public async Task<UpdateContactDto> GetByAsync(int id)
        {
            return await _client.GetFromJsonAsync<UpdateContactDto>("Contacts/" + id);
        }

        public async Task UpdateAsync(UpdateContactDto contactDto)
        {
            await _client.PutAsJsonAsync("Contacts", contactDto);
        }
    }
}
